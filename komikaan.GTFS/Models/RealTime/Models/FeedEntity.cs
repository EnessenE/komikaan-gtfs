using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// A definition (or update) of an entity in the transit feed.
    /// </summary>
    [ProtoContract(Name = "FeedEntity")]
    public class FeedEntity : GTFSRealtimeObject
    {
        /// <summary>
        /// Feed-unique identifier for this entity.
        /// </summary>
        [ProtoMember(1)]
        public required string Id { get; set; }

        /// <summary>
        /// Whether this entity is to be deleted. Should be provided only for feeds with Incrementality of DIFFERENTIAL.
        /// </summary>
        [ProtoMember(2)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Data about the realtime departure delays of a trip.
        /// </summary>
        [ProtoMember(3)]
        public TripUpdate? TripUpdate { get; set; }

        /// <summary>
        /// Data about the realtime position of a vehicle.
        /// </summary>
        [ProtoMember(4)]
        public VehiclePosition? Vehicle { get; set; }

        /// <summary>
        /// Data about a realtime alert.
        /// </summary>
        [ProtoMember(5)]
        public Alert? Alert { get; set; }

        /// <summary>
        /// Data about the realtime added shapes, such as for a detour. Experimental.
        /// </summary>
        [ProtoMember(6)]
        public Shape? Shape { get; set; }

        /// <summary>
        /// A new stop added to the feed dynamically. Experimental.
        /// </summary>
        [ProtoMember(7)]
        public Stop? Stop { get; set; }

        /// <summary>
        /// List of trips affected by a particular modifications, such as a detour. Experimental.
        /// </summary>
        [ProtoMember(8)]
        public TripModifications? TripModifications { get; set; }
    }
}
