
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.Message? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessageRole? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessageContentVariant2ItemText, global::Moonshot.MessageContentVariant2ItemImageUrl, global::Moonshot.MessageContentVariant2ItemVideoUrl>>? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.OneOf<global::Moonshot.MessageContentVariant2ItemText, global::Moonshot.MessageContentVariant2ItemImageUrl, global::Moonshot.MessageContentVariant2ItemVideoUrl>? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessageContentVariant2ItemText? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessageContentVariant2ItemTextType? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessageContentVariant2ItemImageUrl? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessageContentVariant2ItemImageUrlType? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.OneOf<global::Moonshot.MessageContentVariant2ItemImageUrlImageUrl, string>? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessageContentVariant2ItemImageUrlImageUrl? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessageContentVariant2ItemVideoUrl? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessageContentVariant2ItemVideoUrlType? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.OneOf<global::Moonshot.MessageContentVariant2ItemVideoUrlVideoUrl, string>? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessageContentVariant2ItemVideoUrlVideoUrl? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ToolDefinition? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ToolDefinitionType? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ToolDefinitionFunction? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK3DynamicToolMessage? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK3DynamicToolMessageRole? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ToolDefinition>? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK3Message? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestCommon? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestCommonPrediction? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestCommonPredictionType? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<object>>? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestCommonResponseFormat? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestCommonResponseFormatType? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestCommonResponseFormatJsonSchema? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<string>>? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestCommonStreamOptions? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestCommonPromptCacheOptions? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestCommonPromptCacheOptionsMode? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestCommonPromptCacheOptionsTtl? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.OneOf<global::Moonshot.ChatRequestCommonToolChoiceEnum?, global::Moonshot.ChatRequestCommonToolChoiceEnum2>? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestCommonToolChoiceEnum? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestCommonToolChoiceEnum2? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestCommonToolChoiceEnumType? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestCommonToolChoiceEnumFunction? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestBase? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestBasePrediction? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestBasePredictionType? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.Message>? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestBaseResponseFormat? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestBaseResponseFormatType? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestBaseResponseFormatJsonSchema? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestBaseStreamOptions? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestBasePromptCacheOptions? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestBasePromptCacheOptionsMode? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestBasePromptCacheOptionsTtl? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.OneOf<global::Moonshot.ChatRequestBaseToolChoiceEnum?, global::Moonshot.ChatRequestBaseToolChoiceEnum2>? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestBaseToolChoiceEnum? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestBaseToolChoiceEnum2? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestBaseToolChoiceEnumType? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestBaseToolChoiceEnumFunction? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK3ChatRequest? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK3ChatRequestVariant2? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK3ChatRequestVariant2Model? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.KimiK3Message>? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK3ChatRequestVariant2ReasoningEffort? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK26ChatRequest? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK26ChatRequestVariant2? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK26ChatRequestVariant2Model? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK26ChatRequestVariant2Thinking? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK26ChatRequestVariant2ThinkingType? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK26ChatRequestVariant2ThinkingKeep? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK27CodeChatRequest? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK27CodeChatRequestVariant2? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK27CodeChatRequestVariant2Model? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK27CodeChatRequestVariant2Thinking? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK27CodeChatRequestVariant2ThinkingType? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK27CodeChatRequestVariant2ThinkingKeep? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionResponse? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ChatCompletionResponseChoice>? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionResponseChoice? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionResponseChoiceMessage? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionResponseChoiceMessageRole? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ChatCompletionResponseChoiceMessageToolCall>? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionResponseChoiceMessageToolCall? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionResponseChoiceMessageToolCallType? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionResponseChoiceMessageToolCallFunction? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionResponseChoiceFinishReason? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionResponseUsage? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionResponseUsagePromptTokensDetails? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionChunk? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ChoiceDelta>? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChoiceDelta? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionChunkUsage? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionChunkUsagePromptTokensDetails? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChoiceDeltaDelta? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ChoiceDeltaDeltaToolCall>? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChoiceDeltaDeltaToolCall? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChoiceDeltaDeltaToolCallType? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChoiceDeltaDeltaToolCallFunction? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChoiceDeltaFinishReason? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChoiceDeltaUsage? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesRequest? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.ResponsesInputItem>>? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesInputItem>? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesInputItem? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesRequestReasoning? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesRequestReasoningEffort? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesRequestText? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesRequestTextFormat? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesRequestTextFormatType? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesTool>? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesTool? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesToolChoice? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesRequestIncludeItem>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesRequestIncludeItem? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesRequestPromptCacheOptions? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesRequestPromptCacheOptionsMode? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesRequestPromptCacheOptionsTtl? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesMessageItem? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesReasoningItem? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesFunctionCallItem? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesFunctionCallOutputItem? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesCustomToolCallItem? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesCustomToolCallOutputItem? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesWebSearchCallItem? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesAdditionalToolsItem? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesMessageItemType? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesMessageItemRole? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.ResponsesInputContentPart>>? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesInputContentPart>? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesInputContentPart? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesMessageItemStatus? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesReasoningItemType? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesReasoningItemSummaryItem>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesReasoningItemSummaryItem? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesReasoningItemSummaryItemType? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesReasoningItemContentItem>? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesReasoningItemContentItem? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesReasoningItemContentItemType? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesReasoningItemStatus? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesFunctionCallItemType? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesFunctionCallItemStatus? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesFunctionCallOutputItemType? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesFunctionCallOutputItemStatus? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesCustomToolCallItemType? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesCustomToolCallItemStatus? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesCustomToolCallOutputItemType? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesCustomToolCallOutputItemStatus? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesWebSearchCallItemType? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesWebSearchCallItemStatus? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesWebSearchCallItemAction? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesWebSearchCallItemActionType? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesAdditionalToolsItemType? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesAdditionalToolsItemRole? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesInputContentPartInputText? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesInputContentPartInputTextType? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesInputContentPartInputImage? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesInputContentPartInputImageType? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesInputContentPartInputImageDetail? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesInputContentPartOutputText? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesInputContentPartOutputTextType? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesFunctionTool? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesCustomTool? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesNamespaceTool? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesWebSearchTool? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesToolDiscriminator? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesToolDiscriminatorType? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesFunctionToolType? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesCustomToolType? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesCustomToolName? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesCustomToolFormat? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesCustomToolFormatType? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesCustomToolFormatSyntax? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesNamespaceToolType? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.ResponsesFunctionTool, global::Moonshot.ResponsesCustomTool>>? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.OneOf<global::Moonshot.ResponsesFunctionTool, global::Moonshot.ResponsesCustomTool>? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesWebSearchToolType? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesWebSearchToolFilters? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesWebSearchToolSearchContentType>? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesWebSearchToolSearchContentType? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesWebSearchToolImageSettings? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesResponse? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesResponseObject? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesResponseStatus? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesOutputItem>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputItem? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesUsage? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesResponseIncompleteDetails? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesResponseIncompleteDetailsReason? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesResponseError? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesResponsePromptCacheOptions? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesResponsePromptCacheOptionsMode? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesResponsePromptCacheOptionsTtl? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputReasoningItem? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputMessageItem? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputFunctionCallItem? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputCustomToolCallItem? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputWebSearchCallItem? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputItemDiscriminator? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputItemDiscriminatorType? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputReasoningItemType? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesOutputReasoningItemSummaryItem>? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputReasoningItemSummaryItem? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputReasoningItemSummaryItemType? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputReasoningItemStatus? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputMessageItemType? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputMessageItemRole? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesOutputMessageItemContentItem>? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputMessageItemContentItem? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputMessageItemContentItemType? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputMessageItemStatus? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputFunctionCallItemType? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputFunctionCallItemStatus? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputCustomToolCallItemType? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputCustomToolCallItemStatus? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputWebSearchCallItemType? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputWebSearchCallItemStatus? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputWebSearchCallItemAction? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputWebSearchCallItemActionType? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesOutputWebSearchCallItemActionSource>? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputWebSearchCallItemActionSource? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputWebSearchCallItemActionSourceType? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesOutputWebSearchCallItemResult>? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputWebSearchCallItemResult? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputWebSearchCallItemResultType? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesUsageInputTokensDetails? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesUsageOutputTokensDetails? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesStreamEvent? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesStreamEventType? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.BalanceResponse? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.BalanceResponseData? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.EstimateTokenRequest? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.EstimateTokenRequestModel? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.EstimateTokenResponse? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.EstimateTokenResponseData? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.SignatureVerifyRequest? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.SignatureVerifyResponse? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.FileObject? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.FileObjectPurpose? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.FileListResponse? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.FileObject>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.FileDeleteResponse? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.BatchCreateRequest? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.BatchCreateRequestEndpoint? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.BatchRequestCounts? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.BatchObject? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.BatchObjectStatus? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.BatchListResponse? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.BatchObject>? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ToolsSearchRequest? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ToolsSearchResponse? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ToolsSearchResult>? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ToolsSearchResult? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ToolsSearchProRequest? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ToolsSearchTimeWindow? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ToolsSearchProResponse? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ToolsSearchProResult>? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ToolsSearchProResult? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ToolsSearchProChunk>? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ToolsSearchProChunk? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ToolsFetchRequest? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ToolsFetchResponse? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ErrorResponse? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ErrorResponseError? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesTextBlockParam? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesTextBlockParamType? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParam? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamRole? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemText? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemTextType? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemImage? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemImageType? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemImageSource? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemImageSourceType? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemImageSourceMediaType? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemThinking? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemThinkingType? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolUse? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolUseType? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolResult? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultType? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemText? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemTextType? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImage? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageType? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSource? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceType? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceMediaType? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesTool? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesToolType? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesToolChoice? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesToolChoiceType? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesRequest? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesRequestModel? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.MessagesMessageParam>? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.MessagesTextBlockParam>>? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.MessagesTextBlockParam>? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.MessagesTool>? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesRequestMetadata? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesRequestCacheControl? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesRequestCacheControlType? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesRequestCacheControlTtl? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesRequestOutputConfig? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesRequestOutputConfigEffort? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesRequestOutputConfigFormat? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesRequestOutputConfigFormatType? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponse? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseType? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseRole? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessagesResponseContentItemThinking, global::Moonshot.MessagesResponseContentItemText, global::Moonshot.MessagesResponseContentItemToolUse>>? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.OneOf<global::Moonshot.MessagesResponseContentItemThinking, global::Moonshot.MessagesResponseContentItemText, global::Moonshot.MessagesResponseContentItemToolUse>? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseContentItemThinking? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseContentItemThinkingType? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseContentItemText? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseContentItemTextType? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseContentItemToolUse? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseContentItemToolUseType? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseStopReason? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseUsage? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseUsageCacheCreation? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseUsageOutputTokensDetails? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEvent? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageStart? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageStartType? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStart? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStartType? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStartContentBlockThinking? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStartContentBlockThinkingType? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStartContentBlockText? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStartContentBlockTextType? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStartContentBlockToolUse? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStartContentBlockToolUseType? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockDelta? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockDeltaType? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockDeltaDelta? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockDeltaDeltaType? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStop? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStopType? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageDelta? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageDeltaType? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageDeltaDelta? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageDeltaDeltaStopReason? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageDeltaUsage? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageDeltaUsageCacheCreation? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageDeltaUsageOutputTokensDetails? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageStop? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageStopType? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesErrorResponse? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesErrorResponseType? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesErrorResponseError? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.CreateFilesRequest? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.CreateFilesRequestPurpose? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.CreateChatCompletionsRequest? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.CreateChatCompletionsRequestDiscriminator? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.CreateChatCompletionsRequestDiscriminatorModel? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.GetModelsResponse? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.GetModelsResponseDataItem>? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.GetModelsResponseDataItem? Type363 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.OneOf<global::Moonshot.MessageContentVariant2ItemText, global::Moonshot.MessageContentVariant2ItemImageUrl, global::Moonshot.MessageContentVariant2ItemVideoUrl>>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.ToolDefinition>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.OneOf<string, global::System.Collections.Generic.List<object>>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.OneOf<string, global::System.Collections.Generic.List<string>>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.Message>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.KimiK3Message>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.ChatCompletionResponseChoice>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.ChatCompletionResponseChoiceMessageToolCall>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.ChoiceDelta>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.ChoiceDeltaDeltaToolCall>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.OneOf<string, global::System.Collections.Generic.List<global::Moonshot.ResponsesInputItem>>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.ResponsesInputItem>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.ResponsesTool>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.ResponsesRequestIncludeItem>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.OneOf<string, global::System.Collections.Generic.List<global::Moonshot.ResponsesInputContentPart>>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.ResponsesInputContentPart>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.ResponsesReasoningItemSummaryItem>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.ResponsesReasoningItemContentItem>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.OneOf<global::Moonshot.ResponsesFunctionTool, global::Moonshot.ResponsesCustomTool>>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.ResponsesWebSearchToolSearchContentType>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.ResponsesOutputItem>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.ResponsesOutputReasoningItemSummaryItem>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.ResponsesOutputMessageItemContentItem>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.ResponsesOutputWebSearchCallItemActionSource>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.ResponsesOutputWebSearchCallItemResult>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.FileObject>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.BatchObject>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.ToolsSearchResult>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.ToolsSearchProResult>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.ToolsSearchProChunk>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.MessagesMessageParam>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.OneOf<string, global::System.Collections.Generic.List<global::Moonshot.MessagesTextBlockParam>>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.MessagesTextBlockParam>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.MessagesTool>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.OneOf<global::Moonshot.MessagesResponseContentItemThinking, global::Moonshot.MessagesResponseContentItemText, global::Moonshot.MessagesResponseContentItemToolUse>>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.GetModelsResponseDataItem>? ListType37 { get; set; }
    }
}