
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Kimi K3 always enables thinking with Preserved Thinking. Thinking effort supports low, high, and max, with max as the default.<br/>
    /// Default Value: max
    /// </summary>
    public enum KimiK3ChatRequestVariant2ReasoningEffort
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
    public static class KimiK3ChatRequestVariant2ReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KimiK3ChatRequestVariant2ReasoningEffort value)
        {
            return value switch
            {
                KimiK3ChatRequestVariant2ReasoningEffort.High => "high",
                KimiK3ChatRequestVariant2ReasoningEffort.Low => "low",
                KimiK3ChatRequestVariant2ReasoningEffort.Max => "max",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KimiK3ChatRequestVariant2ReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => KimiK3ChatRequestVariant2ReasoningEffort.High,
                "low" => KimiK3ChatRequestVariant2ReasoningEffort.Low,
                "max" => KimiK3ChatRequestVariant2ReasoningEffort.Max,
                _ => null,
            };
        }
    }
}