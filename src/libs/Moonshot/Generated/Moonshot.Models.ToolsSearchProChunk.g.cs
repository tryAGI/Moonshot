
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolsSearchProChunk
    {
        /// <summary>
        /// Content of the chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Relevance score of the chunk to the query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsSearchProChunk" /> class.
        /// </summary>
        /// <param name="text">
        /// Content of the chunk.
        /// </param>
        /// <param name="score">
        /// Relevance score of the chunk to the query.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsSearchProChunk(
            string text,
            float score)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsSearchProChunk" /> class.
        /// </summary>
        public ToolsSearchProChunk()
        {
        }

    }
}