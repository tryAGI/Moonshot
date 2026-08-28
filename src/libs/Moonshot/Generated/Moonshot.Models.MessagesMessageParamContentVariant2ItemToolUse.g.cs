
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// A tool call issued by the model (appears in assistant messages)
    /// </summary>
    public sealed partial class MessagesMessageParamContentVariant2ItemToolUse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.MessagesMessageParamContentVariant2ItemToolUseTypeJsonConverter))]
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolUseType Type { get; set; }

        /// <summary>
        /// Tool call ID; must match `tool_use_id` when submitting the result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Tool name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Tool input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentVariant2ItemToolUse" /> class.
        /// </summary>
        /// <param name="id">
        /// Tool call ID; must match `tool_use_id` when submitting the result
        /// </param>
        /// <param name="name">
        /// Tool name
        /// </param>
        /// <param name="input">
        /// Tool input
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesMessageParamContentVariant2ItemToolUse(
            string id,
            string name,
            object input,
            global::Moonshot.MessagesMessageParamContentVariant2ItemToolUseType type)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentVariant2ItemToolUse" /> class.
        /// </summary>
        public MessagesMessageParamContentVariant2ItemToolUse()
        {
        }

    }
}