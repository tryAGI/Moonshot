
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesAdditionalToolsItemRole
    {
        /// <summary>
        ///
        /// </summary>
        Developer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesAdditionalToolsItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesAdditionalToolsItemRole value)
        {
            return value switch
            {
                ResponsesAdditionalToolsItemRole.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesAdditionalToolsItemRole? ToEnum(string value)
        {
            return value switch
            {
                "developer" => ResponsesAdditionalToolsItemRole.Developer,
                _ => null,
            };
        }
    }
}