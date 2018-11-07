using System;

namespace ProductivityExtensions
{
    /// <summary>
    /// </summary>
    public static class CharExtensions
    {
        /// <summary>
        /// To the lower case.
        /// </summary>
        /// <param name="characters">The characters.</param>
        /// <returns></returns>
        public static char[] ToLowerCase(this char[] characters)
        {
            return new String(characters).ToLower().ToCharArray();
        }

        /// <summary>
        /// To the upper case.
        /// </summary>
        /// <param name="characters">The characters.</param>
        /// <returns></returns>
        public static char[] ToUpperCase(this char[] characters)
        {
            return new String(characters).ToUpper().ToCharArray();
        }
    }
}