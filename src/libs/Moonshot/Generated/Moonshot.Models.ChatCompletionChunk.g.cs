
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionChunk
    {
        /// <summary>
        /// Unique identifier for the completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Object type<br/>
        /// Example: chat.completion.chunk
        /// </summary>
        /// <example>chat.completion.chunk</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Unix timestamp of when the completion was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? Created { get; set; }

        /// <summary>
        /// Model used for the completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// List of completion choices
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        public global::System.Collections.Generic.IList<global::Moonshot.ChoiceDelta>? Choices { get; set; }

        /// <summary>
        /// Token usage statistics. Object in the final chunk with usage, null in ordinary chunks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Moonshot.ChatCompletionChunkUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChunk" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the completion
        /// </param>
        /// <param name="object">
        /// Object type<br/>
        /// Example: chat.completion.chunk
        /// </param>
        /// <param name="created">
        /// Unix timestamp of when the completion was created
        /// </param>
        /// <param name="model">
        /// Model used for the completion
        /// </param>
        /// <param name="choices">
        /// List of completion choices
        /// </param>
        /// <param name="usage">
        /// Token usage statistics. Object in the final chunk with usage, null in ordinary chunks
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionChunk(
            string? id,
            string? @object,
            global::System.DateTimeOffset? created,
            string? model,
            global::System.Collections.Generic.IList<global::Moonshot.ChoiceDelta>? choices,
            global::Moonshot.ChatCompletionChunkUsage? usage)
        {
            this.Id = id;
            this.Object = @object;
            this.Created = created;
            this.Model = model;
            this.Choices = choices;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChunk" /> class.
        /// </summary>
        public ChatCompletionChunk()
        {
        }

    }
}