using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Enums
{
    /// <summary>
    /// The state of passenger occupancy for the vehicle or carriage.
    /// </summary>
    [ProtoContract(Name = "OccupancyStatus")]
    public enum OccupancyStatus
    {
        Empty = 0,
        ManySeatsAvailable = 1,
        FewSeatsAvailable = 2,
        StandingRoomOnly = 3,
        CrushedStandingRoomOnly = 4,
        Full = 5,
        NotAcceptingPassengers = 6,
        NoDataAvailable = 7,
        /// <summary>
        /// The vehicle or carriage is not boardable and never accepts passengers.
        /// Useful for special vehicles or carriages (engine, maintenance carriage, etc…).
        /// </summary>
        NotBoardable = 8
    }
}
