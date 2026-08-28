
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesStreamEventMessageDeltaType
    {
        /// <summary>
        ///
        /// </summary>
        MessageDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesStreamEventMessageDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesStreamEventMessageDeltaType value)
        {
            return value switch
            {
                MessagesStreamEventMessageDeltaType.MessageDelta => "message_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesStreamEventMessageDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "message_delta" => MessagesStreamEventMessageDeltaType.MessageDelta,
                _ => null,
            };
        }
    }
}