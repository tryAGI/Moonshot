
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateChatCompletionsRequestDiscriminatorModel
    {
        /// <summary>
        ///
        /// </summary>
        KimiK26,
        /// <summary>
        ///
        /// </summary>
        KimiK27Code,
        /// <summary>
        ///
        /// </summary>
        KimiK27CodeHighspeed,
        /// <summary>
        ///
        /// </summary>
        KimiK3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionsRequestDiscriminatorModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionsRequestDiscriminatorModel value)
        {
            return value switch
            {
                CreateChatCompletionsRequestDiscriminatorModel.KimiK26 => "kimi-k2.6",
                CreateChatCompletionsRequestDiscriminatorModel.KimiK27Code => "kimi-k2.7-code",
                CreateChatCompletionsRequestDiscriminatorModel.KimiK27CodeHighspeed => "kimi-k2.7-code-highspeed",
                CreateChatCompletionsRequestDiscriminatorModel.KimiK3 => "kimi-k3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionsRequestDiscriminatorModel? ToEnum(string value)
        {
            return value switch
            {
                "kimi-k2.6" => CreateChatCompletionsRequestDiscriminatorModel.KimiK26,
                "kimi-k2.7-code" => CreateChatCompletionsRequestDiscriminatorModel.KimiK27Code,
                "kimi-k2.7-code-highspeed" => CreateChatCompletionsRequestDiscriminatorModel.KimiK27CodeHighspeed,
                "kimi-k3" => CreateChatCompletionsRequestDiscriminatorModel.KimiK3,
                _ => null,
            };
        }
    }
}