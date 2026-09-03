
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResponsesOutputWebSearchCallItemResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesOutputWebSearchCallItemResultTypeJsonConverter))]
        public global::Moonshot.ResponsesOutputWebSearchCallItemResultType? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_url")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_website_url")]
        public string? SourceWebsiteUrl { get; set; }

        /// <summary>
        /// Image caption. Returned only when `image_settings.caption` is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caption")]
        public string? Caption { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesOutputWebSearchCallItemResult" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="imageUrl"></param>
        /// <param name="thumbnailUrl"></param>
        /// <param name="sourceWebsiteUrl"></param>
        /// <param name="caption">
        /// Image caption. Returned only when `image_settings.caption` is enabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesOutputWebSearchCallItemResult(
            global::Moonshot.ResponsesOutputWebSearchCallItemResultType? type,
            string? imageUrl,
            string? thumbnailUrl,
            string? sourceWebsiteUrl,
            string? caption)
        {
            this.Type = type;
            this.ImageUrl = imageUrl;
            this.ThumbnailUrl = thumbnailUrl;
            this.SourceWebsiteUrl = sourceWebsiteUrl;
            this.Caption = caption;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesOutputWebSearchCallItemResult" /> class.
        /// </summary>
        public ResponsesOutputWebSearchCallItemResult()
        {
        }

    }
}