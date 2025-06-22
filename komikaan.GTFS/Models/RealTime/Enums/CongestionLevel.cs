namespace komikaan.GTFS.Models.RealTime.Enums
{
    /// <summary>
    /// Congestion level that is affecting this vehicle.
    /// </summary>
    public enum CongestionLevel
    {
        UnknownCongestionLevel,
        RunningSmoothly,
        StopAndGo,
        Congestion,
        SevereCongestion
    }
}
