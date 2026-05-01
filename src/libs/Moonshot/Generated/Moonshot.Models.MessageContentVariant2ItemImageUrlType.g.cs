
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessageContentVariant2ItemImageUrlType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageContentVariant2ItemImageUrlTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageContentVariant2ItemImageUrlType value)
        {
            return value switch
            {
                MessageContentVariant2ItemImageUrlType.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageContentVariant2ItemImageUrlType? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => MessageContentVariant2ItemImageUrlType.ImageUrl,
                _ => null,
            };
        }
    }
}