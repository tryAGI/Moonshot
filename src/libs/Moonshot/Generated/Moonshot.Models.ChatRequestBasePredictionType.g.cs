
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// The type of the predicted content. Currently only content is supported.
    /// </summary>
    public enum ChatRequestBasePredictionType
    {
        /// <summary>
        /// 
        /// </summary>
        Content,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestBasePredictionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestBasePredictionType value)
        {
            return value switch
            {
                ChatRequestBasePredictionType.Content => "content",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestBasePredictionType? ToEnum(string value)
        {
            return value switch
            {
                "content" => ChatRequestBasePredictionType.Content,
                _ => null,
            };
        }
    }
}