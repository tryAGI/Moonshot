
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Context cache write options. When omitted, cache write is enabled by default (5m tier): the system automatically writes the request prefix to the 5m cache tier
    /// </summary>
    public sealed partial class ResponsesRequestPromptCacheOptions
    {
        /// <summary>
        /// Cache write mode. Only implicit is supported: automatically writes the request prefix to the cache<br/>
        /// Default Value: implicit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesRequestPromptCacheOptionsModeJsonConverter))]
        public global::Moonshot.ResponsesRequestPromptCacheOptionsMode? Mode { get; set; }

        /// <summary>
        /// Lifetime of the written cache. The 5m and 1h tiers are independent of each other. When a request with the same prefix hits the cache within its lifetime, the cache entry is refreshed with its original TTL<br/>
        /// Default Value: 5m
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesRequestPromptCacheOptionsTtlJsonConverter))]
        public global::Moonshot.ResponsesRequestPromptCacheOptionsTtl? Ttl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestPromptCacheOptions" /> class.
        /// </summary>
        /// <param name="mode">
        /// Cache write mode. Only implicit is supported: automatically writes the request prefix to the cache<br/>
        /// Default Value: implicit
        /// </param>
        /// <param name="ttl">
        /// Lifetime of the written cache. The 5m and 1h tiers are independent of each other. When a request with the same prefix hits the cache within its lifetime, the cache entry is refreshed with its original TTL<br/>
        /// Default Value: 5m
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesRequestPromptCacheOptions(
            global::Moonshot.ResponsesRequestPromptCacheOptionsMode? mode,
            global::Moonshot.ResponsesRequestPromptCacheOptionsTtl? ttl)
        {
            this.Mode = mode;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestPromptCacheOptions" /> class.
        /// </summary>
        public ResponsesRequestPromptCacheOptions()
        {
        }

    }
}