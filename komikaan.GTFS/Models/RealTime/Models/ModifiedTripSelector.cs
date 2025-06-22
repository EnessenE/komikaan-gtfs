namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// When a service is affected by a trip modification, ModifiedTripSelector is used to select some trip.
    /// </summary>
    public class ModifiedTripSelector
    {
        /// <summary>
        /// The id of the FeedEntity in which the contained TripModifications object affects this trip.
        /// </summary>
        public required string ModificationsId { get; set; }

        /// <summary>
        /// The trip_id from the GTFS feed that is modified by the modifications_id.
        /// </summary>
        public required string AffectedTripId { get; set; }

        /// <summary>
        /// The initially scheduled start time of this trip instance, applied to the frequency based modified trip.
        /// </summary>
        public string? StartTime { get; set; }

        /// <summary>
        /// The start date of this trip instance in YYYYMMDD format, applied to the modified trip.
        /// </summary>
        public string? StartDate { get; set; }
    }
}
