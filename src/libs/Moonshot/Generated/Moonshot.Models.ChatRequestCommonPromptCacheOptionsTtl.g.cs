
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Lifetime of the written cache. The 5m and 1h tiers are independent of each other. When a request with the same prefix hits the cache within its lifetime, the cache entry is refreshed with its original TTL<br/>
    /// Default Value: 5m
    /// </summary>
    public enum ChatRequestCommonPromptCacheOptionsTtl
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
    public static class ChatRequestCommonPromptCacheOptionsTtlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestCommonPromptCacheOptionsTtl value)
        {
            return value switch
            {
                ChatRequestCommonPromptCacheOptionsTtl.x1h => "1h",
                ChatRequestCommonPromptCacheOptionsTtl.x5m => "5m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestCommonPromptCacheOptionsTtl? ToEnum(string value)
        {
            return value switch
            {
                "1h" => ChatRequestCommonPromptCacheOptionsTtl.x1h,
                "5m" => ChatRequestCommonPromptCacheOptionsTtl.x5m,
                _ => null,
            };
        }
    }
}