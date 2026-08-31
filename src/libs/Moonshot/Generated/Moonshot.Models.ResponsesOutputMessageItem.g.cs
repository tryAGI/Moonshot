
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Text reply produced by the model.
    /// </summary>
    public sealed partial class ResponsesOutputMessageItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesOutputMessageItemTypeJsonConverter))]
        public global::Moonshot.ResponsesOutputMessageItemType? Type { get; set; }

        /// <summary>
        /// Example: msg_68f0c1c2d3e4f5a6b7c8d9e0
        /// </summary>
        /// <example>msg_68f0c1c2d3e4f5a6b7c8d9e0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesOutputMessageItemRoleJsonConverter))]
        public global::Moonshot.ResponsesOutputMessageItemRole? Role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesOutputMessageItemContentItem>? Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesOutputMessageItemStatusJsonConverter))]
        public global::Moonshot.ResponsesOutputMessageItemStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesOutputMessageItem" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id">
        /// Example: msg_68f0c1c2d3e4f5a6b7c8d9e0
        /// </param>
        /// <param name="role"></param>
        /// <param name="content"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesOutputMessageItem(
            global::Moonshot.ResponsesOutputMessageItemType? type,
            string? id,
            global::Moonshot.ResponsesOutputMessageItemRole? role,
            global::System.Collections.Generic.IList<global::Moonshot.ResponsesOutputMessageItemContentItem>? content,
            global::Moonshot.ResponsesOutputMessageItemStatus? status)
        {
            this.Type = type;
            this.Id = id;
            this.Role = role;
            this.Content = content;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesOutputMessageItem" /> class.
        /// </summary>
        public ResponsesOutputMessageItem()
        {
        }

    }
}