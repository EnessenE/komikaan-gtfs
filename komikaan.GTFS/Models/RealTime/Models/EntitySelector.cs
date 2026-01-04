using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// A selector for an entity in a GTFS feed.
    /// </summary>
    [ProtoContract(Name = "EntitySelector")]
    public class EntitySelector : GTFSRealtimeObject
    {
        /// <summary>
        /// The agency_id from the GTFS feed that this selector refers to.
        /// </summary>
        [ProtoMember(1)]
        public string? AgencyId { get; set; }

        /// <summary>
        /// The route_id from the GTFS that this selector refers to.
        /// </summary>
        [ProtoMember(2)]
        public string? RouteId { get; set; }

        /// <summary>
        /// The route_type from the GTFS that this selector refers to.
        /// </summary>
        [ProtoMember(3)]
        public int? RouteType { get; set; }

        /// <summary>
        /// The trip instance from the GTFS that this selector refers to.
        /// </summary>
        [ProtoMember(4)]
        public TripDescriptor? Trip { get; set; }

        /// <summary>
        /// The stop_id from the GTFS feed that this selector refers to.
        /// </summary>
        [ProtoMember(5)]
        public string? StopId { get; set; }

        /// <summary>
        /// The direction_id from the GTFS feed trips.txt file. Experimental.
        /// </summary>
        [ProtoMember(6)]
        public uint? DirectionId { get; set; }
    }
}
