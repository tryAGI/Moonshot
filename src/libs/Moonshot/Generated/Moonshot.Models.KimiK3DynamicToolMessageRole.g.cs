
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// The role of a dynamic tool loading message. Always system.
    /// </summary>
    public enum KimiK3DynamicToolMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KimiK3DynamicToolMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KimiK3DynamicToolMessageRole value)
        {
            return value switch
            {
                KimiK3DynamicToolMessageRole.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KimiK3DynamicToolMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "system" => KimiK3DynamicToolMessageRole.System,
                _ => null,
            };
        }
    }
}