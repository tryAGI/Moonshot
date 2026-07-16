
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Model ID<br/>
    /// Default Value: kimi-k3
    /// </summary>
    public enum KimiK3ChatRequestVariant2Model
    {
        /// <summary>
        /// 
        /// </summary>
        KimiK3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KimiK3ChatRequestVariant2ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KimiK3ChatRequestVariant2Model value)
        {
            return value switch
            {
                KimiK3ChatRequestVariant2Model.KimiK3 => "kimi-k3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KimiK3ChatRequestVariant2Model? ToEnum(string value)
        {
            return value switch
            {
                "kimi-k3" => KimiK3ChatRequestVariant2Model.KimiK3,
                _ => null,
            };
        }
    }
}