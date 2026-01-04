using komikaan.GTFS.Models.RealTime.Enums;
using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// Realtime update for certain properties defined within GTFS stop_times.txt. Experimental.
    /// </summary>
    [ProtoContract(Name = "StopTimeProperties")]
    public class StopTimeProperties : GTFSRealtimeObject
    {
        /// <summary>
        /// Supports real-time stop assignments. Refers to a stop_id defined in the GTFS stops.txt.
        /// </summary>
        [ProtoMember(1)]
        public string? AssignedStopId { get; set; }

        /// <summary>
        /// The updated headsign of the vehicle at the stop.
        /// </summary>
        [ProtoMember(2)]
        public string? StopHeadsign { get; set; }

        /// <summary>
        /// The updated pickup type of the vehicle at the stop.
        /// </summary>
        [ProtoMember(3)]
        public DropOffPickupType? PickupType { get; set; }

        /// <summary>
        /// The updated drop off type of the vehicle at the stop.
        /// </summary>
        [ProtoMember(4)]
        public DropOffPickupType? DropOffType { get; set; }
    }
}
