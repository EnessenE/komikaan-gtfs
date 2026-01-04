using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Enums
{
    /// <summary>
    /// The state of passenger occupancy for the vehicle or carriage.
    /// </summary>
    [ProtoContract(Name = "OccupancyStatus")]
    public enum OccupancyStatus
    {
        Empty,
        ManySeatsAvailable,
        FewSeatsAvailable,
        StandingRoomOnly,
        CrushedStandingRoomOnly,
        Full,
        NotAcceptingPassengers,
        NoDataAvailable,
        NotBoardable
    }
}
