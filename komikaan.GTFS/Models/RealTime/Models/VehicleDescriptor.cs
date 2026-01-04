using komikaan.GTFS.Models.RealTime.Enums;
using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// Identification information for the vehicle performing the trip.
    /// </summary>
    [ProtoContract(Name = "VehicleDescriptor")]
    public class VehicleDescriptor : GTFSRealtimeObject
    {
        /// <summary>
        /// Internal system identification of the vehicle. Should be unique per vehicle.
        /// </summary>
        [ProtoMember(1)]
        public string? Id { get; set; }

        /// <summary>
        /// User visible label, i.e., something that must be shown to the passenger to help identify the correct vehicle.
        /// </summary>
        [ProtoMember(2)]
        public string? Label { get; set; }

        /// <summary>
        /// The license plate of the vehicle.
        /// </summary>
        [ProtoMember(3)]
        public string? LicensePlate { get; set; }

        /// <summary>
        /// If provided, can overwrite the wheelchair_accessible value from the static GTFS.
        /// </summary>
        [ProtoMember(4)]
        public WheelchairAccessible? WheelchairAccessible { get; set; }
    }
}
