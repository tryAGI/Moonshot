
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesOutputReasoningItemType
    {
        /// <summary>
        ///
        /// </summary>
        Reasoning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesOutputReasoningItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesOutputReasoningItemType value)
        {
            return value switch
            {
                ResponsesOutputReasoningItemType.Reasoning => "reasoning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesOutputReasoningItemType? ToEnum(string value)
        {
            return value switch
            {
                "reasoning" => ResponsesOutputReasoningItemType.Reasoning,
                _ => null,
            };
        }
    }
}