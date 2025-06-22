using komikaan.GTFS.Models.RealTime.Enums;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// Metadata about a feed, included in feed messages.
    /// </summary>
    public class FeedHeader
    {
        /// <summary>
        /// Version of the feed specification. The current version is 2.0.
        /// </summary>
        public required string GtfsRealtimeVersion { get; set; }

        /// <summary>
        /// Determines whether the current fetch is incremental.
        /// </summary>
        public Incrementality Incrementality { get; set; }

        /// <summary>
        /// This timestamp identifies the moment when the content of this feed has been created (in server time). In POSIX time.
        /// </summary>
        public ulong Timestamp { get; set; }

        /// <summary>
        /// String that matches the feed_info.feed_version from the GTFS feed that the realtime data is based on.
        /// </summary>
        public string? FeedVersion { get; set; }
    }
}
