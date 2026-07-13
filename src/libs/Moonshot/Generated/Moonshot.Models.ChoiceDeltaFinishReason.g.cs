
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Stop reason, only present in the final chunk
    /// </summary>
    public enum ChoiceDeltaFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        Length,
        /// <summary>
        /// 
        /// </summary>
        Stop,
        /// <summary>
        /// 
        /// </summary>
        ToolCalls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChoiceDeltaFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChoiceDeltaFinishReason value)
        {
            return value switch
            {
                ChoiceDeltaFinishReason.Length => "length",
                ChoiceDeltaFinishReason.Stop => "stop",
                ChoiceDeltaFinishReason.ToolCalls => "tool_calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChoiceDeltaFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "length" => ChoiceDeltaFinishReason.Length,
                "stop" => ChoiceDeltaFinishReason.Stop,
                "tool_calls" => ChoiceDeltaFinishReason.ToolCalls,
                _ => null,
            };
        }
    }
}