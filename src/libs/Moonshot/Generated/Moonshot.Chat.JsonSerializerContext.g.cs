
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessageContentVariant2ItemText, global::Moonshot.MessageContentVariant2ItemImageUrl, global::Moonshot.MessageContentVariant2ItemVideoUrl>>>?), TypeInfoPropertyName = "MessageContentVariant2ItemVideoUrl_5bae655494501c49")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ErrorResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.CreateChatCompletionsRequest), TypeInfoPropertyName = "CreateChatCompletionsRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.CreateChatCompletionsRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.CreateChatCompletionsRequestDiscriminatorModel), TypeInfoPropertyName = "CreateChatCompletionsRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessageRole?), TypeInfoPropertyName = "NullableMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<global::Moonshot.MessageContentVariant2ItemText, global::Moonshot.MessageContentVariant2ItemImageUrl, global::Moonshot.MessageContentVariant2ItemVideoUrl>?), TypeInfoPropertyName = "NullableOneOfMessageContentVariant2ItemTextMessageContentVariant2ItemImageUrlMessageContentVariant2ItemVideoUrl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessageContentVariant2ItemTextType?), TypeInfoPropertyName = "NullableMessageContentVariant2ItemTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessageContentVariant2ItemImageUrlType?), TypeInfoPropertyName = "NullableMessageContentVariant2ItemImageUrlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<global::Moonshot.MessageContentVariant2ItemImageUrlImageUrl, string>?), TypeInfoPropertyName = "NullableOneOfMessageContentVariant2ItemImageUrlImageUrlString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.MessageContentVariant2ItemVideoUrlType?), TypeInfoPropertyName = "NullableMessageContentVariant2ItemVideoUrlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<global::Moonshot.MessageContentVariant2ItemVideoUrlVideoUrl, string>?), TypeInfoPropertyName = "NullableOneOfMessageContentVariant2ItemVideoUrlVideoUrlString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ToolDefinitionType?), TypeInfoPropertyName = "NullableToolDefinitionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK3DynamicToolMessageRole?), TypeInfoPropertyName = "NullableKimiK3DynamicToolMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK3Message?), TypeInfoPropertyName = "NullableKimiK3Message2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestCommonPredictionType?), TypeInfoPropertyName = "NullableChatRequestCommonPredictionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<object>>?), TypeInfoPropertyName = "NullableOneOfStringIListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestCommonResponseFormatType?), TypeInfoPropertyName = "NullableChatRequestCommonResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableOneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<global::Moonshot.ChatRequestCommonToolChoiceEnum?, global::Moonshot.ChatRequestCommonToolChoiceEnum2>?), TypeInfoPropertyName = "NullableOneOfChatRequestCommonToolChoiceEnumChatRequestCommonToolChoiceEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestCommonToolChoiceEnum?), TypeInfoPropertyName = "NullableChatRequestCommonToolChoiceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestCommonToolChoiceEnumType?), TypeInfoPropertyName = "NullableChatRequestCommonToolChoiceEnumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestBasePredictionType?), TypeInfoPropertyName = "NullableChatRequestBasePredictionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestBaseResponseFormatType?), TypeInfoPropertyName = "NullableChatRequestBaseResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.OneOf<global::Moonshot.ChatRequestBaseToolChoiceEnum?, global::Moonshot.ChatRequestBaseToolChoiceEnum2>?), TypeInfoPropertyName = "NullableOneOfChatRequestBaseToolChoiceEnumChatRequestBaseToolChoiceEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestBaseToolChoiceEnum?), TypeInfoPropertyName = "NullableChatRequestBaseToolChoiceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatRequestBaseToolChoiceEnumType?), TypeInfoPropertyName = "NullableChatRequestBaseToolChoiceEnumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK3ChatRequest?), TypeInfoPropertyName = "NullableKimiK3ChatRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK3ChatRequestVariant2Model?), TypeInfoPropertyName = "NullableKimiK3ChatRequestVariant2Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK3ChatRequestVariant2ReasoningEffort?), TypeInfoPropertyName = "NullableKimiK3ChatRequestVariant2ReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK26ChatRequest?), TypeInfoPropertyName = "NullableKimiK26ChatRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK26ChatRequestVariant2Model?), TypeInfoPropertyName = "NullableKimiK26ChatRequestVariant2Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK26ChatRequestVariant2ThinkingType?), TypeInfoPropertyName = "NullableKimiK26ChatRequestVariant2ThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK26ChatRequestVariant2ThinkingKeep?), TypeInfoPropertyName = "NullableKimiK26ChatRequestVariant2ThinkingKeep2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK27CodeChatRequest?), TypeInfoPropertyName = "NullableKimiK27CodeChatRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK27CodeChatRequestVariant2Model?), TypeInfoPropertyName = "NullableKimiK27CodeChatRequestVariant2Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK27CodeChatRequestVariant2ThinkingType?), TypeInfoPropertyName = "NullableKimiK27CodeChatRequestVariant2ThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.KimiK27CodeChatRequestVariant2ThinkingKeep?), TypeInfoPropertyName = "NullableKimiK27CodeChatRequestVariant2ThinkingKeep2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatCompletionResponseChoiceMessageRole?), TypeInfoPropertyName = "NullableChatCompletionResponseChoiceMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatCompletionResponseChoiceMessageToolCallType?), TypeInfoPropertyName = "NullableChatCompletionResponseChoiceMessageToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChatCompletionResponseChoiceFinishReason?), TypeInfoPropertyName = "NullableChatCompletionResponseChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChoiceDeltaDeltaToolCallType?), TypeInfoPropertyName = "NullableChoiceDeltaDeltaToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.ChoiceDeltaFinishReason?), TypeInfoPropertyName = "NullableChoiceDeltaFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.CreateChatCompletionsRequest?), TypeInfoPropertyName = "NullableCreateChatCompletionsRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Moonshot.CreateChatCompletionsRequestDiscriminatorModel?), TypeInfoPropertyName = "NullableCreateChatCompletionsRequestDiscriminatorModel2")]
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
    internal sealed partial class ChatSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ChatSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ChatSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Moonshot.JsonConverters.KimiK3MessageJsonConverter());
            options.Converters.Add(new global::Moonshot.JsonConverters.KimiK3ChatRequestJsonConverter());
            options.Converters.Add(new global::Moonshot.JsonConverters.KimiK26ChatRequestJsonConverter());
            options.Converters.Add(new global::Moonshot.JsonConverters.KimiK27CodeChatRequestJsonConverter());
            options.Converters.Add(new global::Moonshot.JsonConverters.CreateChatCompletionsRequestJsonConverter());
            options.Converters.Add(new global::Moonshot.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Moonshot.OneOf<global::Moonshot.MessageContentVariant2ItemText, global::Moonshot.MessageContentVariant2ItemImageUrl, global::Moonshot.MessageContentVariant2ItemVideoUrl>>>());
            options.Converters.Add(new global::Moonshot.JsonConverters.OneOfJsonConverter<global::Moonshot.MessageContentVariant2ItemText, global::Moonshot.MessageContentVariant2ItemImageUrl, global::Moonshot.MessageContentVariant2ItemVideoUrl>());
            options.Converters.Add(new global::Moonshot.JsonConverters.OneOfJsonConverter<global::Moonshot.MessageContentVariant2ItemImageUrlImageUrl, string>());
            options.Converters.Add(new global::Moonshot.JsonConverters.OneOfJsonConverter<global::Moonshot.MessageContentVariant2ItemVideoUrlVideoUrl, string>());
            options.Converters.Add(new global::Moonshot.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::Moonshot.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Moonshot.JsonConverters.OneOfJsonConverter<global::Moonshot.ChatRequestCommonToolChoiceEnum?, global::Moonshot.ChatRequestCommonToolChoiceEnum2>());
            options.Converters.Add(new global::Moonshot.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::Moonshot.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Moonshot.JsonConverters.OneOfJsonConverter<global::Moonshot.ChatRequestBaseToolChoiceEnum?, global::Moonshot.ChatRequestBaseToolChoiceEnum2>());
            options.Converters.Add(new global::Moonshot.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Moonshot.MessageRole)

                    || typeToConvert == typeof(global::Moonshot.MessageRole?)

                    || typeToConvert == typeof(global::Moonshot.MessageContentVariant2ItemTextType)

                    || typeToConvert == typeof(global::Moonshot.MessageContentVariant2ItemTextType?)

                    || typeToConvert == typeof(global::Moonshot.MessageContentVariant2ItemImageUrlType)

                    || typeToConvert == typeof(global::Moonshot.MessageContentVariant2ItemImageUrlType?)

                    || typeToConvert == typeof(global::Moonshot.MessageContentVariant2ItemVideoUrlType)

                    || typeToConvert == typeof(global::Moonshot.MessageContentVariant2ItemVideoUrlType?)

                    || typeToConvert == typeof(global::Moonshot.ToolDefinitionType)

                    || typeToConvert == typeof(global::Moonshot.ToolDefinitionType?)

                    || typeToConvert == typeof(global::Moonshot.KimiK3DynamicToolMessageRole)

                    || typeToConvert == typeof(global::Moonshot.KimiK3DynamicToolMessageRole?)

                    || typeToConvert == typeof(global::Moonshot.ChatRequestCommonPredictionType)

                    || typeToConvert == typeof(global::Moonshot.ChatRequestCommonPredictionType?)

                    || typeToConvert == typeof(global::Moonshot.ChatRequestCommonResponseFormatType)

                    || typeToConvert == typeof(global::Moonshot.ChatRequestCommonResponseFormatType?)

                    || typeToConvert == typeof(global::Moonshot.ChatRequestCommonToolChoiceEnum)

                    || typeToConvert == typeof(global::Moonshot.ChatRequestCommonToolChoiceEnum?)

                    || typeToConvert == typeof(global::Moonshot.ChatRequestCommonToolChoiceEnumType)

                    || typeToConvert == typeof(global::Moonshot.ChatRequestCommonToolChoiceEnumType?)

                    || typeToConvert == typeof(global::Moonshot.ChatRequestBasePredictionType)

                    || typeToConvert == typeof(global::Moonshot.ChatRequestBasePredictionType?)

                    || typeToConvert == typeof(global::Moonshot.ChatRequestBaseResponseFormatType)

                    || typeToConvert == typeof(global::Moonshot.ChatRequestBaseResponseFormatType?)

                    || typeToConvert == typeof(global::Moonshot.ChatRequestBaseToolChoiceEnum)

                    || typeToConvert == typeof(global::Moonshot.ChatRequestBaseToolChoiceEnum?)

                    || typeToConvert == typeof(global::Moonshot.ChatRequestBaseToolChoiceEnumType)

                    || typeToConvert == typeof(global::Moonshot.ChatRequestBaseToolChoiceEnumType?)

                    || typeToConvert == typeof(global::Moonshot.KimiK3ChatRequestVariant2Model)

                    || typeToConvert == typeof(global::Moonshot.KimiK3ChatRequestVariant2Model?)

                    || typeToConvert == typeof(global::Moonshot.KimiK3ChatRequestVariant2ReasoningEffort)

                    || typeToConvert == typeof(global::Moonshot.KimiK3ChatRequestVariant2ReasoningEffort?)

                    || typeToConvert == typeof(global::Moonshot.KimiK26ChatRequestVariant2Model)

                    || typeToConvert == typeof(global::Moonshot.KimiK26ChatRequestVariant2Model?)

                    || typeToConvert == typeof(global::Moonshot.KimiK26ChatRequestVariant2ThinkingType)

                    || typeToConvert == typeof(global::Moonshot.KimiK26ChatRequestVariant2ThinkingType?)

                    || typeToConvert == typeof(global::Moonshot.KimiK26ChatRequestVariant2ThinkingKeep)

                    || typeToConvert == typeof(global::Moonshot.KimiK26ChatRequestVariant2ThinkingKeep?)

                    || typeToConvert == typeof(global::Moonshot.KimiK27CodeChatRequestVariant2Model)

                    || typeToConvert == typeof(global::Moonshot.KimiK27CodeChatRequestVariant2Model?)

                    || typeToConvert == typeof(global::Moonshot.KimiK27CodeChatRequestVariant2ThinkingType)

                    || typeToConvert == typeof(global::Moonshot.KimiK27CodeChatRequestVariant2ThinkingType?)

                    || typeToConvert == typeof(global::Moonshot.KimiK27CodeChatRequestVariant2ThinkingKeep)

                    || typeToConvert == typeof(global::Moonshot.KimiK27CodeChatRequestVariant2ThinkingKeep?)

                    || typeToConvert == typeof(global::Moonshot.ChatCompletionResponseChoiceMessageRole)

                    || typeToConvert == typeof(global::Moonshot.ChatCompletionResponseChoiceMessageRole?)

                    || typeToConvert == typeof(global::Moonshot.ChatCompletionResponseChoiceMessageToolCallType)

                    || typeToConvert == typeof(global::Moonshot.ChatCompletionResponseChoiceMessageToolCallType?)

                    || typeToConvert == typeof(global::Moonshot.ChatCompletionResponseChoiceFinishReason)

                    || typeToConvert == typeof(global::Moonshot.ChatCompletionResponseChoiceFinishReason?)

                    || typeToConvert == typeof(global::Moonshot.ChoiceDeltaDeltaToolCallType)

                    || typeToConvert == typeof(global::Moonshot.ChoiceDeltaDeltaToolCallType?)

                    || typeToConvert == typeof(global::Moonshot.ChoiceDeltaFinishReason)

                    || typeToConvert == typeof(global::Moonshot.ChoiceDeltaFinishReason?)

                    || typeToConvert == typeof(global::Moonshot.CreateChatCompletionsRequestDiscriminatorModel)

                    || typeToConvert == typeof(global::Moonshot.CreateChatCompletionsRequestDiscriminatorModel?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Moonshot.MessageRole))
                {
                    return new global::Moonshot.JsonConverters.MessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.MessageRole?))
                {
                    return new global::Moonshot.JsonConverters.MessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.MessageContentVariant2ItemTextType))
                {
                    return new global::Moonshot.JsonConverters.MessageContentVariant2ItemTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.MessageContentVariant2ItemTextType?))
                {
                    return new global::Moonshot.JsonConverters.MessageContentVariant2ItemTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.MessageContentVariant2ItemImageUrlType))
                {
                    return new global::Moonshot.JsonConverters.MessageContentVariant2ItemImageUrlTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.MessageContentVariant2ItemImageUrlType?))
                {
                    return new global::Moonshot.JsonConverters.MessageContentVariant2ItemImageUrlTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.MessageContentVariant2ItemVideoUrlType))
                {
                    return new global::Moonshot.JsonConverters.MessageContentVariant2ItemVideoUrlTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.MessageContentVariant2ItemVideoUrlType?))
                {
                    return new global::Moonshot.JsonConverters.MessageContentVariant2ItemVideoUrlTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.ToolDefinitionType))
                {
                    return new global::Moonshot.JsonConverters.ToolDefinitionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.ToolDefinitionType?))
                {
                    return new global::Moonshot.JsonConverters.ToolDefinitionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.KimiK3DynamicToolMessageRole))
                {
                    return new global::Moonshot.JsonConverters.KimiK3DynamicToolMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.KimiK3DynamicToolMessageRole?))
                {
                    return new global::Moonshot.JsonConverters.KimiK3DynamicToolMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.ChatRequestCommonPredictionType))
                {
                    return new global::Moonshot.JsonConverters.ChatRequestCommonPredictionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.ChatRequestCommonPredictionType?))
                {
                    return new global::Moonshot.JsonConverters.ChatRequestCommonPredictionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.ChatRequestCommonResponseFormatType))
                {
                    return new global::Moonshot.JsonConverters.ChatRequestCommonResponseFormatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.ChatRequestCommonResponseFormatType?))
                {
                    return new global::Moonshot.JsonConverters.ChatRequestCommonResponseFormatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.ChatRequestCommonToolChoiceEnum))
                {
                    return new global::Moonshot.JsonConverters.ChatRequestCommonToolChoiceEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.ChatRequestCommonToolChoiceEnum?))
                {
                    return new global::Moonshot.JsonConverters.ChatRequestCommonToolChoiceEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.ChatRequestCommonToolChoiceEnumType))
                {
                    return new global::Moonshot.JsonConverters.ChatRequestCommonToolChoiceEnumTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.ChatRequestCommonToolChoiceEnumType?))
                {
                    return new global::Moonshot.JsonConverters.ChatRequestCommonToolChoiceEnumTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.ChatRequestBasePredictionType))
                {
                    return new global::Moonshot.JsonConverters.ChatRequestBasePredictionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.ChatRequestBasePredictionType?))
                {
                    return new global::Moonshot.JsonConverters.ChatRequestBasePredictionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.ChatRequestBaseResponseFormatType))
                {
                    return new global::Moonshot.JsonConverters.ChatRequestBaseResponseFormatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.ChatRequestBaseResponseFormatType?))
                {
                    return new global::Moonshot.JsonConverters.ChatRequestBaseResponseFormatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.ChatRequestBaseToolChoiceEnum))
                {
                    return new global::Moonshot.JsonConverters.ChatRequestBaseToolChoiceEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.ChatRequestBaseToolChoiceEnum?))
                {
                    return new global::Moonshot.JsonConverters.ChatRequestBaseToolChoiceEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.ChatRequestBaseToolChoiceEnumType))
                {
                    return new global::Moonshot.JsonConverters.ChatRequestBaseToolChoiceEnumTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.ChatRequestBaseToolChoiceEnumType?))
                {
                    return new global::Moonshot.JsonConverters.ChatRequestBaseToolChoiceEnumTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.KimiK3ChatRequestVariant2Model))
                {
                    return new global::Moonshot.JsonConverters.KimiK3ChatRequestVariant2ModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.KimiK3ChatRequestVariant2Model?))
                {
                    return new global::Moonshot.JsonConverters.KimiK3ChatRequestVariant2ModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.KimiK3ChatRequestVariant2ReasoningEffort))
                {
                    return new global::Moonshot.JsonConverters.KimiK3ChatRequestVariant2ReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.KimiK3ChatRequestVariant2ReasoningEffort?))
                {
                    return new global::Moonshot.JsonConverters.KimiK3ChatRequestVariant2ReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.KimiK26ChatRequestVariant2Model))
                {
                    return new global::Moonshot.JsonConverters.KimiK26ChatRequestVariant2ModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.KimiK26ChatRequestVariant2Model?))
                {
                    return new global::Moonshot.JsonConverters.KimiK26ChatRequestVariant2ModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.KimiK26ChatRequestVariant2ThinkingType))
                {
                    return new global::Moonshot.JsonConverters.KimiK26ChatRequestVariant2ThinkingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.KimiK26ChatRequestVariant2ThinkingType?))
                {
                    return new global::Moonshot.JsonConverters.KimiK26ChatRequestVariant2ThinkingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.KimiK26ChatRequestVariant2ThinkingKeep))
                {
                    return new global::Moonshot.JsonConverters.KimiK26ChatRequestVariant2ThinkingKeepJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.KimiK26ChatRequestVariant2ThinkingKeep?))
                {
                    return new global::Moonshot.JsonConverters.KimiK26ChatRequestVariant2ThinkingKeepNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.KimiK27CodeChatRequestVariant2Model))
                {
                    return new global::Moonshot.JsonConverters.KimiK27CodeChatRequestVariant2ModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.KimiK27CodeChatRequestVariant2Model?))
                {
                    return new global::Moonshot.JsonConverters.KimiK27CodeChatRequestVariant2ModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.KimiK27CodeChatRequestVariant2ThinkingType))
                {
                    return new global::Moonshot.JsonConverters.KimiK27CodeChatRequestVariant2ThinkingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.KimiK27CodeChatRequestVariant2ThinkingType?))
                {
                    return new global::Moonshot.JsonConverters.KimiK27CodeChatRequestVariant2ThinkingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.KimiK27CodeChatRequestVariant2ThinkingKeep))
                {
                    return new global::Moonshot.JsonConverters.KimiK27CodeChatRequestVariant2ThinkingKeepJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.KimiK27CodeChatRequestVariant2ThinkingKeep?))
                {
                    return new global::Moonshot.JsonConverters.KimiK27CodeChatRequestVariant2ThinkingKeepNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.ChatCompletionResponseChoiceMessageRole))
                {
                    return new global::Moonshot.JsonConverters.ChatCompletionResponseChoiceMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.ChatCompletionResponseChoiceMessageRole?))
                {
                    return new global::Moonshot.JsonConverters.ChatCompletionResponseChoiceMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.ChatCompletionResponseChoiceMessageToolCallType))
                {
                    return new global::Moonshot.JsonConverters.ChatCompletionResponseChoiceMessageToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.ChatCompletionResponseChoiceMessageToolCallType?))
                {
                    return new global::Moonshot.JsonConverters.ChatCompletionResponseChoiceMessageToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.ChatCompletionResponseChoiceFinishReason))
                {
                    return new global::Moonshot.JsonConverters.ChatCompletionResponseChoiceFinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.ChatCompletionResponseChoiceFinishReason?))
                {
                    return new global::Moonshot.JsonConverters.ChatCompletionResponseChoiceFinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.ChoiceDeltaDeltaToolCallType))
                {
                    return new global::Moonshot.JsonConverters.ChoiceDeltaDeltaToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.ChoiceDeltaDeltaToolCallType?))
                {
                    return new global::Moonshot.JsonConverters.ChoiceDeltaDeltaToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.ChoiceDeltaFinishReason))
                {
                    return new global::Moonshot.JsonConverters.ChoiceDeltaFinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.ChoiceDeltaFinishReason?))
                {
                    return new global::Moonshot.JsonConverters.ChoiceDeltaFinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.CreateChatCompletionsRequestDiscriminatorModel))
                {
                    return new global::Moonshot.JsonConverters.CreateChatCompletionsRequestDiscriminatorModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Moonshot.CreateChatCompletionsRequestDiscriminatorModel?))
                {
                    return new global::Moonshot.JsonConverters.CreateChatCompletionsRequestDiscriminatorModelNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ChatSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}