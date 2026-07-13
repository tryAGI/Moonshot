
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatRequestBaseToolChoiceEnumType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestBaseToolChoiceEnumTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestBaseToolChoiceEnumType value)
        {
            return value switch
            {
                ChatRequestBaseToolChoiceEnumType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestBaseToolChoiceEnumType? ToEnum(string value)
        {
            return value switch
            {
                "function" => ChatRequestBaseToolChoiceEnumType.Function,
                _ => null,
            };
        }
    }
}