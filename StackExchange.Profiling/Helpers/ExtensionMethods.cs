﻿using System.Text.RegularExpressions;
using System.Web.Script.Serialization;

namespace StackExchange.Profiling.Helpers
{
    /// <summary>
    /// Common extension methods to use only in this project
    /// </summary>
    internal static class ExtensionMethods
    {
        /// <summary>
        /// Answers true if this String is either null or empty.
        /// </summary>
        internal static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        /// <summary>
        /// Answers true if this String is neither null or empty.
        /// </summary>
        internal static bool HasValue(this string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }

        internal static string Truncate(this string s, int maxLength)
        {
            return s != null && s.Length > maxLength ? s.Substring(0, maxLength) : s;
        }

        /// <summary>
        /// Removes trailing / characters from a path and leaves just one
        /// </summary>
        internal static string EnsureTrailingSlash(this string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;
            return Regex.Replace(input, "/+$", string.Empty) + "/";
        }

        /// <summary>
        /// Removes any leading / characters from a path
        /// </summary>
        internal static string RemoveLeadingSlash(this string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;
            return Regex.Replace(input, "^/+", string.Empty);
        }

        /// <summary>
        /// Removes any leading / characters from a path
        /// </summary>
        internal static string RemoveTrailingSlash(this string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;
            return Regex.Replace(input, "/+$", string.Empty);
        }

        /// <summary>
        /// Serializes <paramref name="o"/> to a JSON string.
        /// </summary>
        /// <param name="o">the instance to serialise</param>
        /// <returns>the resulting JSON object as a string</returns>
        internal static string ToJson(this object o)
        {
            return o == null ? null : new JavaScriptSerializer().Serialize(o);
        }

        /// <summary>
        /// Returns a lowercase string of <paramref name="b"/> suitable for use in javascript.
        /// </summary>
        internal static string ToJs(this bool b)
        {
            return b ? "true" : "false";
        }

    }
}
