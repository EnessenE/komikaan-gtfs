namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// A localized string mapped to a language.
    /// </summary>
    public class Translation
    {
        /// <summary>
        /// A UTF-8 string containing the message.
        /// </summary>
        public required string Text { get; set; }

        /// <summary>
        /// BCP-47 language code. Can be omitted if the language is unknown.
        /// </summary>
        public string? Language { get; set; }
    }
}
