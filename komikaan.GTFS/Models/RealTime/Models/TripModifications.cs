using komikaan.GTFS.Models.Static;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// A TripModifications message identifies a list of similar trips which are all affected by particular modifications, such as a detour. Experimental.
    /// </summary>
    public class TripModifications : GTFSRealtimeObject
    {
        /// <summary>
        /// A list of selected trips affected by this TripModifications.
        /// </summary>
        public required List<SelectedTrips> SelectedTrips { get; set; }

        /// <summary>
        /// A list of start times in the real-time trip descriptor for the trip_id defined in trip_ids.
        /// </summary>
        public List<string> StartTimes { get; set; } = new List<string>();

        /// <summary>
        /// Dates on which the modification occurs, in the YYYYMMDD format.
        /// </summary>
        public required List<string> ServiceDates { get; set; }

        /// <summary>
        /// A list of modifications to apply to the affected trips.
        /// </summary>
        public required List<Modification> Modifications { get; set; }
    }
}
