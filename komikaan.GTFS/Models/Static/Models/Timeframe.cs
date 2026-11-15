namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents a date and time period used in fare rules for fares that depend on date and time factors.
    /// </summary>
    public class Timeframe : GTFSStaticObject
    {
        /// <summary>
        /// Identifies a group of timeframes.
        /// </summary>
        public string TimeframeGroupId { get; set; }

        /// <summary>
        /// Start of the period, as a local time.
        /// </summary>
        public TimeSpan? StartTime { get; set; }

        /// <summary>
        /// End of the period, as a local time.
        /// </summary>
        public TimeSpan? EndTime { get; set; }

        /// <summary>
        /// Service the timeframe applies to.
        /// </summary>
        public string ServiceId { get; set; }
    }
}
