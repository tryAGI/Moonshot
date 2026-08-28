
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemTextType
    {
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemTextType value)
        {
            return value switch
            {
                MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemTextType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemTextType? ToEnum(string value)
        {
            return value switch
            {
                "text" => MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemTextType.Text,
                _ => null,
            };
        }
    }
}