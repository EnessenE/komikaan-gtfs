using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// An internationalized message containing per-language versions of an image. Experimental.
    /// </summary>
    [ProtoContract]
    public class TranslatedImage : GTFSRealtimeObject
    {
        /// <summary>
        /// At least one localized image must be provided.
        /// </summary>
        public required List<LocalizedImage> LocalizedImage { get; set; }
    }
}
