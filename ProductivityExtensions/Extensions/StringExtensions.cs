using System;

namespace ProductivityExtensions
{
    /// <summary>
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Determines whether this instance has space.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns><c>true</c> if the specified string has space; otherwise, <c>false</c>.</returns>
        public static bool HasSpace(this string str)
        {
            return str.Trim().IndexOf(" ") > 0;
        }

        /// <summary>
        /// Determines whether this instance has value.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns><c>true</c> if the specified string has value; otherwise, <c>false</c>.</returns>
        public static bool HasValue(this string str)
        {
            return !string.IsNullOrWhiteSpace(str);
        }

        /// <summary>
        /// Determines whether [is within square brackets].
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>
        /// <c>true</c> if [is within square brackets] [the specified string]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsWithinSquareBrackets(this string str)
        {
            return str.StartsWith("[") && str.EndsWith("]");
        }

        /// <summary>
        /// Ensures the has value.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="nameOfArgument">The name of argument.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static string EnsureHasValue(this string str, string nameOfArgument)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentNullException(nameOfArgument);
            }

            return str;
        }

        /// <summary>
        /// Trims the end.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="trimChars">The trim chars.</param>
        /// <param name="caseSensitive">if set to <c>true</c> [case sensitive].</param>
        /// <returns></returns>
        public static string TrimEnd(this string str, char[] trimChars, bool caseSensitive)
        {
            if (!caseSensitive)
            {
                return str.TrimEnd(trimChars.ToLowerCase()).TrimEnd(trimChars.ToUpperCase());
            }
            else
            {
                return str.TrimEnd(trimChars);
            }
        }
    }
}