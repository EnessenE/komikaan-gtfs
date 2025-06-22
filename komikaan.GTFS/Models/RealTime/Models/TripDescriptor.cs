using komikaan.GTFS.Models.RealTime.Enums;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// A descriptor that identifies a single instance of a GTFS trip.
    /// </summary>
    public class TripDescriptor
    {
        /// <summary>
        /// The trip_id from the GTFS feed that this selector refers to.
        /// </summary>
        public string? TripId { get; set; }

        /// <summary>
        /// The route_id from the GTFS that this selector refers to.
        /// </summary>
        public string? RouteId { get; set; }

        /// <summary>
        /// The direction_id from the GTFS feed trips.txt file. Experimental.
        /// </summary>
        public uint? DirectionId { get; set; }

        /// <summary>
        /// The initially scheduled start time of this trip instance.
        /// </summary>
        public string? StartTime { get; set; }

        /// <summary>
        /// The start date of this trip instance in YYYYMMDD format.
        /// </summary>
        public string? StartDate { get; set; }

        /// <summary>
        /// The relation between this trip and the static schedule.
        /// </summary>
        public TripScheduleRelationship? ScheduleRelationship { get; set; }

        /// <summary>
        /// Linkage to any modifications done to this trip (shape changes, removal or addition of stops).
        /// </summary>
        public ModifiedTripSelector? ModifiedTrip { get; set; }
    }
}
