
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionResponseChoiceMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionResponseChoiceMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionResponseChoiceMessageRole value)
        {
            return value switch
            {
                ChatCompletionResponseChoiceMessageRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionResponseChoiceMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatCompletionResponseChoiceMessageRole.Assistant,
                _ => null,
            };
        }
    }
}