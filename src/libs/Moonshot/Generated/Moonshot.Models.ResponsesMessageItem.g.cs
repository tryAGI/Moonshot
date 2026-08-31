
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// A conversation message. `type` may be omitted.
    /// </summary>
    public sealed partial class ResponsesMessageItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesMessageItemTypeJsonConverter))]
        public global::Moonshot.ResponsesMessageItemType? Type { get; set; }

        /// <summary>
        /// Message role. `developer` is handled as a system instruction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesMessageItemRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.ResponsesMessageItemRole Role { get; set; }

        /// <summary>
        /// Message content, either a string or an array of content parts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Moonshot.ResponsesInputContentPart>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.ResponsesInputContentPart>> Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesMessageItemStatusJsonConverter))]
        public global::Moonshot.ResponsesMessageItemStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesMessageItem" /> class.
        /// </summary>
        /// <param name="role">
        /// Message role. `developer` is handled as a system instruction.
        /// </param>
        /// <param name="content">
        /// Message content, either a string or an array of content parts.
        /// </param>
        /// <param name="type"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesMessageItem(
            global::Moonshot.ResponsesMessageItemRole role,
            global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.ResponsesInputContentPart>> content,
            global::Moonshot.ResponsesMessageItemType? type,
            global::Moonshot.ResponsesMessageItemStatus? status)
        {
            this.Type = type;
            this.Role = role;
            this.Content = content;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesMessageItem" /> class.
        /// </summary>
        public ResponsesMessageItem()
        {
        }

    }
}