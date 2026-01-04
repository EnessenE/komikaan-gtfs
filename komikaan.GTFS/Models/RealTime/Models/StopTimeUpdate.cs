using komikaan.GTFS.Models.RealTime.Enums;
using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// Realtime update for arrival and/or departure events for a given stop on a trip.
    /// </summary>
    [ProtoContract(Name = "StopTimeUpdate")]
    public class StopTimeUpdate : GTFSRealtimeObject
    {
        /// <summary>
        /// Must be the same as in stop_times.txt. Required for trips that visit the same stop_id more than once.
        /// </summary>
        [ProtoMember(1)]
        public uint? StopSequence { get; set; }

        /// <summary>
        /// Arrival event timing information.
        /// </summary>
        [ProtoMember(2)]
        public StopTimeEvent? Arrival { get; set; }

        /// <summary>
        /// Departure event timing information.
        /// </summary>
        [ProtoMember(3)]
        public StopTimeEvent? Departure { get; set; }

        /// <summary>
        /// The relation between this StopTime and the static schedule.
        /// </summary>
        [ProtoMember(5)]
        public StopTimeScheduleRelationship ScheduleRelationship { get; set; } = StopTimeScheduleRelationship.Scheduled;

        /// <summary>
        /// Must be the same as in stops.txt.
        /// </summary>
        [ProtoMember(4)]
        public string? StopId { get; set; }

        /// <summary>
        /// The predicted state of passenger occupancy for the vehicle immediately after departure from the given stop. Experimental.
        /// </summary>
        [ProtoMember(7)]
        public OccupancyStatus? DepartureOccupancyStatus { get; set; }

        /// <summary>
        /// Realtime updates for certain properties defined within GTFS stop_times.txt. Experimental.
        /// </summary>
        [ProtoMember(6)]
        public StopTimeProperties? StopTimeProperties { get; set; }
    }
}
