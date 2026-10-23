
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesRequest
    {
        /// <summary>
        /// ID of the model to use. This endpoint currently supports `kimi-k3.1-pro`, `kimi-k3.1-pro-highspeed`, and `kimi-k3`.<br/>
        /// Default Value: kimi-k3.1-pro
        /// </summary>
        /// <default>global::Moonshot.MessagesRequestModel.KimiK31Pro</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.MessagesRequestModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.MessagesRequestModel Model { get; set; } = global::Moonshot.MessagesRequestModel.KimiK31Pro;

        /// <summary>
        /// The conversation messages. If the last message is from the assistant, the model continues from that content (Partial Mode).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Moonshot.MessagesMessageParam> Messages { get; set; }

        /// <summary>
        /// Maximum number of tokens to generate, required. If the limit is reached before the model finishes, `stop_reason` is `max_tokens`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxTokens { get; set; }

        /// <summary>
        /// System prompt, either a string or an array of text blocks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Moonshot.MessagesTextBlockParam>>))]
        public global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.MessagesTextBlockParam>>? System { get; set; }

        /// <summary>
        /// Whether to stream the response as Server-Sent Events, default false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Stop sequences. Generation stops on an exact match; the matched sequence itself is not output. Up to 5 entries, each at most 32 bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_sequences")]
        public global::System.Collections.Generic.IList<string>? StopSequences { get; set; }

        /// <summary>
        /// List of tools the model may call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Moonshot.MessagesTool>? Tools { get; set; }

        /// <summary>
        /// Controls whether the model calls tools. `auto` (default): the model decides; `any`: force a call to any tool; `none`: do not call tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        public global::Moonshot.MessagesToolChoice? ToolChoice { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Moonshot.MessagesRequestMetadata? Metadata { get; set; }

        /// <summary>
        /// Context cache write options. Only effective when passed at the top level; cache_control markers inside the messages array are ignored. When omitted, cache reads and writes use the 5m TTL by default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Moonshot.MessagesRequestCacheControl? CacheControl { get; set; }

        /// <summary>
        /// Output configuration: reasoning effort and structured output
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_config")]
        public global::Moonshot.MessagesRequestOutputConfig? OutputConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// ID of the model to use. This endpoint currently supports `kimi-k3.1-pro`, `kimi-k3.1-pro-highspeed`, and `kimi-k3`.<br/>
        /// Default Value: kimi-k3.1-pro
        /// </param>
        /// <param name="messages">
        /// The conversation messages. If the last message is from the assistant, the model continues from that content (Partial Mode).
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens to generate, required. If the limit is reached before the model finishes, `stop_reason` is `max_tokens`.
        /// </param>
        /// <param name="system">
        /// System prompt, either a string or an array of text blocks
        /// </param>
        /// <param name="stream">
        /// Whether to stream the response as Server-Sent Events, default false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="stopSequences">
        /// Stop sequences. Generation stops on an exact match; the matched sequence itself is not output. Up to 5 entries, each at most 32 bytes.
        /// </param>
        /// <param name="tools">
        /// List of tools the model may call
        /// </param>
        /// <param name="toolChoice">
        /// Controls whether the model calls tools. `auto` (default): the model decides; `any`: force a call to any tool; `none`: do not call tools.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="cacheControl">
        /// Context cache write options. Only effective when passed at the top level; cache_control markers inside the messages array are ignored. When omitted, cache reads and writes use the 5m TTL by default
        /// </param>
        /// <param name="outputConfig">
        /// Output configuration: reasoning effort and structured output
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequest(
            global::Moonshot.MessagesRequestModel model,
            global::System.Collections.Generic.IList<global::Moonshot.MessagesMessageParam> messages,
            int maxTokens,
            global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.MessagesTextBlockParam>>? system,
            bool? stream,
            global::System.Collections.Generic.IList<string>? stopSequences,
            global::System.Collections.Generic.IList<global::Moonshot.MessagesTool>? tools,
            global::Moonshot.MessagesToolChoice? toolChoice,
            global::Moonshot.MessagesRequestMetadata? metadata,
            global::Moonshot.MessagesRequestCacheControl? cacheControl,
            global::Moonshot.MessagesRequestOutputConfig? outputConfig)
        {
            this.Model = model;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.MaxTokens = maxTokens;
            this.System = system;
            this.Stream = stream;
            this.StopSequences = stopSequences;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.Metadata = metadata;
            this.CacheControl = cacheControl;
            this.OutputConfig = outputConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequest" /> class.
        /// </summary>
        public MessagesRequest()
        {
        }

    }
}