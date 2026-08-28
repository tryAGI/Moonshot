
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Output configuration: reasoning effort and structured output
    /// </summary>
    public sealed partial class MessagesRequestOutputConfig
    {
        /// <summary>
        /// Reasoning effort: low, high, or max; default max. Changing the level breaks prefix-cache hits, so decide it before the session starts.<br/>
        /// Default Value: max
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.MessagesRequestOutputConfigEffortJsonConverter))]
        public global::Moonshot.MessagesRequestOutputConfigEffort? Effort { get; set; }

        /// <summary>
        /// Structured output. When set, the model outputs JSON that strictly follows the given JSON Schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public global::Moonshot.MessagesRequestOutputConfigFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestOutputConfig" /> class.
        /// </summary>
        /// <param name="effort">
        /// Reasoning effort: low, high, or max; default max. Changing the level breaks prefix-cache hits, so decide it before the session starts.<br/>
        /// Default Value: max
        /// </param>
        /// <param name="format">
        /// Structured output. When set, the model outputs JSON that strictly follows the given JSON Schema.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestOutputConfig(
            global::Moonshot.MessagesRequestOutputConfigEffort? effort,
            global::Moonshot.MessagesRequestOutputConfigFormat? format)
        {
            this.Effort = effort;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestOutputConfig" /> class.
        /// </summary>
        public MessagesRequestOutputConfig()
        {
        }

    }
}