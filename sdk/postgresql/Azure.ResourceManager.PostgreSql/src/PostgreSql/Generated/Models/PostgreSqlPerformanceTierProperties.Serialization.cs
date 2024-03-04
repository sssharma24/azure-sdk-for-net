// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.PostgreSql;

namespace Azure.ResourceManager.PostgreSql.Models
{
    public partial class PostgreSqlPerformanceTierProperties : IUtf8JsonSerializable, IJsonModel<PostgreSqlPerformanceTierProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostgreSqlPerformanceTierProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PostgreSqlPerformanceTierProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlPerformanceTierProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlPerformanceTierProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(MaxBackupRetentionDays))
            {
                writer.WritePropertyName("maxBackupRetentionDays"u8);
                writer.WriteNumberValue(MaxBackupRetentionDays.Value);
            }
            if (Optional.IsDefined(MinBackupRetentionDays))
            {
                writer.WritePropertyName("minBackupRetentionDays"u8);
                writer.WriteNumberValue(MinBackupRetentionDays.Value);
            }
            if (Optional.IsDefined(MaxStorageInMB))
            {
                writer.WritePropertyName("maxStorageMB"u8);
                writer.WriteNumberValue(MaxStorageInMB.Value);
            }
            if (Optional.IsDefined(MinLargeStorageInMB))
            {
                writer.WritePropertyName("minLargeStorageMB"u8);
                writer.WriteNumberValue(MinLargeStorageInMB.Value);
            }
            if (Optional.IsDefined(MaxLargeStorageInMB))
            {
                writer.WritePropertyName("maxLargeStorageMB"u8);
                writer.WriteNumberValue(MaxLargeStorageInMB.Value);
            }
            if (Optional.IsDefined(MinStorageInMB))
            {
                writer.WritePropertyName("minStorageMB"u8);
                writer.WriteNumberValue(MinStorageInMB.Value);
            }
            if (Optional.IsCollectionDefined(ServiceLevelObjectives))
            {
                writer.WritePropertyName("serviceLevelObjectives"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceLevelObjectives)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        PostgreSqlPerformanceTierProperties IJsonModel<PostgreSqlPerformanceTierProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlPerformanceTierProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlPerformanceTierProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlPerformanceTierProperties(document.RootElement, options);
        }

        internal static PostgreSqlPerformanceTierProperties DeserializePostgreSqlPerformanceTierProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            int? maxBackupRetentionDays = default;
            int? minBackupRetentionDays = default;
            int? maxStorageMB = default;
            int? minLargeStorageMB = default;
            int? maxLargeStorageMB = default;
            int? minStorageMB = default;
            IReadOnlyList<PostgreSqlPerformanceTierServiceLevelObjectives> serviceLevelObjectives = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxBackupRetentionDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxBackupRetentionDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minBackupRetentionDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minBackupRetentionDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxStorageMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxStorageMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minLargeStorageMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minLargeStorageMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxLargeStorageMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxLargeStorageMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minStorageMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minStorageMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("serviceLevelObjectives"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PostgreSqlPerformanceTierServiceLevelObjectives> array = new List<PostgreSqlPerformanceTierServiceLevelObjectives>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PostgreSqlPerformanceTierServiceLevelObjectives.DeserializePostgreSqlPerformanceTierServiceLevelObjectives(item, options));
                    }
                    serviceLevelObjectives = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PostgreSqlPerformanceTierProperties(
                id,
                maxBackupRetentionDays,
                minBackupRetentionDays,
                maxStorageMB,
                minLargeStorageMB,
                maxLargeStorageMB,
                minStorageMB,
                serviceLevelObjectives ?? new ChangeTrackingList<PostgreSqlPerformanceTierServiceLevelObjectives>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PostgreSqlPerformanceTierProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlPerformanceTierProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlPerformanceTierProperties)} does not support '{options.Format}' format.");
            }
        }

        PostgreSqlPerformanceTierProperties IPersistableModel<PostgreSqlPerformanceTierProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlPerformanceTierProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePostgreSqlPerformanceTierProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlPerformanceTierProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PostgreSqlPerformanceTierProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
