namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents a group of stops that together indicate a location where a rider may request pickup or drop off.
    /// </summary>
    public class LocationGroup : GTFSStaticObject
    {
        /// <summary>
        /// Identifies a location group.
        /// </summary>
        public string LocationGroupId { get; set; }

        /// <summary>
        /// Name of the location group.
        /// </summary>
        public string? LocationGroupName { get; set; }
    }
}
