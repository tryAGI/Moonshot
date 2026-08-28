
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesMessageParamContentVariant2ItemImage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.MessagesMessageParamContentVariant2ItemImageTypeJsonConverter))]
        public global::Moonshot.MessagesMessageParamContentVariant2ItemImageType Type { get; set; }

        /// <summary>
        /// Image source. When `type` is `base64`, provide both `media_type` and `data`; when `type` is `url`, pass an `ms://&lt;file_id&gt;` file reference in `url`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.MessagesMessageParamContentVariant2ItemImageSource Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentVariant2ItemImage" /> class.
        /// </summary>
        /// <param name="source">
        /// Image source. When `type` is `base64`, provide both `media_type` and `data`; when `type` is `url`, pass an `ms://&lt;file_id&gt;` file reference in `url`.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesMessageParamContentVariant2ItemImage(
            global::Moonshot.MessagesMessageParamContentVariant2ItemImageSource source,
            global::Moonshot.MessagesMessageParamContentVariant2ItemImageType type)
        {
            this.Type = type;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentVariant2ItemImage" /> class.
        /// </summary>
        public MessagesMessageParamContentVariant2ItemImage()
        {
        }

    }
}