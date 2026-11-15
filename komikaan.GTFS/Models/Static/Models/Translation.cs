namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents a translation of a customer-facing dataset value.
    /// The table_name values are the translatable file names without the .txt extension
    /// (agency, stops, routes, trips, stop_times, pathways, levels, feed_info, attributions).
    /// </summary>
    public class Translation : GTFSStaticObject
    {
        /// <summary>
        /// Name of the table that contains the field to be translated.
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// Name of the field to be translated.
        /// </summary>
        public string FieldName { get; set; }

        /// <summary>
        /// Language of the translation.
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Translated value.
        /// </summary>
        public string TranslationValue { get; set; }

        /// <summary>
        /// Record that corresponds to the field to be translated (primary key of the referenced table).
        /// </summary>
        public string? RecordId { get; set; }

        /// <summary>
        /// Secondary ID of the record, for tables without a unique ID (e.g. stop_sequence for stop_times).
        /// </summary>
        public string? RecordSubId { get; set; }

        /// <summary>
        /// Exact value of the field to translate, used instead of record_id/record_sub_id.
        /// </summary>
        public string? FieldValue { get; set; }
    }
}
