using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// A time interval. The interval is considered active at time t if t is greater than or equal to the start time and less than the end time.
    /// </summary>
    [ProtoContract]
    public class TimeRange : GTFSRealtimeObject
    {
        /// <summary>
        /// Start time, in POSIX time. If missing, the interval starts at minus infinity.
        /// </summary>
        public ulong? Start { get; set; }

        /// <summary>
        /// End time, in POSIX time. If missing, the interval ends at plus infinity.
        /// </summary>
        public ulong? End { get; set; }
    }
}
