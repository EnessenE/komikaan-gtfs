using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// List of selected trips with an associated shape. Experimental.
    /// </summary>
    [ProtoContract]
    public class SelectedTrips : GTFSRealtimeObject
    {
        /// <summary>
        /// A list of trip_id from the original (CSV) GTFS that are affected by the containing replacement.
        /// </summary>
        public List<uint> TripIds { get; set; } = new List<uint>();

        /// <summary>
        /// The ID of the new shape for the modified trips in this SelectedTrips.
        /// </summary>
        public required string ShapeId { get; set; }
    }
}
