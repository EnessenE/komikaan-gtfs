namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents a network: a grouping of routes.
    /// </summary>
    public class Network : GTFSStaticObject
    {
        /// <summary>
        /// Identifies a network.
        /// </summary>
        public string NetworkId { get; set; }

        /// <summary>
        /// Name of the network.
        /// </summary>
        public string? NetworkName { get; set; }
    }
}
