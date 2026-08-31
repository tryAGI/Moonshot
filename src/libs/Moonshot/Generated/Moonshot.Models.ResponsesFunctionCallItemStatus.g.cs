
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesFunctionCallItemStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesFunctionCallItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesFunctionCallItemStatus value)
        {
            return value switch
            {
                ResponsesFunctionCallItemStatus.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesFunctionCallItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResponsesFunctionCallItemStatus.Completed,
                _ => null,
            };
        }
    }
}