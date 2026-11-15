namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents a fare rule for an individual leg of travel (an effective fare leg).
    /// </summary>
    public class FareLegRule : GTFSStaticObject
    {
        /// <summary>
        /// Identifies a group of legs this rule applies to.
        /// </summary>
        public string? LegGroupId { get; set; }

        /// <summary>
        /// Network the leg belongs to.
        /// </summary>
        public string? NetworkId { get; set; }

        /// <summary>
        /// Area where the leg starts.
        /// </summary>
        public string? FromAreaId { get; set; }

        /// <summary>
        /// Area where the leg ends.
        /// </summary>
        public string? ToAreaId { get; set; }

        /// <summary>
        /// Timeframe group in which the leg starts.
        /// </summary>
        public string? FromTimeframeGroupId { get; set; }

        /// <summary>
        /// Timeframe group in which the leg ends.
        /// </summary>
        public string? ToTimeframeGroupId { get; set; }

        /// <summary>
        /// Fare product that applies to the leg.
        /// </summary>
        public string FareProductId { get; set; }

        /// <summary>
        /// Priority of the rule when multiple rules match. Lower values take precedence.
        /// </summary>
        public int? RulePriority { get; set; }
    }
}
