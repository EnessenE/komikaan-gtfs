using komikaan.GTFS.Models.Static.Enums;

namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents headway (time between trips) for headway-based service.
    /// </summary>
    public class Frequency
    {
        /// <summary>
        /// Identifies a trip to which the specified headway of service applies.
        /// </summary>
        public string TripId { get; set; }

        /// <summary>
        /// Time at which the first vehicle departs from the first stop of the trip.
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// Time at which service changes to a different headway.
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        /// Time in seconds between departures from the same stop.
        /// </summary>
        public int HeadwaySecs { get; set; }

        /// <summary>
        /// Indicates the type of service for a trip.
        /// </summary>
        public ExactTimes ExactTimes { get; set; }
    }
}
