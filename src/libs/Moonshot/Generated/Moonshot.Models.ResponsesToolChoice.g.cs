
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Controls tool-calling behavior. With `auto`, the model decides whether to call a tool.
    /// </summary>
    public enum ResponsesToolChoice
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesToolChoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesToolChoice value)
        {
            return value switch
            {
                ResponsesToolChoice.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesToolChoice? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResponsesToolChoice.Auto,
                _ => null,
            };
        }
    }
}