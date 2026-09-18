
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Cache write mode. Only implicit is supported: automatically writes the request prefix to the cache<br/>
    /// Default Value: implicit
    /// </summary>
    public enum ChatRequestBasePromptCacheOptionsMode
    {
        /// <summary>
        /// automatically writes the request prefix to the cache
        /// </summary>
        Implicit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestBasePromptCacheOptionsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestBasePromptCacheOptionsMode value)
        {
            return value switch
            {
                ChatRequestBasePromptCacheOptionsMode.Implicit => "implicit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestBasePromptCacheOptionsMode? ToEnum(string value)
        {
            return value switch
            {
                "implicit" => ChatRequestBasePromptCacheOptionsMode.Implicit,
                _ => null,
            };
        }
    }
}