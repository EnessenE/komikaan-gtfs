namespace komikaan.GTFS.Models.Static.Enums;

/// <summary>
/// Which fare products apply for a transfer between legs (fare_transfer_rules.txt fare_transfer_type).
/// </summary>
public enum FareTransferType
{
    /// <summary>
    /// From-leg fare product plus the transfer fare product (A + AB).
    /// </summary>
    FromLegPlusTransfer = 0,
    /// <summary>
    /// From-leg, transfer and to-leg fare products (A + AB + B).
    /// </summary>
    FromLegPlusTransferPlusToLeg = 1,
    /// <summary>
    /// Only the transfer fare product (B).
    /// </summary>
    TransferOnly = 2
}
