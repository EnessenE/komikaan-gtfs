using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Enums
{
    /// <summary>
    /// The relation between a stop time and the static schedule.
    /// </summary>
    [ProtoContract(Name = "StopTimeScheduleRelationship")]
    public enum StopTimeScheduleRelationship
    {
        /// <summary>
        /// The vehicle is proceeding in accordance with its static schedule of stops, although not necessarily according to the times of the schedule. This is the default behavior.
        /// </summary>
        Scheduled = 0,

        /// <summary>
        /// The stop is skipped, i.e., the vehicle will not stop at this stop.
        /// </summary>
        Skipped = 1,

        /// <summary>
        /// No real-time data is given for this stop. It indicates that there is no realtime timing information available.
        /// </summary>
        NoData = 2,

        /// <summary>
        /// The vehicle is operating a frequency-based trip (GTFS frequencies.txt with exact_times = 0).
        /// This field is still experimental, and subject to change. It may be formally adopted in the future.
        /// </summary>
        Unscheduled = 3
    }
}
