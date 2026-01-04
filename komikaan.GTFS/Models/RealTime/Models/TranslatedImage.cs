using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// An internationalized message containing per-language versions of an image. Experimental.
    /// </summary>
    [ProtoContract(Name = "TranslatedImage")]
    public class TranslatedImage : GTFSRealtimeObject
    {
        /// <summary>
        /// At least one localized image must be provided.
        /// </summary>
        [ProtoMember(1)]
        public required List<LocalizedImage> LocalizedImage { get; set; }
    }
}
