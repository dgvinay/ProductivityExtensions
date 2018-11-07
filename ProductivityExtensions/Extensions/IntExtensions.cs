namespace ProductivityExtensions
{
    /// <summary>
    /// </summary>
    public static class IntExtensions
    {
        /// <summary>
        /// Determines whether the specified minimum value is between.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="minValue">The minimum value.</param>
        /// <param name="maxValue">The maximum value.</param>
        /// <param name="inclusive">if set to <c>true</c> [inclusive].</param>
        /// <returns><c>true</c> if the specified minimum value is between; otherwise, <c>false</c>.</returns>
        public static bool IsBetween(this int value, int minValue, int maxValue, bool inclusive = true)
        {
            if (inclusive)
            {
                return value >= minValue && value <= maxValue;
            }
            else
            {
                return value > minValue && value < maxValue;
            }
        }
    }
}