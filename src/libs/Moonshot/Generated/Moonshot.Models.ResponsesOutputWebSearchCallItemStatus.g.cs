
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesOutputWebSearchCallItemStatus
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
    public static class ResponsesOutputWebSearchCallItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesOutputWebSearchCallItemStatus value)
        {
            return value switch
            {
                ResponsesOutputWebSearchCallItemStatus.Completed => "completed",
                ResponsesOutputWebSearchCallItemStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesOutputWebSearchCallItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResponsesOutputWebSearchCallItemStatus.Completed,
                "in_progress" => ResponsesOutputWebSearchCallItemStatus.InProgress,
                _ => null,
            };
        }
    }
}