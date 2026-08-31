
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesFunctionCallOutputItemStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesFunctionCallOutputItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesFunctionCallOutputItemStatus value)
        {
            return value switch
            {
                ResponsesFunctionCallOutputItemStatus.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesFunctionCallOutputItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResponsesFunctionCallOutputItemStatus.Completed,
                _ => null,
            };
        }
    }
}