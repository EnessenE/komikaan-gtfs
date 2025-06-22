using komikaan.GTFS.Models.Static.Enums;

namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents exceptions for the services defined in the calendar.txt.
    /// </summary>
    public class CalendarDate : GTFSStaticObject
    {
        /// <summary>
        /// Identifies a set of dates when a service exception occurs.
        /// </summary>
        public string ServiceId { get; set; }

        /// <summary>
        /// Date when service exception occurs.
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// Indicates whether service is available on the specified date.
        /// </summary>
        public ExceptionType ExceptionType { get; set; }
    }
}
