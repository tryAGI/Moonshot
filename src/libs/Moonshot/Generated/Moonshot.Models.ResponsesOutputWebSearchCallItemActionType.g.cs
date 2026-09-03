
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesOutputWebSearchCallItemActionType
    {
        /// <summary>
        ///
        /// </summary>
        Search,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesOutputWebSearchCallItemActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesOutputWebSearchCallItemActionType value)
        {
            return value switch
            {
                ResponsesOutputWebSearchCallItemActionType.Search => "search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesOutputWebSearchCallItemActionType? ToEnum(string value)
        {
            return value switch
            {
                "search" => ResponsesOutputWebSearchCallItemActionType.Search,
                _ => null,
            };
        }
    }
}