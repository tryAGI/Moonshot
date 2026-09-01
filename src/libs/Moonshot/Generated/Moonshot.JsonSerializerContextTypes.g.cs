
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
        public global::Moonshot.OneOf<global::Moonshot.ChatRequestCommonToolChoiceEnum?, global::Moonshot.ChatRequestCommonToolChoiceEnum2>? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestCommonToolChoiceEnum? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestCommonToolChoiceEnum2? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestCommonToolChoiceEnumType? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestCommonToolChoiceEnumFunction? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestBase? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestBasePrediction? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestBasePredictionType? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.Message>? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestBaseResponseFormat? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestBaseResponseFormatType? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestBaseResponseFormatJsonSchema? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestBaseStreamOptions? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.OneOf<global::Moonshot.ChatRequestBaseToolChoiceEnum?, global::Moonshot.ChatRequestBaseToolChoiceEnum2>? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestBaseToolChoiceEnum? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestBaseToolChoiceEnum2? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestBaseToolChoiceEnumType? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestBaseToolChoiceEnumFunction? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK3ChatRequest? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK3ChatRequestVariant2? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK3ChatRequestVariant2Model? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.KimiK3Message>? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK3ChatRequestVariant2ReasoningEffort? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK26ChatRequest? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK26ChatRequestVariant2? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK26ChatRequestVariant2Model? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK26ChatRequestVariant2Thinking? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK26ChatRequestVariant2ThinkingType? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK26ChatRequestVariant2ThinkingKeep? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK27CodeChatRequest? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK27CodeChatRequestVariant2? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK27CodeChatRequestVariant2Model? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK27CodeChatRequestVariant2Thinking? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK27CodeChatRequestVariant2ThinkingType? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK27CodeChatRequestVariant2ThinkingKeep? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionResponse? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ChatCompletionResponseChoice>? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionResponseChoice? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionResponseChoiceMessage? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionResponseChoiceMessageRole? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ChatCompletionResponseChoiceMessageToolCall>? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionResponseChoiceMessageToolCall? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionResponseChoiceMessageToolCallType? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionResponseChoiceMessageToolCallFunction? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionResponseChoiceFinishReason? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionResponseUsage? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionChunk? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ChoiceDelta>? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChoiceDelta? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionChunkUsage? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChoiceDeltaDelta? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ChoiceDeltaDeltaToolCall>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChoiceDeltaDeltaToolCall? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChoiceDeltaDeltaToolCallType? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChoiceDeltaDeltaToolCallFunction? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChoiceDeltaFinishReason? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChoiceDeltaUsage? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesRequest? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.ResponsesInputItem>>? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesInputItem>? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesInputItem? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesRequestReasoning? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesRequestReasoningEffort? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesRequestText? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesRequestTextFormat? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesRequestTextFormatType? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesTool>? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesTool? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesToolChoice? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesMessageItem? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesReasoningItem? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesFunctionCallItem? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesFunctionCallOutputItem? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesAdditionalToolsItem? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesMessageItemType? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesMessageItemRole? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.ResponsesInputContentPart>>? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesInputContentPart>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesInputContentPart? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesMessageItemStatus? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesReasoningItemType? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesReasoningItemSummaryItem>? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesReasoningItemSummaryItem? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesReasoningItemSummaryItemType? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesReasoningItemContentItem>? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesReasoningItemContentItem? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesReasoningItemContentItemType? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesReasoningItemStatus? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesFunctionCallItemType? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesFunctionCallItemStatus? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesFunctionCallOutputItemType? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesFunctionCallOutputItemStatus? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesAdditionalToolsItemType? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesAdditionalToolsItemRole? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesInputContentPartInputText? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesInputContentPartInputTextType? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesInputContentPartInputImage? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesInputContentPartInputImageType? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesInputContentPartInputImageDetail? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesInputContentPartOutputText? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesInputContentPartOutputTextType? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesFunctionTool? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesNamespaceTool? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesToolDiscriminator? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesToolDiscriminatorType? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesFunctionToolType? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesNamespaceToolType? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesFunctionTool>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesResponse? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesResponseObject? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesResponseStatus? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesOutputItem>? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputItem? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesUsage? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesResponseIncompleteDetails? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesResponseIncompleteDetailsReason? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesResponseError? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputReasoningItem? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputMessageItem? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputFunctionCallItem? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputItemDiscriminator? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputItemDiscriminatorType? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputReasoningItemType? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesOutputReasoningItemSummaryItem>? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputReasoningItemSummaryItem? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputReasoningItemSummaryItemType? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputReasoningItemStatus? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputMessageItemType? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputMessageItemRole? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesOutputMessageItemContentItem>? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputMessageItemContentItem? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputMessageItemContentItemType? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputMessageItemStatus? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputFunctionCallItemType? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputFunctionCallItemStatus? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesUsageInputTokensDetails? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesUsageOutputTokensDetails? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesStreamEvent? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesStreamEventType? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.BalanceResponse? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.BalanceResponseData? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.EstimateTokenRequest? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.EstimateTokenRequestModel? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.EstimateTokenResponse? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.EstimateTokenResponseData? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.SignatureVerifyRequest? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.SignatureVerifyResponse? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.FileObject? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.FileObjectPurpose? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.FileListResponse? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.FileObject>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.FileDeleteResponse? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.BatchCreateRequest? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.BatchCreateRequestEndpoint? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.BatchRequestCounts? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.BatchObject? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.BatchObjectStatus? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.BatchListResponse? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.BatchObject>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ErrorResponse? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ErrorResponseError? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesTextBlockParam? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesTextBlockParamType? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParam? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamRole? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemText? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemTextType? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemImage? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemImageType? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemImageSource? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemImageSourceType? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemImageSourceMediaType? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemThinking? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemThinkingType? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolUse? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolUseType? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolResult? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultType? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemText? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemTextType? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImage? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageType? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSource? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceType? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceMediaType? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesTool? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesToolType? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesToolChoice? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesToolChoiceType? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesRequest? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesRequestModel? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.MessagesMessageParam>? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.MessagesTextBlockParam>>? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.MessagesTextBlockParam>? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.MessagesTool>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesRequestMetadata? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesRequestOutputConfig? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesRequestOutputConfigEffort? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesRequestOutputConfigFormat? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesRequestOutputConfigFormatType? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponse? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseType? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseRole? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessagesResponseContentItemThinking, global::Moonshot.MessagesResponseContentItemText, global::Moonshot.MessagesResponseContentItemToolUse>>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.OneOf<global::Moonshot.MessagesResponseContentItemThinking, global::Moonshot.MessagesResponseContentItemText, global::Moonshot.MessagesResponseContentItemToolUse>? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseContentItemThinking? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseContentItemThinkingType? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseContentItemText? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseContentItemTextType? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseContentItemToolUse? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseContentItemToolUseType? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseStopReason? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseUsage? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseUsageOutputTokensDetails? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEvent? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageStart? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageStartType? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStart? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStartType? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStartContentBlockThinking? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStartContentBlockThinkingType? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStartContentBlockText? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStartContentBlockTextType? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStartContentBlockToolUse? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStartContentBlockToolUseType? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockDelta? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockDeltaType? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockDeltaDelta? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockDeltaDeltaType? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStop? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStopType? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageDelta? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageDeltaType? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageDeltaDelta? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageDeltaDeltaStopReason? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageDeltaUsage? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageDeltaUsageOutputTokensDetails? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageStop? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageStopType? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesErrorResponse? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesErrorResponseType? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesErrorResponseError? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.CreateFilesRequest? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.CreateFilesRequestPurpose? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.CreateChatCompletionsRequest? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.CreateChatCompletionsRequestDiscriminator? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.CreateChatCompletionsRequestDiscriminatorModel? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.GetModelsResponse? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.GetModelsResponseDataItem>? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.GetModelsResponseDataItem? Type291 { get; set; }

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
        public global::Moonshot.OneOf<string, global::System.Collections.Generic.List<global::Moonshot.ResponsesInputContentPart>>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.ResponsesInputContentPart>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.ResponsesReasoningItemSummaryItem>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.ResponsesReasoningItemContentItem>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.ResponsesFunctionTool>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.ResponsesOutputItem>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.ResponsesOutputReasoningItemSummaryItem>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.ResponsesOutputMessageItemContentItem>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.FileObject>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.BatchObject>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.MessagesMessageParam>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.OneOf<string, global::System.Collections.Generic.List<global::Moonshot.MessagesTextBlockParam>>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.MessagesTextBlockParam>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.MessagesTool>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.OneOf<global::Moonshot.MessagesResponseContentItemThinking, global::Moonshot.MessagesResponseContentItemText, global::Moonshot.MessagesResponseContentItemToolUse>>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.GetModelsResponseDataItem>? ListType30 { get; set; }
    }
}