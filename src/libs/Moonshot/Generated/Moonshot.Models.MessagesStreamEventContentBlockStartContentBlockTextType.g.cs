
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesStreamEventContentBlockStartContentBlockTextType
    {
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesStreamEventContentBlockStartContentBlockTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesStreamEventContentBlockStartContentBlockTextType value)
        {
            return value switch
            {
                MessagesStreamEventContentBlockStartContentBlockTextType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesStreamEventContentBlockStartContentBlockTextType? ToEnum(string value)
        {
            return value switch
            {
                "text" => MessagesStreamEventContentBlockStartContentBlockTextType.Text,
                _ => null,
            };
        }
    }
}