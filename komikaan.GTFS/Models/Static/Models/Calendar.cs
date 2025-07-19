namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents service dates specified using a weekly schedule with start and end dates.
    /// </summary>
    public class Calendar : GTFSStaticObject
    {
        /// <summary>
        /// Identifies a set of dates when service is available for one or more routes.
        /// </summary>
        public string ServiceId { get; set; }

        /// <summary>
        /// Indicates whether the service operates on all Mondays in the date range.
        /// </summary>
        public bool Monday { get; set; }

        /// <summary>
        /// Indicates whether the service operates on all Tuesdays in the date range.
        /// </summary>
        public bool Tuesday { get; set; }

        /// <summary>
        /// Indicates whether the service operates on all Wednesdays in the date range.
        /// </summary>
        public bool Wednesday { get; set; }

        /// <summary>
        /// Indicates whether the service operates on all Thursdays in the date range.
        /// </summary>
        public bool Thursday { get; set; }

        /// <summary>
        /// Indicates whether the service operates on all Fridays in the date range.
        /// </summary>
        public bool Friday { get; set; }

        /// <summary>
        /// Indicates whether the service operates on all Saturdays in the date range.
        /// </summary>
        public bool Saturday { get; set; }

        /// <summary>
        /// Indicates whether the service operates on all Sundays in the date range.
        /// </summary>
        public bool Sunday { get; set; }

        /// <summary>
        /// Start service day for the service boolerval.
        /// </summary>
        public DateOnly StartDate { get; set; }

        /// <summary>
        /// End service day for the service boolerval.
        /// </summary>
        public DateOnly EndDate { get; set; }
    }
}
