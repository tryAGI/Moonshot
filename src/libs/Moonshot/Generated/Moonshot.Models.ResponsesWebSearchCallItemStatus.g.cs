
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesWebSearchCallItemStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesWebSearchCallItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesWebSearchCallItemStatus value)
        {
            return value switch
            {
                ResponsesWebSearchCallItemStatus.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesWebSearchCallItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResponsesWebSearchCallItemStatus.Completed,
                _ => null,
            };
        }
    }
}