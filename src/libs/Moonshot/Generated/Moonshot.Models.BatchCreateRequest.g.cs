
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchCreateRequest
    {
        /// <summary>
        /// ID of the input file, must be a .jsonl file uploaded with purpose="batch"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputFileId { get; set; }

        /// <summary>
        /// Request endpoint, currently only /v1/chat/completions is supported
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.BatchCreateRequestEndpointJsonConverter))]
        public global::Moonshot.BatchCreateRequestEndpoint Endpoint { get; set; }

        /// <summary>
        /// Time window for task processing, supports formats like 12h, 1d, 3d, minimum 12h, maximum 7d
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_window")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CompletionWindow { get; set; }

        /// <summary>
        /// Custom metadata, up to 16 key-value pairs, key max 64 chars, value max 512 chars
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchCreateRequest" /> class.
        /// </summary>
        /// <param name="inputFileId">
        /// ID of the input file, must be a .jsonl file uploaded with purpose="batch"
        /// </param>
        /// <param name="completionWindow">
        /// Time window for task processing, supports formats like 12h, 1d, 3d, minimum 12h, maximum 7d
        /// </param>
        /// <param name="endpoint">
        /// Request endpoint, currently only /v1/chat/completions is supported
        /// </param>
        /// <param name="metadata">
        /// Custom metadata, up to 16 key-value pairs, key max 64 chars, value max 512 chars
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchCreateRequest(
            string inputFileId,
            string completionWindow,
            global::Moonshot.BatchCreateRequestEndpoint endpoint,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.InputFileId = inputFileId ?? throw new global::System.ArgumentNullException(nameof(inputFileId));
            this.Endpoint = endpoint;
            this.CompletionWindow = completionWindow ?? throw new global::System.ArgumentNullException(nameof(completionWindow));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchCreateRequest" /> class.
        /// </summary>
        public BatchCreateRequest()
        {
        }
    }
}