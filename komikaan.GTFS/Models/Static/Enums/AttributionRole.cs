namespace komikaan.GTFS.Models.Static.Enums;

/// <summary>
/// Whether an organization has a given role (attributions.txt is_producer / is_operator / is_authority).
/// </summary>
public enum AttributionRole
{
    /// <summary>
    /// Organization does not have this role.
    /// </summary>
    No = 0,
    /// <summary>
    /// Organization does have this role.
    /// </summary>
    Yes = 1
}
