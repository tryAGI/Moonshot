
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// The type of the predicted content. Currently only content is supported.
    /// </summary>
    public enum ChatRequestCommonPredictionType
    {
        /// <summary>
        /// 
        /// </summary>
        Content,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestCommonPredictionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestCommonPredictionType value)
        {
            return value switch
            {
                ChatRequestCommonPredictionType.Content => "content",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestCommonPredictionType? ToEnum(string value)
        {
            return value switch
            {
                "content" => ChatRequestCommonPredictionType.Content,
                _ => null,
            };
        }
    }
}