
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesStreamEventContentBlockDeltaDeltaType
    {
        /// <summary>
        ///
        /// </summary>
        InputJsonDelta,
        /// <summary>
        ///
        /// </summary>
        SignatureDelta,
        /// <summary>
        ///
        /// </summary>
        TextDelta,
        /// <summary>
        ///
        /// </summary>
        ThinkingDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesStreamEventContentBlockDeltaDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesStreamEventContentBlockDeltaDeltaType value)
        {
            return value switch
            {
                MessagesStreamEventContentBlockDeltaDeltaType.InputJsonDelta => "input_json_delta",
                MessagesStreamEventContentBlockDeltaDeltaType.SignatureDelta => "signature_delta",
                MessagesStreamEventContentBlockDeltaDeltaType.TextDelta => "text_delta",
                MessagesStreamEventContentBlockDeltaDeltaType.ThinkingDelta => "thinking_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesStreamEventContentBlockDeltaDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "input_json_delta" => MessagesStreamEventContentBlockDeltaDeltaType.InputJsonDelta,
                "signature_delta" => MessagesStreamEventContentBlockDeltaDeltaType.SignatureDelta,
                "text_delta" => MessagesStreamEventContentBlockDeltaDeltaType.TextDelta,
                "thinking_delta" => MessagesStreamEventContentBlockDeltaDeltaType.ThinkingDelta,
                _ => null,
            };
        }
    }
}