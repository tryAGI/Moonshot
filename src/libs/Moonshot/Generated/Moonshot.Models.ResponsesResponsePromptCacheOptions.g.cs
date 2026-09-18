
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// The context cache write options actually applied by the server. When the request omits prompt_cache_options, refer to the mode and ttl returned here
    /// </summary>
    public sealed partial class ResponsesResponsePromptCacheOptions
    {
        /// <summary>
        /// The write mode actually applied
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesResponsePromptCacheOptionsModeJsonConverter))]
        public global::Moonshot.ResponsesResponsePromptCacheOptionsMode? Mode { get; set; }

        /// <summary>
        /// The cache lifetime actually applied
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesResponsePromptCacheOptionsTtlJsonConverter))]
        public global::Moonshot.ResponsesResponsePromptCacheOptionsTtl? Ttl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesResponsePromptCacheOptions" /> class.
        /// </summary>
        /// <param name="mode">
        /// The write mode actually applied
        /// </param>
        /// <param name="ttl">
        /// The cache lifetime actually applied
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesResponsePromptCacheOptions(
            global::Moonshot.ResponsesResponsePromptCacheOptionsMode? mode,
            global::Moonshot.ResponsesResponsePromptCacheOptionsTtl? ttl)
        {
            this.Mode = mode;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesResponsePromptCacheOptions" /> class.
        /// </summary>
        public ResponsesResponsePromptCacheOptions()
        {
        }

    }
}