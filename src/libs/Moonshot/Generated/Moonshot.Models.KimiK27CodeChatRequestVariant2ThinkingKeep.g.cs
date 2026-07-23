
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Controls whether reasoning_content from previous turns is preserved across a multi-turn conversation, i.e. whether to enable Preserved Thinking.<br/>
    /// - For kimi-k2.7-code this parameter only accepts the valid value `"all"`: passing `"all"`, passing `null`, or omitting it all behave identically and are treated as `"all"` on the server — reasoning_content from historical turns is always preserved; passing any other invalid value returns an error. This differs from kimi-k2.6, whose default is `null` (historical thinking NOT preserved unless you explicitly set `"all"`).<br/>
    /// - Because Preserved Thinking is always on, keep the reasoning_content from every historical assistant message in messages as-is.<br/>
    /// - Note: This parameter only affects reasoning_content from historical turns; it does not change whether the model produces/outputs thinking within the current turn (that is controlled by `type`). For best practices, see [Preserved Thinking](/guide/use-thinking-models#preserved-thinking).
    /// </summary>
    public enum KimiK27CodeChatRequestVariant2ThinkingKeep
    {
        /// <summary>
        /// passing `"all"`, passing `null`, or omitting it all behave identically and are treated as `"all"` on the server — reasoning_content from historical turns is always preserved; passing any other invalid value returns an error. This differs from kimi-k2.6, whose default is `null` (historical thinking NOT preserved unless you explicitly set `"all"`).
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KimiK27CodeChatRequestVariant2ThinkingKeepExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KimiK27CodeChatRequestVariant2ThinkingKeep value)
        {
            return value switch
            {
                KimiK27CodeChatRequestVariant2ThinkingKeep.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KimiK27CodeChatRequestVariant2ThinkingKeep? ToEnum(string value)
        {
            return value switch
            {
                "all" => KimiK27CodeChatRequestVariant2ThinkingKeep.All,
                _ => null,
            };
        }
    }
}