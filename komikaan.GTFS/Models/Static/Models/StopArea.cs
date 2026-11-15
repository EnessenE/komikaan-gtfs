namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents the assignment of a stop to an area.
    /// </summary>
    public class StopArea : GTFSStaticObject
    {
        /// <summary>
        /// Area the stop belongs to.
        /// </summary>
        public string AreaId { get; set; }

        /// <summary>
        /// Stop assigned to the area.
        /// </summary>
        public string StopId { get; set; }
    }
}
