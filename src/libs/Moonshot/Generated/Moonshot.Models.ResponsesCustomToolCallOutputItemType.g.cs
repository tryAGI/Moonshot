
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesCustomToolCallOutputItemType
    {
        /// <summary>
        ///
        /// </summary>
        CustomToolCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesCustomToolCallOutputItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesCustomToolCallOutputItemType value)
        {
            return value switch
            {
                ResponsesCustomToolCallOutputItemType.CustomToolCallOutput => "custom_tool_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesCustomToolCallOutputItemType? ToEnum(string value)
        {
            return value switch
            {
                "custom_tool_call_output" => ResponsesCustomToolCallOutputItemType.CustomToolCallOutput,
                _ => null,
            };
        }
    }
}