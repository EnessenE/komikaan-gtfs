using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// A localized image URL mapped to a language.
    /// </summary>
    [ProtoContract(Name = "LocalizedImage")]
    public class LocalizedImage : GTFSRealtimeObject
    {
        /// <summary>
        /// String containing a URL linking to an image. The image linked must be less than 2MB.
        /// </summary>
        [ProtoMember(1)]
        public required string Url { get; set; }

        /// <summary>
        /// IANA media type as to specify the type of image to be displayed. The type must start with "image/".
        /// </summary>
        [ProtoMember(2)]
        public required string MediaType { get; set; }

        /// <summary>
        /// BCP-47 language code. Can be omitted if the language is unknown.
        /// </summary>
        [ProtoMember(3)]
        public string? Language { get; set; }
    }
}
