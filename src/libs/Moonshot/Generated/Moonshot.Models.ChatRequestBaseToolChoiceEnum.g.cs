
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// auto: the model decides whether to call tools; none: no tool calls; required: force a tool call
    /// </summary>
    public enum ChatRequestBaseToolChoiceEnum
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
    public static class ChatRequestBaseToolChoiceEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestBaseToolChoiceEnum value)
        {
            return value switch
            {
                ChatRequestBaseToolChoiceEnum.Auto => "auto",
                ChatRequestBaseToolChoiceEnum.None => "none",
                ChatRequestBaseToolChoiceEnum.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestBaseToolChoiceEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ChatRequestBaseToolChoiceEnum.Auto,
                "none" => ChatRequestBaseToolChoiceEnum.None,
                "required" => ChatRequestBaseToolChoiceEnum.Required,
                _ => null,
            };
        }
    }
}