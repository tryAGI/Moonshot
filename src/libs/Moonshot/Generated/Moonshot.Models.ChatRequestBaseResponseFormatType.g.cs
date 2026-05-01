
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Output format type. text: default, plain text output; json_object: ensures output is a valid JSON object; json_schema: constrains output to match a specified JSON Schema (recommended, requires the json_schema field)
    /// </summary>
    public enum ChatRequestBaseResponseFormatType
    {
        /// <summary>
        /// default, plain text output; json_object: ensures output is a valid JSON object; json_schema: constrains output to match a specified JSON Schema (recommended, requires the json_schema field)
        /// </summary>
        JsonObject,
        /// <summary>
        /// default, plain text output; json_object: ensures output is a valid JSON object; json_schema: constrains output to match a specified JSON Schema (recommended, requires the json_schema field)
        /// </summary>
        JsonSchema,
        /// <summary>
        /// default, plain text output; json_object: ensures output is a valid JSON object; json_schema: constrains output to match a specified JSON Schema (recommended, requires the json_schema field)
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestBaseResponseFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestBaseResponseFormatType value)
        {
            return value switch
            {
                ChatRequestBaseResponseFormatType.JsonObject => "json_object",
                ChatRequestBaseResponseFormatType.JsonSchema => "json_schema",
                ChatRequestBaseResponseFormatType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestBaseResponseFormatType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => ChatRequestBaseResponseFormatType.JsonObject,
                "json_schema" => ChatRequestBaseResponseFormatType.JsonSchema,
                "text" => ChatRequestBaseResponseFormatType.Text,
                _ => null,
            };
        }
    }
}