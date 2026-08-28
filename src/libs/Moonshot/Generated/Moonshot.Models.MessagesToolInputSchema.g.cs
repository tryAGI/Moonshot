
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// JSON Schema for the tool input; the top-level `type` must be `object`. Must conform to the [MFJS (Moonshot Flavored JSON Schema) specification](https://github.com/MoonshotAI/walle/blob/main/docs/mfjs-spec.md).
    /// </summary>
    public sealed partial class MessagesToolInputSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}