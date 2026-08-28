
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesMessageParam
    {
        /// <summary>
        /// The role of the message. Supports user and assistant. Use the top-level `system` field for the system prompt.<br/>
        /// Example: user
        /// </summary>
        /// <example>user</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.MessagesMessageParamRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.MessagesMessageParamRole Role { get; set; }

        /// <summary>
        /// Message content. Either a plain string or an array of content blocks (text / image / thinking / tool_use / tool_result).<br/>
        /// Example: Hello
        /// </summary>
        /// <example>Hello</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessagesMessageParamContentVariant2ItemText, global::Moonshot.MessagesMessageParamContentVariant2ItemImage, global::Moonshot.MessagesMessageParamContentVariant2ItemThinking, global::Moonshot.MessagesMessageParamContentVariant2ItemToolUse, global::Moonshot.MessagesMessageParamContentVariant2ItemToolResult>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessagesMessageParamContentVariant2ItemText, global::Moonshot.MessagesMessageParamContentVariant2ItemImage, global::Moonshot.MessagesMessageParamContentVariant2ItemThinking, global::Moonshot.MessagesMessageParamContentVariant2ItemToolUse, global::Moonshot.MessagesMessageParamContentVariant2ItemToolResult>>> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParam" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the message. Supports user and assistant. Use the top-level `system` field for the system prompt.<br/>
        /// Example: user
        /// </param>
        /// <param name="content">
        /// Message content. Either a plain string or an array of content blocks (text / image / thinking / tool_use / tool_result).<br/>
        /// Example: Hello
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesMessageParam(
            global::Moonshot.MessagesMessageParamRole role,
            global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessagesMessageParamContentVariant2ItemText, global::Moonshot.MessagesMessageParamContentVariant2ItemImage, global::Moonshot.MessagesMessageParamContentVariant2ItemThinking, global::Moonshot.MessagesMessageParamContentVariant2ItemToolUse, global::Moonshot.MessagesMessageParamContentVariant2ItemToolResult>>> content)
        {
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParam" /> class.
        /// </summary>
        public MessagesMessageParam()
        {
        }

    }
}