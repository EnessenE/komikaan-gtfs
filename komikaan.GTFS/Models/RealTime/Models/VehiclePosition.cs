using komikaan.GTFS.Models.RealTime.Enums;
using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// Realtime positioning information for a given vehicle.
    /// </summary>
    [ProtoContract(Name = "VehiclePosition")]
    public class VehiclePosition : GTFSRealtimeObject
    {
        /// <summary>
        /// The Trip that this vehicle is serving.
        /// </summary>
        [ProtoMember(1)]
        public TripDescriptor? Trip { get; set; }

        /// <summary>
        /// Current position of this vehicle.
        /// </summary>
        [ProtoMember(2)]
        public Position? Position { get; set; }

        /// <summary>
        /// The stop sequence index of the current stop.
        /// </summary>
        [ProtoMember(3)]
        public uint? CurrentStopSequence { get; set; }

        /// <summary>
        /// The exact status of the vehicle with respect to the current stop.
        /// </summary>
        [ProtoMember(4)]
        public VehicleStopStatus CurrentStatus { get; set; } = VehicleStopStatus.InTransitTo;

        /// <summary>
        /// Moment at which the vehicle's position was measured, in POSIX time.
        /// </summary>
        [ProtoMember(5)]
        public ulong? Timestamp { get; set; }

        /// <summary>
        /// Congestion level that is affecting this vehicle.
        /// </summary>
        [ProtoMember(6)]
        public CongestionLevel? CongestionLevel { get; set; }

        /// <summary>
        /// Identifies the current stop. Must be the same as in stops.txt.
        /// </summary>
        [ProtoMember(7)]
        public string? StopId { get; set; }

        /// <summary>
        /// Additional information on the vehicle that is serving this trip.
        /// </summary>
        [ProtoMember(8)]
        public VehicleDescriptor? Vehicle { get; set; }

        /// <summary>
        /// The state of passenger occupancy for the vehicle. Experimental.
        /// </summary>
        [ProtoMember(9)]
        public OccupancyStatus? OccupancyStatus { get; set; }

        /// <summary>
        /// A percentage value indicating the degree of passenger occupancy in the vehicle. Experimental.
        /// </summary>
        [ProtoMember(10)]
        public uint? OccupancyPercentage { get; set; }

        /// <summary>
        /// Details of the multiple carriages of this given vehicle. Experimental.
        /// </summary>
        [ProtoMember(11)]
        public List<CarriageDetails> MultiCarriageDetails { get; set; } = new List<CarriageDetails>();
    }
}
