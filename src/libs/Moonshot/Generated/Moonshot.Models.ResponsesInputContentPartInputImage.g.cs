
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResponsesInputContentPartInputImage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesInputContentPartInputImageTypeJsonConverter))]
        public global::Moonshot.ResponsesInputContentPartInputImageType Type { get; set; }

        /// <summary>
        /// Data URL of the image, for example `data:image/png;base64,&lt;base64&gt;`. Public http(s) URLs are not supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesInputContentPartInputImageDetailJsonConverter))]
        public global::Moonshot.ResponsesInputContentPartInputImageDetail? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesInputContentPartInputImage" /> class.
        /// </summary>
        /// <param name="imageUrl">
        /// Data URL of the image, for example `data:image/png;base64,&lt;base64&gt;`. Public http(s) URLs are not supported.
        /// </param>
        /// <param name="type"></param>
        /// <param name="detail"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesInputContentPartInputImage(
            string imageUrl,
            global::Moonshot.ResponsesInputContentPartInputImageType type,
            global::Moonshot.ResponsesInputContentPartInputImageDetail? detail)
        {
            this.Type = type;
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesInputContentPartInputImage" /> class.
        /// </summary>
        public ResponsesInputContentPartInputImage()
        {
        }

    }
}