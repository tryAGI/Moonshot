
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Enable thinking capability. For kimi-k2.7-code, only `"enabled"` is accepted; passing `"disabled"` returns an error. This differs from kimi-k2.6, which also supports `"disabled"`.
    /// </summary>
    public enum KimiK27CodeChatRequestVariant2ThinkingType
    {
        /// <summary>
        /// 
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KimiK27CodeChatRequestVariant2ThinkingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KimiK27CodeChatRequestVariant2ThinkingType value)
        {
            return value switch
            {
                KimiK27CodeChatRequestVariant2ThinkingType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KimiK27CodeChatRequestVariant2ThinkingType? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => KimiK27CodeChatRequestVariant2ThinkingType.Enabled,
                _ => null,
            };
        }
    }
}