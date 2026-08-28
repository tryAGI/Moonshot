
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesStreamEventContentBlockStartContentBlockToolUseType
    {
        /// <summary>
        ///
        /// </summary>
        ToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesStreamEventContentBlockStartContentBlockToolUseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesStreamEventContentBlockStartContentBlockToolUseType value)
        {
            return value switch
            {
                MessagesStreamEventContentBlockStartContentBlockToolUseType.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesStreamEventContentBlockStartContentBlockToolUseType? ToEnum(string value)
        {
            return value switch
            {
                "tool_use" => MessagesStreamEventContentBlockStartContentBlockToolUseType.ToolUse,
                _ => null,
            };
        }
    }
}