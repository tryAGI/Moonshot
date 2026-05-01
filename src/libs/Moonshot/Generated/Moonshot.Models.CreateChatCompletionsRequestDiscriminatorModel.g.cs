
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
        KimiK20711Preview,
        /// <summary>
        /// 
        /// </summary>
        KimiK20905Preview,
        /// <summary>
        /// 
        /// </summary>
        KimiK2Thinking,
        /// <summary>
        /// 
        /// </summary>
        KimiK2ThinkingTurbo,
        /// <summary>
        /// 
        /// </summary>
        KimiK2TurboPreview,
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
                CreateChatCompletionsRequestDiscriminatorModel.KimiK20711Preview => "kimi-k2-0711-preview",
                CreateChatCompletionsRequestDiscriminatorModel.KimiK20905Preview => "kimi-k2-0905-preview",
                CreateChatCompletionsRequestDiscriminatorModel.KimiK2Thinking => "kimi-k2-thinking",
                CreateChatCompletionsRequestDiscriminatorModel.KimiK2ThinkingTurbo => "kimi-k2-thinking-turbo",
                CreateChatCompletionsRequestDiscriminatorModel.KimiK2TurboPreview => "kimi-k2-turbo-preview",
                CreateChatCompletionsRequestDiscriminatorModel.KimiK25 => "kimi-k2.5",
                CreateChatCompletionsRequestDiscriminatorModel.KimiK26 => "kimi-k2.6",
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
                "kimi-k2-0711-preview" => CreateChatCompletionsRequestDiscriminatorModel.KimiK20711Preview,
                "kimi-k2-0905-preview" => CreateChatCompletionsRequestDiscriminatorModel.KimiK20905Preview,
                "kimi-k2-thinking" => CreateChatCompletionsRequestDiscriminatorModel.KimiK2Thinking,
                "kimi-k2-thinking-turbo" => CreateChatCompletionsRequestDiscriminatorModel.KimiK2ThinkingTurbo,
                "kimi-k2-turbo-preview" => CreateChatCompletionsRequestDiscriminatorModel.KimiK2TurboPreview,
                "kimi-k2.5" => CreateChatCompletionsRequestDiscriminatorModel.KimiK25,
                "kimi-k2.6" => CreateChatCompletionsRequestDiscriminatorModel.KimiK26,
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