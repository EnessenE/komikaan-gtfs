using komikaan.GTFS.Models.Static;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// Describes the physical path that a vehicle takes when the shape is not part of the (CSV) GTFS, such as for an ad-hoc detour. Experimental.
    /// </summary>
    public class Shape : GTFSRealtimeObject
    {
        /// <summary>
        /// Identifier of the shape. Must be different than any shape_id defined in the (CSV) GTFS.
        /// </summary>
        public required string ShapeId { get; set; }

        /// <summary>
        /// Encoded polyline representation of the shape. This polyline must contain at least two points.
        /// </summary>
        public required string EncodedPolyline { get; set; }
    }
}
