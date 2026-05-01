
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Model ID<br/>
    /// Default Value: kimi-k2.6
    /// </summary>
    public enum KimiK26ChatRequestVariant2Model
    {
        /// <summary>
        /// 
        /// </summary>
        KimiK26,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KimiK26ChatRequestVariant2ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KimiK26ChatRequestVariant2Model value)
        {
            return value switch
            {
                KimiK26ChatRequestVariant2Model.KimiK26 => "kimi-k2.6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KimiK26ChatRequestVariant2Model? ToEnum(string value)
        {
            return value switch
            {
                "kimi-k2.6" => KimiK26ChatRequestVariant2Model.KimiK26,
                _ => null,
            };
        }
    }
}