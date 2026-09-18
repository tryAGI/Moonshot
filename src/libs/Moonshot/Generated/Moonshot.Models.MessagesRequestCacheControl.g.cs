
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Context cache write options. Only effective when passed at the top level; cache_control markers inside the messages array are ignored. When omitted, the request only attempts to read the cache (5m tier) and does not write
    /// </summary>
    public sealed partial class MessagesRequestCacheControl
    {
        /// <summary>
        /// Cache type, fixed as ephemeral
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.MessagesRequestCacheControlTypeJsonConverter))]
        public global::Moonshot.MessagesRequestCacheControlType Type { get; set; }

        /// <summary>
        /// Lifetime of the written cache. The 5m and 1h tiers are independent of each other. When a request with the same prefix hits the cache within its lifetime, the cache entry is refreshed with its original TTL<br/>
        /// Default Value: 5m
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.MessagesRequestCacheControlTtlJsonConverter))]
        public global::Moonshot.MessagesRequestCacheControlTtl? Ttl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestCacheControl" /> class.
        /// </summary>
        /// <param name="type">
        /// Cache type, fixed as ephemeral
        /// </param>
        /// <param name="ttl">
        /// Lifetime of the written cache. The 5m and 1h tiers are independent of each other. When a request with the same prefix hits the cache within its lifetime, the cache entry is refreshed with its original TTL<br/>
        /// Default Value: 5m
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestCacheControl(
            global::Moonshot.MessagesRequestCacheControlType type,
            global::Moonshot.MessagesRequestCacheControlTtl? ttl)
        {
            this.Type = type;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestCacheControl" /> class.
        /// </summary>
        public MessagesRequestCacheControl()
        {
        }

    }
}