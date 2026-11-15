using komikaan.GTFS.Models.Static.Enums;

namespace komikaan.GTFS.Models.Static.Models
{
    /// <summary>
    /// Represents booking information for rider-requested (on-demand) services.
    /// </summary>
    public class BookingRule : GTFSStaticObject
    {
        /// <summary>
        /// Identifies a booking rule.
        /// </summary>
        public string BookingRuleId { get; set; }

        /// <summary>
        /// Booking method.
        /// </summary>
        public BookingType BookingType { get; set; }

        /// <summary>
        /// Minimum advance notice required, in minutes.
        /// </summary>
        public int? PriorNoticeDurationMin { get; set; }

        /// <summary>
        /// Maximum advance notice accepted, in minutes.
        /// </summary>
        public int? PriorNoticeDurationMax { get; set; }

        /// <summary>
        /// Last day before the service day on which booking is accepted, relative to the service date.
        /// </summary>
        public int? PriorNoticeLastDay { get; set; }

        /// <summary>
        /// Last time on the last booking day at which booking is accepted.
        /// </summary>
        public TimeSpan? PriorNoticeLastTime { get; set; }

        /// <summary>
        /// First day before the service day on which booking opens, relative to the service date.
        /// </summary>
        public int? PriorNoticeStartDay { get; set; }

        /// <summary>
        /// Time on the first booking day at which booking opens.
        /// </summary>
        public TimeSpan? PriorNoticeStartTime { get; set; }

        /// <summary>
        /// Service defining on which days booking is possible.
        /// </summary>
        public string? PriorNoticeServiceId { get; set; }

        /// <summary>
        /// Message describing the booking rule to riders.
        /// </summary>
        public string? Message { get; set; }

        /// <summary>
        /// Message describing how to book a pickup.
        /// </summary>
        public string? PickupMessage { get; set; }

        /// <summary>
        /// Message describing how to book a drop off.
        /// </summary>
        public string? DropOffMessage { get; set; }

        /// <summary>
        /// Phone number for booking.
        /// </summary>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// URL with more information about booking.
        /// </summary>
        public string? InfoUrl { get; set; }

        /// <summary>
        /// URL where the service can be booked.
        /// </summary>
        public string? BookingUrl { get; set; }
    }
}
