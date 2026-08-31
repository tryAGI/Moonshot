
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesOutputReasoningItemStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesOutputReasoningItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesOutputReasoningItemStatus value)
        {
            return value switch
            {
                ResponsesOutputReasoningItemStatus.Completed => "completed",
                ResponsesOutputReasoningItemStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesOutputReasoningItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResponsesOutputReasoningItemStatus.Completed,
                "in_progress" => ResponsesOutputReasoningItemStatus.InProgress,
                _ => null,
            };
        }
    }
}