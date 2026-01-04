using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// Timing information for a single predicted event (either arrival or departure).
    /// </summary>
    [ProtoContract(Name = "StopTimeEvent")]
    public class StopTimeEvent : GTFSRealtimeObject
    {
        /// <summary>
        /// Delay in seconds. Can be positive (late) or negative (early). A delay of 0 means the vehicle is on time.
        /// </summary>
        [ProtoMember(1)]
        public int? Delay { get; set; }

        /// <summary>
        /// Estimated or actual event as absolute time, in POSIX time.
        /// </summary>
        [ProtoMember(2)]
        public long? Time { get; set; }

        /// <summary>
        /// If uncertainty is omitted, it is interpreted as unknown. To specify a completely certain prediction, set its uncertainty to 0.
        /// </summary>
        [ProtoMember(3)]
        public int? Uncertainty { get; set; }

        /// <summary>
        /// Scheduled time, in POSIX time. Optional for NEW, REPLACEMENT, or DUPLICATED trips.
        /// </summary>
        [ProtoMember(4)]
        public long? ScheduledTime { get; set; }
    }
}
