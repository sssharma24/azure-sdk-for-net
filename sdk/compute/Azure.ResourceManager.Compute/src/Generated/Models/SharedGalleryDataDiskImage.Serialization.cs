// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class SharedGalleryDataDiskImage : IUtf8JsonSerializable, IJsonModel<SharedGalleryDataDiskImage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SharedGalleryDataDiskImage>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SharedGalleryDataDiskImage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharedGalleryDataDiskImage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SharedGalleryDataDiskImage)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("lun"u8);
            writer.WriteNumberValue(Lun);
            if (options.Format != "W" && Optional.IsDefined(DiskSizeGB))
            {
                writer.WritePropertyName("diskSizeGB"u8);
                writer.WriteNumberValue(DiskSizeGB.Value);
            }
            if (Optional.IsDefined(HostCaching))
            {
                writer.WritePropertyName("hostCaching"u8);
                writer.WriteStringValue(HostCaching.Value.ToString());
            }
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

        SharedGalleryDataDiskImage IJsonModel<SharedGalleryDataDiskImage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharedGalleryDataDiskImage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SharedGalleryDataDiskImage)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSharedGalleryDataDiskImage(document.RootElement, options);
        }

        internal static SharedGalleryDataDiskImage DeserializeSharedGalleryDataDiskImage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int lun = default;
            int? diskSizeGB = default;
            SharedGalleryHostCaching? hostCaching = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lun"u8))
                {
                    lun = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("diskSizeGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskSizeGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("hostCaching"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hostCaching = new SharedGalleryHostCaching(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SharedGalleryDataDiskImage(diskSizeGB, hostCaching, serializedAdditionalRawData, lun);
        }

        BinaryData IPersistableModel<SharedGalleryDataDiskImage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharedGalleryDataDiskImage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SharedGalleryDataDiskImage)} does not support '{options.Format}' format.");
            }
        }

        SharedGalleryDataDiskImage IPersistableModel<SharedGalleryDataDiskImage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharedGalleryDataDiskImage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSharedGalleryDataDiskImage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SharedGalleryDataDiskImage)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SharedGalleryDataDiskImage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
