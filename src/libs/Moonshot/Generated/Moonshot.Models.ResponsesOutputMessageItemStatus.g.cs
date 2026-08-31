
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesOutputMessageItemStatus
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
    public static class ResponsesOutputMessageItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesOutputMessageItemStatus value)
        {
            return value switch
            {
                ResponsesOutputMessageItemStatus.Completed => "completed",
                ResponsesOutputMessageItemStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesOutputMessageItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResponsesOutputMessageItemStatus.Completed,
                "in_progress" => ResponsesOutputMessageItemStatus.InProgress,
                _ => null,
            };
        }
    }
}