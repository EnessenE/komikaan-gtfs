namespace komikaan.GTFS.Models.Static.Enums
{
    public enum TransferType
    {
        Recommended = 0,
        Timed = 1,
        MinimumTime = 2,
        NotPossible = 3,
        /// <summary>
        /// Passengers can transfer from one trip to another by staying onboard the same vehicle (an in-seat transfer).
        /// </summary>
        InSeat = 4,
        /// <summary>
        /// In-seat transfers are not allowed between sequential trips. The passenger must alight from the vehicle.
        /// </summary>
        InSeatNotAllowed = 5
    }
}
