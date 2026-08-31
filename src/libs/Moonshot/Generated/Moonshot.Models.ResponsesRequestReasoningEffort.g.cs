
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Reasoning depth. Higher levels reason more thoroughly, which usually also increases latency and reasoning token usage.<br/>
    /// Default Value: max
    /// </summary>
    public enum ResponsesRequestReasoningEffort
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
    public static class ResponsesRequestReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesRequestReasoningEffort value)
        {
            return value switch
            {
                ResponsesRequestReasoningEffort.High => "high",
                ResponsesRequestReasoningEffort.Low => "low",
                ResponsesRequestReasoningEffort.Max => "max",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesRequestReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => ResponsesRequestReasoningEffort.High,
                "low" => ResponsesRequestReasoningEffort.Low,
                "max" => ResponsesRequestReasoningEffort.Max,
                _ => null,
            };
        }
    }
}