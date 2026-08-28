
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesStreamEventMessageStartType
    {
        /// <summary>
        ///
        /// </summary>
        MessageStart,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesStreamEventMessageStartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesStreamEventMessageStartType value)
        {
            return value switch
            {
                MessagesStreamEventMessageStartType.MessageStart => "message_start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesStreamEventMessageStartType? ToEnum(string value)
        {
            return value switch
            {
                "message_start" => MessagesStreamEventMessageStartType.MessageStart,
                _ => null,
            };
        }
    }
}