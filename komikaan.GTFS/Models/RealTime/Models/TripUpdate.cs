using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// Realtime update on the progress of a vehicle along a trip.
    /// </summary>
    [ProtoContract(Name = "TripUpdate")]
    public class TripUpdate : GTFSRealtimeObject
    {
        /// <summary>
        /// The Trip that this message applies to.
        /// </summary>
        [ProtoMember(1)]
        public required TripDescriptor Trip { get; set; }

        /// <summary>
        /// Additional information on the vehicle that is serving this trip.
        /// </summary>
        [ProtoMember(2)]
        public List<StopTimeUpdate> StopTimeUpdate { get; set; } = new List<StopTimeUpdate>();

        /// <summary>
        /// Updates to StopTimes for the trip. The updates must be sorted by stop_sequence.
        /// </summary>
        [ProtoMember(3)]
        public VehicleDescriptor? Vehicle { get; set; }

        /// <summary>
        /// The most recent moment at which the vehicle's real-time progress was measured. In POSIX time.
        /// </summary>
        [ProtoMember(4)]
        public ulong? Timestamp { get; set; }

        /// <summary>
        /// The current schedule deviation for the trip, in seconds. Experimental.
        /// </summary>
        [ProtoMember(5)]
        public int? Delay { get; set; }

        /// <summary>
        /// Provides the updated properties for the trip. Experimental.
        /// </summary>\n        [ProtoMember(6)]
        public TripProperties? TripProperties { get; set; }
    }
}
