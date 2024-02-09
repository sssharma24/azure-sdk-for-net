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
    public partial class SqlMetricDefinition : IUtf8JsonSerializable, IJsonModel<SqlMetricDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlMetricDefinition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlMetricDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlMetricDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlMetricDefinition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteObjectValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(PrimaryAggregationType))
            {
                writer.WritePropertyName("primaryAggregationType"u8);
                writer.WriteStringValue(PrimaryAggregationType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceUriString))
            {
                writer.WritePropertyName("resourceUri"u8);
                writer.WriteStringValue(ResourceUriString);
            }
            if (options.Format != "W" && Optional.IsDefined(Unit))
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(MetricAvailabilities))
            {
                writer.WritePropertyName("metricAvailabilities"u8);
                writer.WriteStartArray();
                foreach (var item in MetricAvailabilities)
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

        SqlMetricDefinition IJsonModel<SqlMetricDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlMetricDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlMetricDefinition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlMetricDefinition(document.RootElement, options);
        }

        internal static SqlMetricDefinition DeserializeSqlMetricDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SqlMetricName> name = default;
            Optional<SqlMetricPrimaryAggregationType> primaryAggregationType = default;
            Optional<string> resourceUri = default;
            Optional<SqlMetricDefinitionUnitType> unit = default;
            Optional<IReadOnlyList<SqlMetricAvailability>> metricAvailabilities = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = SqlMetricName.DeserializeSqlMetricName(property.Value);
                    continue;
                }
                if (property.NameEquals("primaryAggregationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryAggregationType = new SqlMetricPrimaryAggregationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceUri"u8))
                {
                    resourceUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unit = new SqlMetricDefinitionUnitType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("metricAvailabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SqlMetricAvailability> array = new List<SqlMetricAvailability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlMetricAvailability.DeserializeSqlMetricAvailability(item));
                    }
                    metricAvailabilities = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SqlMetricDefinition(name.Value, Optional.ToNullable(primaryAggregationType), resourceUri.Value, Optional.ToNullable(unit), Optional.ToList(metricAvailabilities), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                AppendChildObject(builder, Name, options, 2, false);
            }

            if (Optional.IsDefined(PrimaryAggregationType))
            {
                builder.Append("  primaryAggregationType:");
                builder.AppendLine($" '{PrimaryAggregationType.Value.ToString()}'");
            }

            if (Optional.IsDefined(ResourceUriString))
            {
                builder.Append("  resourceUri:");
                if (ResourceUriString.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{ResourceUriString}'''");
                }
                else
                {
                    builder.AppendLine($" '{ResourceUriString}'");
                }
            }

            if (Optional.IsDefined(Unit))
            {
                builder.Append("  unit:");
                builder.AppendLine($" '{Unit.Value.ToString()}'");
            }

            if (Optional.IsCollectionDefined(MetricAvailabilities))
            {
                if (MetricAvailabilities.Any())
                {
                    builder.Append("  metricAvailabilities:");
                    builder.AppendLine(" [");
                    foreach (var item in MetricAvailabilities)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
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

        BinaryData IPersistableModel<SqlMetricDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlMetricDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SqlMetricDefinition)} does not support '{options.Format}' format.");
            }
        }

        SqlMetricDefinition IPersistableModel<SqlMetricDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlMetricDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlMetricDefinition(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SqlMetricDefinition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlMetricDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
