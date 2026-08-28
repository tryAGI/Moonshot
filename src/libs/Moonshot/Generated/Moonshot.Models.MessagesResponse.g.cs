
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesResponse
    {
        /// <summary>
        /// Unique identifier of the response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Example: message
        /// </summary>
        /// <example>message</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.MessagesResponseTypeJsonConverter))]
        public global::Moonshot.MessagesResponseType? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.MessagesResponseRoleJsonConverter))]
        public global::Moonshot.MessagesResponseRole? Role { get; set; }

        /// <summary>
        /// The model specified in the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Content blocks, ordered thinking → text → tool_use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessagesResponseContentItemThinking, global::Moonshot.MessagesResponseContentItemText, global::Moonshot.MessagesResponseContentItemToolUse>>? Content { get; set; }

        /// <summary>
        /// Stop reason. `end_turn`: finished naturally (including a `stop_sequences` match); `max_tokens`: reached the max_tokens limit; `tool_use`: the model issued a tool call; `refusal`: content safety review was triggered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.MessagesResponseStopReasonJsonConverter))]
        public global::Moonshot.MessagesResponseStopReason? StopReason { get; set; }

        /// <summary>
        /// The stop sequence that was matched
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_sequence")]
        public string? StopSequence { get; set; }

        /// <summary>
        /// Token usage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Moonshot.MessagesResponseUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the response
        /// </param>
        /// <param name="type">
        /// Example: message
        /// </param>
        /// <param name="role"></param>
        /// <param name="model">
        /// The model specified in the request
        /// </param>
        /// <param name="content">
        /// Content blocks, ordered thinking → text → tool_use
        /// </param>
        /// <param name="stopReason">
        /// Stop reason. `end_turn`: finished naturally (including a `stop_sequences` match); `max_tokens`: reached the max_tokens limit; `tool_use`: the model issued a tool call; `refusal`: content safety review was triggered.
        /// </param>
        /// <param name="stopSequence">
        /// The stop sequence that was matched
        /// </param>
        /// <param name="usage">
        /// Token usage
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesResponse(
            string? id,
            global::Moonshot.MessagesResponseType? type,
            global::Moonshot.MessagesResponseRole? role,
            string? model,
            global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessagesResponseContentItemThinking, global::Moonshot.MessagesResponseContentItemText, global::Moonshot.MessagesResponseContentItemToolUse>>? content,
            global::Moonshot.MessagesResponseStopReason? stopReason,
            string? stopSequence,
            global::Moonshot.MessagesResponseUsage? usage)
        {
            this.Id = id;
            this.Type = type;
            this.Role = role;
            this.Model = model;
            this.Content = content;
            this.StopReason = stopReason;
            this.StopSequence = stopSequence;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResponse" /> class.
        /// </summary>
        public MessagesResponse()
        {
        }

    }
}