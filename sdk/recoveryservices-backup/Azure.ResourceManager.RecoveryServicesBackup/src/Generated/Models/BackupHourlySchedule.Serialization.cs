// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesBackup;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class BackupHourlySchedule : IUtf8JsonSerializable, IJsonModel<BackupHourlySchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupHourlySchedule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackupHourlySchedule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupHourlySchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupHourlySchedule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Interval))
            {
                writer.WritePropertyName("interval"u8);
                writer.WriteNumberValue(Interval.Value);
            }
            if (Optional.IsDefined(ScheduleWindowStartOn))
            {
                writer.WritePropertyName("scheduleWindowStartTime"u8);
                writer.WriteStringValue(ScheduleWindowStartOn.Value, "O");
            }
            if (Optional.IsDefined(ScheduleWindowDuration))
            {
                writer.WritePropertyName("scheduleWindowDuration"u8);
                writer.WriteNumberValue(ScheduleWindowDuration.Value);
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

        BackupHourlySchedule IJsonModel<BackupHourlySchedule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupHourlySchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupHourlySchedule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupHourlySchedule(document.RootElement, options);
        }

        internal static BackupHourlySchedule DeserializeBackupHourlySchedule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? interval = default;
            DateTimeOffset? scheduleWindowStartTime = default;
            int? scheduleWindowDuration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("interval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    interval = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("scheduleWindowStartTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduleWindowStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("scheduleWindowDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduleWindowDuration = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BackupHourlySchedule(interval, scheduleWindowStartTime, scheduleWindowDuration, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BackupHourlySchedule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupHourlySchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackupHourlySchedule)} does not support '{options.Format}' format.");
            }
        }

        BackupHourlySchedule IPersistableModel<BackupHourlySchedule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupHourlySchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupHourlySchedule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackupHourlySchedule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupHourlySchedule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
