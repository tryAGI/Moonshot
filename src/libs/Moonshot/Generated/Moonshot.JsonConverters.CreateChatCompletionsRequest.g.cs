#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Moonshot.JsonConverters
{
    /// <inheritdoc />
    public class CreateChatCompletionsRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Moonshot.CreateChatCompletionsRequest>
    {
        /// <inheritdoc />
        public override global::Moonshot.CreateChatCompletionsRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.CreateChatCompletionsRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.CreateChatCompletionsRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Moonshot.CreateChatCompletionsRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Moonshot.KimiK27CodeChatRequest? kimiK27Code = default;
            if (discriminator?.Model == global::Moonshot.CreateChatCompletionsRequestDiscriminatorModel.KimiK27Code)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.KimiK27CodeChatRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.KimiK27CodeChatRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Moonshot.KimiK27CodeChatRequest)}");
                kimiK27Code = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Moonshot.KimiK26ChatRequest? kimiK26 = default;
            if (discriminator?.Model == global::Moonshot.CreateChatCompletionsRequestDiscriminatorModel.KimiK26)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.KimiK26ChatRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.KimiK26ChatRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Moonshot.KimiK26ChatRequest)}");
                kimiK26 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Moonshot.KimiK25ChatRequest? kimiK25 = default;
            if (discriminator?.Model == global::Moonshot.CreateChatCompletionsRequestDiscriminatorModel.KimiK25)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.KimiK25ChatRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.KimiK25ChatRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Moonshot.KimiK25ChatRequest)}");
                kimiK25 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Moonshot.MoonshotV1ChatRequest? moonshotV18k = default;
            if (discriminator?.Model == global::Moonshot.CreateChatCompletionsRequestDiscriminatorModel.MoonshotV18k)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.MoonshotV1ChatRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.MoonshotV1ChatRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Moonshot.MoonshotV1ChatRequest)}");
                moonshotV18k = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Moonshot.CreateChatCompletionsRequest(
                discriminator?.Model,
                kimiK27Code,

                kimiK26,

                kimiK25,

                moonshotV18k
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Moonshot.CreateChatCompletionsRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsKimiK27Code)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.KimiK27CodeChatRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.KimiK27CodeChatRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.KimiK27CodeChatRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.KimiK27Code!.Value, typeInfo);
            }
            else if (value.IsKimiK26)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.KimiK26ChatRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.KimiK26ChatRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.KimiK26ChatRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.KimiK26!.Value, typeInfo);
            }
            else if (value.IsKimiK25)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.KimiK25ChatRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.KimiK25ChatRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.KimiK25ChatRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.KimiK25!.Value, typeInfo);
            }
            else if (value.IsMoonshotV18k)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.MoonshotV1ChatRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.MoonshotV1ChatRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.MoonshotV1ChatRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MoonshotV18k!.Value, typeInfo);
            }
        }
    }
}