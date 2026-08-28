
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Default Value: auto
    /// </summary>
    public enum MessagesToolChoiceType
    {
        /// <summary>
        ///
        /// </summary>
        Any,
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesToolChoiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesToolChoiceType value)
        {
            return value switch
            {
                MessagesToolChoiceType.Any => "any",
                MessagesToolChoiceType.Auto => "auto",
                MessagesToolChoiceType.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesToolChoiceType? ToEnum(string value)
        {
            return value switch
            {
                "any" => MessagesToolChoiceType.Any,
                "auto" => MessagesToolChoiceType.Auto,
                "none" => MessagesToolChoiceType.None,
                _ => null,
            };
        }
    }
}