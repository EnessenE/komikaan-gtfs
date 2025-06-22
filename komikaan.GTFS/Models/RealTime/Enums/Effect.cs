namespace komikaan.GTFS.Models.RealTime.Enums
{
    /// <summary>
    /// The effect of a problem on the affected entity.
    /// </summary>
    public enum Effect
    {
        NoService = 1,
        ReducedService = 2,
        SignificantDelays = 3,
        Detour = 4,
        AdditionalService = 5,
        ModifiedService = 6,
        OtherEffect = 7,
        UnknownEffect = 8,
        StopMoved = 9,
        NoEffect = 10,
        AccessibilityIssue = 11
    }
}
