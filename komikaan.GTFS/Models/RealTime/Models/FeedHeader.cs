using komikaan.GTFS.Models.RealTime.Enums;
using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// Metadata about a feed, included in feed messages.
    /// </summary>
    [ProtoContract(Name = "FeedHeader")]
    public class FeedHeader : GTFSRealtimeObject
    {
        /// <summary>
        /// Version of the feed specification. The current version is 2.0.
        /// </summary>
        [ProtoMember(1)]
        public required string GtfsRealtimeVersion { get; set; }

        /// <summary>
        /// Determines whether the current fetch is incremental.
        /// </summary>
        [ProtoMember(2)]
        public Incrementality Incrementality { get; set; }

        /// <summary>
        /// This timestamp identifies the moment when the content of this feed has been created (in server time). In POSIX time.
        /// </summary>
        [ProtoMember(3)]
        public ulong Timestamp { get; set; }

        /// <summary>
        /// String that matches the feed_info.feed_version from the GTFS feed that the realtime data is based on.
        /// </summary>
        [ProtoMember(4)]
        public string? FeedVersion { get; set; }
    }
}
