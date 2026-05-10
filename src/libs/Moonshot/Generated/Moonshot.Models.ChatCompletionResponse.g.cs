
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionResponse
    {
        /// <summary>
        /// Unique identifier for the completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Object type<br/>
        /// Example: chat.completion
        /// </summary>
        /// <example>chat.completion</example>
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
        public global::System.Collections.Generic.IList<global::Moonshot.ChatCompletionResponseChoice>? Choices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Moonshot.ChatCompletionResponseUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the completion
        /// </param>
        /// <param name="object">
        /// Object type<br/>
        /// Example: chat.completion
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
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionResponse(
            string? id,
            string? @object,
            global::System.DateTimeOffset? created,
            string? model,
            global::System.Collections.Generic.IList<global::Moonshot.ChatCompletionResponseChoice>? choices,
            global::Moonshot.ChatCompletionResponseUsage? usage)
        {
            this.Id = id;
            this.Object = @object;
            this.Created = created;
            this.Model = model;
            this.Choices = choices;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponse" /> class.
        /// </summary>
        public ChatCompletionResponse()
        {
        }

    }
}