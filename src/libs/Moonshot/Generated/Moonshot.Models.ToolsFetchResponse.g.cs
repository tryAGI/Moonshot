
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolsFetchResponse
    {
        /// <summary>
        /// The fetched URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Fetched content in Markdown. Text and images are concatenated in page order, with images rendered as `![imageN](url)` placeholders.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Markdown { get; set; }

        /// <summary>
        /// Page title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsFetchResponse" /> class.
        /// </summary>
        /// <param name="url">
        /// The fetched URL.
        /// </param>
        /// <param name="markdown">
        /// Fetched content in Markdown. Text and images are concatenated in page order, with images rendered as `![imageN](url)` placeholders.
        /// </param>
        /// <param name="title">
        /// Page title.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsFetchResponse(
            string url,
            string markdown,
            string title)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Markdown = markdown ?? throw new global::System.ArgumentNullException(nameof(markdown));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsFetchResponse" /> class.
        /// </summary>
        public ToolsFetchResponse()
        {
        }

    }
}