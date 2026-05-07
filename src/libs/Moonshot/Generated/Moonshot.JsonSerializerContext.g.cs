
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

            typeof(global::Moonshot.JsonConverters.ChatRequestBaseResponseFormatTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatRequestBaseResponseFormatTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.MoonshotV1ChatRequestVariant2ModelJsonConverter),

            typeof(global::Moonshot.JsonConverters.MoonshotV1ChatRequestVariant2ModelNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK2ChatRequestVariant2ModelJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK2ChatRequestVariant2ModelNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK2ThinkingChatRequestVariant2ModelJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK2ThinkingChatRequestVariant2ModelNullableJsonConverter),

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

            typeof(global::Moonshot.JsonConverters.ChatCompletionResponseChoiceMessageRoleJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatCompletionResponseChoiceMessageRoleNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatCompletionResponseChoiceMessageToolCallTypeJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatCompletionResponseChoiceMessageToolCallTypeNullableJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatCompletionResponseChoiceFinishReasonJsonConverter),

            typeof(global::Moonshot.JsonConverters.ChatCompletionResponseChoiceFinishReasonNullableJsonConverter),

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

            typeof(global::Moonshot.JsonConverters.MoonshotV1ChatRequestJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK2ChatRequestJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK2ThinkingChatRequestJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK25ChatRequestJsonConverter),

            typeof(global::Moonshot.JsonConverters.KimiK26ChatRequestJsonConverter),

            typeof(global::Moonshot.JsonConverters.CreateChatCompletionsRequestJsonConverter),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessageContentVariant2ItemText, global::Moonshot.MessageContentVariant2ItemImageUrl, global::Moonshot.MessageContentVariant2ItemVideoUrl>>>),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<global::Moonshot.MessageContentVariant2ItemText, global::Moonshot.MessageContentVariant2ItemImageUrl, global::Moonshot.MessageContentVariant2ItemVideoUrl>),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<global::Moonshot.MessageContentVariant2ItemImageUrlImageUrl, string>),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<global::Moonshot.MessageContentVariant2ItemVideoUrlVideoUrl, string>),

            typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Moonshot.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestBaseResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestBaseResponseFormatType), TypeInfoPropertyName = "ChatRequestBaseResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestBaseResponseFormatJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestBaseStreamOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Moonshot.ToolDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MoonshotV1ChatRequest), TypeInfoPropertyName = "MoonshotV1ChatRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MoonshotV1ChatRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MoonshotV1ChatRequestVariant2Model), TypeInfoPropertyName = "MoonshotV1ChatRequestVariant2Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK2ChatRequest), TypeInfoPropertyName = "KimiK2ChatRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK2ChatRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK2ChatRequestVariant2Model), TypeInfoPropertyName = "KimiK2ChatRequestVariant2Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK2ThinkingChatRequest), TypeInfoPropertyName = "KimiK2ThinkingChatRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK2ThinkingChatRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK2ThinkingChatRequestVariant2Model), TypeInfoPropertyName = "KimiK2ThinkingChatRequestVariant2Model2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.ToolDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.ChatCompletionResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.ChatCompletionResponseChoiceMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.FileObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.BatchObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Moonshot.GetModelsResponseDataItem>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}