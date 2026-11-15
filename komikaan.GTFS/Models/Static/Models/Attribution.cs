using komikaan.GTFS.Models.Static.Enums;

namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents dataset attributions.
    /// </summary>
    public class Attribution : GTFSStaticObject
    {
        /// <summary>
        /// Identifies the attribution.
        /// </summary>
        public string? AttributionId { get; set; }

        /// <summary>
        /// Agency the attribution applies to.
        /// </summary>
        public string? AgencyId { get; set; }

        /// <summary>
        /// Route the attribution applies to.
        /// </summary>
        public string? RouteId { get; set; }

        /// <summary>
        /// Trip the attribution applies to.
        /// </summary>
        public string? TripId { get; set; }

        /// <summary>
        /// Name of the organization that is attributed.
        /// </summary>
        public string OrganizationName { get; set; }

        /// <summary>
        /// Whether the organization is the producer of the dataset.
        /// </summary>
        public AttributionRole? IsProducer { get; set; }

        /// <summary>
        /// Whether the organization is the operator of the service.
        /// </summary>
        public AttributionRole? IsOperator { get; set; }

        /// <summary>
        /// Whether the organization is the authority over the service.
        /// </summary>
        public AttributionRole? IsAuthority { get; set; }

        /// <summary>
        /// URL of the organization.
        /// </summary>
        public string? AttributionUrl { get; set; }

        /// <summary>
        /// Email of the organization.
        /// </summary>
        public string? AttributionEmail { get; set; }

        /// <summary>
        /// Phone number of the organization.
        /// </summary>
        public string? AttributionPhone { get; set; }
    }
}
