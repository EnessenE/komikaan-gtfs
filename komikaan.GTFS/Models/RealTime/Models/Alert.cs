using komikaan.GTFS.Models.RealTime.Enums;
using komikaan.GTFS.Models.Static;
using ProtoBuf;

namespace komikaan.GTFS.Models.RealTime.Models
{
    /// <summary>
    /// An alert, indicating some sort of incident in the public transit network.
    /// </summary>
    [ProtoContract(Name = "Alert")]
    public class Alert : GTFSRealtimeObject
    {
        /// <summary>
        /// Time when the alert should be shown to the user. If multiple ranges are given, the alert will be shown during all of them.
        /// </summary>
        [ProtoMember(1)]
        public List<TimeRange> ActivePeriod { get; set; } = new List<TimeRange>();

        /// <summary>
        /// Entities whose users we should notify of this alert.
        /// </summary>
        [ProtoMember(5)]
        public required List<EntitySelector> InformedEntity { get; set; }

        /// <summary>
        /// The cause of this alert.
        /// </summary>
        [ProtoMember(6)]
        public Cause Cause { get; set; } = Cause.UnknownCause;

        /// <summary>
        /// The effect of this problem on the affected entity.
        /// </summary>
        [ProtoMember(7)]
        public Effect Effect { get; set; } = Effect.UnknownEffect;

        /// <summary>
        /// The URL which provides additional information about the alert.
        /// </summary>
        [ProtoMember(8)]
        public TranslatedString? Url { get; set; }

        /// <summary>
        /// Header for the alert. This plain-text string will be highlighted.
        /// </summary>
        [ProtoMember(10)]
        public required TranslatedString HeaderText { get; set; }

        /// <summary>
        /// Description for the alert. This plain-text string will be formatted as the body of the alert.
        /// </summary>
        [ProtoMember(11)]
        public required TranslatedString DescriptionText { get; set; }

        /// <summary>
        /// Text containing the alert's header to be used for text-to-speech implementations.
        /// </summary>
        [ProtoMember(12)]
        public TranslatedString? TtsHeaderText { get; set; }

        /// <summary>
        /// Text containing a description for the alert to be used for text-to-speech implementations.
        /// </summary>
        [ProtoMember(13)]
        public TranslatedString? TtsDescriptionText { get; set; }

        /// <summary>
        /// Severity of the alert.
        /// </summary>
        [ProtoMember(14)]
        public SeverityLevel SeverityLevel { get; set; } = SeverityLevel.UnknownSeverity;

        /// <summary>
        /// TranslatedImage to be displayed along the alert text. Experimental.
        /// </summary>
        [ProtoMember(15)]
        public TranslatedImage? Image { get; set; }

        /// <summary>
        /// Text describing the appearance of the linked image in the image field. Experimental.
        /// </summary>
        [ProtoMember(16)]
        public TranslatedString? ImageAlternativeText { get; set; }

        /// <summary>
        /// Description of the cause of the alert that allows for agency-specific language. Experimental.
        /// </summary>
        [ProtoMember(17)]
        public TranslatedString? CauseDetail { get; set; }

        /// <summary>
        /// Description of the effect of the alert that allows for agency-specific language. Experimental.
        /// </summary>
        [ProtoMember(18)]
        public TranslatedString? EffectDetail { get; set; }
    }
}
