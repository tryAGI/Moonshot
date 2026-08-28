
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesMessageParamContentVariant2ItemToolResultType
    {
        /// <summary>
        ///
        /// </summary>
        ToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentVariant2ItemToolResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentVariant2ItemToolResultType value)
        {
            return value switch
            {
                MessagesMessageParamContentVariant2ItemToolResultType.ToolResult => "tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentVariant2ItemToolResultType? ToEnum(string value)
        {
            return value switch
            {
                "tool_result" => MessagesMessageParamContentVariant2ItemToolResultType.ToolResult,
                _ => null,
            };
        }
    }
}