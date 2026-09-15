
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolsSearchResult
    {
        /// <summary>
        /// Authority level of the source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authority")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Authority { get; set; }

        /// <summary>
        /// Date of the search result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Date { get; set; }

        /// <summary>
        /// Site icon URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Icon { get; set; }

        /// <summary>
        /// MIME type of the content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Mime { get; set; }

        /// <summary>
        /// Site name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("site_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SiteName { get; set; }

        /// <summary>
        /// Snippet of the search result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snippet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Snippet { get; set; }

        /// <summary>
        /// Full page content; returned when include_content=true, otherwise an empty string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Title of the search result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// URL of the search result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsSearchResult" /> class.
        /// </summary>
        /// <param name="authority">
        /// Authority level of the source.
        /// </param>
        /// <param name="date">
        /// Date of the search result.
        /// </param>
        /// <param name="icon">
        /// Site icon URL.
        /// </param>
        /// <param name="mime">
        /// MIME type of the content.
        /// </param>
        /// <param name="siteName">
        /// Site name.
        /// </param>
        /// <param name="snippet">
        /// Snippet of the search result.
        /// </param>
        /// <param name="text">
        /// Full page content; returned when include_content=true, otherwise an empty string.
        /// </param>
        /// <param name="title">
        /// Title of the search result.
        /// </param>
        /// <param name="url">
        /// URL of the search result.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsSearchResult(
            string authority,
            string date,
            string icon,
            string mime,
            string siteName,
            string snippet,
            string text,
            string title,
            string url)
        {
            this.Authority = authority ?? throw new global::System.ArgumentNullException(nameof(authority));
            this.Date = date ?? throw new global::System.ArgumentNullException(nameof(date));
            this.Icon = icon ?? throw new global::System.ArgumentNullException(nameof(icon));
            this.Mime = mime ?? throw new global::System.ArgumentNullException(nameof(mime));
            this.SiteName = siteName ?? throw new global::System.ArgumentNullException(nameof(siteName));
            this.Snippet = snippet ?? throw new global::System.ArgumentNullException(nameof(snippet));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsSearchResult" /> class.
        /// </summary>
        public ToolsSearchResult()
        {
        }

    }
}