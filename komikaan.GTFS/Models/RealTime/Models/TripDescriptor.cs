using System.Text;
using komikaan.GTFS.Models.RealTime.Enums;
using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// A descriptor that identifies a single instance of a GTFS trip.
    /// </summary>
    [ProtoContract(Name = "TripDescriptor")]
    public class TripDescriptor : GTFSRealtimeObject
    {
        /// <summary>
        /// The trip_id from the GTFS feed that this selector refers to.
        /// </summary>
        [ProtoMember(1)]
        public string? TripId { get; set; }

        /// <summary>
        /// The initially scheduled start time of this trip instance.
        /// </summary>
        [ProtoMember(2)]
        public string? StartTime { get; set; }

        /// <summary>
        /// The start date of this trip instance in YYYYMMDD format.
        /// </summary>
        [ProtoMember(3)]
        public string? StartDate { get; set; }

        /// <summary>
        /// The relation between this trip and the static schedule.
        /// </summary>
        [ProtoMember(4)]
        public TripScheduleRelationship? ScheduleRelationship { get; set; }

        /// <summary>
        /// The route_id from the GTFS that this selector refers to.
        /// </summary>
        [ProtoMember(5)]
        public string? RouteId { get; set; }

        /// <summary>
        /// The direction_id from the GTFS feed trips.txt file. Experimental.
        /// </summary>
        [ProtoMember(6)]
        public uint? DirectionId { get; set; }

        /// <summary>
        /// Linkage to any modifications done to this trip (shape changes, removal or addition of stops).
        /// Raw wire content of field 7. Spec-compliant producers send a serialized <see cref="ModifiedTripSelector"/>
        /// message here, but some producers (e.g. opentransportdata.swiss) send the affected trip_id as a plain
        /// string, which protobuf-net cannot parse as a message. Both forms are length-delimited on the wire,
        /// so the raw bytes are captured without interpretation; use <see cref="ModifiedTripId"/> for the
        /// plain-string form, or deserialize <see cref="ModifiedTripRaw"/> as <see cref="ModifiedTripSelector"/>
        /// for the message form.
        /// </summary>
        [ProtoMember(7)]
        public byte[]? ModifiedTripRaw { get; set; }

        /// <summary>
        /// Field 7 as a string, for producers that send the affected trip_id directly
        /// (e.g. opentransportdata.swiss). Null when the field is absent.
        /// </summary>
        [ProtoIgnore]
        public string? ModifiedTripId =>
            ModifiedTripRaw is { Length: > 0 } ? Encoding.UTF8.GetString(ModifiedTripRaw) : null;
    }
}
