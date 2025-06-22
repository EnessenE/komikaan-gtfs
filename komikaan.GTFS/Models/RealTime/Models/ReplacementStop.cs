using komikaan.GTFS.Models.Static;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// Each ReplacementStop message defines a stop that will now be visited by the trip, and optionally specifies the estimated travel time to the stop. Experimental.
    /// </summary>
    public class ReplacementStop : GTFSRealtimeObject
    {
        /// <summary>
        /// The replacement stop ID which will now be visited by the trip.
        /// </summary>
        public required string StopId { get; set; }

        /// <summary>
        /// The difference in seconds between the arrival time at this stop and the arrival time at the reference stop.
        /// </summary>
        public int? TravelTimeToStop { get; set; }
    }
}
