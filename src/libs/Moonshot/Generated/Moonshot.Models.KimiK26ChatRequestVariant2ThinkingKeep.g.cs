
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Controls whether reasoning_content from previous turns is preserved across a multi-turn conversation, i.e. whether to enable Preserved Thinking. Defaults to `null`, meaning historical thinking is NOT preserved.<br/>
    /// - `null` (default) or omitted: The server ignores reasoning_content from historical turns.<br/>
    /// - `"all"`: Preserves reasoning_content from historical turns and provides it to the model as part of the context, enabling Preserved Thinking. When using this, keep the reasoning_content from every historical assistant message in messages as-is. Recommended to use together with `type: "enabled"`.<br/>
    /// - Note: This parameter only affects reasoning_content from historical turns; it does not change whether the model produces/outputs thinking within the current turn (that is controlled by `type`). For best practices, see [Preserved Thinking](/guide/use-kimi-k2-thinking-model#preserved-thinking).
    /// </summary>
    public enum KimiK26ChatRequestVariant2ThinkingKeep
    {
        /// <summary>
        /// Preserves reasoning_content from historical turns and provides it to the model as part of the context, enabling Preserved Thinking. When using this, keep the reasoning_content from every historical assistant message in messages as-is. Recommended to use together with `type: "enabled"`.
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KimiK26ChatRequestVariant2ThinkingKeepExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KimiK26ChatRequestVariant2ThinkingKeep value)
        {
            return value switch
            {
                KimiK26ChatRequestVariant2ThinkingKeep.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KimiK26ChatRequestVariant2ThinkingKeep? ToEnum(string value)
        {
            return value switch
            {
                "all" => KimiK26ChatRequestVariant2ThinkingKeep.All,
                _ => null,
            };
        }
    }
}