
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Reasoning effort: low, high, or max; default max. Changing the level breaks prefix-cache hits, so decide it before the session starts.<br/>
    /// Default Value: max
    /// </summary>
    public enum MessagesRequestOutputConfigEffort
    {
        /// <summary>
        /// low, high, or max; default max. Changing the level breaks prefix-cache hits, so decide it before the session starts.
        /// </summary>
        High,
        /// <summary>
        /// low, high, or max; default max. Changing the level breaks prefix-cache hits, so decide it before the session starts.
        /// </summary>
        Low,
        /// <summary>
        /// low, high, or max; default max. Changing the level breaks prefix-cache hits, so decide it before the session starts.
        /// </summary>
        Max,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestOutputConfigEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestOutputConfigEffort value)
        {
            return value switch
            {
                MessagesRequestOutputConfigEffort.High => "high",
                MessagesRequestOutputConfigEffort.Low => "low",
                MessagesRequestOutputConfigEffort.Max => "max",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestOutputConfigEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => MessagesRequestOutputConfigEffort.High,
                "low" => MessagesRequestOutputConfigEffort.Low,
                "max" => MessagesRequestOutputConfigEffort.Max,
                _ => null,
            };
        }
    }
}