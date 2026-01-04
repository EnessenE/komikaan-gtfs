using komikaan.GTFS.Models.Static;
using ProtoBuf;
using System.Runtime.Serialization;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// The contents of a feed message. Each message in the stream is obtained as a response to an appropriate HTTP GET request.
    /// </summary>
    [ProtoContract]
    public class FeedMessage : GTFSRealtimeObject
    {
        /// <summary>
        /// Metadata about this feed and feed message.
        /// </summary>
        [ProtoMember(1)]
        [DataMember(Name = "Header")]
        public required FeedHeader Header { get; set; }

        /// <summary>
        /// Contents of the feed. If there is real-time information available for the transit system, this field must be provided.
        /// </summary>
        [ProtoMember(2)]
        [DataMember(Name = "Entity")]
        public List<FeedEntity> Entities { get; set; } = new List<FeedEntity>();
    }
}
