namespace komikaan.GTFS.Models.Static.Enums;

/// <summary>
/// Direction a pathway can be taken (pathways.txt is_bidirectional).
/// </summary>
public enum Bidirectional
{
    /// <summary>
    /// Unidirectional pathway that can only be used from from_stop_id to to_stop_id.
    /// </summary>
    Unidirectional = 0,
    /// <summary>
    /// Bidirectional pathway that can be used in both directions.
    /// </summary>
    Bidirectional = 1
}
