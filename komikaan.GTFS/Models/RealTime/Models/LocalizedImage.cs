namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// A localized image URL mapped to a language.
    /// </summary>
    public class LocalizedImage
    {
        /// <summary>
        /// String containing a URL linking to an image. The image linked must be less than 2MB.
        /// </summary>
        public required string Url { get; set; }

        /// <summary>
        /// IANA media type as to specify the type of image to be displayed. The type must start with "image/".
        /// </summary>
        public required string MediaType { get; set; }

        /// <summary>
        /// BCP-47 language code. Can be omitted if the language is unknown.
        /// </summary>
        public string? Language { get; set; }
    }
}
