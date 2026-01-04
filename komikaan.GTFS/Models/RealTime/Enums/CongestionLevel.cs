using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Enums
{
    /// <summary>
    /// Congestion level that is affecting this vehicle.
    /// </summary>
    [ProtoContract(Name = "CongestionLevel")]
    public enum CongestionLevel
    {
        UnknownCongestionLevel,
        RunningSmoothly,
        StopAndGo,
        Congestion,
        SevereCongestion
    }
}
