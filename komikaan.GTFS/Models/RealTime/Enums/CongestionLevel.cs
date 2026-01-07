using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Enums
{
    /// <summary>
    /// Congestion level that is affecting this vehicle.
    /// </summary>
    [ProtoContract(Name = "CongestionLevel")]
    public enum CongestionLevel
    {
        UnknownCongestionLevel = 0,
        RunningSmoothly = 1,
        StopAndGo = 2,
        Congestion = 3,
        /// <summary>
        /// Its so servere, "people are leaving their cars"
        /// </summary>
        SevereCongestion = 4 
    }
}
