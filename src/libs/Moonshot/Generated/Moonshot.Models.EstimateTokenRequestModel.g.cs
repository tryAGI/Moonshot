
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Model ID<br/>
    /// Default Value: kimi-k2.5
    /// </summary>
    public enum EstimateTokenRequestModel
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
    public static class EstimateTokenRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimateTokenRequestModel value)
        {
            return value switch
            {
                EstimateTokenRequestModel.KimiK20711Preview => "kimi-k2-0711-preview",
                EstimateTokenRequestModel.KimiK20905Preview => "kimi-k2-0905-preview",
                EstimateTokenRequestModel.KimiK2TurboPreview => "kimi-k2-turbo-preview",
                EstimateTokenRequestModel.KimiK25 => "kimi-k2.5",
                EstimateTokenRequestModel.KimiK26 => "kimi-k2.6",
                EstimateTokenRequestModel.MoonshotV1128k => "moonshot-v1-128k",
                EstimateTokenRequestModel.MoonshotV1128kVisionPreview => "moonshot-v1-128k-vision-preview",
                EstimateTokenRequestModel.MoonshotV132k => "moonshot-v1-32k",
                EstimateTokenRequestModel.MoonshotV132kVisionPreview => "moonshot-v1-32k-vision-preview",
                EstimateTokenRequestModel.MoonshotV18k => "moonshot-v1-8k",
                EstimateTokenRequestModel.MoonshotV18kVisionPreview => "moonshot-v1-8k-vision-preview",
                EstimateTokenRequestModel.MoonshotV1Auto => "moonshot-v1-auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimateTokenRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "kimi-k2-0711-preview" => EstimateTokenRequestModel.KimiK20711Preview,
                "kimi-k2-0905-preview" => EstimateTokenRequestModel.KimiK20905Preview,
                "kimi-k2-turbo-preview" => EstimateTokenRequestModel.KimiK2TurboPreview,
                "kimi-k2.5" => EstimateTokenRequestModel.KimiK25,
                "kimi-k2.6" => EstimateTokenRequestModel.KimiK26,
                "moonshot-v1-128k" => EstimateTokenRequestModel.MoonshotV1128k,
                "moonshot-v1-128k-vision-preview" => EstimateTokenRequestModel.MoonshotV1128kVisionPreview,
                "moonshot-v1-32k" => EstimateTokenRequestModel.MoonshotV132k,
                "moonshot-v1-32k-vision-preview" => EstimateTokenRequestModel.MoonshotV132kVisionPreview,
                "moonshot-v1-8k" => EstimateTokenRequestModel.MoonshotV18k,
                "moonshot-v1-8k-vision-preview" => EstimateTokenRequestModel.MoonshotV18kVisionPreview,
                "moonshot-v1-auto" => EstimateTokenRequestModel.MoonshotV1Auto,
                _ => null,
            };
        }
    }
}