
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesInputContentPartInputTextType
    {
        /// <summary>
        ///
        /// </summary>
        InputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesInputContentPartInputTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesInputContentPartInputTextType value)
        {
            return value switch
            {
                ResponsesInputContentPartInputTextType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesInputContentPartInputTextType? ToEnum(string value)
        {
            return value switch
            {
                "input_text" => ResponsesInputContentPartInputTextType.InputText,
                _ => null,
            };
        }
    }
}