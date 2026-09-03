#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Moonshot.JsonConverters
{
    /// <inheritdoc />
    public class ResponsesToolJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Moonshot.ResponsesTool>
    {
        /// <inheritdoc />
        public override global::Moonshot.ResponsesTool Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesToolDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesToolDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Moonshot.ResponsesToolDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Moonshot.ResponsesFunctionTool? function = default;
            if (discriminator?.Type == global::Moonshot.ResponsesToolDiscriminatorType.Function)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesFunctionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesFunctionTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Moonshot.ResponsesFunctionTool)}");
                function = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Moonshot.ResponsesCustomTool? custom = default;
            if (discriminator?.Type == global::Moonshot.ResponsesToolDiscriminatorType.Custom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesCustomTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesCustomTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Moonshot.ResponsesCustomTool)}");
                custom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Moonshot.ResponsesNamespaceTool? @namespace = default;
            if (discriminator?.Type == global::Moonshot.ResponsesToolDiscriminatorType.Namespace)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesNamespaceTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesNamespaceTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Moonshot.ResponsesNamespaceTool)}");
                @namespace = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Moonshot.ResponsesWebSearchTool? webSearch = default;
            if (discriminator?.Type == global::Moonshot.ResponsesToolDiscriminatorType.WebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesWebSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesWebSearchTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Moonshot.ResponsesWebSearchTool)}");
                webSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Moonshot.ResponsesTool(
                discriminator?.Type,
                function,

                custom,

                @namespace,

                webSearch
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Moonshot.ResponsesTool value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesFunctionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesFunctionTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesFunctionTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function!, typeInfo);
            }
            else if (value.IsCustom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesCustomTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesCustomTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesCustomTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Custom!, typeInfo);
            }
            else if (value.IsNamespace)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesNamespaceTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesNamespaceTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesNamespaceTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Namespace!, typeInfo);
            }
            else if (value.IsWebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.ResponsesWebSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.ResponsesWebSearchTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.ResponsesWebSearchTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearch!, typeInfo);
            }
        }
    }
}