using komikaan.GTFS.Models.Static.Enums;

namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents transit routes. A route is a group of trips that are displayed to riders as a single service.
    /// </summary>
    public class Route : GTFSStaticObject
    {
        /// <summary>
        /// Identifies a route.
        /// </summary>
        public string RouteId { get; set; }

        /// <summary>
        /// Agency for the specified route.
        /// </summary>
        public string AgencyId { get; set; }

        /// <summary>
        /// Short name of a route.
        /// </summary>
        public string? RouteShortName { get; set; }

        /// <summary>
        /// Full name of a route.
        /// </summary>
        public string? RouteLongName { get; set; }

        /// <summary>
        /// Description of a route that provides useful, quality information.
        /// </summary>
        public string? RouteDesc { get; set; }

        /// <summary>
        /// Indicates the type of transportation used on a route.
        /// </summary>
        public RouteType RouteType { get; set; }

        /// <summary>
        /// URL of a web page about the particular route.
        /// </summary>
        public string? RouteUrl { get; set; }

        /// <summary>
        /// Route color designation that matches public facing material.
        /// </summary>
        public string? RouteColor { get; set; }

        /// <summary>
        /// Legible color to use for text drawn against a background of route_color.
        /// </summary>
        public string? RouteTextColor { get; set; }

        /// <summary>
        /// Orders the routes in a way which is ideal for presentation to customers.
        /// </summary>
        public int? RouteSortOrder { get; set; }

        /// <summary>
        /// Indicates that the rider can board the transit vehicle at any point along the vehicle's travel path.
        /// </summary>
        public ContinuousPickup? ContinuousPickup { get; set; }

        /// <summary>
        /// Indicates that the rider can alight from the transit vehicle at any point along the vehicle's travel path.
        /// </summary>
        public ContinuousDropOff? ContinuousDropOff { get; set; }

        /// <summary>
        /// Identifies a group of routes.
        /// </summary>
        public string? NetworkId { get; set; }
    }
}
