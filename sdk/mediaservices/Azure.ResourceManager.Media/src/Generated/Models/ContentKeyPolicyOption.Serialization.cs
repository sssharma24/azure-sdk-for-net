// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Media;

namespace Azure.ResourceManager.Media.Models
{
    public partial class ContentKeyPolicyOption : IUtf8JsonSerializable, IJsonModel<ContentKeyPolicyOption>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContentKeyPolicyOption>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContentKeyPolicyOption>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyOption>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyOption)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(PolicyOptionId))
            {
                writer.WritePropertyName("policyOptionId"u8);
                writer.WriteStringValue(PolicyOptionId.Value);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("configuration"u8);
            writer.WriteObjectValue(Configuration);
            writer.WritePropertyName("restriction"u8);
            writer.WriteObjectValue(Restriction);
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

        ContentKeyPolicyOption IJsonModel<ContentKeyPolicyOption>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyOption>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyOption)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContentKeyPolicyOption(document.RootElement, options);
        }

        internal static ContentKeyPolicyOption DeserializeContentKeyPolicyOption(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid? policyOptionId = default;
            string name = default;
            ContentKeyPolicyConfiguration configuration = default;
            ContentKeyPolicyRestriction restriction = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policyOptionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyOptionId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configuration"u8))
                {
                    configuration = ContentKeyPolicyConfiguration.DeserializeContentKeyPolicyConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("restriction"u8))
                {
                    restriction = ContentKeyPolicyRestriction.DeserializeContentKeyPolicyRestriction(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContentKeyPolicyOption(policyOptionId, name, configuration, restriction, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContentKeyPolicyOption>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyOption>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContentKeyPolicyOption)} does not support '{options.Format}' format.");
            }
        }

        ContentKeyPolicyOption IPersistableModel<ContentKeyPolicyOption>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyOption>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContentKeyPolicyOption(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContentKeyPolicyOption)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContentKeyPolicyOption>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
