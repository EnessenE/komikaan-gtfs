using komikaan.GTFS.Models.RealTime.Enums;
using komikaan.GTFS.Models.Static;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// Carriage specific details, used for vehicles composed of several carriages. Experimental.
    /// </summary>
    public class CarriageDetails : GTFSRealtimeObject
    {
        /// <summary>
        /// Identification of the carriage. Should be unique per vehicle.
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// User visible label that may be shown to the passenger to help identify the carriage.
        /// </summary>
        public string? Label { get; set; }

        /// <summary>
        /// Occupancy status for this given carriage, in this vehicle.
        /// </summary>
        public OccupancyStatus OccupancyStatus { get; set; } = OccupancyStatus.NoDataAvailable;

        /// <summary>
        /// Occupancy percentage for this given carriage, in this vehicle. Use -1 in case data is not available.
        /// </summary>
        public int? OccupancyPercentage { get; set; }

        /// <summary>
        /// Identifies the order of this carriage with respect to the other carriages in the vehicle's list of CarriageStatus.
        /// </summary>
        public required uint CarriageSequence { get; set; }
    }
}
