using komikaan.GTFS.Models.Static;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// A selector for an entity in a GTFS feed.
    /// </summary>
    public class EntitySelector : GTFSRealtimeObject
    {
        /// <summary>
        /// The agency_id from the GTFS feed that this selector refers to.
        /// </summary>
        public string? AgencyId { get; set; }

        /// <summary>
        /// The route_id from the GTFS that this selector refers to.
        /// </summary>
        public string? RouteId { get; set; }

        /// <summary>
        /// The route_type from the GTFS that this selector refers to.
        /// </summary>
        public int? RouteType { get; set; }

        /// <summary>
        /// The direction_id from the GTFS feed trips.txt file. Experimental.
        /// </summary>
        public uint? DirectionId { get; set; }

        /// <summary>
        /// The trip instance from the GTFS that this selector refers to.
        /// </summary>
        public TripDescriptor? Trip { get; set; }

        /// <summary>
        /// The stop_id from the GTFS feed that this selector refers to.
        /// </summary>
        public string? StopId { get; set; }
    }
}
