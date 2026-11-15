using komikaan.GTFS.Models.Static.Enums;

namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents fare media that can be used to purchase or validate fare products.
    /// </summary>
    public class FareMedia : GTFSStaticObject
    {
        /// <summary>
        /// Identifies a fare media.
        /// </summary>
        public string FareMediaId { get; set; }

        /// <summary>
        /// Name of the fare media, displayed to riders.
        /// </summary>
        public string? FareMediaName { get; set; }

        /// <summary>
        /// Type of the fare media.
        /// </summary>
        public FareMediaType FareMediaType { get; set; }
    }
}
