
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesOutputFunctionCallItemStatus
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
    public static class ResponsesOutputFunctionCallItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesOutputFunctionCallItemStatus value)
        {
            return value switch
            {
                ResponsesOutputFunctionCallItemStatus.Completed => "completed",
                ResponsesOutputFunctionCallItemStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesOutputFunctionCallItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResponsesOutputFunctionCallItemStatus.Completed,
                "in_progress" => ResponsesOutputFunctionCallItemStatus.InProgress,
                _ => null,
            };
        }
    }
}