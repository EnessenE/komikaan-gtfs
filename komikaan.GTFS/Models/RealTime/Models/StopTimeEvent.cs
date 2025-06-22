namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// Timing information for a single predicted event (either arrival or departure).
    /// </summary>
    public class StopTimeEvent
    {
        /// <summary>
        /// Delay in seconds. Can be positive (late) or negative (early). A delay of 0 means the vehicle is on time.
        /// </summary>
        public int? Delay { get; set; }

        /// <summary>
        /// Estimated or actual event as absolute time, in POSIX time.
        /// </summary>
        public long? Time { get; set; }

        /// <summary>
        /// Scheduled time, in POSIX time. Optional for NEW, REPLACEMENT, or DUPLICATED trips.
        /// </summary>
        public long? ScheduledTime { get; set; }

        /// <summary>
        /// If uncertainty is omitted, it is interpreted as unknown. To specify a completely certain prediction, set its uncertainty to 0.
        /// </summary>
        public int? Uncertainty { get; set; }
    }
}
