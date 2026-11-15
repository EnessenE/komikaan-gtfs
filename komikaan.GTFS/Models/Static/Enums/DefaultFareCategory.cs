namespace komikaan.GTFS.Models.Static.Enums;

/// <summary>
/// Whether a rider category is the default fare category (rider_categories.txt is_default_fare_category).
/// </summary>
public enum DefaultFareCategory
{
    /// <summary>
    /// Category is not the default one.
    /// </summary>
    No = 0,
    /// <summary>
    /// Category is considered the default one.
    /// </summary>
    Yes = 1
}
