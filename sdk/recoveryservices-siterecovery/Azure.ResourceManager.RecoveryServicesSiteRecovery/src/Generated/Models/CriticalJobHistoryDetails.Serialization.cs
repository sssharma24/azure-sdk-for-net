// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class CriticalJobHistoryDetails : IUtf8JsonSerializable, IJsonModel<CriticalJobHistoryDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CriticalJobHistoryDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CriticalJobHistoryDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CriticalJobHistoryDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CriticalJobHistoryDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(JobName))
            {
                writer.WritePropertyName("jobName"u8);
                writer.WriteStringValue(JobName);
            }
            if (options.Format != "W" && Optional.IsDefined(JobId))
            {
                writer.WritePropertyName("jobId"u8);
                writer.WriteStringValue(JobId);
            }
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(JobStatus))
            {
                writer.WritePropertyName("jobStatus"u8);
                writer.WriteStringValue(JobStatus);
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

        CriticalJobHistoryDetails IJsonModel<CriticalJobHistoryDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CriticalJobHistoryDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CriticalJobHistoryDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCriticalJobHistoryDetails(document.RootElement, options);
        }

        internal static CriticalJobHistoryDetails DeserializeCriticalJobHistoryDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string jobName = default;
            ResourceIdentifier jobId = default;
            DateTimeOffset? startTime = default;
            string jobStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobName"u8))
                {
                    jobName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("jobStatus"u8))
                {
                    jobStatus = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CriticalJobHistoryDetails(jobName, jobId, startTime, jobStatus, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CriticalJobHistoryDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CriticalJobHistoryDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CriticalJobHistoryDetails)} does not support '{options.Format}' format.");
            }
        }

        CriticalJobHistoryDetails IPersistableModel<CriticalJobHistoryDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CriticalJobHistoryDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCriticalJobHistoryDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CriticalJobHistoryDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CriticalJobHistoryDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
