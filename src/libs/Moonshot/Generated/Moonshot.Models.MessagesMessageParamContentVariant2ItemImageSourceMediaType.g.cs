
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Image MIME type, required only when `type=base64`
    /// </summary>
    public enum MessagesMessageParamContentVariant2ItemImageSourceMediaType
    {
        /// <summary>
        ///
        /// </summary>
        ImageGif,
        /// <summary>
        ///
        /// </summary>
        ImageJpeg,
        /// <summary>
        ///
        /// </summary>
        ImagePng,
        /// <summary>
        ///
        /// </summary>
        ImageWebp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentVariant2ItemImageSourceMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentVariant2ItemImageSourceMediaType value)
        {
            return value switch
            {
                MessagesMessageParamContentVariant2ItemImageSourceMediaType.ImageGif => "image/gif",
                MessagesMessageParamContentVariant2ItemImageSourceMediaType.ImageJpeg => "image/jpeg",
                MessagesMessageParamContentVariant2ItemImageSourceMediaType.ImagePng => "image/png",
                MessagesMessageParamContentVariant2ItemImageSourceMediaType.ImageWebp => "image/webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentVariant2ItemImageSourceMediaType? ToEnum(string value)
        {
            return value switch
            {
                "image/gif" => MessagesMessageParamContentVariant2ItemImageSourceMediaType.ImageGif,
                "image/jpeg" => MessagesMessageParamContentVariant2ItemImageSourceMediaType.ImageJpeg,
                "image/png" => MessagesMessageParamContentVariant2ItemImageSourceMediaType.ImagePng,
                "image/webp" => MessagesMessageParamContentVariant2ItemImageSourceMediaType.ImageWebp,
                _ => null,
            };
        }
    }
}