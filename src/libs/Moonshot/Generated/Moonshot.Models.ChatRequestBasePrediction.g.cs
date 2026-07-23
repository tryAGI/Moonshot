
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Configuration for a Predicted Output, which can greatly improve response times when large parts of the model response are known ahead of time (for example, regenerating a file with only minor changes).
    /// </summary>
    public sealed partial class ChatRequestBasePrediction
    {
        /// <summary>
        /// The type of the predicted content. Currently only content is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ChatRequestBasePredictionTypeJsonConverter))]
        public global::Moonshot.ChatRequestBasePredictionType? Type { get; set; }

        /// <summary>
        /// The static predicted output content that should be matched when generating the model response, such as the content of a text file being regenerated. Accepts a string or an array of content parts (text parts only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<object>>))]
        public global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<object>>? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestBasePrediction" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the predicted content. Currently only content is supported.
        /// </param>
        /// <param name="content">
        /// The static predicted output content that should be matched when generating the model response, such as the content of a text file being regenerated. Accepts a string or an array of content parts (text parts only).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRequestBasePrediction(
            global::Moonshot.ChatRequestBasePredictionType? type,
            global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<object>>? content)
        {
            this.Type = type;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestBasePrediction" /> class.
        /// </summary>
        public ChatRequestBasePrediction()
        {
        }

    }
}