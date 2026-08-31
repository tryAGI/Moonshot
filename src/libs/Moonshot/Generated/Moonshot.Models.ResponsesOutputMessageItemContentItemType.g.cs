
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesOutputMessageItemContentItemType
    {
        /// <summary>
        ///
        /// </summary>
        OutputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesOutputMessageItemContentItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesOutputMessageItemContentItemType value)
        {
            return value switch
            {
                ResponsesOutputMessageItemContentItemType.OutputText => "output_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesOutputMessageItemContentItemType? ToEnum(string value)
        {
            return value switch
            {
                "output_text" => ResponsesOutputMessageItemContentItemType.OutputText,
                _ => null,
            };
        }
    }
}