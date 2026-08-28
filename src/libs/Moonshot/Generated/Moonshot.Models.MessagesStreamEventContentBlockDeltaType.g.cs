
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesStreamEventContentBlockDeltaType
    {
        /// <summary>
        ///
        /// </summary>
        ContentBlockDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesStreamEventContentBlockDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesStreamEventContentBlockDeltaType value)
        {
            return value switch
            {
                MessagesStreamEventContentBlockDeltaType.ContentBlockDelta => "content_block_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesStreamEventContentBlockDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "content_block_delta" => MessagesStreamEventContentBlockDeltaType.ContentBlockDelta,
                _ => null,
            };
        }
    }
}