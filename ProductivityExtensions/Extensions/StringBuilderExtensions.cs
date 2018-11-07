using System.Text;

namespace ProductivityExtensions
{
    /// <summary>
    /// </summary>
    public static class StringBuilderExtensions
    {
        /// <summary>
        /// Appends the with leading space.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <returns></returns>
        public static StringBuilder AppendWithLeadingSpace<T>(this StringBuilder builder, T appendObject)
        {
            return builder.AppendFormat("{0} ", appendObject);
        }

        public static StringBuilder AppendFormatWithLeadingSpace(this StringBuilder builder, string appendString, params object[] objectArgs)
        {
            return builder.AppendFormat(appendString, objectArgs).Append(" ");
        }
    }
}