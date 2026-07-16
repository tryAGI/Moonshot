
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

            typeof(global::Moonshot.JsonConverters.ChatRequestCommonResponseFormatTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatRequestCommonResponseFormatTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatRequestCommonToolChoiceEnumJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatRequestCommonToolChoiceEnumNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatRequestCommonToolChoiceEnumTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatRequestCommonToolChoiceEnumTypeNullableJsonConverter),

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

            typeof(global::Moonshot.JsonConverters.MoonshotV1ChatRequestVariant2ModelJsonConverter),

            typeof(global::Moonshot.JsonConverters.MoonshotV1ChatRequestVariant2ModelNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK25ChatRequestVariant2ModelJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK25ChatRequestVariant2ModelNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK25ChatRequestVariant2ThinkingTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK25ChatRequestVariant2ThinkingTypeNullableJsonConverter),

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

            typeof(global::Moonshot.JsonConverters.EstimateTokenRequestModelJsonConverter),

            typeof(global::Moonshot.JsonConverters.EstimateTokenRequestModelNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.FileObjectPurposeJsonConverter),

            typeof(global::Moonshot.JsonConverters.FileObjectPurposeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.BatchCreateRequestEndpointJsonConverter),

            typeof(global::Moonshot.JsonConverters.BatchCreateRequestEndpointNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.BatchObjectStatusJsonConverter),

            typeof(global::Moonshot.JsonConverters.BatchObjectStatusNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.CreateFilesRequestPurposeJsonConverter),

            typeof(global::Moonshot.JsonConverters.CreateFilesRequestPurposeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.CreateChatCompletionsRequestDiscriminatorModelJsonConverter),

            typeof(global::Moonshot.JsonConverters.CreateChatCompletionsRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK3MessageJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK3ChatRequestJsonConverter),

            typeof(global::Moonshot.JsonConverters.MoonshotV1ChatRequestJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK25ChatRequestJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK26ChatRequestJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK27CodeChatRequestJsonConverter),

            typeof(global::Moonshot.JsonConverters.CreateChatCompletionsRequestJsonConverter),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessageContentVariant2ItemText, global::Moonshot.MessageContentVariant2ItemImageUrl, global::Moonshot.MessageContentVariant2ItemVideoUrl>>>),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<global::Moonshot.MessageContentVariant2ItemText, global::Moonshot.MessageContentVariant2ItemImageUrl, global::Moonshot.MessageContentVariant2ItemVideoUrl>),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<global::Moonshot.MessageContentVariant2ItemImageUrlImageUrl, string>),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<global::Moonshot.MessageContentVariant2ItemVideoUrlVideoUrl, string>),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<global::Moonshot.ChatRequestCommonToolChoiceEnum?, global::Moonshot.ChatRequestCommonToolChoiceEnum2>),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<global::Moonshot.ChatRequestBaseToolChoiceEnum?, global::Moonshot.ChatRequestBaseToolChoiceEnum2>),

            typeof(global::Moonshot.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.JsonSerializerContextTypes))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MoonshotV1ChatRequest), TypeInfoPropertyName = "MoonshotV1ChatRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MoonshotV1ChatRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MoonshotV1ChatRequestVariant2Model), TypeInfoPropertyName = "MoonshotV1ChatRequestVariant2Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK25ChatRequest), TypeInfoPropertyName = "KimiK25ChatRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK25ChatRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK25ChatRequestVariant2Model), TypeInfoPropertyName = "KimiK25ChatRequestVariant2Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK25ChatRequestVariant2Thinking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK25ChatRequestVariant2ThinkingType), TypeInfoPropertyName = "KimiK25ChatRequestVariant2ThinkingType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.BalanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.BalanceResponseData))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<string, global::System.Collections.Generic.List<global::Moonshot.OneOf<global::Moonshot.MessageContentVariant2ItemText, global::Moonshot.MessageContentVariant2ItemImageUrl, global::Moonshot.MessageContentVariant2ItemVideoUrl>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.OneOf<global::Moonshot.MessageContentVariant2ItemText, global::Moonshot.MessageContentVariant2ItemImageUrl, global::Moonshot.MessageContentVariant2ItemVideoUrl>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.ToolDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.KimiK3Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.ChatCompletionResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.ChatCompletionResponseChoiceMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.ChoiceDelta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.ChoiceDeltaDeltaToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.FileObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.BatchObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.GetModelsResponseDataItem>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}