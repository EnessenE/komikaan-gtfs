using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Enums
{
    /// <summary>
    /// Cause of an alert.
    /// </summary>
    [ProtoContract(Name = "Cause")]
    public enum Cause
    {
        UnknownCause = 1,
        OtherCause = 2,
        TechnicalProblem = 3,
        Strike = 4,
        Demonstration = 5,
        Accident = 6,
        Holiday = 7,
        Weather = 8,
        Maintenance = 9,
        Construction = 10,
        PoliceActivity = 11,
        MedicalEmergency = 12
    }
}
