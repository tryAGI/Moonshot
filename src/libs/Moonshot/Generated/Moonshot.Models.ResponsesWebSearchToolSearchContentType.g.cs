
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesWebSearchToolSearchContentType
    {
        /// <summary>
        ///
        /// </summary>
        Image,
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesWebSearchToolSearchContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesWebSearchToolSearchContentType value)
        {
            return value switch
            {
                ResponsesWebSearchToolSearchContentType.Image => "image",
                ResponsesWebSearchToolSearchContentType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesWebSearchToolSearchContentType? ToEnum(string value)
        {
            return value switch
            {
                "image" => ResponsesWebSearchToolSearchContentType.Image,
                "text" => ResponsesWebSearchToolSearchContentType.Text,
                _ => null,
            };
        }
    }
}