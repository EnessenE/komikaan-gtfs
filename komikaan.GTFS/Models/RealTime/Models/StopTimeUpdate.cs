using komikaan.GTFS.Models.RealTime.Enums;
using komikaan.GTFS.Models.Static;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// Realtime update for arrival and/or departure events for a given stop on a trip.
    /// </summary>
    public class StopTimeUpdate : GTFSRealtimeObject
    {
        /// <summary>
        /// Must be the same as in stop_times.txt. Required for trips that visit the same stop_id more than once.
        /// </summary>
        public uint? StopSequence { get; set; }

        /// <summary>
        /// Must be the same as in stops.txt.
        /// </summary>
        public string? StopId { get; set; }

        /// <summary>
        /// Arrival event timing information.
        /// </summary>
        public StopTimeEvent? Arrival { get; set; }

        /// <summary>
        /// Departure event timing information.
        /// </summary>
        public StopTimeEvent? Departure { get; set; }

        /// <summary>
        /// The predicted state of passenger occupancy for the vehicle immediately after departure from the given stop. Experimental.
        /// </summary>
        public OccupancyStatus? DepartureOccupancyStatus { get; set; }

        /// <summary>
        /// The relation between this StopTime and the static schedule.
        /// </summary>
        public StopTimeScheduleRelationship ScheduleRelationship { get; set; } = StopTimeScheduleRelationship.Scheduled;

        /// <summary>
        /// Realtime updates for certain properties defined within GTFS stop_times.txt. Experimental.
        /// </summary>
        public StopTimeProperties? StopTimeProperties { get; set; }
    }
}
