using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// Defines updated properties of a trip. Experimental.
    /// </summary>
    [ProtoContract(Name = "TripProperties")]
    public class TripProperties : GTFSRealtimeObject
    {
        /// <summary>
        /// Defines the identifier of a new trip that is a duplicate of an existing trip. Required if schedule_relationship is DUPLICATED.
        /// </summary>
        [ProtoMember(1)]
        public string? TripId { get; set; }

        /// <summary>
        /// Service date on which the duplicated trip will be run (YYYYMMDD). Required if schedule_relationship is DUPLICATED.
        /// </summary>
        [ProtoMember(2)]
        public string? StartDate { get; set; }

        /// <summary>
        /// Defines the departure start time of the duplicated trip. Required if schedule_relationship is DUPLICATED.
        /// </summary>
        [ProtoMember(3)]
        public string? StartTime { get; set; }

        /// <summary>
        /// Specifies the identifier of the shape of the vehicle travel path when it differs from the original.
        /// </summary>
        [ProtoMember(4)]
        public string? ShapeId { get; set; }

        /// <summary>
        /// Specifies the headsign for this trip when it differs from the original.
        /// </summary>
        [ProtoMember(5)]
        public string? TripHeadsign { get; set; }

        /// <summary>
        /// Specifies the name for this trip when it differs from the original.
        /// </summary>
        [ProtoMember(6)]
        public string? TripShortName { get; set; }
    }
}
