
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesResponseContentItemToolUseType
    {
        /// <summary>
        ///
        /// </summary>
        ToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesResponseContentItemToolUseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesResponseContentItemToolUseType value)
        {
            return value switch
            {
                MessagesResponseContentItemToolUseType.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesResponseContentItemToolUseType? ToEnum(string value)
        {
            return value switch
            {
                "tool_use" => MessagesResponseContentItemToolUseType.ToolUse,
                _ => null,
            };
        }
    }
}