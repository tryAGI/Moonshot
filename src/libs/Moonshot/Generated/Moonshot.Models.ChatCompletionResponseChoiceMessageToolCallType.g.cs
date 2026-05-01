
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionResponseChoiceMessageToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionResponseChoiceMessageToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionResponseChoiceMessageToolCallType value)
        {
            return value switch
            {
                ChatCompletionResponseChoiceMessageToolCallType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionResponseChoiceMessageToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "function" => ChatCompletionResponseChoiceMessageToolCallType.Function,
                _ => null,
            };
        }
    }
}