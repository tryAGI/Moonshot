
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Cache write mode. Only implicit is supported: automatically writes the request prefix to the cache<br/>
    /// Default Value: implicit
    /// </summary>
    public enum ResponsesRequestPromptCacheOptionsMode
    {
        /// <summary>
        /// automatically writes the request prefix to the cache
        /// </summary>
        Implicit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesRequestPromptCacheOptionsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesRequestPromptCacheOptionsMode value)
        {
            return value switch
            {
                ResponsesRequestPromptCacheOptionsMode.Implicit => "implicit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesRequestPromptCacheOptionsMode? ToEnum(string value)
        {
            return value switch
            {
                "implicit" => ResponsesRequestPromptCacheOptionsMode.Implicit,
                _ => null,
            };
        }
    }
}