
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Image MIME type, required only when `type=base64`
    /// </summary>
    public enum MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceMediaType
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
    public static class MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceMediaType value)
        {
            return value switch
            {
                MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceMediaType.ImageGif => "image/gif",
                MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceMediaType.ImageJpeg => "image/jpeg",
                MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceMediaType.ImagePng => "image/png",
                MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceMediaType.ImageWebp => "image/webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceMediaType? ToEnum(string value)
        {
            return value switch
            {
                "image/gif" => MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceMediaType.ImageGif,
                "image/jpeg" => MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceMediaType.ImageJpeg,
                "image/png" => MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceMediaType.ImagePng,
                "image/webp" => MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceMediaType.ImageWebp,
                _ => null,
            };
        }
    }
}