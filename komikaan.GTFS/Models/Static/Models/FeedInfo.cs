namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents dataset metadata.
    /// </summary>
    public class FeedInfo
    {
        /// <summary>
        /// Full name of the organization that publishes the dataset.
        /// </summary>
        public string FeedPublisherName { get; set; }

        /// <summary>
        /// URL of the dataset publishing organization's website.
        /// </summary>
        public string FeedPublisherUrl { get; set; }

        /// <summary>
        /// Default language used for the text in this dataset.
        /// </summary>
        public string FeedLang { get; set; }

        /// <summary>
        /// Defines the language that should be used when the data consumer doesn't know the language of the rider.
        /// </summary>
        public string DefaultLang { get; set; }

        /// <summary>
        /// The dataset provides complete and reliable schedule information for service in this period.
        /// </summary>
        public string FeedStartDate { get; set; }

        /// <summary>
        /// The dataset provides complete and reliable schedule information for service in this period.
        /// </summary>
        public string FeedEndDate { get; set; }

        /// <summary>
        /// String that indicates the current version of their GTFS dataset.
        /// </summary>
        public string FeedVersion { get; set; }

        /// <summary>
        /// Email address for communication regarding the GTFS dataset.
        /// </summary>
        public string FeedContactEmail { get; set; }

        /// <summary>
        /// URL for contact information for the GTFS dataset.
        /// </summary>
        public string FeedContactUrl { get; set; }
    }
}
