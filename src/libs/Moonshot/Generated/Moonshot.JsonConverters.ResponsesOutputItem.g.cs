#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Moonshot.JsonConverters
{
    /// <inheritdoc />
    public class ResponsesOutputItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Moonshot.ResponsesOutputItem>
    {
        /// <inheritdoc />
        public override global::Moonshot.ResponsesOutputItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesOutputItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesOutputItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Moonshot.ResponsesOutputItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Moonshot.ResponsesOutputReasoningItem? reasoning = default;
            if (discriminator?.Type == global::Moonshot.ResponsesOutputItemDiscriminatorType.Reasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesOutputReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesOutputReasoningItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Moonshot.ResponsesOutputReasoningItem)}");
                reasoning = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Moonshot.ResponsesOutputMessageItem? message = default;
            if (discriminator?.Type == global::Moonshot.ResponsesOutputItemDiscriminatorType.Message)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesOutputMessageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesOutputMessageItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Moonshot.ResponsesOutputMessageItem)}");
                message = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Moonshot.ResponsesOutputFunctionCallItem? functionCall = default;
            if (discriminator?.Type == global::Moonshot.ResponsesOutputItemDiscriminatorType.FunctionCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesOutputFunctionCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesOutputFunctionCallItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Moonshot.ResponsesOutputFunctionCallItem)}");
                functionCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Moonshot.ResponsesOutputItem(
                discriminator?.Type,
                reasoning,

                message,

                functionCall
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Moonshot.ResponsesOutputItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesOutputReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesOutputReasoningItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesOutputReasoningItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Reasoning!, typeInfo);
            }
            else if (value.IsMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesOutputMessageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesOutputMessageItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesOutputMessageItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message!, typeInfo);
            }
            else if (value.IsFunctionCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesOutputFunctionCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesOutputFunctionCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesOutputFunctionCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCall!, typeInfo);
            }
        }
    }
}