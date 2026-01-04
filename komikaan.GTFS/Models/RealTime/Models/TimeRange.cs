using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// A time interval. The interval is considered active at time t if t is greater than or equal to the start time and less than the end time.
    /// </summary>
    [ProtoContract(Name = "TimeRange")]
    public class TimeRange : GTFSRealtimeObject
    {
        /// <summary>
        /// Start time, in POSIX time. If missing, the interval starts at minus infinity.
        /// </summary>
        [ProtoMember(1)]
        public ulong? Start { get; set; }

        /// <summary>
        /// End time, in POSIX time. If missing, the interval ends at plus infinity.
        /// </summary>
        [ProtoMember(2)]
        public ulong? End { get; set; }
    }
}
