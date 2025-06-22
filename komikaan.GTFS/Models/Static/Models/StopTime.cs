using komikaan.GTFS.Models.Static.Enums;

namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents the times that a vehicle arrives at and departs from stops for each trip.
    /// </summary>
    public class StopTime : GTFSStaticObject
    {
        /// <summary>
        /// Identifies a trip.
        /// </summary>
        public string TripId { get; set; }

        /// <summary>
        /// Arrival time at the stop.
        /// </summary>
        public string ArrivalTime { get; set; }

        /// <summary>
        /// Departure time from the stop.
        /// </summary>
        public string DepartureTime { get; set; }

        /// <summary>
        /// Identifies the serviced stop.
        /// </summary>
        public string StopId { get; set; }

        /// <summary>
        /// Order of stops for a particular trip.
        /// </summary>
        public int StopSequence { get; set; }

        /// <summary>
        /// Text that appears on signage identifying the trip's destination to riders.
        /// </summary>
        public string StopHeadsign { get; set; }

        /// <summary>
        /// Indicates pickup method.
        /// </summary>
        public PickupType PickupType { get; set; }

        /// <summary>
        /// Indicates drop off method.
        /// </summary>
        public DropOffType DropOffType { get; set; }

        /// <summary>
        /// Indicates continuous pickup behavior.
        /// </summary>
        public ContinuousPickup ContinuousPickup { get; set; }

        /// <summary>
        /// Indicates continuous drop-off behavior.
        /// </summary>
        public ContinuousDropOff ContinuousDropOff { get; set; }

        /// <summary>
        /// Actual distance traveled along the associated shape.
        /// </summary>
        public double ShapeDistTraveled { get; set; }

        /// <summary>
        /// Indicates if arrival and departure times are strictly adhered to.
        /// </summary>
        public Timepoint Timepoint { get; set; }
    }
}
