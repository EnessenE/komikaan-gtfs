using komikaan.GTFS.Models.RealTime.Enums;
using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// Realtime update for certain properties defined within GTFS stop_times.txt. Experimental.
    /// </summary>
    [ProtoContract]
    public class StopTimeProperties : GTFSRealtimeObject
    {
        /// <summary>
        /// Supports real-time stop assignments. Refers to a stop_id defined in the GTFS stops.txt.
        /// </summary>
        public string? AssignedStopId { get; set; }

        /// <summary>
        /// The updated headsign of the vehicle at the stop.
        /// </summary>
        public string? StopHeadsign { get; set; }

        /// <summary>
        /// The updated drop off type of the vehicle at the stop.
        /// </summary>
        public DropOffPickupType? DropOffType { get; set; }

        /// <summary>
        /// The updated pickup type of the vehicle at the stop.
        /// </summary>
        public DropOffPickupType? PickupType { get; set; }
    }
}
