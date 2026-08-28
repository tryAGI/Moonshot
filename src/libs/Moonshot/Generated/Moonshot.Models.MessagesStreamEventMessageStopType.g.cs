
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesStreamEventMessageStopType
    {
        /// <summary>
        ///
        /// </summary>
        MessageStop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesStreamEventMessageStopTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesStreamEventMessageStopType value)
        {
            return value switch
            {
                MessagesStreamEventMessageStopType.MessageStop => "message_stop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesStreamEventMessageStopType? ToEnum(string value)
        {
            return value switch
            {
                "message_stop" => MessagesStreamEventMessageStopType.MessageStop,
                _ => null,
            };
        }
    }
}