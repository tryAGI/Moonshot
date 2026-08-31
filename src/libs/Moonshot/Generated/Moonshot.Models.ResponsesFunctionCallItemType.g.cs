
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesFunctionCallItemType
    {
        /// <summary>
        ///
        /// </summary>
        FunctionCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesFunctionCallItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesFunctionCallItemType value)
        {
            return value switch
            {
                ResponsesFunctionCallItemType.FunctionCall => "function_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesFunctionCallItemType? ToEnum(string value)
        {
            return value switch
            {
                "function_call" => ResponsesFunctionCallItemType.FunctionCall,
                _ => null,
            };
        }
    }
}