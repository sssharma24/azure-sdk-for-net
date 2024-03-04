// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.BotService;

namespace Azure.ResourceManager.BotService.Models
{
    public partial class SmsChannel : IUtf8JsonSerializable, IJsonModel<SmsChannel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SmsChannel>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SmsChannel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SmsChannel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SmsChannel)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteObjectValue(Properties);
            }
            writer.WritePropertyName("channelName"u8);
            writer.WriteStringValue(ChannelName);
            if (Optional.IsDefined(ETag))
            {
                if (ETag != null)
                {
                    writer.WritePropertyName("etag"u8);
                    writer.WriteStringValue(ETag.Value.ToString());
                }
                else
                {
                    writer.WriteNull("etag");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
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

        SmsChannel IJsonModel<SmsChannel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SmsChannel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SmsChannel)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSmsChannel(document.RootElement, options);
        }

        internal static SmsChannel DeserializeSmsChannel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SmsChannelProperties properties = default;
            string channelName = default;
            ETag? etag = default;
            string provisioningState = default;
            AzureLocation? location = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = SmsChannelProperties.DeserializeSmsChannelProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("channelName"u8))
                {
                    channelName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        etag = null;
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SmsChannel(
                channelName,
                etag,
                provisioningState,
                location,
                serializedAdditionalRawData,
                properties);
        }

        BinaryData IPersistableModel<SmsChannel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SmsChannel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SmsChannel)} does not support '{options.Format}' format.");
            }
        }

        SmsChannel IPersistableModel<SmsChannel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SmsChannel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSmsChannel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SmsChannel)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SmsChannel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
