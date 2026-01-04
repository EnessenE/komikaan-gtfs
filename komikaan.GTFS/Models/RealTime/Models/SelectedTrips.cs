using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// List of selected trips with an associated shape. Experimental.
    /// </summary>
    [ProtoContract(Name = "SelectedTrips")]
    public class SelectedTrips : GTFSRealtimeObject
    {
        /// <summary>
        /// A list of trip_id from the original (CSV) GTFS that are affected by the containing replacement.
        /// </summary>
        [ProtoMember(1)]
        public List<uint> TripIds { get; set; } = new List<uint>();

        /// <summary>
        /// The ID of the new shape for the modified trips in this SelectedTrips.
        /// </summary>
        [ProtoMember(2)]
        public required string ShapeId { get; set; }
    }
}
