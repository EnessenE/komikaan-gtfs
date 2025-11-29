namespace komikaan.GTFS.Models.Static.Enums;

public enum CemvSupport
{
    /// <summary>
    /// No cEMV information.
    /// </summary>
    NoInfo = 0,
    /// <summary>
    ///  Riders may use cEMVs as fare media.
    /// </summary>
    Supported = 1,
    /// <summary>
    /// cEMVs are not supported as fare.
    /// </summary>
    Unsupported = 2
}
