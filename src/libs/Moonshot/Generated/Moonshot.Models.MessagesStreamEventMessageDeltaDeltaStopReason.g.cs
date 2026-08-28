
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Stop reason. `end_turn`: finished naturally (including a `stop_sequences` match); `max_tokens`: reached the max_tokens limit; `tool_use`: the model issued a tool call; `refusal`: content safety review was triggered.
    /// </summary>
    public enum MessagesStreamEventMessageDeltaDeltaStopReason
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
    public static class MessagesStreamEventMessageDeltaDeltaStopReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesStreamEventMessageDeltaDeltaStopReason value)
        {
            return value switch
            {
                MessagesStreamEventMessageDeltaDeltaStopReason.EndTurn => "end_turn",
                MessagesStreamEventMessageDeltaDeltaStopReason.MaxTokens => "max_tokens",
                MessagesStreamEventMessageDeltaDeltaStopReason.Refusal => "refusal",
                MessagesStreamEventMessageDeltaDeltaStopReason.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesStreamEventMessageDeltaDeltaStopReason? ToEnum(string value)
        {
            return value switch
            {
                "end_turn" => MessagesStreamEventMessageDeltaDeltaStopReason.EndTurn,
                "max_tokens" => MessagesStreamEventMessageDeltaDeltaStopReason.MaxTokens,
                "refusal" => MessagesStreamEventMessageDeltaDeltaStopReason.Refusal,
                "tool_use" => MessagesStreamEventMessageDeltaDeltaStopReason.ToolUse,
                _ => null,
            };
        }
    }
}