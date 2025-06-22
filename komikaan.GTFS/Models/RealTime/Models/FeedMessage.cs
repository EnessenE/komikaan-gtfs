namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// The contents of a feed message. Each message in the stream is obtained as a response to an appropriate HTTP GET request.
    /// </summary>
    public class FeedMessage
    {
        /// <summary>
        /// Metadata about this feed and feed message.
        /// </summary>
        public required FeedHeader Header { get; set; }

        /// <summary>
        /// Contents of the feed. If there is real-time information available for the transit system, this field must be provided.
        /// </summary>
        public List<FeedEntity> Entity { get; set; } = new List<FeedEntity>();
    }
}
