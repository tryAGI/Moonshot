
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChoiceDeltaDeltaToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChoiceDeltaDeltaToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChoiceDeltaDeltaToolCallType value)
        {
            return value switch
            {
                ChoiceDeltaDeltaToolCallType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChoiceDeltaDeltaToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "function" => ChoiceDeltaDeltaToolCallType.Function,
                _ => null,
            };
        }
    }
}