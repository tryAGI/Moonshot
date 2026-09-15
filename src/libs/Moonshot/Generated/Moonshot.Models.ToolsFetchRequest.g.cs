
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolsFetchRequest
    {
        /// <summary>
        /// URL of the page to fetch. Only http and https are supported.
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
        /// Initializes a new instance of the <see cref="ToolsFetchRequest" /> class.
        /// </summary>
        /// <param name="url">
        /// URL of the page to fetch. Only http and https are supported.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsFetchRequest(
            string url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsFetchRequest" /> class.
        /// </summary>
        public ToolsFetchRequest()
        {
        }

    }
}