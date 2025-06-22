﻿namespace komikaan.GTFS.Models.RealTime.Enums
{
    /// <summary>
    /// The exact status of the vehicle with respect to the current stop.
    /// </summary>
    public enum VehicleStopStatus
    {
        /// <summary>
        /// The vehicle is just about to arrive at the stop.
        /// </summary>
        IncomingAt,
        /// <summary>
        /// The vehicle is standing at the stop.
        /// </summary>
        StoppedAt,
        /// <summary>
        /// The vehicle has departed the previous stop and is in transit.
        /// </summary>
        InTransitTo
    }
}
