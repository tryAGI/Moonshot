
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// The cache lifetime actually applied
    /// </summary>
    public enum ResponsesResponsePromptCacheOptionsTtl
    {
        /// <summary>
        ///
        /// </summary>
        x1h,
        /// <summary>
        ///
        /// </summary>
        x5m,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesResponsePromptCacheOptionsTtlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesResponsePromptCacheOptionsTtl value)
        {
            return value switch
            {
                ResponsesResponsePromptCacheOptionsTtl.x1h => "1h",
                ResponsesResponsePromptCacheOptionsTtl.x5m => "5m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesResponsePromptCacheOptionsTtl? ToEnum(string value)
        {
            return value switch
            {
                "1h" => ResponsesResponsePromptCacheOptionsTtl.x1h,
                "5m" => ResponsesResponsePromptCacheOptionsTtl.x5m,
                _ => null,
            };
        }
    }
}