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
        Regular = 0,
        /// <summary>
        /// No pickup/dropoff available.
        /// </summary>
        None = 1,
        /// <summary>
        /// Must phone agency to arrange pickup/dropoff.
        /// </summary>
        PhoneAgency = 2,
        /// <summary>
        /// Must coordinate with driver to arrange pickup/dropoff.
        /// </summary>
        CoordinateWithDriver = 3
    }
}
