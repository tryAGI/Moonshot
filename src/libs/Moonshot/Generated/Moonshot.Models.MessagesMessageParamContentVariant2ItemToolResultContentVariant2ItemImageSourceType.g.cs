
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceType
    {
        /// <summary>
        ///
        /// </summary>
        Base64,
        /// <summary>
        ///
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceType value)
        {
            return value switch
            {
                MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceType.Base64 => "base64",
                MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceType.Base64,
                "url" => MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceType.Url,
                _ => null,
            };
        }
    }
}