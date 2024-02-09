// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class ReRegisterSubscriptionMetadata : IUtf8JsonSerializable, IJsonModel<ReRegisterSubscriptionMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReRegisterSubscriptionMetadata>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReRegisterSubscriptionMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReRegisterSubscriptionMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReRegisterSubscriptionMetadata)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("enabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            if (Optional.IsDefined(ConcurrencyLimit))
            {
                writer.WritePropertyName("concurrencyLimit"u8);
                writer.WriteNumberValue(ConcurrencyLimit.Value);
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

        ReRegisterSubscriptionMetadata IJsonModel<ReRegisterSubscriptionMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReRegisterSubscriptionMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReRegisterSubscriptionMetadata)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReRegisterSubscriptionMetadata(document.RootElement, options);
        }

        internal static ReRegisterSubscriptionMetadata DeserializeReRegisterSubscriptionMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool enabled = default;
            Optional<int> concurrencyLimit = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("concurrencyLimit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    concurrencyLimit = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReRegisterSubscriptionMetadata(enabled, Optional.ToNullable(concurrencyLimit), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReRegisterSubscriptionMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReRegisterSubscriptionMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReRegisterSubscriptionMetadata)} does not support '{options.Format}' format.");
            }
        }

        ReRegisterSubscriptionMetadata IPersistableModel<ReRegisterSubscriptionMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReRegisterSubscriptionMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReRegisterSubscriptionMetadata(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReRegisterSubscriptionMetadata)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReRegisterSubscriptionMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
