
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Model ID<br/>
    /// Default Value: kimi-k2-thinking
    /// </summary>
    public enum KimiK2ThinkingChatRequestVariant2Model
    {
        /// <summary>
        /// 
        /// </summary>
        KimiK2Thinking,
        /// <summary>
        /// 
        /// </summary>
        KimiK2ThinkingTurbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KimiK2ThinkingChatRequestVariant2ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KimiK2ThinkingChatRequestVariant2Model value)
        {
            return value switch
            {
                KimiK2ThinkingChatRequestVariant2Model.KimiK2Thinking => "kimi-k2-thinking",
                KimiK2ThinkingChatRequestVariant2Model.KimiK2ThinkingTurbo => "kimi-k2-thinking-turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KimiK2ThinkingChatRequestVariant2Model? ToEnum(string value)
        {
            return value switch
            {
                "kimi-k2-thinking" => KimiK2ThinkingChatRequestVariant2Model.KimiK2Thinking,
                "kimi-k2-thinking-turbo" => KimiK2ThinkingChatRequestVariant2Model.KimiK2ThinkingTurbo,
                _ => null,
            };
        }
    }
}