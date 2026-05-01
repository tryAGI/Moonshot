
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionResponseChoiceFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        Length,
        /// <summary>
        /// 
        /// </summary>
        Stop,
        /// <summary>
        /// 
        /// </summary>
        ToolCalls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionResponseChoiceFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionResponseChoiceFinishReason value)
        {
            return value switch
            {
                ChatCompletionResponseChoiceFinishReason.Length => "length",
                ChatCompletionResponseChoiceFinishReason.Stop => "stop",
                ChatCompletionResponseChoiceFinishReason.ToolCalls => "tool_calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionResponseChoiceFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "length" => ChatCompletionResponseChoiceFinishReason.Length,
                "stop" => ChatCompletionResponseChoiceFinishReason.Stop,
                "tool_calls" => ChatCompletionResponseChoiceFinishReason.ToolCalls,
                _ => null,
            };
        }
    }
}