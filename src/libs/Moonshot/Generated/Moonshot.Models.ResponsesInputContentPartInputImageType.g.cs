
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesInputContentPartInputImageType
    {
        /// <summary>
        ///
        /// </summary>
        InputImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesInputContentPartInputImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesInputContentPartInputImageType value)
        {
            return value switch
            {
                ResponsesInputContentPartInputImageType.InputImage => "input_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesInputContentPartInputImageType? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => ResponsesInputContentPartInputImageType.InputImage,
                _ => null,
            };
        }
    }
}