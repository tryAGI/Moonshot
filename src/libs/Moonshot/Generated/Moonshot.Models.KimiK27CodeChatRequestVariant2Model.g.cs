
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Model ID<br/>
    /// Default Value: kimi-k2.7-code
    /// </summary>
    public enum KimiK27CodeChatRequestVariant2Model
    {
        /// <summary>
        /// 
        /// </summary>
        KimiK27Code,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KimiK27CodeChatRequestVariant2ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KimiK27CodeChatRequestVariant2Model value)
        {
            return value switch
            {
                KimiK27CodeChatRequestVariant2Model.KimiK27Code => "kimi-k2.7-code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KimiK27CodeChatRequestVariant2Model? ToEnum(string value)
        {
            return value switch
            {
                "kimi-k2.7-code" => KimiK27CodeChatRequestVariant2Model.KimiK27Code,
                _ => null,
            };
        }
    }
}