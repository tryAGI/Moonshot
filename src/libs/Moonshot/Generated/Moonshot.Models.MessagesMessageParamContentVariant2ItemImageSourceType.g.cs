
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesMessageParamContentVariant2ItemImageSourceType
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
    public static class MessagesMessageParamContentVariant2ItemImageSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentVariant2ItemImageSourceType value)
        {
            return value switch
            {
                MessagesMessageParamContentVariant2ItemImageSourceType.Base64 => "base64",
                MessagesMessageParamContentVariant2ItemImageSourceType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentVariant2ItemImageSourceType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => MessagesMessageParamContentVariant2ItemImageSourceType.Base64,
                "url" => MessagesMessageParamContentVariant2ItemImageSourceType.Url,
                _ => null,
            };
        }
    }
}