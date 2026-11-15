namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents a rule defining when two or more legs should be considered a single effective fare leg.
    /// </summary>
    public class FareLegJoinRule : GTFSStaticObject
    {
        /// <summary>
        /// Network of the incoming leg.
        /// </summary>
        public string FromNetworkId { get; set; }

        /// <summary>
        /// Network of the outgoing leg.
        /// </summary>
        public string ToNetworkId { get; set; }

        /// <summary>
        /// Stop where the incoming leg ends.
        /// </summary>
        public string? FromStopId { get; set; }

        /// <summary>
        /// Stop where the outgoing leg starts.
        /// </summary>
        public string? ToStopId { get; set; }
    }
}
