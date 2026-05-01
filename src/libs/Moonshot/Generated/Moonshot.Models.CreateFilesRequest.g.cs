
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFilesRequest
    {
        /// <summary>
        /// The file to upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// The file to upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Specifies how the uploaded file will be processed. file-extract: extract file contents; image: upload images for vision understanding; video: upload videos for video understanding; batch: upload JSONL files for batch processing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.CreateFilesRequestPurposeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.CreateFilesRequestPurpose Purpose { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFilesRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// The file to upload
        /// </param>
        /// <param name="filename">
        /// The file to upload
        /// </param>
        /// <param name="purpose">
        /// Specifies how the uploaded file will be processed. file-extract: extract file contents; image: upload images for vision understanding; video: upload videos for video understanding; batch: upload JSONL files for batch processing
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFilesRequest(
            byte[] file,
            string filename,
            global::Moonshot.CreateFilesRequestPurpose purpose)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Purpose = purpose;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFilesRequest" /> class.
        /// </summary>
        public CreateFilesRequest()
        {
        }
    }
}