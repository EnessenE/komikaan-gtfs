namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents the assignment of a stop to a location group.
    /// </summary>
    public class LocationGroupStop : GTFSStaticObject
    {
        /// <summary>
        /// Location group the stop belongs to.
        /// </summary>
        public string LocationGroupId { get; set; }

        /// <summary>
        /// Stop assigned to the location group.
        /// </summary>
        public string StopId { get; set; }
    }
}
