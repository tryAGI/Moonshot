
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Specifies how the uploaded file will be processed. file-extract: extract content from text-based files (such as pdf, doc, txt); images are not supported; image: upload images for vision understanding; video: upload videos for video understanding; batch: upload JSONL files for batch processing
    /// </summary>
    public enum CreateFilesRequestPurpose
    {
        /// <summary>
        /// extract content from text-based files (such as pdf, doc, txt); images are not supported; image: upload images for vision understanding; video: upload videos for video understanding; batch: upload JSONL files for batch processing
        /// </summary>
        Batch,
        /// <summary>
        /// extract content from text-based files (such as pdf, doc, txt); images are not supported; image: upload images for vision understanding; video: upload videos for video understanding; batch: upload JSONL files for batch processing
        /// </summary>
        FileExtract,
        /// <summary>
        /// extract content from text-based files (such as pdf, doc, txt); images are not supported; image: upload images for vision understanding; video: upload videos for video understanding; batch: upload JSONL files for batch processing
        /// </summary>
        Image,
        /// <summary>
        /// extract content from text-based files (such as pdf, doc, txt); images are not supported; image: upload images for vision understanding; video: upload videos for video understanding; batch: upload JSONL files for batch processing
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFilesRequestPurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFilesRequestPurpose value)
        {
            return value switch
            {
                CreateFilesRequestPurpose.Batch => "batch",
                CreateFilesRequestPurpose.FileExtract => "file-extract",
                CreateFilesRequestPurpose.Image => "image",
                CreateFilesRequestPurpose.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFilesRequestPurpose? ToEnum(string value)
        {
            return value switch
            {
                "batch" => CreateFilesRequestPurpose.Batch,
                "file-extract" => CreateFilesRequestPurpose.FileExtract,
                "image" => CreateFilesRequestPurpose.Image,
                "video" => CreateFilesRequestPurpose.Video,
                _ => null,
            };
        }
    }
}