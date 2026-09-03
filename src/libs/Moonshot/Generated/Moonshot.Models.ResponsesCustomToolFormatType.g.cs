
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesCustomToolFormatType
    {
        /// <summary>
        ///
        /// </summary>
        Grammar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesCustomToolFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesCustomToolFormatType value)
        {
            return value switch
            {
                ResponsesCustomToolFormatType.Grammar => "grammar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesCustomToolFormatType? ToEnum(string value)
        {
            return value switch
            {
                "grammar" => ResponsesCustomToolFormatType.Grammar,
                _ => null,
            };
        }
    }
}