using komikaan.GTFS.Models.Static.Enums;

namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents pathways linking together locations within stations.
    /// </summary>
    public class Pathway : GTFSStaticObject
    {
        /// <summary>
        /// Identifies a pathway.
        /// </summary>
        public string PathwayId { get; set; }

        /// <summary>
        /// Location at which the pathway begins.
        /// </summary>
        public string FromStopId { get; set; }

        /// <summary>
        /// Location at which the pathway ends.
        /// </summary>
        public string ToStopId { get; set; }

        /// <summary>
        /// Type of pathway between the from/to location pair.
        /// </summary>
        public PathwayMode PathwayMode { get; set; }

        /// <summary>
        /// Indicates the direction that the pathway can be taken.
        /// </summary>
        public Bidirectional IsBidirectional { get; set; }

        /// <summary>
        /// Horizontal length in meters of the pathway.
        /// </summary>
        public double? Length { get; set; }

        /// <summary>
        /// Average time in seconds needed to walk through the pathway.
        /// </summary>
        public int? TraversalTime { get; set; }

        /// <summary>
        /// Number of stairs of the pathway. Positive implies walking up, negative walking down.
        /// </summary>
        public int? StairCount { get; set; }

        /// <summary>
        /// Maximum slope ratio of the pathway. 0 means no slope.
        /// </summary>
        public double? MaxSlope { get; set; }

        /// <summary>
        /// Minimum width of the pathway in meters.
        /// </summary>
        public double? MinWidth { get; set; }

        /// <summary>
        /// Public facing text from physical signage that is visible to riders.
        /// </summary>
        public string? SignpostedAs { get; set; }

        /// <summary>
        /// Same as signposted_as, but when the pathway is used in the reverse direction.
        /// </summary>
        public string? ReversedSignpostedAs { get; set; }
    }
}
