
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesStreamEventContentBlockStartType
    {
        /// <summary>
        ///
        /// </summary>
        ContentBlockStart,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesStreamEventContentBlockStartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesStreamEventContentBlockStartType value)
        {
            return value switch
            {
                MessagesStreamEventContentBlockStartType.ContentBlockStart => "content_block_start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesStreamEventContentBlockStartType? ToEnum(string value)
        {
            return value switch
            {
                "content_block_start" => MessagesStreamEventContentBlockStartType.ContentBlockStart,
                _ => null,
            };
        }
    }
}