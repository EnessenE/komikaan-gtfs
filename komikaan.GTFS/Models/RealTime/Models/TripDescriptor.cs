using komikaan.GTFS.Models.RealTime.Enums;
using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// A descriptor that identifies a single instance of a GTFS trip.
    /// </summary>
    [ProtoContract(Name = "TripDescriptor")]
    public class TripDescriptor : GTFSRealtimeObject
    {
        /// <summary>
        /// The trip_id from the GTFS feed that this selector refers to.
        /// </summary>
        [ProtoMember(1)]
        public string? TripId { get; set; }

        /// <summary>
        /// The initially scheduled start time of this trip instance.
        /// </summary>
        [ProtoMember(2)]
        public string? StartTime { get; set; }

        /// <summary>
        /// The start date of this trip instance in YYYYMMDD format.
        /// </summary>
        [ProtoMember(3)]
        public string? StartDate { get; set; }

        /// <summary>
        /// The relation between this trip and the static schedule.
        /// </summary>
        [ProtoMember(4)]
        public TripScheduleRelationship? ScheduleRelationship { get; set; }

        /// <summary>
        /// The route_id from the GTFS that this selector refers to.
        /// </summary>
        [ProtoMember(5)]
        public string? RouteId { get; set; }

        /// <summary>
        /// The direction_id from the GTFS feed trips.txt file. Experimental.
        /// </summary>
        [ProtoMember(6)]
        public uint? DirectionId { get; set; }

        /// <summary>
        /// Linkage to any modifications done to this trip (shape changes, removal or addition of stops).
        /// </summary>
        [ProtoMember(7)]
        public ModifiedTripSelector? ModifiedTrip { get; set; }
    }
}
