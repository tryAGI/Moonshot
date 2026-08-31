
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesOutputFunctionCallItemType
    {
        /// <summary>
        ///
        /// </summary>
        FunctionCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesOutputFunctionCallItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesOutputFunctionCallItemType value)
        {
            return value switch
            {
                ResponsesOutputFunctionCallItemType.FunctionCall => "function_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesOutputFunctionCallItemType? ToEnum(string value)
        {
            return value switch
            {
                "function_call" => ResponsesOutputFunctionCallItemType.FunctionCall,
                _ => null,
            };
        }
    }
}