using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// An internationalized message containing per-language versions of a snippet of text or a URL.
    /// </summary>
    [ProtoContract]
    public class TranslatedString : GTFSRealtimeObject
    {
        /// <summary>
        /// At least one translation must be provided.
        /// </summary>
        public required List<Translation> Translation { get; set; }
    }
}
