namespace komikaan.GTFS.Models.Static.Enums;

/// <summary>
/// Type of fare media (fare_media.txt fare_media_type).
/// </summary>
public enum FareMediaType
{
    /// <summary>
    /// No fare media involved in purchasing or validating a fare product.
    /// </summary>
    None = 0,
    /// <summary>
    /// Physical paper ticket.
    /// </summary>
    PaperTicket = 1,
    /// <summary>
    /// Physical transit card with stored tickets, passes or monetary value.
    /// </summary>
    TransitCard = 2,
    /// <summary>
    /// cEMV (contactless Europay, Mastercard and Visa) as an open-loop token container.
    /// </summary>
    Cemv = 3,
    /// <summary>
    /// Mobile app with stored virtual transit cards, tickets, passes or monetary value.
    /// </summary>
    MobileApp = 4
}
