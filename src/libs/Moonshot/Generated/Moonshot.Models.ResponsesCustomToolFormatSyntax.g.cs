
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesCustomToolFormatSyntax
    {
        /// <summary>
        ///
        /// </summary>
        Lark,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesCustomToolFormatSyntaxExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesCustomToolFormatSyntax value)
        {
            return value switch
            {
                ResponsesCustomToolFormatSyntax.Lark => "lark",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesCustomToolFormatSyntax? ToEnum(string value)
        {
            return value switch
            {
                "lark" => ResponsesCustomToolFormatSyntax.Lark,
                _ => null,
            };
        }
    }
}