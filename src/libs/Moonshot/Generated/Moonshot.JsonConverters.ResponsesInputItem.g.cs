#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Moonshot.JsonConverters
{
    /// <inheritdoc />
    public class ResponsesInputItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Moonshot.ResponsesInputItem>
    {
        /// <inheritdoc />
        public override global::Moonshot.ResponsesInputItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("content")) __score0++;
            if (__jsonProps.Contains("role")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("status")) __score1++;
            if (__jsonProps.Contains("summary")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("arguments")) __score2++;
            if (__jsonProps.Contains("call_id")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("namespace")) __score2++;
            if (__jsonProps.Contains("status")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("call_id")) __score3++;
            if (__jsonProps.Contains("output")) __score3++;
            if (__jsonProps.Contains("status")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("call_id")) __score4++;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("input")) __score4++;
            if (__jsonProps.Contains("name")) __score4++;
            if (__jsonProps.Contains("namespace")) __score4++;
            if (__jsonProps.Contains("status")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("call_id")) __score5++;
            if (__jsonProps.Contains("output")) __score5++;
            if (__jsonProps.Contains("status")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("action")) __score6++;
            if (__jsonProps.Contains("action.query")) __score6++;
            if (__jsonProps.Contains("action.type")) __score6++;
            if (__jsonProps.Contains("id")) __score6++;
            if (__jsonProps.Contains("status")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("id")) __score7++;
            if (__jsonProps.Contains("role")) __score7++;
            if (__jsonProps.Contains("tools")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }

            global::Moonshot.ResponsesMessageItem? message = default;
            global::Moonshot.ResponsesReasoningItem? reasoning = default;
            global::Moonshot.ResponsesFunctionCallItem? functionCall = default;
            global::Moonshot.ResponsesFunctionCallOutputItem? functionCallOutput = default;
            global::Moonshot.ResponsesCustomToolCallItem? customToolCall = default;
            global::Moonshot.ResponsesCustomToolCallOutputItem? customToolCallOutput = default;
            global::Moonshot.ResponsesWebSearchCallItem? webSearchCall = default;
            global::Moonshot.ResponsesAdditionalToolsItem? additionalTools = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesMessageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesMessageItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesMessageItem).Name}");
                        message = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesReasoningItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesReasoningItem).Name}");
                        reasoning = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesFunctionCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesFunctionCallItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesFunctionCallItem).Name}");
                        functionCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesFunctionCallOutputItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesFunctionCallOutputItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesFunctionCallOutputItem).Name}");
                        functionCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesCustomToolCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesCustomToolCallItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesCustomToolCallItem).Name}");
                        customToolCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesCustomToolCallOutputItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesCustomToolCallOutputItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesCustomToolCallOutputItem).Name}");
                        customToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesWebSearchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesWebSearchCallItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesWebSearchCallItem).Name}");
                        webSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesAdditionalToolsItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesAdditionalToolsItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesAdditionalToolsItem).Name}");
                        additionalTools = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (message == null && reasoning == null && functionCall == null && functionCallOutput == null && customToolCall == null && customToolCallOutput == null && webSearchCall == null && additionalTools == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesMessageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesMessageItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesMessageItem).Name}");
                    message = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (message == null && reasoning == null && functionCall == null && functionCallOutput == null && customToolCall == null && customToolCallOutput == null && webSearchCall == null && additionalTools == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesReasoningItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesReasoningItem).Name}");
                    reasoning = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (message == null && reasoning == null && functionCall == null && functionCallOutput == null && customToolCall == null && customToolCallOutput == null && webSearchCall == null && additionalTools == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesFunctionCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesFunctionCallItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesFunctionCallItem).Name}");
                    functionCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (message == null && reasoning == null && functionCall == null && functionCallOutput == null && customToolCall == null && customToolCallOutput == null && webSearchCall == null && additionalTools == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesFunctionCallOutputItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesFunctionCallOutputItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesFunctionCallOutputItem).Name}");
                    functionCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (message == null && reasoning == null && functionCall == null && functionCallOutput == null && customToolCall == null && customToolCallOutput == null && webSearchCall == null && additionalTools == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesCustomToolCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesCustomToolCallItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesCustomToolCallItem).Name}");
                    customToolCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (message == null && reasoning == null && functionCall == null && functionCallOutput == null && customToolCall == null && customToolCallOutput == null && webSearchCall == null && additionalTools == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesCustomToolCallOutputItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesCustomToolCallOutputItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesCustomToolCallOutputItem).Name}");
                    customToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (message == null && reasoning == null && functionCall == null && functionCallOutput == null && customToolCall == null && customToolCallOutput == null && webSearchCall == null && additionalTools == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesWebSearchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesWebSearchCallItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesWebSearchCallItem).Name}");
                    webSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (message == null && reasoning == null && functionCall == null && functionCallOutput == null && customToolCall == null && customToolCallOutput == null && webSearchCall == null && additionalTools == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesAdditionalToolsItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesAdditionalToolsItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesAdditionalToolsItem).Name}");
                    additionalTools = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Moonshot.ResponsesInputItem(
                message,

                reasoning,

                functionCall,

                functionCallOutput,

                customToolCall,

                customToolCallOutput,

                webSearchCall,

                additionalTools
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Moonshot.ResponsesInputItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesMessageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesMessageItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesMessageItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message!, typeInfo);
            }
            else if (value.IsReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesReasoningItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesReasoningItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Reasoning!, typeInfo);
            }
            else if (value.IsFunctionCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesFunctionCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesFunctionCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesFunctionCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCall!, typeInfo);
            }
            else if (value.IsFunctionCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesFunctionCallOutputItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesFunctionCallOutputItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesFunctionCallOutputItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCallOutput!, typeInfo);
            }
            else if (value.IsCustomToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesCustomToolCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesCustomToolCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesCustomToolCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomToolCall!, typeInfo);
            }
            else if (value.IsCustomToolCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesCustomToolCallOutputItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesCustomToolCallOutputItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesCustomToolCallOutputItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomToolCallOutput!, typeInfo);
            }
            else if (value.IsWebSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesWebSearchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesWebSearchCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesWebSearchCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchCall!, typeInfo);
            }
            else if (value.IsAdditionalTools)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesAdditionalToolsItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesAdditionalToolsItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesAdditionalToolsItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AdditionalTools!, typeInfo);
            }
        }
    }
}