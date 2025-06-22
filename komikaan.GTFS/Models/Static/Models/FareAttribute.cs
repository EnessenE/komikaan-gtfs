using komikaan.GTFS.Models.Static.Enums;

namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents fare information for a transit agency's routes.
    /// </summary>
    public class FareAttribute : GTFSStaticObject
    {
        /// <summary>
        /// Identifies a fare class.
        /// </summary>
        public string FareId { get; set; }

        /// <summary>
        /// Fare price, in the unit specified by currency_type.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Currency used to pay the fare.
        /// </summary>
        public string CurrencyType { get; set; }

        /// <summary>
        /// Indicates when the fare must be paid.
        /// </summary>
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Indicates the number of transfers permitted on this fare.
        /// </summary>
        public Transfers Transfers { get; set; }

        /// <summary>
        /// Identifies the relevant agency for a fare.
        /// </summary>
        public string AgencyId { get; set; }

        /// <summary>
        /// Length of time in seconds before a transfer expires.
        /// </summary>
        public int TransferDuration { get; set; }
    }
}
