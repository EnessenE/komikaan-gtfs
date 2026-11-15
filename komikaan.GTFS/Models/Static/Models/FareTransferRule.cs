using komikaan.GTFS.Models.Static.Enums;

namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents a fare rule for transfers between legs of travel.
    /// </summary>
    public class FareTransferRule : GTFSStaticObject
    {
        /// <summary>
        /// Leg group of the incoming leg.
        /// </summary>
        public string? FromLegGroupId { get; set; }

        /// <summary>
        /// Leg group of the outgoing leg.
        /// </summary>
        public string? ToLegGroupId { get; set; }

        /// <summary>
        /// Number of transfers this rule applies to.
        /// </summary>
        public int? TransferCount { get; set; }

        /// <summary>
        /// Maximum duration of the transfer, in seconds.
        /// </summary>
        public int? DurationLimit { get; set; }

        /// <summary>
        /// What the duration limit is measured between.
        /// </summary>
        public DurationLimitType? DurationLimitType { get; set; }

        /// <summary>
        /// Which fare products apply for the transfer.
        /// </summary>
        public FareTransferType FareTransferType { get; set; }

        /// <summary>
        /// Fare product to pay for the transfer.
        /// </summary>
        public string? FareProductId { get; set; }
    }
}
