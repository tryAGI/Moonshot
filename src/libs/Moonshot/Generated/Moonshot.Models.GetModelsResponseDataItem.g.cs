
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetModelsResponseDataItem
    {
        /// <summary>
        /// Model ID<br/>
        /// Example: kimi-k2.5
        /// </summary>
        /// <example>kimi-k2.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Example: model
        /// </summary>
        /// <example>model</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Creation timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public int? Created { get; set; }

        /// <summary>
        /// Example: moonshot
        /// </summary>
        /// <example>moonshot</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("owned_by")]
        public string? OwnedBy { get; set; }

        /// <summary>
        /// Maximum context length (tokens)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_length")]
        public int? ContextLength { get; set; }

        /// <summary>
        /// Whether the model supports image input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_image_in")]
        public bool? SupportsImageIn { get; set; }

        /// <summary>
        /// Whether the model supports video input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_video_in")]
        public bool? SupportsVideoIn { get; set; }

        /// <summary>
        /// Whether the model supports deep thinking
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_reasoning")]
        public bool? SupportsReasoning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsResponseDataItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Model ID<br/>
        /// Example: kimi-k2.5
        /// </param>
        /// <param name="object">
        /// Example: model
        /// </param>
        /// <param name="created">
        /// Creation timestamp
        /// </param>
        /// <param name="ownedBy">
        /// Example: moonshot
        /// </param>
        /// <param name="contextLength">
        /// Maximum context length (tokens)
        /// </param>
        /// <param name="supportsImageIn">
        /// Whether the model supports image input
        /// </param>
        /// <param name="supportsVideoIn">
        /// Whether the model supports video input
        /// </param>
        /// <param name="supportsReasoning">
        /// Whether the model supports deep thinking
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetModelsResponseDataItem(
            string? id,
            string? @object,
            int? created,
            string? ownedBy,
            int? contextLength,
            bool? supportsImageIn,
            bool? supportsVideoIn,
            bool? supportsReasoning)
        {
            this.Id = id;
            this.Object = @object;
            this.Created = created;
            this.OwnedBy = ownedBy;
            this.ContextLength = contextLength;
            this.SupportsImageIn = supportsImageIn;
            this.SupportsVideoIn = supportsVideoIn;
            this.SupportsReasoning = supportsReasoning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsResponseDataItem" /> class.
        /// </summary>
        public GetModelsResponseDataItem()
        {
        }
    }
}