namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// A definition (or update) of an entity in the transit feed.
    /// </summary>
    public class FeedEntity
    {
        /// <summary>
        /// Feed-unique identifier for this entity.
        /// </summary>
        public required string Id { get; set; }

        /// <summary>
        /// Whether this entity is to be deleted. Should be provided only for feeds with Incrementality of DIFFERENTIAL.
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Data about the realtime departure delays of a trip.
        /// </summary>
        public TripUpdate? TripUpdate { get; set; }

        /// <summary>
        /// Data about the realtime position of a vehicle.
        /// </summary>
        public VehiclePosition? Vehicle { get; set; }

        /// <summary>
        /// Data about a realtime alert.
        /// </summary>
        public Alert? Alert { get; set; }

        /// <summary>
        /// Data about the realtime added shapes, such as for a detour. Experimental.
        /// </summary>
        public Shape? Shape { get; set; }

        /// <summary>
        /// A new stop added to the feed dynamically. Experimental.
        /// </summary>
        public Stop? Stop { get; set; }

        /// <summary>
        /// List of trips affected by a particular modifications, such as a detour. Experimental.
        /// </summary>
        public TripModifications? TripModifications { get; set; }
    }
}
