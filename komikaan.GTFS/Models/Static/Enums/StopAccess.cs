namespace komikaan.GTFS.Models.Static.Enums;

public enum StopAccess
{
    /// <summary>
    ///  The stop/platform cannot be directly accessed from the street network.
    ///  It must be accessed from a station entrance if there is one defined for the station, otherwise the station itself. If there are pathways defined for the station, they must be used to access the stop/platform.
    /// </summary>
    NotEasilyAccessible = 0,
    /// <summary>
    /// Consuming applications should generate directions for access directly to the stop, independent of any entrances or pathways of the parent station.
    /// </summary>
    Accessable = 1
}
