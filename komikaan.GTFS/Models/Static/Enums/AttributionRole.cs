namespace komikaan.GTFS.Models.Static.Enums;

/// <summary>
/// Role indicator for attributions.txt is_producer / is_operator / is_authority (spec type: Enum, 0 or 1).
/// </summary>
public enum AttributionRole
{
    /// <summary>
    /// 0 or empty - the organization doesn't have this role.
    /// </summary>
    No = 0,
    /// <summary>
    /// 1 - the organization does have this role.
    /// </summary>
    Yes = 1
}
