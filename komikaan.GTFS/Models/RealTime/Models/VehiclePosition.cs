using komikaan.GTFS.Models.RealTime.Enums;
using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// Realtime positioning information for a given vehicle.
    /// </summary>
    [ProtoContract]
    public class VehiclePosition : GTFSRealtimeObject
    {
        /// <summary>
        /// The Trip that this vehicle is serving.
        /// </summary>
        public TripDescriptor? Trip { get; set; }

        /// <summary>
        /// Additional information on the vehicle that is serving this trip.
        /// </summary>
        public VehicleDescriptor? Vehicle { get; set; }

        /// <summary>
        /// Current position of this vehicle.
        /// </summary>
        public Position? Position { get; set; }

        /// <summary>
        /// The stop sequence index of the current stop.
        /// </summary>
        public uint? CurrentStopSequence { get; set; }

        /// <summary>
        /// Identifies the current stop. Must be the same as in stops.txt.
        /// </summary>
        public string? StopId { get; set; }

        /// <summary>
        /// The exact status of the vehicle with respect to the current stop.
        /// </summary>
        public VehicleStopStatus CurrentStatus { get; set; } = VehicleStopStatus.InTransitTo;

        /// <summary>
        /// Moment at which the vehicle's position was measured, in POSIX time.
        /// </summary>
        public ulong? Timestamp { get; set; }

        /// <summary>
        /// Congestion level that is affecting this vehicle.
        /// </summary>
        public CongestionLevel? CongestionLevel { get; set; }

        /// <summary>
        /// The state of passenger occupancy for the vehicle. Experimental.
        /// </summary>
        public OccupancyStatus? OccupancyStatus { get; set; }

        /// <summary>
        /// A percentage value indicating the degree of passenger occupancy in the vehicle. Experimental.
        /// </summary>
        public uint? OccupancyPercentage { get; set; }

        /// <summary>
        /// Details of the multiple carriages of this given vehicle. Experimental.
        /// </summary>
        public List<CarriageDetails> MultiCarriageDetails { get; set; } = new List<CarriageDetails>();
    }
}
