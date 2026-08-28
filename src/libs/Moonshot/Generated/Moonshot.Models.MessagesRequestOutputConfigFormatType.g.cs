
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesRequestOutputConfigFormatType
    {
        /// <summary>
        ///
        /// </summary>
        JsonSchema,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestOutputConfigFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestOutputConfigFormatType value)
        {
            return value switch
            {
                MessagesRequestOutputConfigFormatType.JsonSchema => "json_schema",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestOutputConfigFormatType? ToEnum(string value)
        {
            return value switch
            {
                "json_schema" => MessagesRequestOutputConfigFormatType.JsonSchema,
                _ => null,
            };
        }
    }
}