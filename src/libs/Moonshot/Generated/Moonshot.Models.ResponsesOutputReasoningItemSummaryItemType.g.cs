
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesOutputReasoningItemSummaryItemType
    {
        /// <summary>
        ///
        /// </summary>
        SummaryText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesOutputReasoningItemSummaryItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesOutputReasoningItemSummaryItemType value)
        {
            return value switch
            {
                ResponsesOutputReasoningItemSummaryItemType.SummaryText => "summary_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesOutputReasoningItemSummaryItemType? ToEnum(string value)
        {
            return value switch
            {
                "summary_text" => ResponsesOutputReasoningItemSummaryItemType.SummaryText,
                _ => null,
            };
        }
    }
}