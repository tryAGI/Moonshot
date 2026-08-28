
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesStreamEventContentBlockStartContentBlockThinkingType
    {
        /// <summary>
        ///
        /// </summary>
        Thinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesStreamEventContentBlockStartContentBlockThinkingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesStreamEventContentBlockStartContentBlockThinkingType value)
        {
            return value switch
            {
                MessagesStreamEventContentBlockStartContentBlockThinkingType.Thinking => "thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesStreamEventContentBlockStartContentBlockThinkingType? ToEnum(string value)
        {
            return value switch
            {
                "thinking" => MessagesStreamEventContentBlockStartContentBlockThinkingType.Thinking,
                _ => null,
            };
        }
    }
}