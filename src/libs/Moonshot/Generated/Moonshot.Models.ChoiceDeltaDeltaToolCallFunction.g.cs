
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChoiceDeltaDeltaToolCallFunction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// JSON string of function arguments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public string? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChoiceDeltaDeltaToolCallFunction" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="arguments">
        /// JSON string of function arguments
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChoiceDeltaDeltaToolCallFunction(
            string? name,
            string? arguments)
        {
            this.Name = name;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChoiceDeltaDeltaToolCallFunction" /> class.
        /// </summary>
        public ChoiceDeltaDeltaToolCallFunction()
        {
        }

    }
}