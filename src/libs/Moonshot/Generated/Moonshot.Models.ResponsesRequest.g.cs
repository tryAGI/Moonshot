
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResponsesRequest
    {
        /// <summary>
        /// ID of the model to use. This endpoint currently supports `kimi-k3`.<br/>
        /// Example: kimi-k3
        /// </summary>
        /// <example>kimi-k3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Input for this request. A string is equivalent to a single user message. An array holds ordered typed items and may contain conversation history, tool calls, and tool results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Moonshot.ResponsesInputItem>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.ResponsesInputItem>> Input { get; set; }

        /// <summary>
        /// Top-level system instructions, applied ahead of every input item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// When true, the response is delivered as a stream of SSE events.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Maximum number of tokens to generate for this response. For `kimi-k3` it defaults to 131072 and can be set up to 1048576. This refers to the length of tokens you expect us to return, not the total length of input plus output. When the limit is reached, `status` is `incomplete` and `incomplete_details.reason` is `max_output_tokens`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// Reasoning configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::Moonshot.ResponsesRequestReasoning? Reasoning { get; set; }

        /// <summary>
        /// Output text configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::Moonshot.ResponsesRequestText? Text { get; set; }

        /// <summary>
        /// List of tools the model may call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesTool>? Tools { get; set; }

        /// <summary>
        /// Controls tool-calling behavior. With `auto`, the model decides whether to call a tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesToolChoiceJsonConverter))]
        public global::Moonshot.ResponsesToolChoice? ToolChoice { get; set; }

        /// <summary>
        /// Additional fields to return. Only effective when the `web_search` tool is used. `web_search_call.action.sources` returns the web pages the search hit; `web_search_call.results` returns image search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesRequestIncludeItem>? Include { get; set; }

        /// <summary>
        /// Context cache identifier. Reusing the same value across a session improves cache hit rate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_key")]
        public string? PromptCacheKey { get; set; }

        /// <summary>
        /// A stable identifier used to help detect users of your application that may be violating usage policies. The ID should be a string that uniquely identifies each user. It is recommended to hash the username or email address to avoid sending any identifying information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_identifier")]
        public string? SafetyIdentifier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// ID of the model to use. This endpoint currently supports `kimi-k3`.<br/>
        /// Example: kimi-k3
        /// </param>
        /// <param name="input">
        /// Input for this request. A string is equivalent to a single user message. An array holds ordered typed items and may contain conversation history, tool calls, and tool results.
        /// </param>
        /// <param name="instructions">
        /// Top-level system instructions, applied ahead of every input item.
        /// </param>
        /// <param name="stream">
        /// When true, the response is delivered as a stream of SSE events.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="maxOutputTokens">
        /// Maximum number of tokens to generate for this response. For `kimi-k3` it defaults to 131072 and can be set up to 1048576. This refers to the length of tokens you expect us to return, not the total length of input plus output. When the limit is reached, `status` is `incomplete` and `incomplete_details.reason` is `max_output_tokens`.
        /// </param>
        /// <param name="reasoning">
        /// Reasoning configuration.
        /// </param>
        /// <param name="text">
        /// Output text configuration.
        /// </param>
        /// <param name="tools">
        /// List of tools the model may call.
        /// </param>
        /// <param name="toolChoice">
        /// Controls tool-calling behavior. With `auto`, the model decides whether to call a tool.
        /// </param>
        /// <param name="include">
        /// Additional fields to return. Only effective when the `web_search` tool is used. `web_search_call.action.sources` returns the web pages the search hit; `web_search_call.results` returns image search results.
        /// </param>
        /// <param name="promptCacheKey">
        /// Context cache identifier. Reusing the same value across a session improves cache hit rate.
        /// </param>
        /// <param name="safetyIdentifier">
        /// A stable identifier used to help detect users of your application that may be violating usage policies. The ID should be a string that uniquely identifies each user. It is recommended to hash the username or email address to avoid sending any identifying information
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesRequest(
            string model,
            global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.ResponsesInputItem>> input,
            string? instructions,
            bool? stream,
            int? maxOutputTokens,
            global::Moonshot.ResponsesRequestReasoning? reasoning,
            global::Moonshot.ResponsesRequestText? text,
            global::System.Collections.Generic.IList<global::Moonshot.ResponsesTool>? tools,
            global::Moonshot.ResponsesToolChoice? toolChoice,
            global::System.Collections.Generic.IList<global::Moonshot.ResponsesRequestIncludeItem>? include,
            string? promptCacheKey,
            string? safetyIdentifier)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Input = input;
            this.Instructions = instructions;
            this.Stream = stream;
            this.MaxOutputTokens = maxOutputTokens;
            this.Reasoning = reasoning;
            this.Text = text;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.Include = include;
            this.PromptCacheKey = promptCacheKey;
            this.SafetyIdentifier = safetyIdentifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequest" /> class.
        /// </summary>
        public ResponsesRequest()
        {
        }

    }
}