using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// A geographic position of a vehicle.
    /// </summary>
    [ProtoContract(Name = "Position")]
    public class Position : GTFSRealtimeObject
    {
        /// <summary>
        /// Degrees North, in the WGS-84 coordinate system.
        /// </summary>
        [ProtoMember(1)]
        public float Latitude { get; set; }

        /// <summary>
        /// Degrees East, in the WGS-84 coordinate system.
        /// </summary>
        [ProtoMember(2)]
        public float Longitude { get; set; }

        /// <summary>
        /// Bearing, in degrees, clockwise from True North, i.e., 0 is North and 90 is East.
        /// </summary>
        [ProtoMember(3)]
        public float? Bearing { get; set; }

        /// <summary>
        /// Odometer value, in meters.
        /// </summary>
        [ProtoMember(4)]
        public double? Odometer { get; set; }

        /// <summary>
        /// Momentary speed measured by the vehicle, in meters per second.
        /// </summary>
        [ProtoMember(5)]
        public float? Speed { get; set; }
    }
}
