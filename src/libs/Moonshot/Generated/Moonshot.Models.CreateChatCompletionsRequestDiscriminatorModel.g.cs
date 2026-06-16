
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
        KimiK25,
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
        MoonshotV1128k,
        /// <summary>
        /// 
        /// </summary>
        MoonshotV1128kVisionPreview,
        /// <summary>
        /// 
        /// </summary>
        MoonshotV132k,
        /// <summary>
        /// 
        /// </summary>
        MoonshotV132kVisionPreview,
        /// <summary>
        /// 
        /// </summary>
        MoonshotV18k,
        /// <summary>
        /// 
        /// </summary>
        MoonshotV18kVisionPreview,
        /// <summary>
        /// 
        /// </summary>
        MoonshotV1Auto,
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
                CreateChatCompletionsRequestDiscriminatorModel.KimiK25 => "kimi-k2.5",
                CreateChatCompletionsRequestDiscriminatorModel.KimiK26 => "kimi-k2.6",
                CreateChatCompletionsRequestDiscriminatorModel.KimiK27Code => "kimi-k2.7-code",
                CreateChatCompletionsRequestDiscriminatorModel.KimiK27CodeHighspeed => "kimi-k2.7-code-highspeed",
                CreateChatCompletionsRequestDiscriminatorModel.MoonshotV1128k => "moonshot-v1-128k",
                CreateChatCompletionsRequestDiscriminatorModel.MoonshotV1128kVisionPreview => "moonshot-v1-128k-vision-preview",
                CreateChatCompletionsRequestDiscriminatorModel.MoonshotV132k => "moonshot-v1-32k",
                CreateChatCompletionsRequestDiscriminatorModel.MoonshotV132kVisionPreview => "moonshot-v1-32k-vision-preview",
                CreateChatCompletionsRequestDiscriminatorModel.MoonshotV18k => "moonshot-v1-8k",
                CreateChatCompletionsRequestDiscriminatorModel.MoonshotV18kVisionPreview => "moonshot-v1-8k-vision-preview",
                CreateChatCompletionsRequestDiscriminatorModel.MoonshotV1Auto => "moonshot-v1-auto",
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
                "kimi-k2.5" => CreateChatCompletionsRequestDiscriminatorModel.KimiK25,
                "kimi-k2.6" => CreateChatCompletionsRequestDiscriminatorModel.KimiK26,
                "kimi-k2.7-code" => CreateChatCompletionsRequestDiscriminatorModel.KimiK27Code,
                "kimi-k2.7-code-highspeed" => CreateChatCompletionsRequestDiscriminatorModel.KimiK27CodeHighspeed,
                "moonshot-v1-128k" => CreateChatCompletionsRequestDiscriminatorModel.MoonshotV1128k,
                "moonshot-v1-128k-vision-preview" => CreateChatCompletionsRequestDiscriminatorModel.MoonshotV1128kVisionPreview,
                "moonshot-v1-32k" => CreateChatCompletionsRequestDiscriminatorModel.MoonshotV132k,
                "moonshot-v1-32k-vision-preview" => CreateChatCompletionsRequestDiscriminatorModel.MoonshotV132kVisionPreview,
                "moonshot-v1-8k" => CreateChatCompletionsRequestDiscriminatorModel.MoonshotV18k,
                "moonshot-v1-8k-vision-preview" => CreateChatCompletionsRequestDiscriminatorModel.MoonshotV18kVisionPreview,
                "moonshot-v1-auto" => CreateChatCompletionsRequestDiscriminatorModel.MoonshotV1Auto,
                _ => null,
            };
        }
    }
}