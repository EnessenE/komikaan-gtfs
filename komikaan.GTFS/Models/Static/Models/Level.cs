namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents a level within a station.
    /// </summary>
    public class Level : GTFSStaticObject
    {
        /// <summary>
        /// Identifies a level.
        /// </summary>
        public string LevelId { get; set; }

        /// <summary>
        /// Numeric index of the level, corresponding to elevator levels.
        /// </summary>
        public double LevelIndex { get; set; }

        /// <summary>
        /// Optional name of the level.
        /// </summary>
        public string? LevelName { get; set; }
    }
}
