
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Message
    {
        /// <summary>
        /// The role of the message sender<br/>
        /// Example: user
        /// </summary>
        /// <example>user</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.MessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.MessageRole Role { get; set; }

        /// <summary>
        /// The content of the message. Can be a plain text string, or an array of objects with text/image_url/video_url types (for multimodal input)<br/>
        /// Example: Hello
        /// </summary>
        /// <example>Hello</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessageContentVariant2ItemText, global::Moonshot.MessageContentVariant2ItemImageUrl, global::Moonshot.MessageContentVariant2ItemVideoUrl>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessageContentVariant2ItemText, global::Moonshot.MessageContentVariant2ItemImageUrl, global::Moonshot.MessageContentVariant2ItemVideoUrl>>> Content { get; set; }

        /// <summary>
        /// Optional name for the message sender<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Enable Partial Mode by setting this to true in the last assistant message<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partial")]
        public bool? Partial { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the message sender<br/>
        /// Example: user
        /// </param>
        /// <param name="content">
        /// The content of the message. Can be a plain text string, or an array of objects with text/image_url/video_url types (for multimodal input)<br/>
        /// Example: Hello
        /// </param>
        /// <param name="name">
        /// Optional name for the message sender<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="partial">
        /// Enable Partial Mode by setting this to true in the last assistant message<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Message(
            global::Moonshot.MessageRole role,
            global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessageContentVariant2ItemText, global::Moonshot.MessageContentVariant2ItemImageUrl, global::Moonshot.MessageContentVariant2ItemVideoUrl>>> content,
            string? name,
            bool? partial)
        {
            this.Role = role;
            this.Content = content;
            this.Name = name;
            this.Partial = partial;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        public Message()
        {
        }

    }
}