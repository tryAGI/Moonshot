
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// A Kimi K3 dynamic tool loading message. This message must use the system role, declares tools available to subsequent conversation turns from its position, and does not include a content field.
    /// </summary>
    public sealed partial class KimiK3DynamicToolMessage
    {
        /// <summary>
        /// The role of a dynamic tool loading message. Always system.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.KimiK3DynamicToolMessageRoleJsonConverter))]
        public global::Moonshot.KimiK3DynamicToolMessageRole Role { get; set; }

        /// <summary>
        /// Tools available for the model to call from this message onward
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Moonshot.ToolDefinition> Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KimiK3DynamicToolMessage" /> class.
        /// </summary>
        /// <param name="tools">
        /// Tools available for the model to call from this message onward
        /// </param>
        /// <param name="role">
        /// The role of a dynamic tool loading message. Always system.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KimiK3DynamicToolMessage(
            global::System.Collections.Generic.IList<global::Moonshot.ToolDefinition> tools,
            global::Moonshot.KimiK3DynamicToolMessageRole role)
        {
            this.Role = role;
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KimiK3DynamicToolMessage" /> class.
        /// </summary>
        public KimiK3DynamicToolMessage()
        {
        }

    }
}