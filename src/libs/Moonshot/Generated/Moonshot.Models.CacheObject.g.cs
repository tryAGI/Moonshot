
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CacheObject
    {
        /// <summary>
        /// Cache ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Object type<br/>
        /// Example: cache
        /// </summary>
        /// <example>cache</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Model ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Cache status: pending (being created), active (ready), expired (expired)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.CacheObjectStatusJsonConverter))]
        public global::Moonshot.CacheObjectStatus? Status { get; set; }

        /// <summary>
        /// Creation timestamp (Unix)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// Expiration timestamp (Unix)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public int? ExpiresAt { get; set; }

        /// <summary>
        /// Cache TTL in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        public int? Ttl { get; set; }

        /// <summary>
        /// Business identifier for the cache
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheObject" /> class.
        /// </summary>
        /// <param name="id">
        /// Cache ID
        /// </param>
        /// <param name="object">
        /// Object type<br/>
        /// Example: cache
        /// </param>
        /// <param name="model">
        /// Model ID
        /// </param>
        /// <param name="status">
        /// Cache status: pending (being created), active (ready), expired (expired)
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp (Unix)
        /// </param>
        /// <param name="expiresAt">
        /// Expiration timestamp (Unix)
        /// </param>
        /// <param name="ttl">
        /// Cache TTL in seconds
        /// </param>
        /// <param name="name">
        /// Business identifier for the cache
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CacheObject(
            string? id,
            string? @object,
            string? model,
            global::Moonshot.CacheObjectStatus? status,
            int? createdAt,
            int? expiresAt,
            int? ttl,
            string? name)
        {
            this.Id = id;
            this.Object = @object;
            this.Model = model;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
            this.Ttl = ttl;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheObject" /> class.
        /// </summary>
        public CacheObject()
        {
        }

    }
}