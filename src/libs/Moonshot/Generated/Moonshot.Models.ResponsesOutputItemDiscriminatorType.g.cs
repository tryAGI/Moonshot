
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesOutputItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        CustomToolCall,
        /// <summary>
        ///
        /// </summary>
        FunctionCall,
        /// <summary>
        ///
        /// </summary>
        Message,
        /// <summary>
        ///
        /// </summary>
        Reasoning,
        /// <summary>
        ///
        /// </summary>
        WebSearchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesOutputItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesOutputItemDiscriminatorType value)
        {
            return value switch
            {
                ResponsesOutputItemDiscriminatorType.CustomToolCall => "custom_tool_call",
                ResponsesOutputItemDiscriminatorType.FunctionCall => "function_call",
                ResponsesOutputItemDiscriminatorType.Message => "message",
                ResponsesOutputItemDiscriminatorType.Reasoning => "reasoning",
                ResponsesOutputItemDiscriminatorType.WebSearchCall => "web_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesOutputItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom_tool_call" => ResponsesOutputItemDiscriminatorType.CustomToolCall,
                "function_call" => ResponsesOutputItemDiscriminatorType.FunctionCall,
                "message" => ResponsesOutputItemDiscriminatorType.Message,
                "reasoning" => ResponsesOutputItemDiscriminatorType.Reasoning,
                "web_search_call" => ResponsesOutputItemDiscriminatorType.WebSearchCall,
                _ => null,
            };
        }
    }
}