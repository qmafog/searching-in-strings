﻿using System;
#pragma warning disable

namespace SearchingInStrings
{
    public static class Contains
    {
        /// <summary>
        /// Returns a value indicating whether a specified character occurs within this string.
        /// </summary>
        /// <returns>true if the <paramref name="value"/> parameter occurs within this string; otherwise, false.</returns>
        public static bool IsContainsChar(string str, char value)
        {
            return str.Contains(value);
        }

        /// <summary>
        /// Returns a value indicating whether a specified character occurs within this string, using the specified comparison rules.
        /// </summary>
        /// <returns>true if the <paramref name="value"/> parameter occurs within this string; otherwise, false.</returns>
        public static bool IsContainsCharWithStringComparison(string str, char value)
        {
            return str.Contains(value, StringComparison.CurrentCulture);
        }

        /// <summary>
        /// Returns a value indicating whether a specified substring occurs within this string.
        /// </summary>
        /// <returns>true if the <paramref name="value"/> parameter occurs within this string, or if <paramref name="value"/> is the <see cref="string.Empty"/>; otherwise, false.</returns>
        public static bool IsContainsString(string str, string value)
        {
            return str.Contains(value);
        }

        /// <summary>
        /// Returns a value indicating whether a specified string occurs within this string, using the specified comparison rules.
        /// </summary>
        /// <returns>true if the <paramref name="value"/> parameter occurs within this string, or if <paramref name="value"/> is the <see cref="string.Empty"/>; otherwise, false.</returns>
        public static bool IsContainsStringWithStringComparison(string str, string value)
        {
            return str.Contains(value, StringComparison.CurrentCulture);
        }
    }
}
