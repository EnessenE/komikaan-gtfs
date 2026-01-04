using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Enums
{
    /// <summary>
    /// The severity of an alert.
    /// </summary>
    [ProtoContract(Name = "SeverityLevel")]
    public enum SeverityLevel
    {
        UnknownSeverity = 1,
        Info = 2,
        Warning = 3,
        Severe = 4
    }
}
