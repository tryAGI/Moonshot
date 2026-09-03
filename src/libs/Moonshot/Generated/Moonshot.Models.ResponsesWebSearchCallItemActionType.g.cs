
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesWebSearchCallItemActionType
    {
        /// <summary>
        ///
        /// </summary>
        Search,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesWebSearchCallItemActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesWebSearchCallItemActionType value)
        {
            return value switch
            {
                ResponsesWebSearchCallItemActionType.Search => "search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesWebSearchCallItemActionType? ToEnum(string value)
        {
            return value switch
            {
                "search" => ResponsesWebSearchCallItemActionType.Search,
                _ => null,
            };
        }
    }
}