
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesMessageParamContentVariant2ItemToolUseType
    {
        /// <summary>
        ///
        /// </summary>
        ToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentVariant2ItemToolUseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentVariant2ItemToolUseType value)
        {
            return value switch
            {
                MessagesMessageParamContentVariant2ItemToolUseType.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentVariant2ItemToolUseType? ToEnum(string value)
        {
            return value switch
            {
                "tool_use" => MessagesMessageParamContentVariant2ItemToolUseType.ToolUse,
                _ => null,
            };
        }
    }
}