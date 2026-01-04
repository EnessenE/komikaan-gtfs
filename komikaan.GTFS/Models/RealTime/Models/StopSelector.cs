using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// Selector for a stop. Either by stop_id or stop_sequence. Experimental.
    /// </summary>
    [ProtoContract(Name = "StopSelector")]
    public class StopSelector : GTFSRealtimeObject
    {
        /// <summary>
        /// Must be the same as in stop_times.txt in the corresponding GTFS feed.
        /// </summary>
        [ProtoMember(1)]
        public uint? StopSequence { get; set; }

        /// <summary>
        /// Must be the same as in stops.txt in the corresponding GTFS feed.
        /// </summary>
        [ProtoMember(2)]
        public string? StopId { get; set; }
    }
}
