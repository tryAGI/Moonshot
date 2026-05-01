
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Model ID<br/>
    /// Default Value: kimi-k2.5
    /// </summary>
    public enum KimiK25ChatRequestVariant2Model
    {
        /// <summary>
        /// 
        /// </summary>
        KimiK25,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KimiK25ChatRequestVariant2ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KimiK25ChatRequestVariant2Model value)
        {
            return value switch
            {
                KimiK25ChatRequestVariant2Model.KimiK25 => "kimi-k2.5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KimiK25ChatRequestVariant2Model? ToEnum(string value)
        {
            return value switch
            {
                "kimi-k2.5" => KimiK25ChatRequestVariant2Model.KimiK25,
                _ => null,
            };
        }
    }
}