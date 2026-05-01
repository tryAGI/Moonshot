
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Custom metadata, up to 16 key-value pairs, key max 64 chars, value max 512 chars
    /// </summary>
    public sealed partial class BatchCreateRequestMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}