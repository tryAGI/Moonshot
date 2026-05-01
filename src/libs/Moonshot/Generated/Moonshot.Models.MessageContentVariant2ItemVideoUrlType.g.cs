
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessageContentVariant2ItemVideoUrlType
    {
        /// <summary>
        /// 
        /// </summary>
        VideoUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageContentVariant2ItemVideoUrlTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageContentVariant2ItemVideoUrlType value)
        {
            return value switch
            {
                MessageContentVariant2ItemVideoUrlType.VideoUrl => "video_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageContentVariant2ItemVideoUrlType? ToEnum(string value)
        {
            return value switch
            {
                "video_url" => MessageContentVariant2ItemVideoUrlType.VideoUrl,
                _ => null,
            };
        }
    }
}