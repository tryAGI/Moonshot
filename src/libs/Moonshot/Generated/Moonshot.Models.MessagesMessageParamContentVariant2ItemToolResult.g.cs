
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// The result of a tool execution (appears in user messages)
    /// </summary>
    public sealed partial class MessagesMessageParamContentVariant2ItemToolResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.MessagesMessageParamContentVariant2ItemToolResultTypeJsonConverter))]
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultType Type { get; set; }

        /// <summary>
        /// The `id` of the corresponding tool_use block
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_use_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolUseId { get; set; }

        /// <summary>
        /// Tool output, either a string or an array of text / image blocks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemText, global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImage>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemText, global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImage>>> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentVariant2ItemToolResult" /> class.
        /// </summary>
        /// <param name="toolUseId">
        /// The `id` of the corresponding tool_use block
        /// </param>
        /// <param name="content">
        /// Tool output, either a string or an array of text / image blocks
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesMessageParamContentVariant2ItemToolResult(
            string toolUseId,
            global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemText, global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImage>>> content,
            global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultType type)
        {
            this.Type = type;
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentVariant2ItemToolResult" /> class.
        /// </summary>
        public MessagesMessageParamContentVariant2ItemToolResult()
        {
        }

    }
}