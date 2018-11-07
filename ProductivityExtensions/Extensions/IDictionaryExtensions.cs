using ProductivityExtensions.Exceptions;
using System.Collections.Generic;

namespace ProductivityExtensions
{
    /// <summary>
    /// </summary>
    public static class IDictionaryExtensions
    {
        /// <summary>
        /// Ensures the key is unique.
        /// </summary>
        /// <typeparam name="Tkey">The type of the key.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="keyValuePairs">The key value pairs.</param>
        /// <param name="keyToVerify">The key to verify.</param>
        /// <param name="nameOfArgument">The name of argument.</param>
        /// <exception cref="ProductivityExtensions.Exceptions.ValueNotUniqueException"></exception>
        public static void EnsureKeyIsUnique<Tkey, TValue>(
            this IDictionary<Tkey, TValue> keyValuePairs,
            Tkey keyToVerify,
            string nameOfArgument)
        {
            if (keyValuePairs.ContainsKey(keyToVerify))
            {
                throw new ValueNotUniqueException(keyToVerify, nameOfArgument);
            }
        }
    }
}