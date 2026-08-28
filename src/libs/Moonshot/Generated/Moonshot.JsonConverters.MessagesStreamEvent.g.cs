#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Moonshot.JsonConverters
{
    /// <inheritdoc />
    public class MessagesStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Moonshot.MessagesStreamEvent>
    {
        /// <inheritdoc />
        public override global::Moonshot.MessagesStreamEvent Read(
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
            if (__jsonProps.Contains("message")) __score0++;
            if (__jsonProps.Contains("message.content")) __score0++;
            if (__jsonProps.Contains("message.id")) __score0++;
            if (__jsonProps.Contains("message.model")) __score0++;
            if (__jsonProps.Contains("message.role")) __score0++;
            if (__jsonProps.Contains("message.stop_reason")) __score0++;
            if (__jsonProps.Contains("message.stop_sequence")) __score0++;
            if (__jsonProps.Contains("message.type")) __score0++;
            if (__jsonProps.Contains("message.usage")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("content_block")) __score1++;
            if (__jsonProps.Contains("index")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("delta")) __score2++;
            if (__jsonProps.Contains("delta.partial_json")) __score2++;
            if (__jsonProps.Contains("delta.signature")) __score2++;
            if (__jsonProps.Contains("delta.text")) __score2++;
            if (__jsonProps.Contains("delta.thinking")) __score2++;
            if (__jsonProps.Contains("delta.type")) __score2++;
            if (__jsonProps.Contains("index")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("index")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("delta")) __score4++;
            if (__jsonProps.Contains("delta.stop_reason")) __score4++;
            if (__jsonProps.Contains("delta.stop_sequence")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("usage")) __score4++;
            if (__jsonProps.Contains("usage.cache_creation_input_tokens")) __score4++;
            if (__jsonProps.Contains("usage.cache_read_input_tokens")) __score4++;
            if (__jsonProps.Contains("usage.input_tokens")) __score4++;
            if (__jsonProps.Contains("usage.output_tokens")) __score4++;
            if (__jsonProps.Contains("usage.output_tokens_details")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("type")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::Moonshot.MessagesStreamEventMessageStart? messageStart = default;
            global::Moonshot.MessagesStreamEventContentBlockStart? contentBlockStart = default;
            global::Moonshot.MessagesStreamEventContentBlockDelta? contentBlockDelta = default;
            global::Moonshot.MessagesStreamEventContentBlockStop? contentBlockStop = default;
            global::Moonshot.MessagesStreamEventMessageDelta? messageDelta = default;
            global::Moonshot.MessagesStreamEventMessageStop? messageStop = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.MessagesStreamEventMessageStart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.MessagesStreamEventMessageStart> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.MessagesStreamEventMessageStart).Name}");
                        messageStart = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.MessagesStreamEventContentBlockStart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.MessagesStreamEventContentBlockStart> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.MessagesStreamEventContentBlockStart).Name}");
                        contentBlockStart = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.MessagesStreamEventContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.MessagesStreamEventContentBlockDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.MessagesStreamEventContentBlockDelta).Name}");
                        contentBlockDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.MessagesStreamEventContentBlockStop), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.MessagesStreamEventContentBlockStop> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.MessagesStreamEventContentBlockStop).Name}");
                        contentBlockStop = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.MessagesStreamEventMessageDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.MessagesStreamEventMessageDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.MessagesStreamEventMessageDelta).Name}");
                        messageDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.MessagesStreamEventMessageStop), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.MessagesStreamEventMessageStop> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.MessagesStreamEventMessageStop).Name}");
                        messageStop = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (messageStart == null && contentBlockStart == null && contentBlockDelta == null && contentBlockStop == null && messageDelta == null && messageStop == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.MessagesStreamEventMessageStart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.MessagesStreamEventMessageStart> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.MessagesStreamEventMessageStart).Name}");
                    messageStart = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (messageStart == null && contentBlockStart == null && contentBlockDelta == null && contentBlockStop == null && messageDelta == null && messageStop == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.MessagesStreamEventContentBlockStart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.MessagesStreamEventContentBlockStart> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.MessagesStreamEventContentBlockStart).Name}");
                    contentBlockStart = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (messageStart == null && contentBlockStart == null && contentBlockDelta == null && contentBlockStop == null && messageDelta == null && messageStop == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.MessagesStreamEventContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.MessagesStreamEventContentBlockDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.MessagesStreamEventContentBlockDelta).Name}");
                    contentBlockDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (messageStart == null && contentBlockStart == null && contentBlockDelta == null && contentBlockStop == null && messageDelta == null && messageStop == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.MessagesStreamEventContentBlockStop), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.MessagesStreamEventContentBlockStop> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.MessagesStreamEventContentBlockStop).Name}");
                    contentBlockStop = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (messageStart == null && contentBlockStart == null && contentBlockDelta == null && contentBlockStop == null && messageDelta == null && messageStop == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.MessagesStreamEventMessageDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.MessagesStreamEventMessageDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.MessagesStreamEventMessageDelta).Name}");
                    messageDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (messageStart == null && contentBlockStart == null && contentBlockDelta == null && contentBlockStop == null && messageDelta == null && messageStop == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.MessagesStreamEventMessageStop), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.MessagesStreamEventMessageStop> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.MessagesStreamEventMessageStop).Name}");
                    messageStop = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Moonshot.MessagesStreamEvent(
                messageStart,

                contentBlockStart,

                contentBlockDelta,

                contentBlockStop,

                messageDelta,

                messageStop
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Moonshot.MessagesStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessageStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.MessagesStreamEventMessageStart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.MessagesStreamEventMessageStart?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.MessagesStreamEventMessageStart).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageStart!, typeInfo);
            }
            else if (value.IsContentBlockStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.MessagesStreamEventContentBlockStart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.MessagesStreamEventContentBlockStart?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.MessagesStreamEventContentBlockStart).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockStart!, typeInfo);
            }
            else if (value.IsContentBlockDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.MessagesStreamEventContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.MessagesStreamEventContentBlockDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.MessagesStreamEventContentBlockDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockDelta!, typeInfo);
            }
            else if (value.IsContentBlockStop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.MessagesStreamEventContentBlockStop), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.MessagesStreamEventContentBlockStop?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.MessagesStreamEventContentBlockStop).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockStop!, typeInfo);
            }
            else if (value.IsMessageDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.MessagesStreamEventMessageDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.MessagesStreamEventMessageDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.MessagesStreamEventMessageDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageDelta!, typeInfo);
            }
            else if (value.IsMessageStop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.MessagesStreamEventMessageStop), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.MessagesStreamEventMessageStop?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.MessagesStreamEventMessageStop).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageStop!, typeInfo);
            }
        }
    }
}