
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Purpose used when uploading the file. file-extract: extract content from text-based files (such as pdf, doc, txt); images are not supported; image: upload images for vision understanding; video: upload videos for video understanding; batch: upload JSONL files for batch processing
    /// </summary>
    public enum FileObjectPurpose
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
    public static class FileObjectPurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileObjectPurpose value)
        {
            return value switch
            {
                FileObjectPurpose.Batch => "batch",
                FileObjectPurpose.FileExtract => "file-extract",
                FileObjectPurpose.Image => "image",
                FileObjectPurpose.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileObjectPurpose? ToEnum(string value)
        {
            return value switch
            {
                "batch" => FileObjectPurpose.Batch,
                "file-extract" => FileObjectPurpose.FileExtract,
                "image" => FileObjectPurpose.Image,
                "video" => FileObjectPurpose.Video,
                _ => null,
            };
        }
    }
}