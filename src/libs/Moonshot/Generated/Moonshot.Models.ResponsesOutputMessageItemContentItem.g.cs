
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResponsesOutputMessageItemContentItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesOutputMessageItemContentItemTypeJsonConverter))]
        public global::Moonshot.ResponsesOutputMessageItemContentItemType? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public global::System.Collections.Generic.IList<object>? Annotations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesOutputMessageItemContentItem" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="text"></param>
        /// <param name="annotations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesOutputMessageItemContentItem(
            global::Moonshot.ResponsesOutputMessageItemContentItemType? type,
            string? text,
            global::System.Collections.Generic.IList<object>? annotations)
        {
            this.Type = type;
            this.Text = text;
            this.Annotations = annotations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesOutputMessageItemContentItem" /> class.
        /// </summary>
        public ResponsesOutputMessageItemContentItem()
        {
        }

    }
}