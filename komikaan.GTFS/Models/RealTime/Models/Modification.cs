using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// A Modification message describes changes to each affected trip starting at start_stop_selector. Experimental.
    /// </summary>
    [ProtoContract]
    public class Modification : GTFSRealtimeObject
    {
        /// <summary>
        /// The stop selector of the first stop of the original trip that is to be affected by this modification.
        /// </summary>
        public required StopSelector StartStopSelector { get; set; }

        /// <summary>
        /// The stop selector of the last stop of the original trip that is to be affected by this modification.
        /// </summary>
        public StopSelector? EndStopSelector { get; set; }

        /// <summary>
        /// The number of seconds of delay to add to all departure and arrival times subsequent to the last stop inserted by a modification.
        /// </summary>
        public int? PropagatedModificationDelay { get; set; }

        /// <summary>
        /// A list of replacement stops, replacing those of the original trip.
        /// </summary>
        public List<ReplacementStop> ReplacementStops { get; set; } = new List<ReplacementStop>();

        /// <summary>
        /// An id value from the FeedEntity message that contains the Alert describing this Modification for user-facing communication.
        /// </summary>
        public string? ServiceAlertId { get; set; }

        /// <summary>
        /// This timestamp identifies the moment when the modification has last been changed. In POSIX time.
        /// </summary>
        public ulong? LastModifiedTime { get; set; }
    }
}
