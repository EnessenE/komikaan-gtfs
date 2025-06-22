using komikaan.GTFS.Models.RealTime.Enums;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// Identification information for the vehicle performing the trip.
    /// </summary>
    public class VehicleDescriptor
    {
        /// <summary>
        /// Internal system identification of the vehicle. Should be unique per vehicle.
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// User visible label, i.e., something that must be shown to the passenger to help identify the correct vehicle.
        /// </summary>
        public string? Label { get; set; }

        /// <summary>
        /// The license plate of the vehicle.
        /// </summary>
        public string? LicensePlate { get; set; }

        /// <summary>
        /// If provided, can overwrite the wheelchair_accessible value from the static GTFS.
        /// </summary>
        public WheelchairAccessible? WheelchairAccessible { get; set; }
    }
}
