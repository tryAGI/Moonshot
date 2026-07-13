
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Incremental content object
    /// </summary>
    public sealed partial class ChoiceDeltaDelta
    {
        /// <summary>
        /// Message role (only present in the first chunk)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Message content fragment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Tool calls initiated by the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::Moonshot.ChoiceDeltaDeltaToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChoiceDeltaDelta" /> class.
        /// </summary>
        /// <param name="role">
        /// Message role (only present in the first chunk)
        /// </param>
        /// <param name="content">
        /// Message content fragment
        /// </param>
        /// <param name="toolCalls">
        /// Tool calls initiated by the model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChoiceDeltaDelta(
            string? role,
            string? content,
            global::System.Collections.Generic.IList<global::Moonshot.ChoiceDeltaDeltaToolCall>? toolCalls)
        {
            this.Role = role;
            this.Content = content;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChoiceDeltaDelta" /> class.
        /// </summary>
        public ChoiceDeltaDelta()
        {
        }

    }
}