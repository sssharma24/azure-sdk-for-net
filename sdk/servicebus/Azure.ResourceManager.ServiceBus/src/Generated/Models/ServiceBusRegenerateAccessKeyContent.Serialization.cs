// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ServiceBus;

namespace Azure.ResourceManager.ServiceBus.Models
{
    public partial class ServiceBusRegenerateAccessKeyContent : IUtf8JsonSerializable, IJsonModel<ServiceBusRegenerateAccessKeyContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceBusRegenerateAccessKeyContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceBusRegenerateAccessKeyContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusRegenerateAccessKeyContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceBusRegenerateAccessKeyContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("keyType"u8);
            writer.WriteStringValue(KeyType.ToSerialString());
            if (Optional.IsDefined(Key))
            {
                writer.WritePropertyName("key"u8);
                writer.WriteStringValue(Key);
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

        ServiceBusRegenerateAccessKeyContent IJsonModel<ServiceBusRegenerateAccessKeyContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusRegenerateAccessKeyContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceBusRegenerateAccessKeyContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceBusRegenerateAccessKeyContent(document.RootElement, options);
        }

        internal static ServiceBusRegenerateAccessKeyContent DeserializeServiceBusRegenerateAccessKeyContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ServiceBusAccessKeyType keyType = default;
            string key = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyType"u8))
                {
                    keyType = property.Value.GetString().ToServiceBusAccessKeyType();
                    continue;
                }
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServiceBusRegenerateAccessKeyContent(keyType, key, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceBusRegenerateAccessKeyContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusRegenerateAccessKeyContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServiceBusRegenerateAccessKeyContent)} does not support '{options.Format}' format.");
            }
        }

        ServiceBusRegenerateAccessKeyContent IPersistableModel<ServiceBusRegenerateAccessKeyContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusRegenerateAccessKeyContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceBusRegenerateAccessKeyContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceBusRegenerateAccessKeyContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceBusRegenerateAccessKeyContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
