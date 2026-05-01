
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessageContentVariant2ItemTextType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageContentVariant2ItemTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageContentVariant2ItemTextType value)
        {
            return value switch
            {
                MessageContentVariant2ItemTextType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageContentVariant2ItemTextType? ToEnum(string value)
        {
            return value switch
            {
                "text" => MessageContentVariant2ItemTextType.Text,
                _ => null,
            };
        }
    }
}