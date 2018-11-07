using System;

namespace ProductivityExtensions
{
    /// <summary>
    /// </summary>
    public static class GenericExtensions
    {
        /// <summary>
        /// Ensures the value is not null.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item">The item.</param>
        /// <param name="nameOfArgument">The name of argument.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void EnsureNotNull<T>(this T item, string nameOfArgument = "")
        {
            if (item == null)
            {
                if (nameOfArgument.HasValue())
                {
                    throw new ArgumentNullException(nameOfArgument);
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }

        /// <summary>
        /// Determines whether this instance is null.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item">The item.</param>
        /// <returns><c>true</c> if the specified item is null; otherwise, <c>false</c>.</returns>
        public static bool IsNull<T>(this T item)
        {
            return item == null;
        }
    }
}