
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesAdditionalToolsItemType
    {
        /// <summary>
        ///
        /// </summary>
        AdditionalTools,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesAdditionalToolsItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesAdditionalToolsItemType value)
        {
            return value switch
            {
                ResponsesAdditionalToolsItemType.AdditionalTools => "additional_tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesAdditionalToolsItemType? ToEnum(string value)
        {
            return value switch
            {
                "additional_tools" => ResponsesAdditionalToolsItemType.AdditionalTools,
                _ => null,
            };
        }
    }
}