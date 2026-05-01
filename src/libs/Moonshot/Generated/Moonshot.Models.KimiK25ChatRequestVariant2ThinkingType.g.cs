
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Enable or disable thinking capability
    /// </summary>
    public enum KimiK25ChatRequestVariant2ThinkingType
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KimiK25ChatRequestVariant2ThinkingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KimiK25ChatRequestVariant2ThinkingType value)
        {
            return value switch
            {
                KimiK25ChatRequestVariant2ThinkingType.Disabled => "disabled",
                KimiK25ChatRequestVariant2ThinkingType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KimiK25ChatRequestVariant2ThinkingType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => KimiK25ChatRequestVariant2ThinkingType.Disabled,
                "enabled" => KimiK25ChatRequestVariant2ThinkingType.Enabled,
                _ => null,
            };
        }
    }
}