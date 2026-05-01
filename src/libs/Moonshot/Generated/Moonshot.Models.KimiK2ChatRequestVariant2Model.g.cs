
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Model ID<br/>
    /// Default Value: kimi-k2-0905-preview
    /// </summary>
    public enum KimiK2ChatRequestVariant2Model
    {
        /// <summary>
        /// 
        /// </summary>
        KimiK20711Preview,
        /// <summary>
        /// 
        /// </summary>
        KimiK20905Preview,
        /// <summary>
        /// 
        /// </summary>
        KimiK2TurboPreview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KimiK2ChatRequestVariant2ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KimiK2ChatRequestVariant2Model value)
        {
            return value switch
            {
                KimiK2ChatRequestVariant2Model.KimiK20711Preview => "kimi-k2-0711-preview",
                KimiK2ChatRequestVariant2Model.KimiK20905Preview => "kimi-k2-0905-preview",
                KimiK2ChatRequestVariant2Model.KimiK2TurboPreview => "kimi-k2-turbo-preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KimiK2ChatRequestVariant2Model? ToEnum(string value)
        {
            return value switch
            {
                "kimi-k2-0711-preview" => KimiK2ChatRequestVariant2Model.KimiK20711Preview,
                "kimi-k2-0905-preview" => KimiK2ChatRequestVariant2Model.KimiK20905Preview,
                "kimi-k2-turbo-preview" => KimiK2ChatRequestVariant2Model.KimiK2TurboPreview,
                _ => null,
            };
        }
    }
}