
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatRequestBase
    {
        /// <summary>
        /// A list of messages in the conversation so far. Each element has the format {"role": "user", "content": "Hello"}. role supports system, user, or assistant. content must not be empty. The content field can be a string or an array[object] (for multimodal input).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Moonshot.Message> Messages { get; set; }

        /// <summary>
        /// Deprecated, please refer to max_completion_tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// The maximum number of tokens to generate for the chat completion. If not specified, defaults to a reasonable integer such as 1024. If the result reaches the maximum number of tokens without ending, the finish reason will be "length"; otherwise, it will be "stop". This refers to the length of tokens you expect us to return, not the total length of input plus output. If input plus max_completion_tokens exceeds the model context window, the API returns invalid_request_error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        /// Controls the model output format. Default is {"type": "text"} for plain text output. Set to {"type": "json_object"} to enable JSON mode, ensuring output is a valid JSON object (you must guide the model to output JSON in the prompt). Set to {"type": "json_schema"} to enable Structured Output, constraining output to match a specified JSON Schema (recommended, requires the json_schema field). If you encounter schema validation issues, please submit feedback at walle GitHub Issues (https://github.com/MoonshotAI/walle/issues).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::Moonshot.ChatRequestBaseResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// Stop words, which will halt the output when a full match is found. The matched words themselves will not be output. A maximum of 5 strings is allowed, and each string must not exceed 32 bytes<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<string>>? Stop { get; set; }

        /// <summary>
        /// Whether to return the response in a streaming fashion. Default is false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Options for streaming responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_options")]
        public global::Moonshot.ChatRequestBaseStreamOptions? StreamOptions { get; set; }

        /// <summary>
        /// A list of tools the model may call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Moonshot.ToolDefinition>? Tools { get; set; }

        /// <summary>
        /// Used to cache responses for similar requests to optimize cache hit rates. For Coding Agents, this is typically a session id or task id representing a single session; if the session is exited and later resumed, this value should remain the same. For Kimi Code Plan, this field is required to improve cache hit rates. For other agents involving multi-turn conversations, it is also recommended to implement this field<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
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
        /// Initializes a new instance of the <see cref="ChatRequestBase" /> class.
        /// </summary>
        /// <param name="messages">
        /// A list of messages in the conversation so far. Each element has the format {"role": "user", "content": "Hello"}. role supports system, user, or assistant. content must not be empty. The content field can be a string or an array[object] (for multimodal input).
        /// </param>
        /// <param name="maxCompletionTokens">
        /// The maximum number of tokens to generate for the chat completion. If not specified, defaults to a reasonable integer such as 1024. If the result reaches the maximum number of tokens without ending, the finish reason will be "length"; otherwise, it will be "stop". This refers to the length of tokens you expect us to return, not the total length of input plus output. If input plus max_completion_tokens exceeds the model context window, the API returns invalid_request_error.
        /// </param>
        /// <param name="responseFormat">
        /// Controls the model output format. Default is {"type": "text"} for plain text output. Set to {"type": "json_object"} to enable JSON mode, ensuring output is a valid JSON object (you must guide the model to output JSON in the prompt). Set to {"type": "json_schema"} to enable Structured Output, constraining output to match a specified JSON Schema (recommended, requires the json_schema field). If you encounter schema validation issues, please submit feedback at walle GitHub Issues (https://github.com/MoonshotAI/walle/issues).
        /// </param>
        /// <param name="stop">
        /// Stop words, which will halt the output when a full match is found. The matched words themselves will not be output. A maximum of 5 strings is allowed, and each string must not exceed 32 bytes<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="stream">
        /// Whether to return the response in a streaming fashion. Default is false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="streamOptions">
        /// Options for streaming responses
        /// </param>
        /// <param name="tools">
        /// A list of tools the model may call
        /// </param>
        /// <param name="promptCacheKey">
        /// Used to cache responses for similar requests to optimize cache hit rates. For Coding Agents, this is typically a session id or task id representing a single session; if the session is exited and later resumed, this value should remain the same. For Kimi Code Plan, this field is required to improve cache hit rates. For other agents involving multi-turn conversations, it is also recommended to implement this field<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="safetyIdentifier">
        /// A stable identifier used to help detect users of your application that may be violating usage policies. The ID should be a string that uniquely identifies each user. It is recommended to hash the username or email address to avoid sending any identifying information
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRequestBase(
            global::System.Collections.Generic.IList<global::Moonshot.Message> messages,
            int? maxCompletionTokens,
            global::Moonshot.ChatRequestBaseResponseFormat? responseFormat,
            global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<string>>? stop,
            bool? stream,
            global::Moonshot.ChatRequestBaseStreamOptions? streamOptions,
            global::System.Collections.Generic.IList<global::Moonshot.ToolDefinition>? tools,
            string? promptCacheKey,
            string? safetyIdentifier)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.MaxCompletionTokens = maxCompletionTokens;
            this.ResponseFormat = responseFormat;
            this.Stop = stop;
            this.Stream = stream;
            this.StreamOptions = streamOptions;
            this.Tools = tools;
            this.PromptCacheKey = promptCacheKey;
            this.SafetyIdentifier = safetyIdentifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestBase" /> class.
        /// </summary>
        public ChatRequestBase()
        {
        }
    }
}