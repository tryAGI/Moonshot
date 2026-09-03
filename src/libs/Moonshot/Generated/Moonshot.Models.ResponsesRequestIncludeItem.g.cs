
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesRequestIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        WebSearchCallActionSources,
        /// <summary>
        ///
        /// </summary>
        WebSearchCallResults,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesRequestIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesRequestIncludeItem value)
        {
            return value switch
            {
                ResponsesRequestIncludeItem.WebSearchCallActionSources => "web_search_call.action.sources",
                ResponsesRequestIncludeItem.WebSearchCallResults => "web_search_call.results",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesRequestIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "web_search_call.action.sources" => ResponsesRequestIncludeItem.WebSearchCallActionSources,
                "web_search_call.results" => ResponsesRequestIncludeItem.WebSearchCallResults,
                _ => null,
            };
        }
    }
}