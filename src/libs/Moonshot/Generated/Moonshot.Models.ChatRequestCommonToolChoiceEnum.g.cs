
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// auto: the model decides whether to call tools; none: no tool calls; required: force a tool call
    /// </summary>
    public enum ChatRequestCommonToolChoiceEnum
    {
        /// <summary>
        /// the model decides whether to call tools; none: no tool calls; required: force a tool call
        /// </summary>
        Auto,
        /// <summary>
        /// the model decides whether to call tools; none: no tool calls; required: force a tool call
        /// </summary>
        None,
        /// <summary>
        /// the model decides whether to call tools; none: no tool calls; required: force a tool call
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestCommonToolChoiceEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestCommonToolChoiceEnum value)
        {
            return value switch
            {
                ChatRequestCommonToolChoiceEnum.Auto => "auto",
                ChatRequestCommonToolChoiceEnum.None => "none",
                ChatRequestCommonToolChoiceEnum.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestCommonToolChoiceEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ChatRequestCommonToolChoiceEnum.Auto,
                "none" => ChatRequestCommonToolChoiceEnum.None,
                "required" => ChatRequestCommonToolChoiceEnum.Required,
                _ => null,
            };
        }
    }
}