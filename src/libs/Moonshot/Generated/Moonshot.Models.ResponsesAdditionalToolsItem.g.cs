
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Adds callable tools partway through a conversation, effective from the position of this item.
    /// </summary>
    public sealed partial class ResponsesAdditionalToolsItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesAdditionalToolsItemTypeJsonConverter))]
        public global::Moonshot.ResponsesAdditionalToolsItemType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesAdditionalToolsItemRoleJsonConverter))]
        public global::Moonshot.ResponsesAdditionalToolsItemRole Role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Moonshot.ResponsesTool> Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesAdditionalToolsItem" /> class.
        /// </summary>
        /// <param name="tools"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesAdditionalToolsItem(
            global::System.Collections.Generic.IList<global::Moonshot.ResponsesTool> tools,
            global::Moonshot.ResponsesAdditionalToolsItemType type,
            string? id,
            global::Moonshot.ResponsesAdditionalToolsItemRole role)
        {
            this.Type = type;
            this.Id = id;
            this.Role = role;
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesAdditionalToolsItem" /> class.
        /// </summary>
        public ResponsesAdditionalToolsItem()
        {
        }

    }
}