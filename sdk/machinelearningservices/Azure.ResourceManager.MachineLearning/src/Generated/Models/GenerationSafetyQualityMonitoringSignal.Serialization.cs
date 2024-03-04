// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class GenerationSafetyQualityMonitoringSignal : IUtf8JsonSerializable, IJsonModel<GenerationSafetyQualityMonitoringSignal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GenerationSafetyQualityMonitoringSignal>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GenerationSafetyQualityMonitoringSignal>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GenerationSafetyQualityMonitoringSignal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GenerationSafetyQualityMonitoringSignal)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("metricThresholds"u8);
            writer.WriteStartArray();
            foreach (var item in MetricThresholds)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(ProductionData))
            {
                if (ProductionData != null)
                {
                    writer.WritePropertyName("productionData"u8);
                    writer.WriteStartArray();
                    foreach (var item in ProductionData)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("productionData");
                }
            }
            writer.WritePropertyName("samplingRate"u8);
            writer.WriteNumberValue(SamplingRate);
            if (Optional.IsDefined(WorkspaceConnectionId))
            {
                if (WorkspaceConnectionId != null)
                {
                    writer.WritePropertyName("workspaceConnectionId"u8);
                    writer.WriteStringValue(WorkspaceConnectionId);
                }
                else
                {
                    writer.WriteNull("workspaceConnectionId");
                }
            }
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
            }
            writer.WritePropertyName("signalType"u8);
            writer.WriteStringValue(SignalType.ToString());
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

        GenerationSafetyQualityMonitoringSignal IJsonModel<GenerationSafetyQualityMonitoringSignal>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GenerationSafetyQualityMonitoringSignal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GenerationSafetyQualityMonitoringSignal)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGenerationSafetyQualityMonitoringSignal(document.RootElement, options);
        }

        internal static GenerationSafetyQualityMonitoringSignal DeserializeGenerationSafetyQualityMonitoringSignal(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<GenerationSafetyQualityMetricThreshold> metricThresholds = default;
            IList<MonitoringInputDataBase> productionData = default;
            double samplingRate = default;
            string workspaceConnectionId = default;
            MonitoringNotificationMode? mode = default;
            IDictionary<string, string> properties = default;
            MonitoringSignalType signalType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metricThresholds"u8))
                {
                    List<GenerationSafetyQualityMetricThreshold> array = new List<GenerationSafetyQualityMetricThreshold>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GenerationSafetyQualityMetricThreshold.DeserializeGenerationSafetyQualityMetricThreshold(item, options));
                    }
                    metricThresholds = array;
                    continue;
                }
                if (property.NameEquals("productionData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        productionData = null;
                        continue;
                    }
                    List<MonitoringInputDataBase> array = new List<MonitoringInputDataBase>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitoringInputDataBase.DeserializeMonitoringInputDataBase(item, options));
                    }
                    productionData = array;
                    continue;
                }
                if (property.NameEquals("samplingRate"u8))
                {
                    samplingRate = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("workspaceConnectionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        workspaceConnectionId = null;
                        continue;
                    }
                    workspaceConnectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = new MonitoringNotificationMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("signalType"u8))
                {
                    signalType = new MonitoringSignalType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GenerationSafetyQualityMonitoringSignal(
                mode,
                properties ?? new ChangeTrackingDictionary<string, string>(),
                signalType,
                serializedAdditionalRawData,
                metricThresholds,
                productionData ?? new ChangeTrackingList<MonitoringInputDataBase>(),
                samplingRate,
                workspaceConnectionId);
        }

        BinaryData IPersistableModel<GenerationSafetyQualityMonitoringSignal>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GenerationSafetyQualityMonitoringSignal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GenerationSafetyQualityMonitoringSignal)} does not support '{options.Format}' format.");
            }
        }

        GenerationSafetyQualityMonitoringSignal IPersistableModel<GenerationSafetyQualityMonitoringSignal>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GenerationSafetyQualityMonitoringSignal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGenerationSafetyQualityMonitoringSignal(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GenerationSafetyQualityMonitoringSignal)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GenerationSafetyQualityMonitoringSignal>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
