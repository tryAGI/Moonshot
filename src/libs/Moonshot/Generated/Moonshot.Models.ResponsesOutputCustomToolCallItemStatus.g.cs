
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesOutputCustomToolCallItemStatus
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
    public static class ResponsesOutputCustomToolCallItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesOutputCustomToolCallItemStatus value)
        {
            return value switch
            {
                ResponsesOutputCustomToolCallItemStatus.Completed => "completed",
                ResponsesOutputCustomToolCallItemStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesOutputCustomToolCallItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResponsesOutputCustomToolCallItemStatus.Completed,
                "in_progress" => ResponsesOutputCustomToolCallItemStatus.InProgress,
                _ => null,
            };
        }
    }
}