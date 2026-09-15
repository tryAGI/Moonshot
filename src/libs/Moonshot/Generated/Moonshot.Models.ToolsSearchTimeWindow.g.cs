
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Time-window constraint on result dates. start and end are each normalized to the first day of their period before comparison; start must not be later than end.
    /// </summary>
    public sealed partial class ToolsSearchTimeWindow
    {
        /// <summary>
        /// Lower bound of the time window, in YYYY / YYYY-MM / YYYY-MM-DD format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public string? Start { get; set; }

        /// <summary>
        /// Upper bound of the time window, in YYYY / YYYY-MM / YYYY-MM-DD format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public string? End { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsSearchTimeWindow" /> class.
        /// </summary>
        /// <param name="start">
        /// Lower bound of the time window, in YYYY / YYYY-MM / YYYY-MM-DD format.
        /// </param>
        /// <param name="end">
        /// Upper bound of the time window, in YYYY / YYYY-MM / YYYY-MM-DD format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsSearchTimeWindow(
            string? start,
            string? end)
        {
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsSearchTimeWindow" /> class.
        /// </summary>
        public ToolsSearchTimeWindow()
        {
        }

    }
}