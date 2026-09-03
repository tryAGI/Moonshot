
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesOutputWebSearchCallItemType
    {
        /// <summary>
        ///
        /// </summary>
        WebSearchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesOutputWebSearchCallItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesOutputWebSearchCallItemType value)
        {
            return value switch
            {
                ResponsesOutputWebSearchCallItemType.WebSearchCall => "web_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesOutputWebSearchCallItemType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_call" => ResponsesOutputWebSearchCallItemType.WebSearchCall,
                _ => null,
            };
        }
    }
}