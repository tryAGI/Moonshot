
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Model ID<br/>
    /// Default Value: kimi-k3
    /// </summary>
    public enum MessagesRequestModel
    {
        /// <summary>
        ///
        /// </summary>
        KimiK3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestModel value)
        {
            return value switch
            {
                MessagesRequestModel.KimiK3 => "kimi-k3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "kimi-k3" => MessagesRequestModel.KimiK3,
                _ => null,
            };
        }
    }
}