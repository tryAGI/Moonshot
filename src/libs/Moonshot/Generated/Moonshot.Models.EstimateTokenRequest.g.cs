
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EstimateTokenRequest
    {
        /// <summary>
        /// Model ID<br/>
        /// Default Value: kimi-k2.5
        /// </summary>
        /// <default>global::Moonshot.EstimateTokenRequestModel.KimiK25</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.EstimateTokenRequestModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.EstimateTokenRequestModel Model { get; set; } = global::Moonshot.EstimateTokenRequestModel.KimiK25;

        /// <summary>
        /// A list of messages in the conversation so far. Each element has the format {"role": "user", "content": "Hello"}. role supports system, user, assistant, or tool. content must not be empty
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Moonshot.Message> Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimateTokenRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Model ID<br/>
        /// Default Value: kimi-k2.5
        /// </param>
        /// <param name="messages">
        /// A list of messages in the conversation so far. Each element has the format {"role": "user", "content": "Hello"}. role supports system, user, assistant, or tool. content must not be empty
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EstimateTokenRequest(
            global::Moonshot.EstimateTokenRequestModel model,
            global::System.Collections.Generic.IList<global::Moonshot.Message> messages)
        {
            this.Model = model;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimateTokenRequest" /> class.
        /// </summary>
        public EstimateTokenRequest()
        {
        }

    }
}