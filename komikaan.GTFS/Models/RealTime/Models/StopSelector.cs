namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// Selector for a stop. Either by stop_id or stop_sequence. Experimental.
    /// </summary>
    public class StopSelector
    {
        /// <summary>
        /// Must be the same as in stop_times.txt in the corresponding GTFS feed.
        /// </summary>
        public uint? StopSequence { get; set; }

        /// <summary>
        /// Must be the same as in stops.txt in the corresponding GTFS feed.
        /// </summary>
        public string? StopId { get; set; }
    }
}
