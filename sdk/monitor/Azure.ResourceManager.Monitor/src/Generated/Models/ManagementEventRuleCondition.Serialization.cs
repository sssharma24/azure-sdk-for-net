// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class ManagementEventRuleCondition : IUtf8JsonSerializable, IJsonModel<ManagementEventRuleCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagementEventRuleCondition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagementEventRuleCondition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementEventRuleCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementEventRuleCondition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Aggregation))
            {
                writer.WritePropertyName("aggregation"u8);
                writer.WriteObjectValue(Aggregation);
            }
            writer.WritePropertyName("odata.type"u8);
            writer.WriteStringValue(OdataType);
            if (Optional.IsDefined(DataSource))
            {
                writer.WritePropertyName("dataSource"u8);
                writer.WriteObjectValue(DataSource);
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

        ManagementEventRuleCondition IJsonModel<ManagementEventRuleCondition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementEventRuleCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementEventRuleCondition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagementEventRuleCondition(document.RootElement, options);
        }

        internal static ManagementEventRuleCondition DeserializeManagementEventRuleCondition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ManagementEventAggregationCondition aggregation = default;
            string odataType = default;
            RuleDataSource dataSource = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("aggregation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aggregation = ManagementEventAggregationCondition.DeserializeManagementEventAggregationCondition(property.Value, options);
                    continue;
                }
                if (property.NameEquals("odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataSource = RuleDataSource.DeserializeRuleDataSource(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagementEventRuleCondition(odataType, dataSource, serializedAdditionalRawData, aggregation);
        }

        BinaryData IPersistableModel<ManagementEventRuleCondition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementEventRuleCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagementEventRuleCondition)} does not support '{options.Format}' format.");
            }
        }

        ManagementEventRuleCondition IPersistableModel<ManagementEventRuleCondition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementEventRuleCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagementEventRuleCondition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagementEventRuleCondition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagementEventRuleCondition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
