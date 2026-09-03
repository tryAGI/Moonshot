
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesCustomToolCallOutputItemStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesCustomToolCallOutputItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesCustomToolCallOutputItemStatus value)
        {
            return value switch
            {
                ResponsesCustomToolCallOutputItemStatus.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesCustomToolCallOutputItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResponsesCustomToolCallOutputItemStatus.Completed,
                _ => null,
            };
        }
    }
}