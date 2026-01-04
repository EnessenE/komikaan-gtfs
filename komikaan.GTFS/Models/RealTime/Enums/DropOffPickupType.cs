using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Enums
{
    /// <summary>
    /// Defines pickup or dropoff types.
    /// </summary>
    [ProtoContract(Name = "DropOffPickupType")]
    public enum DropOffPickupType
    {
        /// <summary>
        /// Regularly scheduled pickup/dropoff.
        /// </summary>
        Regular,
        /// <summary>
        /// No pickup/dropoff available.
        /// </summary>
        None,
        /// <summary>
        /// Must phone agency to arrange pickup/dropoff.
        /// </summary>
        PhoneAgency,
        /// <summary>
        /// Must coordinate with driver to arrange pickup/dropoff.
        /// </summary>
        CoordinateWithDriver
    }
}
