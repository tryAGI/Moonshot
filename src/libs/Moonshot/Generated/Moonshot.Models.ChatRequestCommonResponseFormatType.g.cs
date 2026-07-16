
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Output format type. text: default, plain text output; json_object: ensures output is a valid JSON object; json_schema: constrains output to match a specified JSON Schema (recommended, requires the json_schema field)
    /// </summary>
    public enum ChatRequestCommonResponseFormatType
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
    public static class ChatRequestCommonResponseFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestCommonResponseFormatType value)
        {
            return value switch
            {
                ChatRequestCommonResponseFormatType.JsonObject => "json_object",
                ChatRequestCommonResponseFormatType.JsonSchema => "json_schema",
                ChatRequestCommonResponseFormatType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestCommonResponseFormatType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => ChatRequestCommonResponseFormatType.JsonObject,
                "json_schema" => ChatRequestCommonResponseFormatType.JsonSchema,
                "text" => ChatRequestCommonResponseFormatType.Text,
                _ => null,
            };
        }
    }
}