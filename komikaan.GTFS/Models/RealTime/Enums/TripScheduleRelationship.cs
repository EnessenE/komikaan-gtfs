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
        Scheduled,

        /// <summary>
        /// A trip that is running with no schedule associated to it.
        /// </summary>
        Unscheduled,

        /// <summary>
        /// A trip that existed in the schedule but was removed.
        /// </summary>
        Canceled,

        /// <summary>
        /// A trip that replaces an existing scheduled trip, for example, with a changed schedule or a diverted routing.
        /// </summary>
        Replacement,

        /// <summary>
        /// A new trip that is the same as an existing scheduled trip except for service start date and time.
        /// </summary>
        Duplicated,

        /// <summary>
        /// An extra trip unrelated to any existing trips, for example, to respond to sudden passenger load.
        /// </summary>
        New,

        /// <summary>
        /// A trip that existed in the schedule but was removed that must not be shown to users.
        /// </summary>
        Deleted
    }
}
