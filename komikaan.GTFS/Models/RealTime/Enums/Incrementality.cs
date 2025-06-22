﻿namespace komikaan.GTFS.Models.RealTime.Enums
{
    /// <summary>
    /// Determines whether the current fetch is incremental.
    /// </summary>
    public enum Incrementality
    {
        /// <summary>
        /// This feed update will overwrite all preceding realtime information for the feed. Thus this update is expected to provide a full snapshot of all known realtime information.
        /// </summary>
        FullDataset,

        /// <summary>
        /// Currently, this mode is unsupported and behavior is unspecified for feeds that use this mode.
        /// </summary>
        Differential
    }
}
