
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Stop reason. `end_turn`: finished naturally (including a `stop_sequences` match); `max_tokens`: reached the max_tokens limit; `tool_use`: the model issued a tool call; `refusal`: content safety review was triggered.
    /// </summary>
    public enum MessagesResponseStopReason
    {
        /// <summary>
        /// finished naturally (including a `stop_sequences` match); `max_tokens`: reached the max_tokens limit; `tool_use`: the model issued a tool call; `refusal`: content safety review was triggered.
        /// </summary>
        EndTurn,
        /// <summary>
        /// finished naturally (including a `stop_sequences` match); `max_tokens`: reached the max_tokens limit; `tool_use`: the model issued a tool call; `refusal`: content safety review was triggered.
        /// </summary>
        MaxTokens,
        /// <summary>
        /// finished naturally (including a `stop_sequences` match); `max_tokens`: reached the max_tokens limit; `tool_use`: the model issued a tool call; `refusal`: content safety review was triggered.
        /// </summary>
        Refusal,
        /// <summary>
        /// finished naturally (including a `stop_sequences` match); `max_tokens`: reached the max_tokens limit; `tool_use`: the model issued a tool call; `refusal`: content safety review was triggered.
        /// </summary>
        ToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesResponseStopReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesResponseStopReason value)
        {
            return value switch
            {
                MessagesResponseStopReason.EndTurn => "end_turn",
                MessagesResponseStopReason.MaxTokens => "max_tokens",
                MessagesResponseStopReason.Refusal => "refusal",
                MessagesResponseStopReason.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesResponseStopReason? ToEnum(string value)
        {
            return value switch
            {
                "end_turn" => MessagesResponseStopReason.EndTurn,
                "max_tokens" => MessagesResponseStopReason.MaxTokens,
                "refusal" => MessagesResponseStopReason.Refusal,
                "tool_use" => MessagesResponseStopReason.ToolUse,
                _ => null,
            };
        }
    }
}