namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents a fare product that riders can purchase (e.g. a ticket or pass).
    /// </summary>
    public class FareProduct : GTFSStaticObject
    {
        /// <summary>
        /// Identifies a fare product.
        /// </summary>
        public string FareProductId { get; set; }

        /// <summary>
        /// Name of the fare product, displayed to riders.
        /// </summary>
        public string? FareProductName { get; set; }

        /// <summary>
        /// Rider category this fare product is available to.
        /// </summary>
        public string? RiderCategoryId { get; set; }

        /// <summary>
        /// Fare media required to use this fare product.
        /// </summary>
        public string? FareMediaId { get; set; }

        /// <summary>
        /// Price of the fare product.
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Currency of the price.
        /// </summary>
        public string Currency { get; set; }
    }
}
