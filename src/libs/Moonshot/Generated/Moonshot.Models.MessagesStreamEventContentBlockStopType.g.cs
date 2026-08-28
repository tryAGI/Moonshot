
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesStreamEventContentBlockStopType
    {
        /// <summary>
        ///
        /// </summary>
        ContentBlockStop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesStreamEventContentBlockStopTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesStreamEventContentBlockStopType value)
        {
            return value switch
            {
                MessagesStreamEventContentBlockStopType.ContentBlockStop => "content_block_stop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesStreamEventContentBlockStopType? ToEnum(string value)
        {
            return value switch
            {
                "content_block_stop" => MessagesStreamEventContentBlockStopType.ContentBlockStop,
                _ => null,
            };
        }
    }
}