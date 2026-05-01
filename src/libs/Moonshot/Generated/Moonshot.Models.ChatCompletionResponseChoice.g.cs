
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionResponseChoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public global::Moonshot.ChatCompletionResponseChoiceMessage? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ChatCompletionResponseChoiceFinishReasonJsonConverter))]
        public global::Moonshot.ChatCompletionResponseChoiceFinishReason? FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseChoice" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="message"></param>
        /// <param name="finishReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionResponseChoice(
            int? index,
            global::Moonshot.ChatCompletionResponseChoiceMessage? message,
            global::Moonshot.ChatCompletionResponseChoiceFinishReason? finishReason)
        {
            this.Index = index;
            this.Message = message;
            this.FinishReason = finishReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseChoice" /> class.
        /// </summary>
        public ChatCompletionResponseChoice()
        {
        }
    }
}