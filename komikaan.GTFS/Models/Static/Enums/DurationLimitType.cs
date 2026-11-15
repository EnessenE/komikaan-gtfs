namespace komikaan.GTFS.Models.Static.Enums;

/// <summary>
/// What the duration_limit of a fare transfer rule is measured between (fare_transfer_rules.txt duration_limit_type).
/// </summary>
public enum DurationLimitType
{
    /// <summary>
    /// Between the departure fare validation of the first leg and the arrival fare validation of the last leg.
    /// </summary>
    DepartureFirstToArrivalLast = 0,
    /// <summary>
    /// Between the departure fare validation of the first leg and the departure fare validation of the last leg.
    /// </summary>
    DepartureFirstToDepartureLast = 1,
    /// <summary>
    /// Between the arrival fare validation of the first leg and the departure fare validation of the last leg.
    /// </summary>
    ArrivalFirstToDepartureLast = 2,
    /// <summary>
    /// Between the arrival fare validation of the first leg and the arrival fare validation of the last leg.
    /// </summary>
    ArrivalFirstToArrivalLast = 3
}
