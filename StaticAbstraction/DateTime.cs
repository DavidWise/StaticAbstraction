using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace StaticAbstraction
{
    public class StAbDateTime : IDateTime
    {
        public DateTime Today => DateTime.Today;
        public DateTime MaxValue => DateTime.MaxValue;
        public DateTime MinValue => DateTime.MinValue;
        public DateTime Now => DateTime.Now;
        public DateTime UtcNow => DateTime.UtcNow;

        public int Compare(DateTime t1, DateTime t2)
        {
            return DateTime.Compare(t1, t2);
        }

        public int DaysInMonth(int year, int month)
        {
            return DateTime.DaysInMonth(year, month);
        }

        public DateTime FromBinary(long dateData)
        {
            return DateTime.FromBinary(dateData);
        }

        public DateTime FromFileTime(long fileTime)
        {
            return DateTime.FromFileTime(fileTime);
        }

        public DateTime FromFileTimeUtc(long fileTime)
        {
            return DateTime.FromFileTimeUtc(fileTime);
        }

        public DateTime FromOADate(double d)
        {
            return DateTime.FromOADate(d);
        }

        public bool IsLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }

        public DateTime Parse(string s)
        {
            return DateTime.Parse(s);
        }
        public DateTime Parse(string s, IFormatProvider provider)
        {
            return DateTime.Parse(s, provider);
        }
        public DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles)
        {
            return DateTime.Parse(s, provider, styles);
        }

        public DateTime ParseExact(string s, string format, IFormatProvider provider)
        {
            return DateTime.ParseExact(s, format, provider);
        }
        public DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style)
        {
            return DateTime.ParseExact(s, format, provider, style);
        }
        public DateTime ParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style)
        {
            return DateTime.ParseExact(s, formats, provider, style);
        }

        public DateTime SpecifyKind(DateTime value, DateTimeKind kind)
        {
            return DateTime.SpecifyKind(value, kind);
        }


        public bool TryParse(string s, out DateTime result)
        {
            return DateTime.TryParse(s, out result);
        }
        public bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
        {
            return DateTime.TryParse(s, provider, styles, out result);
        }

        public bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result)
        {
            return DateTime.TryParseExact(s, format, provider, style, out result);
        }
        public bool TryParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style, out DateTime result)
        {
            return DateTime.TryParseExact(s, formats, provider, style, out result);
        }


#if NETCORE22
        public DateTime Parse(ReadOnlySpan<char> s, IFormatProvider provider = null, DateTimeStyles styles = DateTimeStyles.None)
        {
            return DateTime.Parse(s, provider, styles);
        }
        public DateTime ParseExact(ReadOnlySpan<char> s, string[] formats, IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None)
        {
            return DateTime.ParseExact(s, formats, provider, style);
        }
        public DateTime ParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None)
        {
            return DateTime.ParseExact(s, format, provider, style);
        }
        public bool TryParse(ReadOnlySpan<char> s, out DateTime result)
        {
            return DateTime.TryParse(s, out result);
        }

        public bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
        {
            return DateTime.TryParse(s, provider, styles, out result);
        }

        public bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, IFormatProvider provider, DateTimeStyles style, out DateTime result)
        {
            return DateTime.TryParseExact(s, format, provider, style, out result);
        }
        public bool TryParseExact(ReadOnlySpan<char> s, string[] formats, IFormatProvider provider, DateTimeStyles style, out DateTime result)
        {
            return DateTime.TryParseExact(s, formats, provider, style, out result);
        }

        public DateTime UnixEpoch => DateTime.UnixEpoch;

#endif

    }
}
