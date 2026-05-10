
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchObject
    {
        /// <summary>
        /// Unique identifier for the batch task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Object type, always batch<br/>
        /// Example: batch
        /// </summary>
        /// <example>batch</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Object { get; set; }

        /// <summary>
        /// Request endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Endpoint { get; set; }

        /// <summary>
        /// Input file ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputFileId { get; set; }

        /// <summary>
        /// Processing time window
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_window")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CompletionWindow { get; set; }

        /// <summary>
        /// Current status: validating, failed, in_progress, finalizing, completed, expired, cancelling, cancelled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.BatchObjectStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.BatchObjectStatus Status { get; set; }

        /// <summary>
        /// Output file ID for successful results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_file_id")]
        public string? OutputFileId { get; set; }

        /// <summary>
        /// Error file ID for failed results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_file_id")]
        public string? ErrorFileId { get; set; }

        /// <summary>
        /// Creation timestamp (Unix)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// Execution start timestamp (Unix)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_progress_at")]
        public int? InProgressAt { get; set; }

        /// <summary>
        /// Expiration timestamp (Unix)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public int? ExpiresAt { get; set; }

        /// <summary>
        /// Result preparation start timestamp (Unix)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finalizing_at")]
        public int? FinalizingAt { get; set; }

        /// <summary>
        /// Completion timestamp (Unix)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public int? CompletedAt { get; set; }

        /// <summary>
        /// Validation failure timestamp (Unix)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_at")]
        public int? FailedAt { get; set; }

        /// <summary>
        /// Cancellation request timestamp (Unix)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelling_at")]
        public int? CancellingAt { get; set; }

        /// <summary>
        /// Cancellation completion timestamp (Unix)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelled_at")]
        public int? CancelledAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_counts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.BatchRequestCounts RequestCounts { get; set; }

        /// <summary>
        /// Custom metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObject" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the batch task
        /// </param>
        /// <param name="object">
        /// Object type, always batch<br/>
        /// Example: batch
        /// </param>
        /// <param name="endpoint">
        /// Request endpoint
        /// </param>
        /// <param name="inputFileId">
        /// Input file ID
        /// </param>
        /// <param name="completionWindow">
        /// Processing time window
        /// </param>
        /// <param name="status">
        /// Current status: validating, failed, in_progress, finalizing, completed, expired, cancelling, cancelled
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp (Unix)
        /// </param>
        /// <param name="requestCounts"></param>
        /// <param name="outputFileId">
        /// Output file ID for successful results
        /// </param>
        /// <param name="errorFileId">
        /// Error file ID for failed results
        /// </param>
        /// <param name="inProgressAt">
        /// Execution start timestamp (Unix)
        /// </param>
        /// <param name="expiresAt">
        /// Expiration timestamp (Unix)
        /// </param>
        /// <param name="finalizingAt">
        /// Result preparation start timestamp (Unix)
        /// </param>
        /// <param name="completedAt">
        /// Completion timestamp (Unix)
        /// </param>
        /// <param name="failedAt">
        /// Validation failure timestamp (Unix)
        /// </param>
        /// <param name="cancellingAt">
        /// Cancellation request timestamp (Unix)
        /// </param>
        /// <param name="cancelledAt">
        /// Cancellation completion timestamp (Unix)
        /// </param>
        /// <param name="metadata">
        /// Custom metadata
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchObject(
            string id,
            string @object,
            string endpoint,
            string inputFileId,
            string completionWindow,
            global::Moonshot.BatchObjectStatus status,
            int createdAt,
            global::Moonshot.BatchRequestCounts requestCounts,
            string? outputFileId,
            string? errorFileId,
            int? inProgressAt,
            int? expiresAt,
            int? finalizingAt,
            int? completedAt,
            int? failedAt,
            int? cancellingAt,
            int? cancelledAt,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.InputFileId = inputFileId ?? throw new global::System.ArgumentNullException(nameof(inputFileId));
            this.CompletionWindow = completionWindow ?? throw new global::System.ArgumentNullException(nameof(completionWindow));
            this.Status = status;
            this.OutputFileId = outputFileId;
            this.ErrorFileId = errorFileId;
            this.CreatedAt = createdAt;
            this.InProgressAt = inProgressAt;
            this.ExpiresAt = expiresAt;
            this.FinalizingAt = finalizingAt;
            this.CompletedAt = completedAt;
            this.FailedAt = failedAt;
            this.CancellingAt = cancellingAt;
            this.CancelledAt = cancelledAt;
            this.RequestCounts = requestCounts ?? throw new global::System.ArgumentNullException(nameof(requestCounts));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObject" /> class.
        /// </summary>
        public BatchObject()
        {
        }

    }
}