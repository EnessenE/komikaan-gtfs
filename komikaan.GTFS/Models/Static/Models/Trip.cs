using komikaan.GTFS.Models.Static.Enums;

namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents trips for each route. A trip is a sequence of two or more stops that occur during a specific time period.
    /// </summary>
    public class Trip : GTFSStaticObject
    {
        /// <summary>
        /// Identifies a route.
        /// </summary>
        public string RouteId { get; set; }

        /// <summary>
        /// Identifies a set of dates when service is available for one or more routes.
        /// </summary>
        public string ServiceId { get; set; }

        /// <summary>
        /// Identifies a trip.
        /// </summary>
        public string TripId { get; set; }

        /// <summary>
        /// Text that appears on signage identifying the trip's destination to riders.
        /// </summary>
        public string? TripHeadsign { get; set; }

        /// <summary>
        /// Public facing text used to identify the trip to riders.
        /// </summary>
        public string? TripShortName { get; set; }

        /// <summary>
        /// Indicates the direction of travel for a trip.
        /// </summary>
        public Direction? DirectionId { get; set; }

        /// <summary>
        /// Identifies the block to which the trip belongs.
        /// </summary>
        public string? BlockId { get; set; }

        /// <summary>
        /// Identifies a geospatial shape describing the vehicle travel path for a trip.
        /// </summary>
        public string? ShapeId { get; set; }

        /// <summary>
        /// Indicates wheelchair accessibility.
        /// </summary>
        public WheelchairAccessible? WheelchairAccessible { get; set; }

        /// <summary>
        /// Indicates whether bikes are allowed.
        /// </summary>
        public BikesAllowed? BikesAllowed { get; set; }

        /// <summary>
        /// Indicates whether cars are allowed.
        /// </summary>
        public CarsAllowed? CarsAllowed { get; set; }


    }
}
