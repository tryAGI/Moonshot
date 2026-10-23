#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Moonshot.JsonConverters
{
    /// <inheritdoc />
    public class KimiK31ProChatRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Moonshot.KimiK31ProChatRequest>
    {
        /// <inheritdoc />
        public override global::Moonshot.KimiK31ProChatRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Moonshot.KimiK3ChatRequestBase? k3Base = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.KimiK3ChatRequestBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.KimiK3ChatRequestBase> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.KimiK3ChatRequestBase).Name}");
                k3Base = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
            {
                // Legacy enum converters signal an incompatible JSON token with this exception.
            }

            global::Moonshot.KimiK31ProChatRequestVariant2? kimiK31ProChatRequestVariant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.KimiK31ProChatRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.KimiK31ProChatRequestVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.KimiK31ProChatRequestVariant2).Name}");
                kimiK31ProChatRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
            {
                // Legacy enum converters signal an incompatible JSON token with this exception.
            }
            var __value = new global::Moonshot.KimiK31ProChatRequest(
                k3Base,

                kimiK31ProChatRequestVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Moonshot.KimiK31ProChatRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsK3Base)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.KimiK3ChatRequestBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.KimiK3ChatRequestBase> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.KimiK3ChatRequestBase).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.PickK3Base(), typeInfo);
                if (__element0.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element0.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            if (value.IsKimiK31ProChatRequestVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Moonshot.KimiK31ProChatRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Moonshot.KimiK31ProChatRequestVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Moonshot.KimiK31ProChatRequestVariant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.PickKimiK31ProChatRequestVariant2(), typeInfo);
                if (__element1.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element1.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            writer.WriteEndObject();
        }
    }
}