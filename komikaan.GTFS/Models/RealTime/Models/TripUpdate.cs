namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// Realtime update on the progress of a vehicle along a trip.
    /// </summary>
    public class TripUpdate
    {
        /// <summary>
        /// The Trip that this message applies to.
        /// </summary>
        public required TripDescriptor Trip { get; set; }

        /// <summary>
        /// Additional information on the vehicle that is serving this trip.
        /// </summary>
        public VehicleDescriptor? Vehicle { get; set; }

        /// <summary>
        /// Updates to StopTimes for the trip. The updates must be sorted by stop_sequence.
        /// </summary>
        public List<StopTimeUpdate> StopTimeUpdate { get; set; } = new List<StopTimeUpdate>();

        /// <summary>
        /// The most recent moment at which the vehicle's real-time progress was measured. In POSIX time.
        /// </summary>
        public ulong? Timestamp { get; set; }

        /// <summary>
        /// The current schedule deviation for the trip, in seconds. Experimental.
        /// </summary>
        public int? Delay { get; set; }

        /// <summary>
        /// Provides the updated properties for the trip. Experimental.
        /// </summary>
        public TripProperties? TripProperties { get; set; }
    }
}
