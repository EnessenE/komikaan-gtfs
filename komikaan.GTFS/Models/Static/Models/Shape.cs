namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents rules for mapping vehicle travel paths.
    /// </summary>
    public class Shape : GTFSStaticObject
    {
        /// <summary>
        /// Identifies a shape.
        /// </summary>
        public string ShapeId { get; set; }

        /// <summary>
        /// Latitude of a shape point.
        /// </summary>
        public double ShapePtLat { get; set; }

        /// <summary>
        /// Longitude of a shape point.
        /// </summary>
        public double ShapePtLon { get; set; }

        /// <summary>
        /// Sequence in which the shape points connect to form the shape.
        /// </summary>
        public int ShapePtSequence { get; set; }

        /// <summary>
        /// Actual distance traveled along the shape from the first shape point to this point.
        /// </summary>
        public double ShapeDistTraveled { get; set; }
    }
}
