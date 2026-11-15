#if NETSTANDARD2_1
// DateOnly was introduced in .NET 6 and does not exist in netstandard2.1.
// This minimal polyfill keeps the public model API identical across all target frameworks.
namespace System
{
    /// <summary>
    /// Minimal netstandard2.1 polyfill of System.DateOnly (net6.0+).
    /// </summary>
    public readonly struct DateOnly : IEquatable<DateOnly>, IComparable<DateOnly>
    {
        public DateOnly(int year, int month, int day)
        {
            if (year < 1 || year > 9999) throw new ArgumentOutOfRangeException(nameof(year));
            if (month < 1 || month > 12) throw new ArgumentOutOfRangeException(nameof(month));
            if (day < 1 || day > DateTime.DaysInMonth(year, month)) throw new ArgumentOutOfRangeException(nameof(day));
            Year = year;
            Month = month;
            Day = day;
        }

        public DateOnly(DateTime date)
        {
            Year = date.Year;
            Month = date.Month;
            Day = date.Day;
        }

        public int Year { get; }
        public int Month { get; }
        public int Day { get; }

        public int DayOfYear => new DateTime(Year, Month, Day).DayOfYear;
        public DayOfWeek DayOfWeek => new DateTime(Year, Month, Day).DayOfWeek;

        public DateTime ToDateTime() => new DateTime(Year, Month, Day);

        public static DateOnly FromDateTime(DateTime date) => new DateOnly(date);

        public static DateOnly Parse(string s) => FromDateTime(DateTime.Parse(s));

        public static bool TryParse(string? s, out DateOnly result)
        {
            if (DateTime.TryParse(s, out var dt))
            {
                result = new DateOnly(dt);
                return true;
            }
            result = default;
            return false;
        }

        public override string ToString() => $"{Year:D4}-{Month:D2}-{Day:D2}";

        public bool Equals(DateOnly other) => Year == other.Year && Month == other.Month && Day == other.Day;
        public override bool Equals(object? obj) => obj is DateOnly other && Equals(other);
        public override int GetHashCode() => HashCode.Combine(Year, Month, Day);
        public int CompareTo(DateOnly other) => new DateTime(Year, Month, Day).CompareTo(new DateTime(other.Year, other.Month, other.Day));

        public static bool operator ==(DateOnly left, DateOnly right) => left.Equals(right);
        public static bool operator !=(DateOnly left, DateOnly right) => !left.Equals(right);
        public static bool operator <(DateOnly left, DateOnly right) => left.CompareTo(right) < 0;
        public static bool operator >(DateOnly left, DateOnly right) => left.CompareTo(right) > 0;
        public static bool operator <=(DateOnly left, DateOnly right) => left.CompareTo(right) <= 0;
        public static bool operator >=(DateOnly left, DateOnly right) => left.CompareTo(right) >= 0;
    }
}
#endif
