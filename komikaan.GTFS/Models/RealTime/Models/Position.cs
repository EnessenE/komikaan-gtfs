namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// A geographic position of a vehicle.
    /// </summary>
    public class Position
    {
        /// <summary>
        /// Degrees North, in the WGS-84 coordinate system.
        /// </summary>
        public float Latitude { get; set; }

        /// <summary>
        /// Degrees East, in the WGS-84 coordinate system.
        /// </summary>
        public float Longitude { get; set; }

        /// <summary>
        /// Bearing, in degrees, clockwise from True North, i.e., 0 is North and 90 is East.
        /// </summary>
        public float? Bearing { get; set; }

        /// <summary>
        /// Odometer value, in meters.
        /// </summary>
        public double? Odometer { get; set; }

        /// <summary>
        /// Momentary speed measured by the vehicle, in meters per second.
        /// </summary>
        public float? Speed { get; set; }
    }
}
