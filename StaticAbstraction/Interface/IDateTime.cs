using System;
using System.Globalization;

namespace StaticAbstraction
{
    public interface IDateTime 
    {
        DateTime MaxValue { get; }
        DateTime MinValue { get; }
        DateTime Now { get; }
        DateTime Today { get; }
        DateTime UtcNow { get; }

        int Compare(DateTime t1, DateTime t2);
        int DaysInMonth(int year, int month);
        DateTime FromBinary(long dateData);
        DateTime FromFileTime(long fileTime);
        DateTime FromFileTimeUtc(long fileTime);
        DateTime FromOADate(double d);
        bool IsLeapYear(int year);
        DateTime Parse(string s);
        DateTime Parse(string s, IFormatProvider provider);

#if NET7_0_OR_GREATER
        DateTime Parse(ReadOnlySpan<Char> s, IFormatProvider provider);
        Boolean TryParse(String s, IFormatProvider provider, out DateTime result);
        Boolean TryParse(ReadOnlySpan<Char> s, IFormatProvider provider, out DateTime result);
#endif

        DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles);

        DateTime ParseExact(string s, string format, IFormatProvider provider);
        DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style);
        DateTime ParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style);
        DateTime SpecifyKind(DateTime value, DateTimeKind kind);
        bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result);
        bool TryParse(string s, out DateTime result);


        bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result);
        bool TryParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style, out DateTime result);

#if NETSTANDARD2_1 || NETCOREAPP2_1_OR_GREATER
        DateTime Parse(ReadOnlySpan<char> s, IFormatProvider provider = null, DateTimeStyles styles = DateTimeStyles.None);
        DateTime ParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None);
        DateTime ParseExact(ReadOnlySpan<char> s, string[] formats, IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None);
        bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, DateTimeStyles styles, out DateTime result);
        bool TryParse(ReadOnlySpan<char> s, out DateTime result);
        bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, IFormatProvider provider, DateTimeStyles style, out DateTime result);
        bool TryParseExact(ReadOnlySpan<char> s, string[] formats, IFormatProvider provider, DateTimeStyles style, out DateTime result);
        DateTime UnixEpoch { get; }
#endif
    }
}