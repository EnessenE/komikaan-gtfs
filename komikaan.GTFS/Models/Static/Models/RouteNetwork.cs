namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents the assignment of a route to a network.
    /// </summary>
    public class RouteNetwork : GTFSStaticObject
    {
        /// <summary>
        /// Network the route belongs to.
        /// </summary>
        public string NetworkId { get; set; }

        /// <summary>
        /// Route assigned to the network.
        /// </summary>
        public string RouteId { get; set; }
    }
}
