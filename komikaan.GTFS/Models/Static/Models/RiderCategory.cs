using komikaan.GTFS.Models.Static.Enums;

namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents a category of riders (e.g. elderly, student).
    /// </summary>
    public class RiderCategory : GTFSStaticObject
    {
        /// <summary>
        /// Identifies a rider category.
        /// </summary>
        public string RiderCategoryId { get; set; }

        /// <summary>
        /// Name of the rider category, displayed to riders.
        /// </summary>
        public string RiderCategoryName { get; set; }

        /// <summary>
        /// Whether this category is the default fare category.
        /// </summary>
        public DefaultFareCategory IsDefaultFareCategory { get; set; }

        /// <summary>
        /// URL describing the eligibility rules for this rider category.
        /// </summary>
        public string? EligibilityUrl { get; set; }
    }
}
