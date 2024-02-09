// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class MediaEnabledProtocols : IUtf8JsonSerializable, IJsonModel<MediaEnabledProtocols>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MediaEnabledProtocols>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MediaEnabledProtocols>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaEnabledProtocols>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaEnabledProtocols)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("download"u8);
            writer.WriteBooleanValue(IsDownloadEnabled);
            writer.WritePropertyName("dash"u8);
            writer.WriteBooleanValue(IsDashEnabled);
            writer.WritePropertyName("hls"u8);
            writer.WriteBooleanValue(IsHlsEnabled);
            writer.WritePropertyName("smoothStreaming"u8);
            writer.WriteBooleanValue(IsSmoothStreamingEnabled);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        MediaEnabledProtocols IJsonModel<MediaEnabledProtocols>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaEnabledProtocols>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaEnabledProtocols)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaEnabledProtocols(document.RootElement, options);
        }

        internal static MediaEnabledProtocols DeserializeMediaEnabledProtocols(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool download = default;
            bool dash = default;
            bool hls = default;
            bool smoothStreaming = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("download"u8))
                {
                    download = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dash"u8))
                {
                    dash = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("hls"u8))
                {
                    hls = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("smoothStreaming"u8))
                {
                    smoothStreaming = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MediaEnabledProtocols(download, dash, hls, smoothStreaming, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MediaEnabledProtocols>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaEnabledProtocols>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MediaEnabledProtocols)} does not support '{options.Format}' format.");
            }
        }

        MediaEnabledProtocols IPersistableModel<MediaEnabledProtocols>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaEnabledProtocols>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMediaEnabledProtocols(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MediaEnabledProtocols)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MediaEnabledProtocols>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
