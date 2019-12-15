using System;
using System.Globalization;

namespace StaticAbstraction
{
    public class StAbDateTime : IDateTime
    {
        public virtual DateTime Today => DateTime.Today;
        public virtual DateTime MaxValue => DateTime.MaxValue;
        public virtual DateTime MinValue => DateTime.MinValue;
        public virtual DateTime Now => DateTime.Now;
        public virtual DateTime UtcNow => DateTime.UtcNow;

        public virtual int Compare(DateTime t1, DateTime t2)
        {
            return DateTime.Compare(t1, t2);
        }

        public virtual int DaysInMonth(int year, int month)
        {
            return DateTime.DaysInMonth(year, month);
        }

        public virtual DateTime FromBinary(long dateData)
        {
            return DateTime.FromBinary(dateData);
        }

        public virtual DateTime FromFileTime(long fileTime)
        {
            return DateTime.FromFileTime(fileTime);
        }

        public virtual DateTime FromFileTimeUtc(long fileTime)
        {
            return DateTime.FromFileTimeUtc(fileTime);
        }

        public virtual DateTime FromOADate(double d)
        {
            return DateTime.FromOADate(d);
        }

        public virtual bool IsLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }

        public virtual DateTime Parse(string s)
        {
            return DateTime.Parse(s);
        }
        public virtual DateTime Parse(string s, IFormatProvider provider)
        {
            return DateTime.Parse(s, provider);
        }
        public virtual DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles)
        {
            return DateTime.Parse(s, provider, styles);
        }

        public virtual DateTime ParseExact(string s, string format, IFormatProvider provider)
        {
            return DateTime.ParseExact(s, format, provider);
        }
        public virtual DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style)
        {
            return DateTime.ParseExact(s, format, provider, style);
        }
        public virtual DateTime ParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style)
        {
            return DateTime.ParseExact(s, formats, provider, style);
        }

        public virtual DateTime SpecifyKind(DateTime value, DateTimeKind kind)
        {
            return DateTime.SpecifyKind(value, kind);
        }


        public virtual bool TryParse(string s, out DateTime result)
        {
            return DateTime.TryParse(s, out result);
        }
        public virtual bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
        {
            return DateTime.TryParse(s, provider, styles, out result);
        }

        public virtual bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result)
        {
            return DateTime.TryParseExact(s, format, provider, style, out result);
        }
        public virtual bool TryParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style, out DateTime result)
        {
            return DateTime.TryParseExact(s, formats, provider, style, out result);
        }


#if NETSTANDARD2_1 || NETCORE21 || NETCORE22 
        public virtual DateTime Parse(ReadOnlySpan<char> s, IFormatProvider provider = null, DateTimeStyles styles = DateTimeStyles.None)
        {
            return DateTime.Parse(s, provider, styles);
        }
        public virtual DateTime ParseExact(ReadOnlySpan<char> s, string[] formats, IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None)
        {
            return DateTime.ParseExact(s, formats, provider, style);
        }
        public virtual DateTime ParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None)
        {
            return DateTime.ParseExact(s, format, provider, style);
        }
        public virtual bool TryParse(ReadOnlySpan<char> s, out DateTime result)
        {
            return DateTime.TryParse(s, out result);
        }

        public virtual bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
        {
            return DateTime.TryParse(s, provider, styles, out result);
        }

        public virtual bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, IFormatProvider provider, DateTimeStyles style, out DateTime result)
        {
            return DateTime.TryParseExact(s, format, provider, style, out result);
        }
        public virtual bool TryParseExact(ReadOnlySpan<char> s, string[] formats, IFormatProvider provider, DateTimeStyles style, out DateTime result)
        {
            return DateTime.TryParseExact(s, formats, provider, style, out result);
        }

        public virtual DateTime UnixEpoch => DateTime.UnixEpoch;

#endif

    }
}
