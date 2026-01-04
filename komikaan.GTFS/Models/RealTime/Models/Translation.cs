using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// A localized string mapped to a language.
    /// </summary>
    [ProtoContract(Name = "Translation")]
    public class Translation : GTFSRealtimeObject
    {
        /// <summary>
        /// A UTF-8 string containing the message.
        /// </summary>
        [ProtoMember(1)]
        public required string Text { get; set; }

        /// <summary>
        /// BCP-47 language code. Can be omitted if the language is unknown.
        /// </summary>
        [ProtoMember(2)]
        public string? Language { get; set; }
    }
}
