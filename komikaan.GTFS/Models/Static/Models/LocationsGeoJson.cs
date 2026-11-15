using System.Text.Json;

namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Root object of locations.geojson: a GeoJSON FeatureCollection of on-demand service zones.
    /// </summary>
    public class LocationsGeoJson : GTFSStaticObject
    {
        /// <summary>
        /// Always "FeatureCollection".
        /// </summary>
        public string Type { get; set; } = "FeatureCollection";

        /// <summary>
        /// Collection of location features.
        /// </summary>
        public List<LocationFeature> Features { get; set; } = new();
    }

    /// <summary>
    /// A single GeoJSON Feature describing one service zone.
    /// </summary>
    public class LocationFeature
    {
        /// <summary>
        /// Always "Feature".
        /// </summary>
        public string Type { get; set; } = "Feature";

        /// <summary>
        /// Identifies the location. Unique across stops.stop_id, locations.geojson ids and location_group_id values.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Location properties.
        /// </summary>
        public LocationProperties Properties { get; set; } = new();

        /// <summary>
        /// Polygon or MultiPolygon geometry of the zone.
        /// </summary>
        public LocationGeometry Geometry { get; set; } = new();
    }

    /// <summary>
    /// Properties of a location feature.
    /// </summary>
    public class LocationProperties
    {
        /// <summary>
        /// Name of the location as displayed to riders.
        /// </summary>
        public string? StopName { get; set; }

        /// <summary>
        /// Meaningful description of the location to help orient riders.
        /// </summary>
        public string? StopDesc { get; set; }
    }

    /// <summary>
    /// Geometry of a location feature. Type is "Polygon" or "MultiPolygon";
    /// coordinates are kept raw since their nesting depth differs per type.
    /// </summary>
    public class LocationGeometry
    {
        /// <summary>
        /// "Polygon" or "MultiPolygon".
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Raw GeoJSON coordinates array.
        /// </summary>
        public JsonElement Coordinates { get; set; }
    }
}
