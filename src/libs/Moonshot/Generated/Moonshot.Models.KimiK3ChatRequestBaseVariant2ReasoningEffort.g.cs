
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Kimi K3-series models always enable thinking with Preserved Thinking. Reasoning effort supports low, high, and max, with max as the default.<br/>
    /// Default Value: max
    /// </summary>
    public enum KimiK3ChatRequestBaseVariant2ReasoningEffort
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Max,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KimiK3ChatRequestBaseVariant2ReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KimiK3ChatRequestBaseVariant2ReasoningEffort value)
        {
            return value switch
            {
                KimiK3ChatRequestBaseVariant2ReasoningEffort.High => "high",
                KimiK3ChatRequestBaseVariant2ReasoningEffort.Low => "low",
                KimiK3ChatRequestBaseVariant2ReasoningEffort.Max => "max",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KimiK3ChatRequestBaseVariant2ReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => KimiK3ChatRequestBaseVariant2ReasoningEffort.High,
                "low" => KimiK3ChatRequestBaseVariant2ReasoningEffort.Low,
                "max" => KimiK3ChatRequestBaseVariant2ReasoningEffort.Max,
                _ => null,
            };
        }
    }
}