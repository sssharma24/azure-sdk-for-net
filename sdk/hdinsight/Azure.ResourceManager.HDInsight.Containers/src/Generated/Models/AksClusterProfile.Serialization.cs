// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HDInsight.Containers;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class AksClusterProfile : IUtf8JsonSerializable, IJsonModel<AksClusterProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AksClusterProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AksClusterProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AksClusterProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AksClusterProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AksClusterResourceId))
            {
                writer.WritePropertyName("aksClusterResourceId"u8);
                writer.WriteStringValue(AksClusterResourceId);
            }
            if (Optional.IsDefined(AksClusterAgentPoolIdentityProfile))
            {
                writer.WritePropertyName("aksClusterAgentPoolIdentityProfile"u8);
                writer.WriteObjectValue(AksClusterAgentPoolIdentityProfile);
            }
            if (options.Format != "W" && Optional.IsDefined(AksVersion))
            {
                writer.WritePropertyName("aksVersion"u8);
                writer.WriteStringValue(AksVersion);
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

        AksClusterProfile IJsonModel<AksClusterProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AksClusterProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AksClusterProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAksClusterProfile(document.RootElement, options);
        }

        internal static AksClusterProfile DeserializeAksClusterProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier aksClusterResourceId = default;
            HDInsightIdentityProfile aksClusterAgentPoolIdentityProfile = default;
            string aksVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("aksClusterResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aksClusterResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("aksClusterAgentPoolIdentityProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aksClusterAgentPoolIdentityProfile = HDInsightIdentityProfile.DeserializeHDInsightIdentityProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("aksVersion"u8))
                {
                    aksVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AksClusterProfile(aksClusterResourceId, aksClusterAgentPoolIdentityProfile, aksVersion, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AksClusterProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AksClusterProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AksClusterProfile)} does not support '{options.Format}' format.");
            }
        }

        AksClusterProfile IPersistableModel<AksClusterProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AksClusterProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAksClusterProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AksClusterProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AksClusterProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
