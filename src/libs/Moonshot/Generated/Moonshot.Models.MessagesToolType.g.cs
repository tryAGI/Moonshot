
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Tool type, may be omitted
    /// </summary>
    public enum MessagesToolType
    {
        /// <summary>
        ///
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesToolType value)
        {
            return value switch
            {
                MessagesToolType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesToolType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => MessagesToolType.Custom,
                _ => null,
            };
        }
    }
}