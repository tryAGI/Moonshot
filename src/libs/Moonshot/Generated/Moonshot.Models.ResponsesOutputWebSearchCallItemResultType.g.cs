
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesOutputWebSearchCallItemResultType
    {
        /// <summary>
        ///
        /// </summary>
        ImageResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesOutputWebSearchCallItemResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesOutputWebSearchCallItemResultType value)
        {
            return value switch
            {
                ResponsesOutputWebSearchCallItemResultType.ImageResult => "image_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesOutputWebSearchCallItemResultType? ToEnum(string value)
        {
            return value switch
            {
                "image_result" => ResponsesOutputWebSearchCallItemResultType.ImageResult,
                _ => null,
            };
        }
    }
}