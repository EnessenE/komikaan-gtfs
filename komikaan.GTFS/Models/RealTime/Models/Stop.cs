using komikaan.GTFS.Models.RealTime.Enums;
using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// Represents a new Stop added to the feed dynamically. The location type of the new stop is 0 (routable stop). Experimental.
    /// </summary>
    [ProtoContract(Name = "Stop")]
    public class Stop : GTFSRealtimeObject
    {
        /// <summary>
        /// Identifier of the stop. Must be different than any stop_id defined in the (CSV) GTFS.
        /// </summary>
        [ProtoMember(1)]
        public required string StopId { get; set; }

        /// <summary>
        /// See definition of stops.stop_code in (CSV) GTFS.
        /// </summary>
        [ProtoMember(2)]
        public TranslatedString? StopCode { get; set; }

        /// <summary>
        /// See definition of stops.stop_name in (CSV) GTFS.
        /// </summary>
        [ProtoMember(3)]
        public required TranslatedString StopName { get; set; }

        /// <summary>
        /// See definition of stops.tts_stop_name in (CSV) GTFS.
        /// </summary>
        [ProtoMember(4)]
        public TranslatedString? TtsStopName { get; set; }

        /// <summary>
        /// See definition of stops.stop_desc in (CSV) GTFS.
        /// </summary>
        [ProtoMember(5)]
        public TranslatedString? StopDesc { get; set; }

        /// <summary>
        /// See definition of stops.stop_lat in (CSV) GTFS.
        /// </summary>
        [ProtoMember(6)]
        public float StopLat { get; set; }

        /// <summary>
        /// See definition of stops.stop_lon in (CSV) GTFS.
        /// </summary>
        [ProtoMember(7)]
        public float StopLon { get; set; }

        /// <summary>
        /// See definition of stops.zone_id in (CSV) GTFS.
        /// </summary>
        [ProtoMember(8)]
        public string? ZoneId { get; set; }

        /// <summary>
        /// See definition of stops.stop_url in (CSV) GTFS.
        /// </summary>
        [ProtoMember(9)]
        public TranslatedString? StopUrl { get; set; }

        /// <summary>
        /// See definition of stops.parent_station in (CSV) GTFS.
        /// </summary>
        [ProtoMember(11)]
        public string? ParentStation { get; set; }

        /// <summary>
        /// See definition of stops.stop_timezone in (CSV) GTFS.
        /// </summary>
        [ProtoMember(12)]
        public string? StopTimezone { get; set; }

        /// <summary>
        /// See definition of stops.wheelchair_boarding in (CSV) GTFS.
        /// </summary>
        [ProtoMember(13)]
        public WheelchairBoarding? WheelchairBoarding { get; set; }

        /// <summary>
        /// See definition of stops.level_id in (CSV) GTFS.
        /// </summary>
        [ProtoMember(14)]
        public string? LevelId { get; set; }

        /// <summary>
        /// See definition of stops.platform_code in (CSV) GTFS.
        /// </summary>
        [ProtoMember(15)]
        public TranslatedString? PlatformCode { get; set; }
    }
}
