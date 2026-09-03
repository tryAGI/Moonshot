
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// A single model response.
    /// </summary>
    public sealed partial class ResponsesResponse
    {
        /// <summary>
        /// Unique identifier of the response.<br/>
        /// Example: resp_68f0c1c2d3e4f5a6b7c8d9e0
        /// </summary>
        /// <example>resp_68f0c1c2d3e4f5a6b7c8d9e0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesResponseObjectJsonConverter))]
        public global::Moonshot.ResponsesResponseObject? Object { get; set; }

        /// <summary>
        /// Unix timestamp of when the response was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Unix timestamp of when the response finished. Present when `status` is `completed` or `incomplete`; `null` when `status` is `in_progress` or `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? CompletedAt { get; set; }

        /// <summary>
        /// Response status. The opening snapshot of a stream is `in_progress`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesResponseStatusJsonConverter))]
        public global::Moonshot.ResponsesResponseStatus? Status { get; set; }

        /// <summary>
        /// Model that produced the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The output item array, ordered as web_search_call (if any), reasoning, message, tool calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesOutputItem>? Output { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Moonshot.ResponsesUsage? Usage { get; set; }

        /// <summary>
        /// Reason the response is `incomplete`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("incomplete_details")]
        public global::Moonshot.ResponsesResponseIncompleteDetails? IncompleteDetails { get; set; }

        /// <summary>
        /// Error information when `status` is `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Moonshot.ResponsesResponseError? Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public object? Reasoning { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public object? Text { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesTool>? Tools { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        public global::Moonshot.ResponsesToolChoice? ToolChoice { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        public string? ServiceTier { get; set; }

        /// <summary>
        /// Always `false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store")]
        public bool? Store { get; set; }

        /// <summary>
        /// Always `false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public bool? Background { get; set; }

        /// <summary>
        /// Always `null`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_response_id")]
        public string? PreviousResponseId { get; set; }

        /// <summary>
        /// Always `null`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        public object? Conversation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the response.<br/>
        /// Example: resp_68f0c1c2d3e4f5a6b7c8d9e0
        /// </param>
        /// <param name="object"></param>
        /// <param name="createdAt">
        /// Unix timestamp of when the response was created.
        /// </param>
        /// <param name="completedAt">
        /// Unix timestamp of when the response finished. Present when `status` is `completed` or `incomplete`; `null` when `status` is `in_progress` or `failed`.
        /// </param>
        /// <param name="status">
        /// Response status. The opening snapshot of a stream is `in_progress`.
        /// </param>
        /// <param name="model">
        /// Model that produced the response.
        /// </param>
        /// <param name="output">
        /// The output item array, ordered as web_search_call (if any), reasoning, message, tool calls.
        /// </param>
        /// <param name="usage"></param>
        /// <param name="incompleteDetails">
        /// Reason the response is `incomplete`.
        /// </param>
        /// <param name="error">
        /// Error information when `status` is `failed`.
        /// </param>
        /// <param name="instructions"></param>
        /// <param name="reasoning"></param>
        /// <param name="text"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="maxOutputTokens"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="metadata"></param>
        /// <param name="parallelToolCalls"></param>
        /// <param name="serviceTier"></param>
        /// <param name="store">
        /// Always `false`.
        /// </param>
        /// <param name="background">
        /// Always `false`.
        /// </param>
        /// <param name="previousResponseId">
        /// Always `null`.
        /// </param>
        /// <param name="conversation">
        /// Always `null`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesResponse(
            string? id,
            global::Moonshot.ResponsesResponseObject? @object,
            global::System.DateTimeOffset? createdAt,
            global::System.DateTimeOffset? completedAt,
            global::Moonshot.ResponsesResponseStatus? status,
            string? model,
            global::System.Collections.Generic.IList<global::Moonshot.ResponsesOutputItem>? output,
            global::Moonshot.ResponsesUsage? usage,
            global::Moonshot.ResponsesResponseIncompleteDetails? incompleteDetails,
            global::Moonshot.ResponsesResponseError? error,
            string? instructions,
            object? reasoning,
            object? text,
            global::System.Collections.Generic.IList<global::Moonshot.ResponsesTool>? tools,
            global::Moonshot.ResponsesToolChoice? toolChoice,
            int? maxOutputTokens,
            double? temperature,
            double? topP,
            object? metadata,
            bool? parallelToolCalls,
            string? serviceTier,
            bool? store,
            bool? background,
            string? previousResponseId,
            object? conversation)
        {
            this.Id = id;
            this.Object = @object;
            this.CreatedAt = createdAt;
            this.CompletedAt = completedAt;
            this.Status = status;
            this.Model = model;
            this.Output = output;
            this.Usage = usage;
            this.IncompleteDetails = incompleteDetails;
            this.Error = error;
            this.Instructions = instructions;
            this.Reasoning = reasoning;
            this.Text = text;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.MaxOutputTokens = maxOutputTokens;
            this.Temperature = temperature;
            this.TopP = topP;
            this.Metadata = metadata;
            this.ParallelToolCalls = parallelToolCalls;
            this.ServiceTier = serviceTier;
            this.Store = store;
            this.Background = background;
            this.PreviousResponseId = previousResponseId;
            this.Conversation = conversation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesResponse" /> class.
        /// </summary>
        public ResponsesResponse()
        {
        }

    }
}