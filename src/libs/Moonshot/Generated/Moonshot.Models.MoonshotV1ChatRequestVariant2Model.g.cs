
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Model ID<br/>
    /// Default Value: moonshot-v1-128k
    /// </summary>
    public enum MoonshotV1ChatRequestVariant2Model
    {
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
    public static class MoonshotV1ChatRequestVariant2ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MoonshotV1ChatRequestVariant2Model value)
        {
            return value switch
            {
                MoonshotV1ChatRequestVariant2Model.MoonshotV1128k => "moonshot-v1-128k",
                MoonshotV1ChatRequestVariant2Model.MoonshotV1128kVisionPreview => "moonshot-v1-128k-vision-preview",
                MoonshotV1ChatRequestVariant2Model.MoonshotV132k => "moonshot-v1-32k",
                MoonshotV1ChatRequestVariant2Model.MoonshotV132kVisionPreview => "moonshot-v1-32k-vision-preview",
                MoonshotV1ChatRequestVariant2Model.MoonshotV18k => "moonshot-v1-8k",
                MoonshotV1ChatRequestVariant2Model.MoonshotV18kVisionPreview => "moonshot-v1-8k-vision-preview",
                MoonshotV1ChatRequestVariant2Model.MoonshotV1Auto => "moonshot-v1-auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MoonshotV1ChatRequestVariant2Model? ToEnum(string value)
        {
            return value switch
            {
                "moonshot-v1-128k" => MoonshotV1ChatRequestVariant2Model.MoonshotV1128k,
                "moonshot-v1-128k-vision-preview" => MoonshotV1ChatRequestVariant2Model.MoonshotV1128kVisionPreview,
                "moonshot-v1-32k" => MoonshotV1ChatRequestVariant2Model.MoonshotV132k,
                "moonshot-v1-32k-vision-preview" => MoonshotV1ChatRequestVariant2Model.MoonshotV132kVisionPreview,
                "moonshot-v1-8k" => MoonshotV1ChatRequestVariant2Model.MoonshotV18k,
                "moonshot-v1-8k-vision-preview" => MoonshotV1ChatRequestVariant2Model.MoonshotV18kVisionPreview,
                "moonshot-v1-auto" => MoonshotV1ChatRequestVariant2Model.MoonshotV1Auto,
                _ => null,
            };
        }
    }
}