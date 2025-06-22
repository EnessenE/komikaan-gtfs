using komikaan.GTFS.Models.Static.Enums;

namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents stops where vehicles pick up or drop off riders. Also defines stations and station entrances.
    /// </summary>
    public class Stop
    {
        /// <summary>
        /// Identifies a location: stop/platform, station, entrance/exit, generic node or boarding area.
        /// </summary>
        public string StopId { get; set; }

        /// <summary>
        /// Short text or a number that identifies the location for riders.
        /// </summary>
        public string StopCode { get; set; }

        /// <summary>
        /// Name of the location. The stop_name should match the agency's rider-facing name for the location.
        /// Required for stops, stations, and entrances/exits.
        /// </summary>
        public string StopName { get; set; }

        /// <summary>
        /// Readable version of the stop_name.
        /// </summary>
        public string TtsStopName { get; set; }

        /// <summary>
        /// Description of the location that provides useful, quality information.
        /// </summary>
        public string StopDesc { get; set; }

        /// <summary>
        /// Latitude of the location. Required for stops, stations, and entrances/exits.
        /// </summary>
        public double StopLat { get; set; }

        /// <summary>
        /// Longitude of the location. Required for stops, stations, and entrances/exits.
        /// </summary>
        public double StopLon { get; set; }

        /// <summary>
        /// Identifies the fare zone for a stop.
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// URL of a web page about the location.
        /// </summary>
        public string StopUrl { get; set; }

        /// <summary>
        /// Location type.
        /// </summary>
        public LocationType LocationType { get; set; }

        /// <summary>
        /// Defines hierarchy between the different locations defined in stops.txt.
        /// </summary>
        public string ParentStation { get; set; }

        /// <summary>
        /// Timezone of the location.
        /// </summary>
        public string StopTimezone { get; set; }

        /// <summary>
        /// Indicates whether wheelchair boardings are possible from the location.
        /// </summary>
        public WheelchairBoarding WheelchairBoarding { get; set; }

        /// <summary>
        /// Level of the location.
        /// </summary>
        public string LevelId { get; set; }

        /// <summary>
        /// Platform identifier for a platform stop.
        /// </summary>
        public string PlatformCode { get; set; }
    }
}
