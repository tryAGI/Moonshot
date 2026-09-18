
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// The write mode actually applied
    /// </summary>
    public enum ResponsesResponsePromptCacheOptionsMode
    {
        /// <summary>
        ///
        /// </summary>
        Implicit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesResponsePromptCacheOptionsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesResponsePromptCacheOptionsMode value)
        {
            return value switch
            {
                ResponsesResponsePromptCacheOptionsMode.Implicit => "implicit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesResponsePromptCacheOptionsMode? ToEnum(string value)
        {
            return value switch
            {
                "implicit" => ResponsesResponsePromptCacheOptionsMode.Implicit,
                _ => null,
            };
        }
    }
}