#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Moonshot.JsonConverters
{
    /// <inheritdoc />
    public class KimiK2ChatRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Moonshot.KimiK2ChatRequest>
    {
        /// <inheritdoc />
        public override global::Moonshot.KimiK2ChatRequest Read(
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
            if (__jsonProps.Contains("max_completion_tokens")) __score0++;
            if (__jsonProps.Contains("max_tokens")) __score0++;
            if (__jsonProps.Contains("messages")) __score0++;
            if (__jsonProps.Contains("prompt_cache_key")) __score0++;
            if (__jsonProps.Contains("response_format")) __score0++;
            if (__jsonProps.Contains("response_format.json_schema")) __score0++;
            if (__jsonProps.Contains("response_format.type")) __score0++;
            if (__jsonProps.Contains("safety_identifier")) __score0++;
            if (__jsonProps.Contains("stop")) __score0++;
            if (__jsonProps.Contains("stream")) __score0++;
            if (__jsonProps.Contains("stream_options")) __score0++;
            if (__jsonProps.Contains("stream_options.include_usage")) __score0++;
            if (__jsonProps.Contains("tools")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("frequency_penalty")) __score1++;
            if (__jsonProps.Contains("model")) __score1++;
            if (__jsonProps.Contains("n")) __score1++;
            if (__jsonProps.Contains("presence_penalty")) __score1++;
            if (__jsonProps.Contains("temperature")) __score1++;
            if (__jsonProps.Contains("top_p")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Moonshot.ChatRequestBase? @base = default;
            global::Moonshot.KimiK2ChatRequestVariant2? kimiK2ChatRequestVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ChatRequestBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ChatRequestBase> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ChatRequestBase).Name}");
                        @base = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.KimiK2ChatRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.KimiK2ChatRequestVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.KimiK2ChatRequestVariant2).Name}");
                        kimiK2ChatRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (@base == null && kimiK2ChatRequestVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ChatRequestBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ChatRequestBase> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ChatRequestBase).Name}");
                    @base = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.KimiK2ChatRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.KimiK2ChatRequestVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.KimiK2ChatRequestVariant2).Name}");
                    kimiK2ChatRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Moonshot.KimiK2ChatRequest(
                @base,

                kimiK2ChatRequestVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Moonshot.KimiK2ChatRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ChatRequestBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ChatRequestBase?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ChatRequestBase).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base!, typeInfo);
            }
            else if (value.IsKimiK2ChatRequestVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.KimiK2ChatRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.KimiK2ChatRequestVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.KimiK2ChatRequestVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.KimiK2ChatRequestVariant2!, typeInfo);
            }
        }
    }
}