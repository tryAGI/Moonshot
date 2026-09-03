
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResponsesOutputWebSearchCallItemActionSource
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesOutputWebSearchCallItemActionSourceTypeJsonConverter))]
        public global::Moonshot.ResponsesOutputWebSearchCallItemActionSourceType? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesOutputWebSearchCallItemActionSource" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="url"></param>
        /// <param name="title"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesOutputWebSearchCallItemActionSource(
            global::Moonshot.ResponsesOutputWebSearchCallItemActionSourceType? type,
            string? url,
            string? title)
        {
            this.Type = type;
            this.Url = url;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesOutputWebSearchCallItemActionSource" /> class.
        /// </summary>
        public ResponsesOutputWebSearchCallItemActionSource()
        {
        }

    }
}