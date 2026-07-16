
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatRequestCommonToolChoiceEnumType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestCommonToolChoiceEnumTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestCommonToolChoiceEnumType value)
        {
            return value switch
            {
                ChatRequestCommonToolChoiceEnumType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestCommonToolChoiceEnumType? ToEnum(string value)
        {
            return value switch
            {
                "function" => ChatRequestCommonToolChoiceEnumType.Function,
                _ => null,
            };
        }
    }
}