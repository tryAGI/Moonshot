
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileObject
    {
        /// <summary>
        /// Unique file identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Object type<br/>
        /// Example: file
        /// </summary>
        /// <example>file</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Object { get; set; }

        /// <summary>
        /// File size in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Bytes { get; set; }

        /// <summary>
        /// Unix timestamp when the file was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Original file name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Purpose used when uploading the file. file-extract: extract file contents; image: upload images for vision understanding; video: upload videos for video understanding; batch: upload JSONL files for batch processing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.FileObjectPurposeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.FileObjectPurpose Purpose { get; set; }

        /// <summary>
        /// Processing status of the file<br/>
        /// Example: ready
        /// </summary>
        /// <example>ready</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Additional status details when processing fails or returns warnings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_details")]
        public string? StatusDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileObject" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique file identifier
        /// </param>
        /// <param name="object">
        /// Object type<br/>
        /// Example: file
        /// </param>
        /// <param name="bytes">
        /// File size in bytes
        /// </param>
        /// <param name="createdAt">
        /// Unix timestamp when the file was created
        /// </param>
        /// <param name="filename">
        /// Original file name
        /// </param>
        /// <param name="purpose">
        /// Purpose used when uploading the file. file-extract: extract file contents; image: upload images for vision understanding; video: upload videos for video understanding; batch: upload JSONL files for batch processing
        /// </param>
        /// <param name="status">
        /// Processing status of the file<br/>
        /// Example: ready
        /// </param>
        /// <param name="statusDetails">
        /// Additional status details when processing fails or returns warnings
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileObject(
            string id,
            string @object,
            long bytes,
            global::System.DateTimeOffset createdAt,
            string filename,
            global::Moonshot.FileObjectPurpose purpose,
            string status,
            string? statusDetails)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Bytes = bytes;
            this.CreatedAt = createdAt;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Purpose = purpose;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.StatusDetails = statusDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileObject" /> class.
        /// </summary>
        public FileObject()
        {
        }
    }
}