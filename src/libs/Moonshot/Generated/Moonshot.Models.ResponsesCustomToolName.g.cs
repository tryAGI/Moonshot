
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Tool name. Only `apply_patch` is supported.
    /// </summary>
    public enum ResponsesCustomToolName
    {
        /// <summary>
        ///
        /// </summary>
        ApplyPatch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesCustomToolNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesCustomToolName value)
        {
            return value switch
            {
                ResponsesCustomToolName.ApplyPatch => "apply_patch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesCustomToolName? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch" => ResponsesCustomToolName.ApplyPatch,
                _ => null,
            };
        }
    }
}