
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesToolDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Custom,
        /// <summary>
        ///
        /// </summary>
        Function,
        /// <summary>
        ///
        /// </summary>
        Namespace,
        /// <summary>
        ///
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesToolDiscriminatorType value)
        {
            return value switch
            {
                ResponsesToolDiscriminatorType.Custom => "custom",
                ResponsesToolDiscriminatorType.Function => "function",
                ResponsesToolDiscriminatorType.Namespace => "namespace",
                ResponsesToolDiscriminatorType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => ResponsesToolDiscriminatorType.Custom,
                "function" => ResponsesToolDiscriminatorType.Function,
                "namespace" => ResponsesToolDiscriminatorType.Namespace,
                "web_search" => ResponsesToolDiscriminatorType.WebSearch,
                _ => null,
            };
        }
    }
}