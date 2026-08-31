
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Message role. `developer` is handled as a system instruction.
    /// </summary>
    public enum ResponsesMessageItemRole
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
        /// <summary>
        ///
        /// </summary>
        Developer,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesMessageItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesMessageItemRole value)
        {
            return value switch
            {
                ResponsesMessageItemRole.Assistant => "assistant",
                ResponsesMessageItemRole.Developer => "developer",
                ResponsesMessageItemRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesMessageItemRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ResponsesMessageItemRole.Assistant,
                "developer" => ResponsesMessageItemRole.Developer,
                "user" => ResponsesMessageItemRole.User,
                _ => null,
            };
        }
    }
}