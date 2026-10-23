
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// ID of the model to use. This endpoint currently supports `kimi-k3.1-pro`, `kimi-k3.1-pro-highspeed`, and `kimi-k3`.<br/>
    /// Default Value: kimi-k3.1-pro
    /// </summary>
    public enum MessagesRequestModel
    {
        /// <summary>
        ///
        /// </summary>
        KimiK3,
        /// <summary>
        ///
        /// </summary>
        KimiK31Pro,
        /// <summary>
        ///
        /// </summary>
        KimiK31ProHighspeed,
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
                MessagesRequestModel.KimiK31Pro => "kimi-k3.1-pro",
                MessagesRequestModel.KimiK31ProHighspeed => "kimi-k3.1-pro-highspeed",
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
                "kimi-k3.1-pro" => MessagesRequestModel.KimiK31Pro,
                "kimi-k3.1-pro-highspeed" => MessagesRequestModel.KimiK31ProHighspeed,
                _ => null,
            };
        }
    }
}