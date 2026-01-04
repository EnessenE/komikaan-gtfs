using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// When a service is affected by a trip modification, ModifiedTripSelector is used to select some trip.
    /// </summary>
    [ProtoContract(Name = "ModifiedTripSelector")]
    public class ModifiedTripSelector : GTFSRealtimeObject
    {
        /// <summary>
        /// The id of the FeedEntity in which the contained TripModifications object affects this trip.
        /// </summary>
        [ProtoMember(1)]
        public required string ModificationsId { get; set; }

        /// <summary>
        /// The trip_id from the GTFS feed that is modified by the modifications_id.
        /// </summary>
        [ProtoMember(2)]
        public required string AffectedTripId { get; set; }

        /// <summary>
        /// The initially scheduled start time of this trip instance, applied to the frequency based modified trip.
        /// </summary>
        [ProtoMember(3)]
        public string? StartTime { get; set; }

        /// <summary>
        /// The start date of this trip instance in YYYYMMDD format, applied to the modified trip.
        /// </summary>
        [ProtoMember(4)]
        public string? StartDate { get; set; }
    }
}
