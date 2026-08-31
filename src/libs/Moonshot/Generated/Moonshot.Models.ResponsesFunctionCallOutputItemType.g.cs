
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesFunctionCallOutputItemType
    {
        /// <summary>
        ///
        /// </summary>
        FunctionCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesFunctionCallOutputItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesFunctionCallOutputItemType value)
        {
            return value switch
            {
                ResponsesFunctionCallOutputItemType.FunctionCallOutput => "function_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesFunctionCallOutputItemType? ToEnum(string value)
        {
            return value switch
            {
                "function_call_output" => ResponsesFunctionCallOutputItemType.FunctionCallOutput,
                _ => null,
            };
        }
    }
}