
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesOutputWebSearchCallItemActionSourceType
    {
        /// <summary>
        ///
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesOutputWebSearchCallItemActionSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesOutputWebSearchCallItemActionSourceType value)
        {
            return value switch
            {
                ResponsesOutputWebSearchCallItemActionSourceType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesOutputWebSearchCallItemActionSourceType? ToEnum(string value)
        {
            return value switch
            {
                "url" => ResponsesOutputWebSearchCallItemActionSourceType.Url,
                _ => null,
            };
        }
    }
}