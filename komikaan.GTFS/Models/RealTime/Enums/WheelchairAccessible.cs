using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Enums
{
    /// <summary>
    /// Accessibility of a trip for wheelchairs.
    /// </summary>
    [ProtoContract(Name = "WheelchairAccessible")]
    public enum WheelchairAccessible
    {
        /// <summary>
        /// The trip doesn't have information about wheelchair accessibility.
        /// </summary>
        NoValue = 0,
        /// <summary>
        /// The trip has no accessibility value present.
        /// </summary>
        Unknown = 1,
        /// <summary>
        /// The trip is wheelchair accessible.
        /// </summary>
        WheelchairAccessibleOption = 2, // Renamed to avoid conflict with the enum name
        /// <summary>
        /// The trip is not wheelchair accessible.
        /// </summary>
        WheelchairInaccessible = 3
    }
}
