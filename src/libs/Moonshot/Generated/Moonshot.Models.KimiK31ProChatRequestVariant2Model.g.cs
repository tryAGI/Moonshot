
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Model ID<br/>
    /// Default Value: kimi-k3.1-pro
    /// </summary>
    public enum KimiK31ProChatRequestVariant2Model
    {
        /// <summary>
        ///
        /// </summary>
        KimiK31Pro,
        /// <summary>
        ///
        /// </summary>
        KimiK31ProHighspeed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KimiK31ProChatRequestVariant2ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KimiK31ProChatRequestVariant2Model value)
        {
            return value switch
            {
                KimiK31ProChatRequestVariant2Model.KimiK31Pro => "kimi-k3.1-pro",
                KimiK31ProChatRequestVariant2Model.KimiK31ProHighspeed => "kimi-k3.1-pro-highspeed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KimiK31ProChatRequestVariant2Model? ToEnum(string value)
        {
            return value switch
            {
                "kimi-k3.1-pro" => KimiK31ProChatRequestVariant2Model.KimiK31Pro,
                "kimi-k3.1-pro-highspeed" => KimiK31ProChatRequestVariant2Model.KimiK31ProHighspeed,
                _ => null,
            };
        }
    }
}