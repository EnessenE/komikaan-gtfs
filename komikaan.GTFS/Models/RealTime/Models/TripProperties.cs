namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// Defines updated properties of a trip. Experimental.
    /// </summary>
    public class TripProperties
    {
        /// <summary>
        /// Defines the identifier of a new trip that is a duplicate of an existing trip. Required if schedule_relationship is DUPLICATED.
        /// </summary>
        public string? TripId { get; set; }

        /// <summary>
        /// Service date on which the duplicated trip will be run (YYYYMMDD). Required if schedule_relationship is DUPLICATED.
        /// </summary>
        public string? StartDate { get; set; }

        /// <summary>
        /// Defines the departure start time of the duplicated trip. Required if schedule_relationship is DUPLICATED.
        /// </summary>
        public string? StartTime { get; set; }

        /// <summary>
        /// Specifies the headsign for this trip when it differs from the original.
        /// </summary>
        public string? TripHeadsign { get; set; }

        /// <summary>
        /// Specifies the name for this trip when it differs from the original.
        /// </summary>
        public string? TripShortName { get; set; }

        /// <summary>
        /// Specifies the identifier of the shape of the vehicle travel path when the trip shape differs from the shape specified in GTFS.
        /// </summary>
        public string? ShapeId { get; set; }
    }
}
