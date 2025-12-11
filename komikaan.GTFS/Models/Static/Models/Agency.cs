using komikaan.GTFS.Models.Static.Enums;

namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents a transit agency with service represented in the dataset.
    /// </summary>
    public class Agency : GTFSStaticObject
    {
        /// <summary>
        /// Identifies a transit brand which is often synonymous with a transit agency.
        /// Required when the dataset contains data for multiple transit agencies.
        /// Recommended otherwise.
        /// </summary>
        public string AgencyId { get; set; }

        /// <summary>
        /// Full name of the transit agency.
        /// </summary>
        public string AgencyName { get; set; }

        /// <summary>
        /// URL of the transit agency.
        /// </summary>
        public string AgencyUrl { get; set; }

        /// <summary>
        /// Timezone where the transit agency is located. If multiple agencies are specified in the dataset, each must have the same agency_timezone.
        /// </summary>
        public string AgencyTimezone { get; set; }

        /// <summary>
        /// Primary language used by this transit agency. Should be provided to help GTFS consumers choose capitalization rules and other language-specific settings for the dataset.
        /// </summary>
        public string AgencyLang { get; set; }

        /// <summary>
        /// A voice telephone number for the specified agency. This field is a string value that presents the telephone number as typical for the agency's service area.
        /// </summary>
        public string AgencyPhone { get; set; }

        /// <summary>
        /// URL of a web page where a rider can purchase tickets or other fare instruments for that agency, or a web page containing information about that agency's fares.
        /// </summary>
        public string AgencyFareUrl { get; set; }

        /// <summary>
        /// Email address actively monitored by the agency's customer service department.
        /// </summary>
        public string AgencyEmail { get; set; }

        /// <summary>
        /// Indicates if riders can access a transit service (i.e., trip) associated with this agency by using a contactless EMV (Europay, Mastercard, and Visa) card 
        /// or mobile device as fare media at a fare validator (such as in pay-as-you-go or open-loop systems). 
        /// This field does not indicate that cEMV can be used to purchase other fare products or to add value to another fare media.
        /// </summary>
        /// <remarks>If both agency.cemv_support and routes.cemv_support are provided for the same service, the value in routes.cemv_support shall take precedence.</remarks>
        public CemvSupport? CemvSupport { get; set; }
    }
}
