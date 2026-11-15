namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents an area: a grouping of stops/locations.
    /// </summary>
    public class Area : GTFSStaticObject
    {
        /// <summary>
        /// Identifies an area.
        /// </summary>
        public string AreaId { get; set; }

        /// <summary>
        /// Name of the area.
        /// </summary>
        public string? AreaName { get; set; }
    }
}
