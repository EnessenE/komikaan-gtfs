using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Enums
{
    /// <summary>
    /// The relation between a trip and the static schedule.
    /// </summary>
    [ProtoContract(Name = "TripScheduleRelationship")]
    public enum TripScheduleRelationship
    {
        /// <summary>
        /// Trip that is running in accordance with its GTFS schedule, or is close enough to the scheduled trip to be associated with it.
        /// </summary>
        Scheduled = 0,

        [Obsolete("Use DUPLICATED for an extra trip that is the same as a scheduled trip except the start date or time, or NEW for an extra trip that is unrelated to an existing trip.")]
        Added = 1,

        /// <summary>
        /// A trip that is running with no schedule associated to it.
        /// </summary>
        Unscheduled = 2,

        /// <summary>
        /// A trip that existed in the schedule but was removed.
        /// </summary>
        Canceled = 3,

        /// <summary>
        /// A trip that replaces an existing scheduled trip, for example, with a changed schedule or a diverted routing.
        /// "This field is still experimental, and subject to change. It may be formally adopted in the future
        /// </summary>
        Replacement = 5,

        /// <summary>
        /// A new trip that is the same as an existing scheduled trip except for service start date and time.
        /// This field is still experimental, and subject to change. It may be formally adopted in the future.
        /// </summary>
        Duplicated = 6,

        /// <summary>
        /// A trip that existed in the schedule but was removed that must not be shown to users.
        /// This field is still experimental, and subject to change. It may be formally adopted in the future.
        /// </summary>
        Deleted = 7,

        /// <summary>
        /// An extra trip unrelated to any existing trips, for example, to respond to sudden passenger load.
        /// This field is still experimental, and subject to change. It may be formally adopted in the future.
        /// </summary>
        New = 8
    }
}
