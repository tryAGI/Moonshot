
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesResponseContentItemTextType
    {
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesResponseContentItemTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesResponseContentItemTextType value)
        {
            return value switch
            {
                MessagesResponseContentItemTextType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesResponseContentItemTextType? ToEnum(string value)
        {
            return value switch
            {
                "text" => MessagesResponseContentItemTextType.Text,
                _ => null,
            };
        }
    }
}