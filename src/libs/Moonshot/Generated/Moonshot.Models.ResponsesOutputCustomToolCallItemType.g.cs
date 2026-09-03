
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesOutputCustomToolCallItemType
    {
        /// <summary>
        ///
        /// </summary>
        CustomToolCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesOutputCustomToolCallItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesOutputCustomToolCallItemType value)
        {
            return value switch
            {
                ResponsesOutputCustomToolCallItemType.CustomToolCall => "custom_tool_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesOutputCustomToolCallItemType? ToEnum(string value)
        {
            return value switch
            {
                "custom_tool_call" => ResponsesOutputCustomToolCallItemType.CustomToolCall,
                _ => null,
            };
        }
    }
}