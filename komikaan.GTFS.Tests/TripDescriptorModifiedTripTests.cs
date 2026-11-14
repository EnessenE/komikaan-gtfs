using System.Text;
using komikaan.GTFS.Models.RealTime.Models;
using ProtoBuf;
using Xunit;

namespace komikaan.GTFS.Tests;

public class TripDescriptorModifiedTripTests
{
    // Builds a wire-level GTFS-RT alerts feed in the shape geops.ch / opentransportdata.swiss
    // sends it: TripDescriptor field 7 (modified_trip) carries a plain string instead of a
    // ModifiedTripSelector message. With the old model that made protobuf-net throw
    // "Invalid wire-type (String)" while deserializing the feed.
    private static byte[] AlertsFeedWithStringModifiedTrip()
    {
        byte[] Varint(int value)
        {
            var bytes = new List<byte>();
            var v = (uint)value;
            while (v >= 0x80)
            {
                bytes.Add((byte)(v | 0x80));
                v >>= 7;
            }
            bytes.Add((byte)v);
            return bytes.ToArray();
        }

        byte[] Tag(int field) => Varint(field << 3 | 2); // wire type 2 = length-delimited

        byte[] StringField(int field, string value)
        {
            var payload = Encoding.UTF8.GetBytes(value);
            return [.. Tag(field), .. Varint(payload.Length), .. payload];
        }

        byte[] MessageField(int field, byte[] payload) =>
            [.. Tag(field), .. Varint(payload.Length), .. payload];

        var tripDescriptor = StringField(1, "trip-1") // trip_id
            .Concat(StringField(7, "mod-trip-42")) // modified_trip as a plain string
            .ToArray();
        var entitySelector = MessageField(4, tripDescriptor); // EntitySelector.trip
        var alert = MessageField(5, entitySelector); // Alert.informed_entity
        var entity = StringField(1, "alert-1") // FeedEntity.id
            .Concat(MessageField(5, alert)) // FeedEntity.alert
            .ToArray();
        var header = StringField(1, "2.0"); // FeedHeader.gtfs_realtime_version
        return MessageField(1, header) // FeedMessage.header
            .Concat(MessageField(2, entity)) // FeedMessage.entity
            .ToArray();
    }

    private static FeedMessage SampleFeed(TripDescriptor trip)
    {
        return new FeedMessage
        {
            Header = new FeedHeader { GtfsRealtimeVersion = "2.0", Timestamp = 1_700_000_000 },
            Entities =
            {
                new FeedEntity
                {
                    Id = "alert-1",
                    Alert = new Alert
                    {
                        HeaderText = new TranslatedString
                        {
                            Translation = new List<Translation> { new Translation { Text = "header" } },
                        },
                        DescriptionText = new TranslatedString
                        {
                            Translation = new List<Translation> { new Translation { Text = "description" } },
                        },
                        InformedEntity = new List<EntitySelector>
                        {
                            new EntitySelector { Trip = trip },
                        },
                    },
                },
            },
        };
    }

    [Fact]
    public void Alerts_feed_with_string_modified_trip_parses_without_wire_type_error()
    {
        var bytes = AlertsFeedWithStringModifiedTrip();

        var feed = Serializer.Deserialize<FeedMessage>(new MemoryStream(bytes));

        var trip = Assert.Single(feed.Entities).Alert?.InformedEntity.Single().Trip;
        Assert.NotNull(trip);
        Assert.Equal("trip-1", trip.TripId);
        Assert.Equal("mod-trip-42", trip.ModifiedTripId);
        Assert.Equal("mod-trip-42", Encoding.UTF8.GetString(trip.ModifiedTripRaw!));
    }

    [Fact]
    public void Spec_compliant_message_modified_trip_roundtrips()
    {
        byte[] selectorBytes;
        using (var ms = new MemoryStream())
        {
            Serializer.Serialize(ms, new ModifiedTripSelector
            {
                ModificationsId = "mod-1",
                AffectedTripId = "trip-9",
            });
            selectorBytes = ms.ToArray();
        }

        var feed = SampleFeed(new TripDescriptor { TripId = "trip-1", ModifiedTripRaw = selectorBytes });
        using var ms2 = new MemoryStream();
        Serializer.Serialize(ms2, feed);
        ms2.Position = 0;

        var parsed = Serializer.Deserialize<FeedMessage>(ms2);

        var trip = Assert.Single(parsed.Entities).Alert?.InformedEntity.Single().Trip;
        Assert.NotNull(trip);
        Assert.Equal("trip-1", trip.TripId);
        var parsedSelector = Serializer.Deserialize<ModifiedTripSelector>(new MemoryStream(trip.ModifiedTripRaw!));
        Assert.Equal("mod-1", parsedSelector.ModificationsId);
        Assert.Equal("trip-9", parsedSelector.AffectedTripId);
    }

    [Fact]
    public void Trip_descriptor_without_modified_trip_still_parses()
    {
        var feed = SampleFeed(new TripDescriptor { TripId = "trip-1" });
        using var ms = new MemoryStream();
        Serializer.Serialize(ms, feed);
        ms.Position = 0;

        var parsed = Serializer.Deserialize<FeedMessage>(ms);

        var trip = Assert.Single(parsed.Entities).Alert?.InformedEntity.Single().Trip;
        Assert.NotNull(trip);
        Assert.Equal("trip-1", trip.TripId);
        Assert.Null(trip.ModifiedTripRaw);
        Assert.Null(trip.ModifiedTripId);
    }
}
