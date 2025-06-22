namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents rules to apply fares for itineraries.
    /// </summary>
    public class FareRule
    {
        /// <summary>
        /// Identifies a fare class.
        /// </summary>
        public string FareId { get; set; }

        /// <summary>
        /// Identifies a route associated with the fare class.
        /// </summary>
        public string RouteId { get; set; }

        /// <summary>
        /// Identifies an origin zone.
        /// </summary>
        public string OriginId { get; set; }

        /// <summary>
        /// Identifies a destination zone.
        /// </summary>
        public string DestinationId { get; set; }

        /// <summary>
        /// Identifies the zones that a rider will enter while using a given fare class.
        /// </summary>
        public string ContainsId { get; set; }
    }
}
