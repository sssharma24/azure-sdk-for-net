// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ElasticPoolPerformanceLevelCapability : IUtf8JsonSerializable, IJsonModel<ElasticPoolPerformanceLevelCapability>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ElasticPoolPerformanceLevelCapability>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ElasticPoolPerformanceLevelCapability>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticPoolPerformanceLevelCapability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ElasticPoolPerformanceLevelCapability)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(PerformanceLevel))
            {
                writer.WritePropertyName("performanceLevel"u8);
                writer.WriteObjectValue(PerformanceLevel);
            }
            if (options.Format != "W" && Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedLicenseTypes))
            {
                writer.WritePropertyName("supportedLicenseTypes"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedLicenseTypes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(MaxDatabaseCount))
            {
                writer.WritePropertyName("maxDatabaseCount"u8);
                writer.WriteNumberValue(MaxDatabaseCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IncludedMaxSize))
            {
                writer.WritePropertyName("includedMaxSize"u8);
                writer.WriteObjectValue(IncludedMaxSize);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedMaxSizes))
            {
                writer.WritePropertyName("supportedMaxSizes"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedMaxSizes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedPerDatabaseMaxSizes))
            {
                writer.WritePropertyName("supportedPerDatabaseMaxSizes"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedPerDatabaseMaxSizes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedPerDatabaseMaxPerformanceLevels))
            {
                writer.WritePropertyName("supportedPerDatabaseMaxPerformanceLevels"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedPerDatabaseMaxPerformanceLevels)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(IsZoneRedundant))
            {
                writer.WritePropertyName("zoneRedundant"u8);
                writer.WriteBooleanValue(IsZoneRedundant.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedMaintenanceConfigurations))
            {
                writer.WritePropertyName("supportedMaintenanceConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedMaintenanceConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (Optional.IsDefined(Reason))
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason);
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

        ElasticPoolPerformanceLevelCapability IJsonModel<ElasticPoolPerformanceLevelCapability>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticPoolPerformanceLevelCapability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ElasticPoolPerformanceLevelCapability)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeElasticPoolPerformanceLevelCapability(document.RootElement, options);
        }

        internal static ElasticPoolPerformanceLevelCapability DeserializeElasticPoolPerformanceLevelCapability(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PerformanceLevelCapability> performanceLevel = default;
            Optional<SqlSku> sku = default;
            Optional<IReadOnlyList<LicenseTypeCapability>> supportedLicenseTypes = default;
            Optional<int> maxDatabaseCount = default;
            Optional<MaxSizeCapability> includedMaxSize = default;
            Optional<IReadOnlyList<MaxSizeRangeCapability>> supportedMaxSizes = default;
            Optional<IReadOnlyList<MaxSizeRangeCapability>> supportedPerDatabaseMaxSizes = default;
            Optional<IReadOnlyList<ElasticPoolPerDatabaseMaxPerformanceLevelCapability>> supportedPerDatabaseMaxPerformanceLevels = default;
            Optional<bool> zoneRedundant = default;
            Optional<IReadOnlyList<MaintenanceConfigurationCapability>> supportedMaintenanceConfigurations = default;
            Optional<SqlCapabilityStatus> status = default;
            Optional<string> reason = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("performanceLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    performanceLevel = PerformanceLevelCapability.DeserializePerformanceLevelCapability(property.Value);
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = SqlSku.DeserializeSqlSku(property.Value);
                    continue;
                }
                if (property.NameEquals("supportedLicenseTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LicenseTypeCapability> array = new List<LicenseTypeCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LicenseTypeCapability.DeserializeLicenseTypeCapability(item));
                    }
                    supportedLicenseTypes = array;
                    continue;
                }
                if (property.NameEquals("maxDatabaseCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxDatabaseCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("includedMaxSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    includedMaxSize = MaxSizeCapability.DeserializeMaxSizeCapability(property.Value);
                    continue;
                }
                if (property.NameEquals("supportedMaxSizes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MaxSizeRangeCapability> array = new List<MaxSizeRangeCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MaxSizeRangeCapability.DeserializeMaxSizeRangeCapability(item));
                    }
                    supportedMaxSizes = array;
                    continue;
                }
                if (property.NameEquals("supportedPerDatabaseMaxSizes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MaxSizeRangeCapability> array = new List<MaxSizeRangeCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MaxSizeRangeCapability.DeserializeMaxSizeRangeCapability(item));
                    }
                    supportedPerDatabaseMaxSizes = array;
                    continue;
                }
                if (property.NameEquals("supportedPerDatabaseMaxPerformanceLevels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ElasticPoolPerDatabaseMaxPerformanceLevelCapability> array = new List<ElasticPoolPerDatabaseMaxPerformanceLevelCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ElasticPoolPerDatabaseMaxPerformanceLevelCapability.DeserializeElasticPoolPerDatabaseMaxPerformanceLevelCapability(item));
                    }
                    supportedPerDatabaseMaxPerformanceLevels = array;
                    continue;
                }
                if (property.NameEquals("zoneRedundant"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    zoneRedundant = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("supportedMaintenanceConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MaintenanceConfigurationCapability> array = new List<MaintenanceConfigurationCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MaintenanceConfigurationCapability.DeserializeMaintenanceConfigurationCapability(item));
                    }
                    supportedMaintenanceConfigurations = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToSqlCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ElasticPoolPerformanceLevelCapability(performanceLevel.Value, sku.Value, Optional.ToList(supportedLicenseTypes), Optional.ToNullable(maxDatabaseCount), includedMaxSize.Value, Optional.ToList(supportedMaxSizes), Optional.ToList(supportedPerDatabaseMaxSizes), Optional.ToList(supportedPerDatabaseMaxPerformanceLevels), Optional.ToNullable(zoneRedundant), Optional.ToList(supportedMaintenanceConfigurations), Optional.ToNullable(status), reason.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(PerformanceLevel))
            {
                builder.Append("  performanceLevel:");
                AppendChildObject(builder, PerformanceLevel, options, 2, false);
            }

            if (Optional.IsDefined(Sku))
            {
                builder.Append("  sku:");
                AppendChildObject(builder, Sku, options, 2, false);
            }

            if (Optional.IsCollectionDefined(SupportedLicenseTypes))
            {
                if (SupportedLicenseTypes.Any())
                {
                    builder.Append("  supportedLicenseTypes:");
                    builder.AppendLine(" [");
                    foreach (var item in SupportedLicenseTypes)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsDefined(MaxDatabaseCount))
            {
                builder.Append("  maxDatabaseCount:");
                builder.AppendLine($" {MaxDatabaseCount.Value}");
            }

            if (Optional.IsDefined(IncludedMaxSize))
            {
                builder.Append("  includedMaxSize:");
                AppendChildObject(builder, IncludedMaxSize, options, 2, false);
            }

            if (Optional.IsCollectionDefined(SupportedMaxSizes))
            {
                if (SupportedMaxSizes.Any())
                {
                    builder.Append("  supportedMaxSizes:");
                    builder.AppendLine(" [");
                    foreach (var item in SupportedMaxSizes)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsCollectionDefined(SupportedPerDatabaseMaxSizes))
            {
                if (SupportedPerDatabaseMaxSizes.Any())
                {
                    builder.Append("  supportedPerDatabaseMaxSizes:");
                    builder.AppendLine(" [");
                    foreach (var item in SupportedPerDatabaseMaxSizes)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsCollectionDefined(SupportedPerDatabaseMaxPerformanceLevels))
            {
                if (SupportedPerDatabaseMaxPerformanceLevels.Any())
                {
                    builder.Append("  supportedPerDatabaseMaxPerformanceLevels:");
                    builder.AppendLine(" [");
                    foreach (var item in SupportedPerDatabaseMaxPerformanceLevels)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsDefined(IsZoneRedundant))
            {
                builder.Append("  zoneRedundant:");
                var boolValue = IsZoneRedundant.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsCollectionDefined(SupportedMaintenanceConfigurations))
            {
                if (SupportedMaintenanceConfigurations.Any())
                {
                    builder.Append("  supportedMaintenanceConfigurations:");
                    builder.AppendLine(" [");
                    foreach (var item in SupportedMaintenanceConfigurations)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsDefined(Status))
            {
                builder.Append("  status:");
                builder.AppendLine($" '{Status.Value.ToSerialString()}'");
            }

            if (Optional.IsDefined(Reason))
            {
                builder.Append("  reason:");
                if (Reason.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Reason}'''");
                }
                else
                {
                    builder.AppendLine($" '{Reason}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            bool inMultilineString = false;
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (inMultilineString)
                {
                    if (line.Contains("'''"))
                    {
                        inMultilineString = false;
                    }
                    stringBuilder.AppendLine(line);
                    continue;
                }
                if (line.Contains("'''"))
                {
                    inMultilineString = true;
                    stringBuilder.AppendLine($"{indent}{line}");
                    continue;
                }
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<ElasticPoolPerformanceLevelCapability>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticPoolPerformanceLevelCapability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ElasticPoolPerformanceLevelCapability)} does not support '{options.Format}' format.");
            }
        }

        ElasticPoolPerformanceLevelCapability IPersistableModel<ElasticPoolPerformanceLevelCapability>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticPoolPerformanceLevelCapability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeElasticPoolPerformanceLevelCapability(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ElasticPoolPerformanceLevelCapability)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ElasticPoolPerformanceLevelCapability>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
