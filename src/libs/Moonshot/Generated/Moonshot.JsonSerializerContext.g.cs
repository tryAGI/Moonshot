
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Moonshot.JsonConverters.MessageRoleJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessageRoleNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessageContentVariant2ItemTextTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessageContentVariant2ItemTextTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessageContentVariant2ItemImageUrlTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessageContentVariant2ItemImageUrlTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessageContentVariant2ItemVideoUrlTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessageContentVariant2ItemVideoUrlTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ToolDefinitionTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ToolDefinitionTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK3DynamicToolMessageRoleJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK3DynamicToolMessageRoleNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatRequestCommonPredictionTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatRequestCommonPredictionTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatRequestCommonResponseFormatTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatRequestCommonResponseFormatTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatRequestCommonToolChoiceEnumJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatRequestCommonToolChoiceEnumNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatRequestCommonToolChoiceEnumTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatRequestCommonToolChoiceEnumTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatRequestBasePredictionTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatRequestBasePredictionTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatRequestBaseResponseFormatTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatRequestBaseResponseFormatTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatRequestBaseToolChoiceEnumJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatRequestBaseToolChoiceEnumNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatRequestBaseToolChoiceEnumTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatRequestBaseToolChoiceEnumTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK3ChatRequestVariant2ModelJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK3ChatRequestVariant2ModelNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK3ChatRequestVariant2ReasoningEffortJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK3ChatRequestVariant2ReasoningEffortNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK26ChatRequestVariant2ModelJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK26ChatRequestVariant2ModelNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK26ChatRequestVariant2ThinkingTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK26ChatRequestVariant2ThinkingTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK26ChatRequestVariant2ThinkingKeepJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK26ChatRequestVariant2ThinkingKeepNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK27CodeChatRequestVariant2ModelJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK27CodeChatRequestVariant2ModelNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK27CodeChatRequestVariant2ThinkingTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK27CodeChatRequestVariant2ThinkingTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK27CodeChatRequestVariant2ThinkingKeepJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK27CodeChatRequestVariant2ThinkingKeepNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatCompletionResponseChoiceMessageRoleJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatCompletionResponseChoiceMessageRoleNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatCompletionResponseChoiceMessageToolCallTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatCompletionResponseChoiceMessageToolCallTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatCompletionResponseChoiceFinishReasonJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatCompletionResponseChoiceFinishReasonNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChoiceDeltaDeltaToolCallTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChoiceDeltaDeltaToolCallTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChoiceDeltaFinishReasonJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChoiceDeltaFinishReasonNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesRequestReasoningEffortJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesRequestReasoningEffortNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesRequestTextFormatTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesRequestTextFormatTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesMessageItemTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesMessageItemTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesMessageItemRoleJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesMessageItemRoleNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesMessageItemStatusJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesMessageItemStatusNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesReasoningItemTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesReasoningItemTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesReasoningItemSummaryItemTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesReasoningItemSummaryItemTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesReasoningItemContentItemTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesReasoningItemContentItemTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesReasoningItemStatusJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesReasoningItemStatusNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesFunctionCallItemTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesFunctionCallItemTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesFunctionCallItemStatusJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesFunctionCallItemStatusNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesFunctionCallOutputItemTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesFunctionCallOutputItemTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesFunctionCallOutputItemStatusJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesFunctionCallOutputItemStatusNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesAdditionalToolsItemTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesAdditionalToolsItemTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesAdditionalToolsItemRoleJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesAdditionalToolsItemRoleNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesInputContentPartInputTextTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesInputContentPartInputTextTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesInputContentPartInputImageTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesInputContentPartInputImageTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesInputContentPartInputImageDetailJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesInputContentPartInputImageDetailNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesInputContentPartOutputTextTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesInputContentPartOutputTextTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesToolDiscriminatorTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesFunctionToolTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesFunctionToolTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesNamespaceToolTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesNamespaceToolTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesToolChoiceJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesToolChoiceNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesResponseObjectJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesResponseObjectNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesResponseStatusJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesResponseStatusNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesResponseIncompleteDetailsReasonJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesResponseIncompleteDetailsReasonNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesOutputItemDiscriminatorTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesOutputItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesOutputReasoningItemTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesOutputReasoningItemTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesOutputReasoningItemSummaryItemTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesOutputReasoningItemSummaryItemTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesOutputReasoningItemStatusJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesOutputReasoningItemStatusNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesOutputMessageItemTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesOutputMessageItemTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesOutputMessageItemRoleJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesOutputMessageItemRoleNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesOutputMessageItemContentItemTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesOutputMessageItemContentItemTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesOutputMessageItemStatusJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesOutputMessageItemStatusNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesOutputFunctionCallItemTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesOutputFunctionCallItemTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesOutputFunctionCallItemStatusJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesOutputFunctionCallItemStatusNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesStreamEventTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesStreamEventTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.EstimateTokenRequestModelJsonConverter),

            typeof(global::Moonshot.JsonConverters.EstimateTokenRequestModelNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.FileObjectPurposeJsonConverter),

            typeof(global::Moonshot.JsonConverters.FileObjectPurposeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.BatchCreateRequestEndpointJsonConverter),

            typeof(global::Moonshot.JsonConverters.BatchCreateRequestEndpointNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.BatchObjectStatusJsonConverter),

            typeof(global::Moonshot.JsonConverters.BatchObjectStatusNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesTextBlockParamTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesTextBlockParamTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesMessageParamRoleJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesMessageParamRoleNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesMessageParamContentVariant2ItemTextTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesMessageParamContentVariant2ItemTextTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesMessageParamContentVariant2ItemImageTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesMessageParamContentVariant2ItemImageTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesMessageParamContentVariant2ItemImageSourceTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesMessageParamContentVariant2ItemImageSourceTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesMessageParamContentVariant2ItemImageSourceMediaTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesMessageParamContentVariant2ItemImageSourceMediaTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesMessageParamContentVariant2ItemThinkingTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesMessageParamContentVariant2ItemThinkingTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesMessageParamContentVariant2ItemToolUseTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesMessageParamContentVariant2ItemToolUseTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesMessageParamContentVariant2ItemToolResultTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesMessageParamContentVariant2ItemToolResultTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemTextTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemTextTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceMediaTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceMediaTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesToolTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesToolTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesToolChoiceTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesToolChoiceTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesRequestModelJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesRequestModelNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesRequestOutputConfigEffortJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesRequestOutputConfigEffortNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesRequestOutputConfigFormatTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesRequestOutputConfigFormatTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesResponseTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesResponseTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesResponseRoleJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesResponseRoleNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesResponseContentItemThinkingTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesResponseContentItemThinkingTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesResponseContentItemTextTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesResponseContentItemTextTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesResponseContentItemToolUseTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesResponseContentItemToolUseTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesResponseStopReasonJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesResponseStopReasonNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesStreamEventMessageStartTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesStreamEventMessageStartTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesStreamEventContentBlockStartTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesStreamEventContentBlockStartTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesStreamEventContentBlockStartContentBlockThinkingTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesStreamEventContentBlockStartContentBlockThinkingTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesStreamEventContentBlockStartContentBlockTextTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesStreamEventContentBlockStartContentBlockTextTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesStreamEventContentBlockStartContentBlockToolUseTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesStreamEventContentBlockStartContentBlockToolUseTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesStreamEventContentBlockDeltaTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesStreamEventContentBlockDeltaTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesStreamEventContentBlockDeltaDeltaTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesStreamEventContentBlockDeltaDeltaTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesStreamEventContentBlockStopTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesStreamEventContentBlockStopTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesStreamEventMessageDeltaTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesStreamEventMessageDeltaTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesStreamEventMessageDeltaDeltaStopReasonJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesStreamEventMessageDeltaDeltaStopReasonNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesStreamEventMessageStopTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesStreamEventMessageStopTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesErrorResponseTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesErrorResponseTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.CreateFilesRequestPurposeJsonConverter),

            typeof(global::Moonshot.JsonConverters.CreateFilesRequestPurposeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.CreateChatCompletionsRequestDiscriminatorModelJsonConverter),

            typeof(global::Moonshot.JsonConverters.CreateChatCompletionsRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK3MessageJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK3ChatRequestJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK26ChatRequestJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK27CodeChatRequestJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesInputItemJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesInputContentPartJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesToolJsonConverter),

            typeof(global::Moonshot.JsonConverters.ResponsesOutputItemJsonConverter),

            typeof(global::Moonshot.JsonConverters.MessagesStreamEventJsonConverter),

            typeof(global::Moonshot.JsonConverters.CreateChatCompletionsRequestJsonConverter),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessageContentVariant2ItemText, global::Moonshot.MessageContentVariant2ItemImageUrl, global::Moonshot.MessageContentVariant2ItemVideoUrl>>>),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<global::Moonshot.MessageContentVariant2ItemText, global::Moonshot.MessageContentVariant2ItemImageUrl, global::Moonshot.MessageContentVariant2ItemVideoUrl>),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<global::Moonshot.MessageContentVariant2ItemImageUrlImageUrl, string>),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<global::Moonshot.MessageContentVariant2ItemVideoUrlVideoUrl, string>),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<object>>),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<global::Moonshot.ChatRequestCommonToolChoiceEnum?, global::Moonshot.ChatRequestCommonToolChoiceEnum2>),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<object>>),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<global::Moonshot.ChatRequestBaseToolChoiceEnum?, global::Moonshot.ChatRequestBaseToolChoiceEnum2>),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Moonshot.ResponsesInputItem>>),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Moonshot.ResponsesInputContentPart>>),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Moonshot.ResponsesInputContentPart>>),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessagesMessageParamContentVariant2ItemText, global::Moonshot.MessagesMessageParamContentVariant2ItemImage, global::Moonshot.MessagesMessageParamContentVariant2ItemThinking, global::Moonshot.MessagesMessageParamContentVariant2ItemToolUse, global::Moonshot.MessagesMessageParamContentVariant2ItemToolResult>>>),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<global::Moonshot.MessagesMessageParamContentVariant2ItemText, global::Moonshot.MessagesMessageParamContentVariant2ItemImage, global::Moonshot.MessagesMessageParamContentVariant2ItemThinking, global::Moonshot.MessagesMessageParamContentVariant2ItemToolUse, global::Moonshot.MessagesMessageParamContentVariant2ItemToolResult>),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemText, global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImage>>>),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemText, global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImage>),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Moonshot.MessagesTextBlockParam>>),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<global::Moonshot.MessagesResponseContentItemThinking, global::Moonshot.MessagesResponseContentItemText, global::Moonshot.MessagesResponseContentItemToolUse>),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<global::Moonshot.MessagesStreamEventContentBlockStartContentBlockThinking, global::Moonshot.MessagesStreamEventContentBlockStartContentBlockText, global::Moonshot.MessagesStreamEventContentBlockStartContentBlockToolUse>),

            typeof(global::Moonshot.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.Message))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessageRole), TypeInfoPropertyName = "MessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessageContentVariant2ItemText, global::Moonshot.MessageContentVariant2ItemImageUrl, global::Moonshot.MessageContentVariant2ItemVideoUrl>>>), TypeInfoPropertyName = "OneOfStringIListOneOfMessageContentVariant2ItemTextMessageContentVariant2ItemImageUrlMessageContentVariant2ItemVideoUrl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessageContentVariant2ItemText, global::Moonshot.MessageContentVariant2ItemImageUrl, global::Moonshot.MessageContentVariant2ItemVideoUrl>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<global::Moonshot.MessageContentVariant2ItemText, global::Moonshot.MessageContentVariant2ItemImageUrl, global::Moonshot.MessageContentVariant2ItemVideoUrl>), TypeInfoPropertyName = "OneOfMessageContentVariant2ItemTextMessageContentVariant2ItemImageUrlMessageContentVariant2ItemVideoUrl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessageContentVariant2ItemText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessageContentVariant2ItemTextType), TypeInfoPropertyName = "MessageContentVariant2ItemTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessageContentVariant2ItemImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessageContentVariant2ItemImageUrlType), TypeInfoPropertyName = "MessageContentVariant2ItemImageUrlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<global::Moonshot.MessageContentVariant2ItemImageUrlImageUrl, string>), TypeInfoPropertyName = "OneOfMessageContentVariant2ItemImageUrlImageUrlString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessageContentVariant2ItemImageUrlImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessageContentVariant2ItemVideoUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessageContentVariant2ItemVideoUrlType), TypeInfoPropertyName = "MessageContentVariant2ItemVideoUrlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<global::Moonshot.MessageContentVariant2ItemVideoUrlVideoUrl, string>), TypeInfoPropertyName = "OneOfMessageContentVariant2ItemVideoUrlVideoUrlString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessageContentVariant2ItemVideoUrlVideoUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ToolDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ToolDefinitionType), TypeInfoPropertyName = "ToolDefinitionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ToolDefinitionFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK3DynamicToolMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK3DynamicToolMessageRole), TypeInfoPropertyName = "KimiK3DynamicToolMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Moonshot.ToolDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK3Message), TypeInfoPropertyName = "KimiK3Message2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestCommon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestCommonPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestCommonPredictionType), TypeInfoPropertyName = "ChatRequestCommonPredictionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<object>>), TypeInfoPropertyName = "OneOfStringIListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestCommonResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestCommonResponseFormatType), TypeInfoPropertyName = "ChatRequestCommonResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestCommonResponseFormatJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestCommonStreamOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<global::Moonshot.ChatRequestCommonToolChoiceEnum?, global::Moonshot.ChatRequestCommonToolChoiceEnum2>), TypeInfoPropertyName = "OneOfChatRequestCommonToolChoiceEnumChatRequestCommonToolChoiceEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestCommonToolChoiceEnum), TypeInfoPropertyName = "ChatRequestCommonToolChoiceEnum2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestCommonToolChoiceEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestCommonToolChoiceEnumType), TypeInfoPropertyName = "ChatRequestCommonToolChoiceEnumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestCommonToolChoiceEnumFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestBasePrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestBasePredictionType), TypeInfoPropertyName = "ChatRequestBasePredictionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Moonshot.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestBaseResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestBaseResponseFormatType), TypeInfoPropertyName = "ChatRequestBaseResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestBaseResponseFormatJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestBaseStreamOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<global::Moonshot.ChatRequestBaseToolChoiceEnum?, global::Moonshot.ChatRequestBaseToolChoiceEnum2>), TypeInfoPropertyName = "OneOfChatRequestBaseToolChoiceEnumChatRequestBaseToolChoiceEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestBaseToolChoiceEnum), TypeInfoPropertyName = "ChatRequestBaseToolChoiceEnum2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestBaseToolChoiceEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestBaseToolChoiceEnumType), TypeInfoPropertyName = "ChatRequestBaseToolChoiceEnumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestBaseToolChoiceEnumFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK3ChatRequest), TypeInfoPropertyName = "KimiK3ChatRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK3ChatRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK3ChatRequestVariant2Model), TypeInfoPropertyName = "KimiK3ChatRequestVariant2Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Moonshot.KimiK3Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK3ChatRequestVariant2ReasoningEffort), TypeInfoPropertyName = "KimiK3ChatRequestVariant2ReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK26ChatRequest), TypeInfoPropertyName = "KimiK26ChatRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK26ChatRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK26ChatRequestVariant2Model), TypeInfoPropertyName = "KimiK26ChatRequestVariant2Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK26ChatRequestVariant2Thinking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK26ChatRequestVariant2ThinkingType), TypeInfoPropertyName = "KimiK26ChatRequestVariant2ThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK26ChatRequestVariant2ThinkingKeep), TypeInfoPropertyName = "KimiK26ChatRequestVariant2ThinkingKeep2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK27CodeChatRequest), TypeInfoPropertyName = "KimiK27CodeChatRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK27CodeChatRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK27CodeChatRequestVariant2Model), TypeInfoPropertyName = "KimiK27CodeChatRequestVariant2Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK27CodeChatRequestVariant2Thinking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK27CodeChatRequestVariant2ThinkingType), TypeInfoPropertyName = "KimiK27CodeChatRequestVariant2ThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK27CodeChatRequestVariant2ThinkingKeep), TypeInfoPropertyName = "KimiK27CodeChatRequestVariant2ThinkingKeep2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Moonshot.ChatCompletionResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatCompletionResponseChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatCompletionResponseChoiceMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatCompletionResponseChoiceMessageRole), TypeInfoPropertyName = "ChatCompletionResponseChoiceMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Moonshot.ChatCompletionResponseChoiceMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatCompletionResponseChoiceMessageToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatCompletionResponseChoiceMessageToolCallType), TypeInfoPropertyName = "ChatCompletionResponseChoiceMessageToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatCompletionResponseChoiceMessageToolCallFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatCompletionResponseChoiceFinishReason), TypeInfoPropertyName = "ChatCompletionResponseChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatCompletionResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatCompletionChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Moonshot.ChoiceDelta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChoiceDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatCompletionChunkUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChoiceDeltaDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Moonshot.ChoiceDeltaDeltaToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChoiceDeltaDeltaToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChoiceDeltaDeltaToolCallType), TypeInfoPropertyName = "ChoiceDeltaDeltaToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChoiceDeltaDeltaToolCallFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChoiceDeltaFinishReason), TypeInfoPropertyName = "ChoiceDeltaFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChoiceDeltaUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.ResponsesInputItem>>), TypeInfoPropertyName = "OneOfStringIListResponsesInputItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Moonshot.ResponsesInputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesInputItem), TypeInfoPropertyName = "ResponsesInputItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesRequestReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesRequestReasoningEffort), TypeInfoPropertyName = "ResponsesRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesRequestText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesRequestTextFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesRequestTextFormatType), TypeInfoPropertyName = "ResponsesRequestTextFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Moonshot.ResponsesTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesTool), TypeInfoPropertyName = "ResponsesTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesToolChoice), TypeInfoPropertyName = "ResponsesToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesMessageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesReasoningItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesFunctionCallItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesFunctionCallOutputItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesAdditionalToolsItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesMessageItemType), TypeInfoPropertyName = "ResponsesMessageItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesMessageItemRole), TypeInfoPropertyName = "ResponsesMessageItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.ResponsesInputContentPart>>), TypeInfoPropertyName = "OneOfStringIListResponsesInputContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Moonshot.ResponsesInputContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesInputContentPart), TypeInfoPropertyName = "ResponsesInputContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesMessageItemStatus), TypeInfoPropertyName = "ResponsesMessageItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesReasoningItemType), TypeInfoPropertyName = "ResponsesReasoningItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Moonshot.ResponsesReasoningItemSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesReasoningItemSummaryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesReasoningItemSummaryItemType), TypeInfoPropertyName = "ResponsesReasoningItemSummaryItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Moonshot.ResponsesReasoningItemContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesReasoningItemContentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesReasoningItemContentItemType), TypeInfoPropertyName = "ResponsesReasoningItemContentItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesReasoningItemStatus), TypeInfoPropertyName = "ResponsesReasoningItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesFunctionCallItemType), TypeInfoPropertyName = "ResponsesFunctionCallItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesFunctionCallItemStatus), TypeInfoPropertyName = "ResponsesFunctionCallItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesFunctionCallOutputItemType), TypeInfoPropertyName = "ResponsesFunctionCallOutputItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesFunctionCallOutputItemStatus), TypeInfoPropertyName = "ResponsesFunctionCallOutputItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesAdditionalToolsItemType), TypeInfoPropertyName = "ResponsesAdditionalToolsItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesAdditionalToolsItemRole), TypeInfoPropertyName = "ResponsesAdditionalToolsItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesInputContentPartInputText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesInputContentPartInputTextType), TypeInfoPropertyName = "ResponsesInputContentPartInputTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesInputContentPartInputImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesInputContentPartInputImageType), TypeInfoPropertyName = "ResponsesInputContentPartInputImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesInputContentPartInputImageDetail), TypeInfoPropertyName = "ResponsesInputContentPartInputImageDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesInputContentPartOutputText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesInputContentPartOutputTextType), TypeInfoPropertyName = "ResponsesInputContentPartOutputTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesFunctionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesNamespaceTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesToolDiscriminatorType), TypeInfoPropertyName = "ResponsesToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesFunctionToolType), TypeInfoPropertyName = "ResponsesFunctionToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesNamespaceToolType), TypeInfoPropertyName = "ResponsesNamespaceToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Moonshot.ResponsesFunctionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesResponseObject), TypeInfoPropertyName = "ResponsesResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesResponseStatus), TypeInfoPropertyName = "ResponsesResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Moonshot.ResponsesOutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesOutputItem), TypeInfoPropertyName = "ResponsesOutputItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesResponseIncompleteDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesResponseIncompleteDetailsReason), TypeInfoPropertyName = "ResponsesResponseIncompleteDetailsReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesOutputReasoningItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesOutputMessageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesOutputFunctionCallItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesOutputItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesOutputItemDiscriminatorType), TypeInfoPropertyName = "ResponsesOutputItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesOutputReasoningItemType), TypeInfoPropertyName = "ResponsesOutputReasoningItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Moonshot.ResponsesOutputReasoningItemSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesOutputReasoningItemSummaryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesOutputReasoningItemSummaryItemType), TypeInfoPropertyName = "ResponsesOutputReasoningItemSummaryItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesOutputReasoningItemStatus), TypeInfoPropertyName = "ResponsesOutputReasoningItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesOutputMessageItemType), TypeInfoPropertyName = "ResponsesOutputMessageItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesOutputMessageItemRole), TypeInfoPropertyName = "ResponsesOutputMessageItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Moonshot.ResponsesOutputMessageItemContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesOutputMessageItemContentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesOutputMessageItemContentItemType), TypeInfoPropertyName = "ResponsesOutputMessageItemContentItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesOutputMessageItemStatus), TypeInfoPropertyName = "ResponsesOutputMessageItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesOutputFunctionCallItemType), TypeInfoPropertyName = "ResponsesOutputFunctionCallItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesOutputFunctionCallItemStatus), TypeInfoPropertyName = "ResponsesOutputFunctionCallItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesUsageInputTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesUsageOutputTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesStreamEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ResponsesStreamEventType), TypeInfoPropertyName = "ResponsesStreamEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.BalanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.BalanceResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.EstimateTokenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.EstimateTokenRequestModel), TypeInfoPropertyName = "EstimateTokenRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.EstimateTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.EstimateTokenResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.FileObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.FileObjectPurpose), TypeInfoPropertyName = "FileObjectPurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.FileListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Moonshot.FileObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.FileDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.BatchCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.BatchCreateRequestEndpoint), TypeInfoPropertyName = "BatchCreateRequestEndpoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.BatchRequestCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.BatchObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.BatchObjectStatus), TypeInfoPropertyName = "BatchObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.BatchListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Moonshot.BatchObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ErrorResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesTextBlockParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesTextBlockParamType), TypeInfoPropertyName = "MessagesTextBlockParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesMessageParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesMessageParamRole), TypeInfoPropertyName = "MessagesMessageParamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessagesMessageParamContentVariant2ItemText, global::Moonshot.MessagesMessageParamContentVariant2ItemImage, global::Moonshot.MessagesMessageParamContentVariant2ItemThinking, global::Moonshot.MessagesMessageParamContentVariant2ItemToolUse, global::Moonshot.MessagesMessageParamContentVariant2ItemToolResult>>>), TypeInfoPropertyName = "MessagesMessageParamContentVariant2ItemToolResult_862ddc3e9f8653a7")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessagesMessageParamContentVariant2ItemText, global::Moonshot.MessagesMessageParamContentVariant2ItemImage, global::Moonshot.MessagesMessageParamContentVariant2ItemThinking, global::Moonshot.MessagesMessageParamContentVariant2ItemToolUse, global::Moonshot.MessagesMessageParamContentVariant2ItemToolResult>>), TypeInfoPropertyName = "MessagesMessageParamContentVariant2ItemToolResult_f48f112b6bf07113")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<global::Moonshot.MessagesMessageParamContentVariant2ItemText, global::Moonshot.MessagesMessageParamContentVariant2ItemImage, global::Moonshot.MessagesMessageParamContentVariant2ItemThinking, global::Moonshot.MessagesMessageParamContentVariant2ItemToolUse, global::Moonshot.MessagesMessageParamContentVariant2ItemToolResult>), TypeInfoPropertyName = "MessagesMessageParamContentVariant2ItemToolResult_156e6107fef75c78")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesMessageParamContentVariant2ItemText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesMessageParamContentVariant2ItemTextType), TypeInfoPropertyName = "MessagesMessageParamContentVariant2ItemTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesMessageParamContentVariant2ItemImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesMessageParamContentVariant2ItemImageType), TypeInfoPropertyName = "MessagesMessageParamContentVariant2ItemImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesMessageParamContentVariant2ItemImageSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesMessageParamContentVariant2ItemImageSourceType), TypeInfoPropertyName = "MessagesMessageParamContentVariant2ItemImageSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesMessageParamContentVariant2ItemImageSourceMediaType), TypeInfoPropertyName = "MessagesMessageParamContentVariant2ItemImageSourceMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesMessageParamContentVariant2ItemThinking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesMessageParamContentVariant2ItemThinkingType), TypeInfoPropertyName = "MessagesMessageParamContentVariant2ItemThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesMessageParamContentVariant2ItemToolUse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesMessageParamContentVariant2ItemToolUseType), TypeInfoPropertyName = "MessagesMessageParamContentVariant2ItemToolUseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesMessageParamContentVariant2ItemToolResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultType), TypeInfoPropertyName = "MessagesMessageParamContentVariant2ItemToolResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemText, global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImage>>>), TypeInfoPropertyName = "MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImage_5a79a47930101aac")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemText, global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImage>>), TypeInfoPropertyName = "MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImage_fcf2e06987e5da8f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemText, global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImage>), TypeInfoPropertyName = "MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImage_eb777cec0c628ee8")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemTextType), TypeInfoPropertyName = "MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageType), TypeInfoPropertyName = "MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceType), TypeInfoPropertyName = "MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceMediaType), TypeInfoPropertyName = "MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesToolType), TypeInfoPropertyName = "MessagesToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesToolChoiceType), TypeInfoPropertyName = "MessagesToolChoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesRequestModel), TypeInfoPropertyName = "MessagesRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Moonshot.MessagesMessageParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.MessagesTextBlockParam>>), TypeInfoPropertyName = "OneOfStringIListMessagesTextBlockParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Moonshot.MessagesTextBlockParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Moonshot.MessagesTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesRequestMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesRequestOutputConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesRequestOutputConfigEffort), TypeInfoPropertyName = "MessagesRequestOutputConfigEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesRequestOutputConfigFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesRequestOutputConfigFormatType), TypeInfoPropertyName = "MessagesRequestOutputConfigFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesResponseType), TypeInfoPropertyName = "MessagesResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesResponseRole), TypeInfoPropertyName = "MessagesResponseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessagesResponseContentItemThinking, global::Moonshot.MessagesResponseContentItemText, global::Moonshot.MessagesResponseContentItemToolUse>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<global::Moonshot.MessagesResponseContentItemThinking, global::Moonshot.MessagesResponseContentItemText, global::Moonshot.MessagesResponseContentItemToolUse>), TypeInfoPropertyName = "OneOfMessagesResponseContentItemThinkingMessagesResponseContentItemTextMessagesResponseContentItemToolUse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesResponseContentItemThinking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesResponseContentItemThinkingType), TypeInfoPropertyName = "MessagesResponseContentItemThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesResponseContentItemText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesResponseContentItemTextType), TypeInfoPropertyName = "MessagesResponseContentItemTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesResponseContentItemToolUse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesResponseContentItemToolUseType), TypeInfoPropertyName = "MessagesResponseContentItemToolUseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesResponseStopReason), TypeInfoPropertyName = "MessagesResponseStopReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesResponseUsageOutputTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesStreamEvent), TypeInfoPropertyName = "MessagesStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesStreamEventMessageStart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesStreamEventMessageStartType), TypeInfoPropertyName = "MessagesStreamEventMessageStartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesStreamEventContentBlockStart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesStreamEventContentBlockStartType), TypeInfoPropertyName = "MessagesStreamEventContentBlockStartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<global::Moonshot.MessagesStreamEventContentBlockStartContentBlockThinking, global::Moonshot.MessagesStreamEventContentBlockStartContentBlockText, global::Moonshot.MessagesStreamEventContentBlockStartContentBlockToolUse>), TypeInfoPropertyName = "MessagesStreamEventContentBlockStartContentBlockToolUse_383da0addf62373f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesStreamEventContentBlockStartContentBlockThinking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesStreamEventContentBlockStartContentBlockThinkingType), TypeInfoPropertyName = "MessagesStreamEventContentBlockStartContentBlockThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesStreamEventContentBlockStartContentBlockText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesStreamEventContentBlockStartContentBlockTextType), TypeInfoPropertyName = "MessagesStreamEventContentBlockStartContentBlockTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesStreamEventContentBlockStartContentBlockToolUse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesStreamEventContentBlockStartContentBlockToolUseType), TypeInfoPropertyName = "MessagesStreamEventContentBlockStartContentBlockToolUseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesStreamEventContentBlockDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesStreamEventContentBlockDeltaType), TypeInfoPropertyName = "MessagesStreamEventContentBlockDeltaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesStreamEventContentBlockDeltaDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesStreamEventContentBlockDeltaDeltaType), TypeInfoPropertyName = "MessagesStreamEventContentBlockDeltaDeltaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesStreamEventContentBlockStop))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesStreamEventContentBlockStopType), TypeInfoPropertyName = "MessagesStreamEventContentBlockStopType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesStreamEventMessageDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesStreamEventMessageDeltaType), TypeInfoPropertyName = "MessagesStreamEventMessageDeltaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesStreamEventMessageDeltaDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesStreamEventMessageDeltaDeltaStopReason), TypeInfoPropertyName = "MessagesStreamEventMessageDeltaDeltaStopReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesStreamEventMessageDeltaUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesStreamEventMessageDeltaUsageOutputTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesStreamEventMessageStop))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesStreamEventMessageStopType), TypeInfoPropertyName = "MessagesStreamEventMessageStopType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesErrorResponseType), TypeInfoPropertyName = "MessagesErrorResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessagesErrorResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.CreateFilesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.CreateFilesRequestPurpose), TypeInfoPropertyName = "CreateFilesRequestPurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.CreateChatCompletionsRequest), TypeInfoPropertyName = "CreateChatCompletionsRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.CreateChatCompletionsRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.CreateChatCompletionsRequestDiscriminatorModel), TypeInfoPropertyName = "CreateChatCompletionsRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.GetModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Moonshot.GetModelsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.GetModelsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessageContentVariant2ItemText, global::Moonshot.MessageContentVariant2ItemImageUrl, global::Moonshot.MessageContentVariant2ItemVideoUrl>>>?), TypeInfoPropertyName = "MessageContentVariant2ItemVideoUrl_5bae655494501c49")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessagesMessageParamContentVariant2ItemText, global::Moonshot.MessagesMessageParamContentVariant2ItemImage, global::Moonshot.MessagesMessageParamContentVariant2ItemThinking, global::Moonshot.MessagesMessageParamContentVariant2ItemToolUse, global::Moonshot.MessagesMessageParamContentVariant2ItemToolResult>>>?), TypeInfoPropertyName = "MessagesMessageParamContentVariant2ItemToolResult_35e0ee76ebb01d77")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<global::Moonshot.MessagesMessageParamContentVariant2ItemText, global::Moonshot.MessagesMessageParamContentVariant2ItemImage, global::Moonshot.MessagesMessageParamContentVariant2ItemThinking, global::Moonshot.MessagesMessageParamContentVariant2ItemToolUse, global::Moonshot.MessagesMessageParamContentVariant2ItemToolResult>?), TypeInfoPropertyName = "MessagesMessageParamContentVariant2ItemToolResult_58ffa822d68bcf8c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemText, global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImage>>>?), TypeInfoPropertyName = "MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImage_7745a1b79703f731")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemText, global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImage>?), TypeInfoPropertyName = "MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImage_b6bd440034c6bacf")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<global::Moonshot.MessagesStreamEventContentBlockStartContentBlockThinking, global::Moonshot.MessagesStreamEventContentBlockStartContentBlockText, global::Moonshot.MessagesStreamEventContentBlockStartContentBlockToolUse>?), TypeInfoPropertyName = "MessagesStreamEventContentBlockStartContentBlockToolUse_8b2c4e8fbdc60be7")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<string, global::System.Collections.Generic.List<global::Moonshot.OneOf<global::Moonshot.MessageContentVariant2ItemText, global::Moonshot.MessageContentVariant2ItemImageUrl, global::Moonshot.MessageContentVariant2ItemVideoUrl>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.OneOf<global::Moonshot.MessageContentVariant2ItemText, global::Moonshot.MessageContentVariant2ItemImageUrl, global::Moonshot.MessageContentVariant2ItemVideoUrl>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.ToolDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<string, global::System.Collections.Generic.List<object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.KimiK3Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.ChatCompletionResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.ChatCompletionResponseChoiceMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.ChoiceDelta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.ChoiceDeltaDeltaToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<string, global::System.Collections.Generic.List<global::Moonshot.ResponsesInputItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.ResponsesInputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.ResponsesTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<string, global::System.Collections.Generic.List<global::Moonshot.ResponsesInputContentPart>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.ResponsesInputContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.ResponsesReasoningItemSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.ResponsesReasoningItemContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.ResponsesFunctionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.ResponsesOutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.ResponsesOutputReasoningItemSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.ResponsesOutputMessageItemContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.FileObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.BatchObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<string, global::System.Collections.Generic.List<global::Moonshot.OneOf<global::Moonshot.MessagesMessageParamContentVariant2ItemText, global::Moonshot.MessagesMessageParamContentVariant2ItemImage, global::Moonshot.MessagesMessageParamContentVariant2ItemThinking, global::Moonshot.MessagesMessageParamContentVariant2ItemToolUse, global::Moonshot.MessagesMessageParamContentVariant2ItemToolResult>>>), TypeInfoPropertyName = "MessagesMessageParamContentVariant2ItemToolResult_26a2d5cd390b2230")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.OneOf<global::Moonshot.MessagesMessageParamContentVariant2ItemText, global::Moonshot.MessagesMessageParamContentVariant2ItemImage, global::Moonshot.MessagesMessageParamContentVariant2ItemThinking, global::Moonshot.MessagesMessageParamContentVariant2ItemToolUse, global::Moonshot.MessagesMessageParamContentVariant2ItemToolResult>>), TypeInfoPropertyName = "MessagesMessageParamContentVariant2ItemToolResult_25d6ad333667e8cb")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<string, global::System.Collections.Generic.List<global::Moonshot.OneOf<global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemText, global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImage>>>), TypeInfoPropertyName = "MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImage_3d221b39a2761bdb")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.OneOf<global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemText, global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImage>>), TypeInfoPropertyName = "MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImage_7e9f2e9f2b2325b7")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.MessagesMessageParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<string, global::System.Collections.Generic.List<global::Moonshot.MessagesTextBlockParam>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.MessagesTextBlockParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.MessagesTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.OneOf<global::Moonshot.MessagesResponseContentItemThinking, global::Moonshot.MessagesResponseContentItemText, global::Moonshot.MessagesResponseContentItemToolUse>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.GetModelsResponseDataItem>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}