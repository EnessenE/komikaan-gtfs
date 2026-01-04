using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Enums
{
    /// <summary>
    /// Wheelchair boarding accessibility for a stop.
    /// </summary>
    [ProtoContract(Name = "WheelchairBoarding")]
    public enum WheelchairBoarding
    {
        /// <summary>
        /// No accessibility information for the stop.
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// Some vehicles at this stop can be boarded by a rider in a wheelchair.
        /// </summary>
        Available = 1,
        /// <summary>
        /// Wheelchair boarding is not possible at this stop.
        /// </summary>
        NotAvailable = 2
    }
}
