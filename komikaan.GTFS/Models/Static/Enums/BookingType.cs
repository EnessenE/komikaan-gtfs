namespace komikaan.GTFS.Models.Static.Enums;

/// <summary>
/// Booking method for rider-requested services (booking_rules.txt booking_type).
/// </summary>
public enum BookingType
{
    /// <summary>
    /// Real time booking.
    /// </summary>
    RealTime = 0,
    /// <summary>
    /// Up to same-day booking with advance notice.
    /// </summary>
    SameDay = 1,
    /// <summary>
    /// Up to prior day(s) booking.
    /// </summary>
    PriorDay = 2
}
