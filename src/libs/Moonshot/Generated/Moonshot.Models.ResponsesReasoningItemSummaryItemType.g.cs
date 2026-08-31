
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesReasoningItemSummaryItemType
    {
        /// <summary>
        ///
        /// </summary>
        SummaryText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesReasoningItemSummaryItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesReasoningItemSummaryItemType value)
        {
            return value switch
            {
                ResponsesReasoningItemSummaryItemType.SummaryText => "summary_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesReasoningItemSummaryItemType? ToEnum(string value)
        {
            return value switch
            {
                "summary_text" => ResponsesReasoningItemSummaryItemType.SummaryText,
                _ => null,
            };
        }
    }
}