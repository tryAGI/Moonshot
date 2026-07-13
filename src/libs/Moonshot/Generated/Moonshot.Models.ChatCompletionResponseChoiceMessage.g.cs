
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionResponseChoiceMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ChatCompletionResponseChoiceMessageRoleJsonConverter))]
        public global::Moonshot.ChatCompletionResponseChoiceMessageRole? Role { get; set; }

        /// <summary>
        /// The assistant's message content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Tool calls made by the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::Moonshot.ChatCompletionResponseChoiceMessageToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Reasoning process (returned only when thinking mode is enabled)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_content")]
        public string? ReasoningContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseChoiceMessage" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="content">
        /// The assistant's message content
        /// </param>
        /// <param name="toolCalls">
        /// Tool calls made by the model
        /// </param>
        /// <param name="reasoningContent">
        /// Reasoning process (returned only when thinking mode is enabled)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionResponseChoiceMessage(
            global::Moonshot.ChatCompletionResponseChoiceMessageRole? role,
            string? content,
            global::System.Collections.Generic.IList<global::Moonshot.ChatCompletionResponseChoiceMessageToolCall>? toolCalls,
            string? reasoningContent)
        {
            this.Role = role;
            this.Content = content;
            this.ToolCalls = toolCalls;
            this.ReasoningContent = reasoningContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseChoiceMessage" /> class.
        /// </summary>
        public ChatCompletionResponseChoiceMessage()
        {
        }

    }
}