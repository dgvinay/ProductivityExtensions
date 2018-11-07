using System;
using System.Runtime.Serialization;

namespace ProductivityExtensions.Exceptions
{
    /// <summary>
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class ValueNotUniqueException : Exception
    {
        private string _message;

        /// <summary>
        /// Gets a message that describes the current exception.
        /// </summary>
        public override string Message
        {
            get
            {
                if (!_message.HasValue())
                {
                    return base.Message;
                }
                else
                {
                    return _message;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueNotUniqueException" /> class.
        /// </summary>
        public ValueNotUniqueException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueNotUniqueException" /> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public ValueNotUniqueException(string message)
                    : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueNotUniqueException" /> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="innerException">The inner exception.</param>
        public ValueNotUniqueException(string message, Exception innerException)
                    : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueNotUniqueException" /> class.
        /// </summary>
        /// <param name="info">The information.</param>
        /// <param name="context">The context.</param>
        protected ValueNotUniqueException(SerializationInfo info, StreamingContext context)
                    : base(info, context)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueNotUniqueException" /> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public ValueNotUniqueException(object value)
        {
            _message = $"Value [{value}] was not found to be unique.";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueNotUniqueException" /> class.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="nameOfArgument">The name of argument.</param>
        public ValueNotUniqueException(object value, string nameOfArgument)
        {
            _message = $"Value [{value}] specified in [{nameOfArgument}] was not found to be unique.";
        }
    }
}