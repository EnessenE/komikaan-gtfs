using komikaan.GTFS.Models.Static.Enums;
using System.Diagnostics.Metrics;

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
        ///  Arrival time at the stop (defined by stop_times.stop_id) for a specific trip (defined by stop_times.trip_id) in the time zone specified by agency.agency_timezone, not stops.stop_timezone.
        ///        If there are not separate times for arrival and departure at a stop, arrival_time and departure_time should be the same.
        ///        For times occurring after midnight on the service day, enter the time as a value greater than 24:00:00 in HH:MM:SS.
        ///        If exact arrival and departure times (timepoint= 1) are not available, estimated or interpolated arrival and departure times(timepoint= 0) should be provided.
        ///
        ///        Conditionally Required:
        ///- Required for the first and last stop in a trip(defined by stop_times.stop_sequence).
        ///- Required for timepoint=1.
        ///- Forbidden when start_pickup_drop_off_window or end_pickup_drop_off_window are defined.
        ///- Optional otherwise.
        /// </summary>
        public TimeSpan? ArrivalTime { get; set; }

        /// <summary>
        /// Departure time from the stop.
        /// </summary>
        public TimeSpan? DepartureTime { get; set; }

        /// <summary>
        /// Identifies the serviced stop.
        /// </summary>
        public string? StopId { get; set; }

        /// <summary>
        /// Order of stops for a particular trip.
        /// </summary>
        public double StopSequence { get; set; }

        /// <summary>
        /// Text that appears on signage identifying the trip's destination to riders.
        /// </summary>
        public string? StopHeadsign { get; set; }

        /// <summary>
        /// Indicates pickup method.
        /// </summary>
        public PickupType? PickupType { get; set; }

        /// <summary>
        /// Indicates drop off method.
        /// </summary>
        public DropOffType? DropOffType { get; set; }

        /// <summary>
        /// Indicates continuous pickup behavior.
        /// </summary>
        public ContinuousPickup? ContinuousPickup { get; set; }

        /// <summary>
        /// Indicates continuous drop-off behavior.
        /// </summary>
        public ContinuousDropOff? ContinuousDropOff { get; set; }

        /// <summary>
        /// Actual distance traveled along the associated shape.
        /// </summary>
        public double? ShapeDistTraveled { get; set; }

        /// <summary>
        /// Indicates if arrival and departure times are strictly adhered to.
        /// </summary>
        public Timepoint Timepoint { get; set; }
    }
}
