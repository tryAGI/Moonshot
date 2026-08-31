
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesInputContentPartInputImageDetail
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Original,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesInputContentPartInputImageDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesInputContentPartInputImageDetail value)
        {
            return value switch
            {
                ResponsesInputContentPartInputImageDetail.Auto => "auto",
                ResponsesInputContentPartInputImageDetail.High => "high",
                ResponsesInputContentPartInputImageDetail.Low => "low",
                ResponsesInputContentPartInputImageDetail.Original => "original",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesInputContentPartInputImageDetail? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResponsesInputContentPartInputImageDetail.Auto,
                "high" => ResponsesInputContentPartInputImageDetail.High,
                "low" => ResponsesInputContentPartInputImageDetail.Low,
                "original" => ResponsesInputContentPartInputImageDetail.Original,
                _ => null,
            };
        }
    }
}