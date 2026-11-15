using komikaan.GTFS.Models.Static.Enums;

namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents rules for making connections at transfer points between routes.
    /// </summary>
    public class Transfer : GTFSStaticObject
    {
        /// <summary>
        /// Identifies a stop or station where a connection begins.
        /// </summary>
        public string FromStopId { get; set; }

        /// <summary>
        /// Identifies a stop or station where a connection ends.
        /// </summary>
        public string ToStopId { get; set; }

        /// <summary>
        /// Identifies a route where a connection begins.
        /// </summary>
        public string? FromRouteId { get; set; }

        /// <summary>
        /// Identifies a route where a connection ends.
        /// </summary>
        public string? ToRouteId { get; set; }

        /// <summary>
        /// Identifies a trip where a connection begins.
        /// </summary>
        public string? FromTripId { get; set; }

        /// <summary>
        /// Identifies a trip where a connection ends.
        /// </summary>
        public string? ToTripId { get; set; }

        /// <summary>
        /// Indicates the type of connection for the specified transfer.
        /// </summary>
        public TransferType TransferType { get; set; }

        /// <summary>
        /// Amount of time in seconds that must be available to permit a transfer.
        /// </summary>
        public int MinTransferTime { get; set; }
    }
}
