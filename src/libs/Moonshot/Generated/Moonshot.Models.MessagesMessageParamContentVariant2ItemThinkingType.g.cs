
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesMessageParamContentVariant2ItemThinkingType
    {
        /// <summary>
        ///
        /// </summary>
        Thinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentVariant2ItemThinkingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentVariant2ItemThinkingType value)
        {
            return value switch
            {
                MessagesMessageParamContentVariant2ItemThinkingType.Thinking => "thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentVariant2ItemThinkingType? ToEnum(string value)
        {
            return value switch
            {
                "thinking" => MessagesMessageParamContentVariant2ItemThinkingType.Thinking,
                _ => null,
            };
        }
    }
}