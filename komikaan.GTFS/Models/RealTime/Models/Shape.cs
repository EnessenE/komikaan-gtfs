using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// Describes the physical path that a vehicle takes when the shape is not part of the (CSV) GTFS, such as for an ad-hoc detour. Experimental.
    /// </summary>
    [ProtoContract(Name = "Shape")]
    public class Shape : GTFSRealtimeObject
    {
        /// <summary>
        /// Identifier of the shape. Must be different than any shape_id defined in the (CSV) GTFS.
        /// </summary>
        [ProtoMember(1)]
        public required string ShapeId { get; set; }

        /// <summary>
        /// Encoded polyline representation of the shape. This polyline must contain at least two points.
        /// </summary>
        [ProtoMember(2)]
        public required string EncodedPolyline { get; set; }
    }
}
