
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
        public global::Moonshot.MoonshotV1ChatRequest? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MoonshotV1ChatRequestVariant2? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MoonshotV1ChatRequestVariant2Model? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK25ChatRequest? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK25ChatRequestVariant2? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK25ChatRequestVariant2Model? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK25ChatRequestVariant2Thinking? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK25ChatRequestVariant2ThinkingType? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK26ChatRequest? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK26ChatRequestVariant2? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK26ChatRequestVariant2Model? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK26ChatRequestVariant2Thinking? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK26ChatRequestVariant2ThinkingType? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK26ChatRequestVariant2ThinkingKeep? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK27CodeChatRequest? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK27CodeChatRequestVariant2? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK27CodeChatRequestVariant2Model? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK27CodeChatRequestVariant2Thinking? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK27CodeChatRequestVariant2ThinkingType? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK27CodeChatRequestVariant2ThinkingKeep? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionResponse? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ChatCompletionResponseChoice>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionResponseChoice? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionResponseChoiceMessage? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionResponseChoiceMessageRole? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ChatCompletionResponseChoiceMessageToolCall>? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionResponseChoiceMessageToolCall? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionResponseChoiceMessageToolCallType? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionResponseChoiceMessageToolCallFunction? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionResponseChoiceFinishReason? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionResponseUsage? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionChunk? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ChoiceDelta>? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChoiceDelta? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatCompletionChunkUsage? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChoiceDeltaDelta? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.ChoiceDeltaDeltaToolCall>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChoiceDeltaDeltaToolCall? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChoiceDeltaDeltaToolCallType? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChoiceDeltaDeltaToolCallFunction? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChoiceDeltaFinishReason? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChoiceDeltaUsage? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.BalanceResponse? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.BalanceResponseData? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.EstimateTokenRequest? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.EstimateTokenRequestModel? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.EstimateTokenResponse? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.EstimateTokenResponseData? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.FileObject? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.FileObjectPurpose? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.FileListResponse? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.FileObject>? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.FileDeleteResponse? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.BatchCreateRequest? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.BatchCreateRequestEndpoint? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.BatchRequestCounts? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.BatchObject? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.BatchObjectStatus? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.BatchListResponse? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.BatchObject>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ErrorResponse? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ErrorResponseError? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesTextBlockParam? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesTextBlockParamType? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParam? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamRole? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemText? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemTextType? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemImage? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemImageType? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemImageSource? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemImageSourceType? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemImageSourceMediaType? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemThinking? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemThinkingType? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolUse? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolUseType? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolResult? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultType? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemText? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemTextType? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImage? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageType? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSource? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceType? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceMediaType? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesTool? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesToolType? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesToolChoice? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesToolChoiceType? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesRequest? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesRequestModel? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.MessagesMessageParam>? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.MessagesTextBlockParam>>? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.MessagesTextBlockParam>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.MessagesTool>? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesRequestMetadata? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesRequestOutputConfig? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesRequestOutputConfigEffort? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesRequestOutputConfigFormat? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesRequestOutputConfigFormatType? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponse? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseType? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseRole? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessagesResponseContentItemThinking, global::Moonshot.MessagesResponseContentItemText, global::Moonshot.MessagesResponseContentItemToolUse>>? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.OneOf<global::Moonshot.MessagesResponseContentItemThinking, global::Moonshot.MessagesResponseContentItemText, global::Moonshot.MessagesResponseContentItemToolUse>? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseContentItemThinking? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseContentItemThinkingType? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseContentItemText? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseContentItemTextType? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseContentItemToolUse? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseContentItemToolUseType? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseStopReason? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseUsage? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesResponseUsageOutputTokensDetails? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEvent? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageStart? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageStartType? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStart? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStartType? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStartContentBlockThinking? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStartContentBlockThinkingType? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStartContentBlockText? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStartContentBlockTextType? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStartContentBlockToolUse? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStartContentBlockToolUseType? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockDelta? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockDeltaType? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockDeltaDelta? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockDeltaDeltaType? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStop? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStopType? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageDelta? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageDeltaType? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageDeltaDelta? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageDeltaDeltaStopReason? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageDeltaUsage? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageDeltaUsageOutputTokensDetails? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageStop? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageStopType? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesErrorResponse? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesErrorResponseType? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesErrorResponseError? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.CreateFilesRequest? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.CreateFilesRequestPurpose? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.CreateChatCompletionsRequest? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.CreateChatCompletionsRequestDiscriminator? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.CreateChatCompletionsRequestDiscriminatorModel? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.GetModelsResponse? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Moonshot.GetModelsResponseDataItem>? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.GetModelsResponseDataItem? Type214 { get; set; }

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
        public global::System.Collections.Generic.List<global::Moonshot.FileObject>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.BatchObject>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.MessagesMessageParam>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.OneOf<string, global::System.Collections.Generic.List<global::Moonshot.MessagesTextBlockParam>>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.MessagesTextBlockParam>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.MessagesTool>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.OneOf<global::Moonshot.MessagesResponseContentItemThinking, global::Moonshot.MessagesResponseContentItemText, global::Moonshot.MessagesResponseContentItemToolUse>>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Moonshot.GetModelsResponseDataItem>? ListType19 { get; set; }
    }
}