
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesNamespaceToolType
    {
        /// <summary>
        ///
        /// </summary>
        Namespace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesNamespaceToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesNamespaceToolType value)
        {
            return value switch
            {
                ResponsesNamespaceToolType.Namespace => "namespace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesNamespaceToolType? ToEnum(string value)
        {
            return value switch
            {
                "namespace" => ResponsesNamespaceToolType.Namespace,
                _ => null,
            };
        }
    }
}