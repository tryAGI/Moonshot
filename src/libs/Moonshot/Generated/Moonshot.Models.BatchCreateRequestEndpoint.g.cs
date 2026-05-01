
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Request endpoint, currently only /v1/chat/completions is supported
    /// </summary>
    public enum BatchCreateRequestEndpoint
    {
        /// <summary>
        /// 
        /// </summary>
        V1ChatCompletions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchCreateRequestEndpointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchCreateRequestEndpoint value)
        {
            return value switch
            {
                BatchCreateRequestEndpoint.V1ChatCompletions => "/v1/chat/completions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchCreateRequestEndpoint? ToEnum(string value)
        {
            return value switch
            {
                "/v1/chat/completions" => BatchCreateRequestEndpoint.V1ChatCompletions,
                _ => null,
            };
        }
    }
}