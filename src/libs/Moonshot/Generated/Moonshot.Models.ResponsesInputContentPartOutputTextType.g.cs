
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesInputContentPartOutputTextType
    {
        /// <summary>
        ///
        /// </summary>
        OutputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesInputContentPartOutputTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesInputContentPartOutputTextType value)
        {
            return value switch
            {
                ResponsesInputContentPartOutputTextType.OutputText => "output_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesInputContentPartOutputTextType? ToEnum(string value)
        {
            return value switch
            {
                "output_text" => ResponsesInputContentPartOutputTextType.OutputText,
                _ => null,
            };
        }
    }
}