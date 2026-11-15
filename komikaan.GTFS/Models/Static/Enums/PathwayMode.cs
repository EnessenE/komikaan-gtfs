namespace komikaan.GTFS.Models.Static.Enums;

/// <summary>
/// Type of pathway between a from/to stop pair (pathways.txt pathway_mode).
/// </summary>
public enum PathwayMode
{
    /// <summary>
    /// Walkway.
    /// </summary>
    Walkway = 1,
    /// <summary>
    /// Stairs.
    /// </summary>
    Stairs = 2,
    /// <summary>
    /// Moving sidewalk/travelator.
    /// </summary>
    MovingSidewalk = 3,
    /// <summary>
    /// Escalator.
    /// </summary>
    Escalator = 4,
    /// <summary>
    /// Elevator.
    /// </summary>
    Elevator = 5,
    /// <summary>
    /// Fare gate (or payment gate).
    /// </summary>
    FareGate = 6,
    /// <summary>
    /// Exit gate: a pathway exiting a paid area into an unpaid area.
    /// </summary>
    ExitGate = 7
}
