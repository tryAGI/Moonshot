
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Image source. When `type` is `base64`, provide both `media_type` and `data`; when `type` is `url`, pass an `ms://&lt;file_id&gt;` file reference in `url`.
    /// </summary>
    public sealed partial class MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSource
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceType Type { get; set; }

        /// <summary>
        /// Image MIME type, required only when `type=base64`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceMediaTypeJsonConverter))]
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceMediaType? MediaType { get; set; }

        /// <summary>
        /// Base64-encoded image content, required only when `type=base64`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// Reference to an uploaded image by file ID in the form `ms://&lt;file_id&gt;`, required only when `type=url`. See [Upload File](/api/files-upload).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSource" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="mediaType">
        /// Image MIME type, required only when `type=base64`
        /// </param>
        /// <param name="data">
        /// Base64-encoded image content, required only when `type=base64`
        /// </param>
        /// <param name="url">
        /// Reference to an uploaded image by file ID in the form `ms://&lt;file_id&gt;`, required only when `type=url`. See [Upload File](/api/files-upload).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSource(
            global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceType type,
            global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceMediaType? mediaType,
            string? data,
            string? url)
        {
            this.Type = type;
            this.MediaType = mediaType;
            this.Data = data;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSource" /> class.
        /// </summary>
        public MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSource()
        {
        }

    }
}