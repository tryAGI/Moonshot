
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChoiceDeltaDeltaToolCall
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ChoiceDeltaDeltaToolCallTypeJsonConverter))]
        public global::Moonshot.ChoiceDeltaDeltaToolCallType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        public global::Moonshot.ChoiceDeltaDeltaToolCallFunction? Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChoiceDeltaDeltaToolCall" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="function"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChoiceDeltaDeltaToolCall(
            string? id,
            global::Moonshot.ChoiceDeltaDeltaToolCallType? type,
            global::Moonshot.ChoiceDeltaDeltaToolCallFunction? function)
        {
            this.Id = id;
            this.Type = type;
            this.Function = function;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChoiceDeltaDeltaToolCall" /> class.
        /// </summary>
        public ChoiceDeltaDeltaToolCall()
        {
        }

    }
}