
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCachingRequest
    {
        /// <summary>
        /// Model ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// List of messages to cache
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Moonshot.Message> Messages { get; set; }

        /// <summary>
        /// List of tool definitions to cache (optional)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Moonshot.ToolDefinition>? Tools { get; set; }

        /// <summary>
        /// Business identifier for the cache (optional)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Cache TTL in seconds, optional. For example, 3600 = 1 hour
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        public int? Ttl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCachingRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Model ID
        /// </param>
        /// <param name="messages">
        /// List of messages to cache
        /// </param>
        /// <param name="tools">
        /// List of tool definitions to cache (optional)
        /// </param>
        /// <param name="name">
        /// Business identifier for the cache (optional)
        /// </param>
        /// <param name="ttl">
        /// Cache TTL in seconds, optional. For example, 3600 = 1 hour
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCachingRequest(
            string model,
            global::System.Collections.Generic.IList<global::Moonshot.Message> messages,
            global::System.Collections.Generic.IList<global::Moonshot.ToolDefinition>? tools,
            string? name,
            int? ttl)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Tools = tools;
            this.Name = name;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCachingRequest" /> class.
        /// </summary>
        public CreateCachingRequest()
        {
        }

    }
}