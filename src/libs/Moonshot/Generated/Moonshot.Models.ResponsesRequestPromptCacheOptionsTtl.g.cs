
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Lifetime of the written cache. The 5m and 1h tiers are independent of each other. When a request with the same prefix hits the cache within its lifetime, the cache entry is refreshed with its original TTL<br/>
    /// Default Value: 5m
    /// </summary>
    public enum ResponsesRequestPromptCacheOptionsTtl
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
    public static class ResponsesRequestPromptCacheOptionsTtlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesRequestPromptCacheOptionsTtl value)
        {
            return value switch
            {
                ResponsesRequestPromptCacheOptionsTtl.x1h => "1h",
                ResponsesRequestPromptCacheOptionsTtl.x5m => "5m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesRequestPromptCacheOptionsTtl? ToEnum(string value)
        {
            return value switch
            {
                "1h" => ResponsesRequestPromptCacheOptionsTtl.x1h,
                "5m" => ResponsesRequestPromptCacheOptionsTtl.x5m,
                _ => null,
            };
        }
    }
}