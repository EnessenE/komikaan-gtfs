namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents service dates specified using a weekly schedule with start and end dates.
    /// </summary>
    public class Calendar
    {
        /// <summary>
        /// Identifies a set of dates when service is available for one or more routes.
        /// </summary>
        public string ServiceId { get; set; }

        /// <summary>
        /// Indicates whether the service operates on all Mondays in the date range.
        /// </summary>
        public int Monday { get; set; }

        /// <summary>
        /// Indicates whether the service operates on all Tuesdays in the date range.
        /// </summary>
        public int Tuesday { get; set; }

        /// <summary>
        /// Indicates whether the service operates on all Wednesdays in the date range.
        /// </summary>
        public int Wednesday { get; set; }

        /// <summary>
        /// Indicates whether the service operates on all Thursdays in the date range.
        /// </summary>
        public int Thursday { get; set; }

        /// <summary>
        /// Indicates whether the service operates on all Fridays in the date range.
        /// </summary>
        public int Friday { get; set; }

        /// <summary>
        /// Indicates whether the service operates on all Saturdays in the date range.
        /// </summary>
        public int Saturday { get; set; }

        /// <summary>
        /// Indicates whether the service operates on all Sundays in the date range.
        /// </summary>
        public int Sunday { get; set; }

        /// <summary>
        /// Start service day for the service interval.
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// End service day for the service interval.
        /// </summary>
        public string EndDate { get; set; }
    }
}
