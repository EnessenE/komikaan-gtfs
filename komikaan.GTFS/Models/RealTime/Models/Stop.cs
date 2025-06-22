using komikaan.GTFS.Models.RealTime.Enums;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// Represents a new Stop added to the feed dynamically. The location type of the new stop is 0 (routable stop). Experimental.
    /// </summary>
    public class Stop
    {
        /// <summary>
        /// Identifier of the stop. Must be different than any stop_id defined in the (CSV) GTFS.
        /// </summary>
        public required string StopId { get; set; }

        /// <summary>
        /// See definition of stops.stop_code in (CSV) GTFS.
        /// </summary>
        public TranslatedString? StopCode { get; set; }

        /// <summary>
        /// See definition of stops.stop_name in (CSV) GTFS.
        /// </summary>
        public required TranslatedString StopName { get; set; }

        /// <summary>
        /// See definition of stops.tts_stop_name in (CSV) GTFS.
        /// </summary>
        public TranslatedString? TtsStopName { get; set; }

        /// <summary>
        /// See definition of stops.stop_desc in (CSV) GTFS.
        /// </summary>
        public TranslatedString? StopDesc { get; set; }

        /// <summary>
        /// See definition of stops.stop_lat in (CSV) GTFS.
        /// </summary>
        public float StopLat { get; set; }

        /// <summary>
        /// See definition of stops.stop_lon in (CSV) GTFS.
        /// </summary>
        public float StopLon { get; set; }

        /// <summary>
        /// See definition of stops.zone_id in (CSV) GTFS.
        /// </summary>
        public string? ZoneId { get; set; }

        /// <summary>
        /// See definition of stops.stop_url in (CSV) GTFS.
        /// </summary>
        public TranslatedString? StopUrl { get; set; }

        /// <summary>
        /// See definition of stops.parent_station in (CSV) GTFS.
        /// </summary>
        public string? ParentStation { get; set; }

        /// <summary>
        /// See definition of stops.stop_timezone in (CSV) GTFS.
        /// </summary>
        public string? StopTimezone { get; set; }

        /// <summary>
        /// See definition of stops.wheelchair_boarding in (CSV) GTFS.
        /// </summary>
        public WheelchairBoarding? WheelchairBoarding { get; set; }

        /// <summary>
        /// See definition of stops.level_id in (CSV) GTFS.
        /// </summary>
        public string? LevelId { get; set; }

        /// <summary>
        /// See definition of stops.platform_code in (CSV) GTFS.
        /// </summary>
        public TranslatedString? PlatformCode { get; set; }
    }
}
