using komikaan.GTFS.Models.RealTime.Enums;
using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// Carriage specific details, used for vehicles composed of several carriages. Experimental.
    /// </summary>
    [ProtoContract(Name = "CarriageDetails")]
    public class CarriageDetails : GTFSRealtimeObject
    {
        /// <summary>
        /// Identification of the carriage. Should be unique per vehicle.
        /// </summary>
        [ProtoMember(1)]
        public string? Id { get; set; }

        /// <summary>
        /// User visible label that may be shown to the passenger to help identify the carriage.
        /// </summary>
        [ProtoMember(2)]
        public string? Label { get; set; }

        /// <summary>
        /// Occupancy status for this given carriage, in this vehicle.
        /// </summary>
        [ProtoMember(3)]
        public OccupancyStatus OccupancyStatus { get; set; } = OccupancyStatus.NoDataAvailable;

        /// <summary>
        /// Occupancy percentage for this given carriage, in this vehicle. Use -1 in case data is not available.
        /// </summary>
        [ProtoMember(4)]
        public int? OccupancyPercentage { get; set; }

        /// <summary>
        /// Identifies the order of this carriage with respect to the other carriages in the vehicle's list of CarriageStatus.
        /// </summary>
        [ProtoMember(5)]
        public required uint CarriageSequence { get; set; }
    }
}
