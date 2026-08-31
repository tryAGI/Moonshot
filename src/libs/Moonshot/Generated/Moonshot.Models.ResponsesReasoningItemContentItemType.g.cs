
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesReasoningItemContentItemType
    {
        /// <summary>
        ///
        /// </summary>
        ReasoningText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesReasoningItemContentItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesReasoningItemContentItemType value)
        {
            return value switch
            {
                ResponsesReasoningItemContentItemType.ReasoningText => "reasoning_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesReasoningItemContentItemType? ToEnum(string value)
        {
            return value switch
            {
                "reasoning_text" => ResponsesReasoningItemContentItemType.ReasoningText,
                _ => null,
            };
        }
    }
}