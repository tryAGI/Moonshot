
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KimiK2ChatRequestVariant2
    {
        /// <summary>
        /// Model ID<br/>
        /// Default Value: kimi-k2-0905-preview
        /// </summary>
        /// <default>global::Moonshot.KimiK2ChatRequestVariant2Model.KimiK20905Preview</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.KimiK2ChatRequestVariant2ModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.KimiK2ChatRequestVariant2Model Model { get; set; } = global::Moonshot.KimiK2ChatRequestVariant2Model.KimiK20905Preview;

        /// <summary>
        /// The sampling temperature to use, ranging from 0 to 1. A higher value (e.g., 0.7) will make the output more random, while a lower value (e.g., 0.2) will make it more focused and deterministic. Default is 0.6.<br/>
        /// Default Value: 0.6F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Another sampling method, where the model considers the results of tokens with a cumulative probability mass of top_p. Thus, 0.1 means only considering the top 10% of tokens by probability mass. Generally, we suggest changing either this or the temperature, but not both at the same time. Default is 1.0.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public float? TopP { get; set; }

        /// <summary>
        /// The number of results to generate for each input message. Default is 1, must not exceed 5. When the temperature is very close to 0, only 1 result can be returned.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// Presence penalty, a number between -2.0 and 2.0. A positive value will penalize new tokens based on whether they appear in the text, increasing the likelihood of the model discussing new topics<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public float? PresencePenalty { get; set; }

        /// <summary>
        /// Frequency penalty, a number between -2.0 and 2.0. A positive value will penalize new tokens based on their existing frequency in the text, reducing the likelihood of the model repeating the same phrases verbatim<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public float? FrequencyPenalty { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KimiK2ChatRequestVariant2" /> class.
        /// </summary>
        /// <param name="model">
        /// Model ID<br/>
        /// Default Value: kimi-k2-0905-preview
        /// </param>
        /// <param name="temperature">
        /// The sampling temperature to use, ranging from 0 to 1. A higher value (e.g., 0.7) will make the output more random, while a lower value (e.g., 0.2) will make it more focused and deterministic. Default is 0.6.<br/>
        /// Default Value: 0.6F
        /// </param>
        /// <param name="topP">
        /// Another sampling method, where the model considers the results of tokens with a cumulative probability mass of top_p. Thus, 0.1 means only considering the top 10% of tokens by probability mass. Generally, we suggest changing either this or the temperature, but not both at the same time. Default is 1.0.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="n">
        /// The number of results to generate for each input message. Default is 1, must not exceed 5. When the temperature is very close to 0, only 1 result can be returned.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="presencePenalty">
        /// Presence penalty, a number between -2.0 and 2.0. A positive value will penalize new tokens based on whether they appear in the text, increasing the likelihood of the model discussing new topics<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="frequencyPenalty">
        /// Frequency penalty, a number between -2.0 and 2.0. A positive value will penalize new tokens based on their existing frequency in the text, reducing the likelihood of the model repeating the same phrases verbatim<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KimiK2ChatRequestVariant2(
            global::Moonshot.KimiK2ChatRequestVariant2Model model,
            float? temperature,
            float? topP,
            int? n,
            float? presencePenalty,
            float? frequencyPenalty)
        {
            this.Model = model;
            this.Temperature = temperature;
            this.TopP = topP;
            this.N = n;
            this.PresencePenalty = presencePenalty;
            this.FrequencyPenalty = frequencyPenalty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KimiK2ChatRequestVariant2" /> class.
        /// </summary>
        public KimiK2ChatRequestVariant2()
        {
        }

    }
}