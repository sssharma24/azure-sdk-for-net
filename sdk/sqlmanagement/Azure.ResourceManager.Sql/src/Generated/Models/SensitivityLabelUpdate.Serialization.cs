// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SensitivityLabelUpdate : IUtf8JsonSerializable, IJsonModel<SensitivityLabelUpdate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SensitivityLabelUpdate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SensitivityLabelUpdate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SensitivityLabelUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SensitivityLabelUpdate)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Op))
            {
                writer.WritePropertyName("op"u8);
                writer.WriteStringValue(Op.Value.ToSerialString());
            }
            if (Optional.IsDefined(Schema))
            {
                writer.WritePropertyName("schema"u8);
                writer.WriteStringValue(Schema);
            }
            if (Optional.IsDefined(Table))
            {
                writer.WritePropertyName("table"u8);
                writer.WriteStringValue(Table);
            }
            if (Optional.IsDefined(Column))
            {
                writer.WritePropertyName("column"u8);
                writer.WriteStringValue(Column);
            }
            if (Optional.IsDefined(SensitivityLabel))
            {
                writer.WritePropertyName("sensitivityLabel"u8);
                writer.WriteObjectValue(SensitivityLabel);
            }
            writer.WriteEndObject();
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

        SensitivityLabelUpdate IJsonModel<SensitivityLabelUpdate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SensitivityLabelUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SensitivityLabelUpdate)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSensitivityLabelUpdate(document.RootElement, options);
        }

        internal static SensitivityLabelUpdate DeserializeSensitivityLabelUpdate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<SensitivityLabelUpdateKind> op = default;
            Optional<string> schema = default;
            Optional<string> table = default;
            Optional<string> column = default;
            Optional<SensitivityLabelData> sensitivityLabel = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("op"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            op = property0.Value.GetString().ToSensitivityLabelUpdateKind();
                            continue;
                        }
                        if (property0.NameEquals("schema"u8))
                        {
                            schema = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("table"u8))
                        {
                            table = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("column"u8))
                        {
                            column = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sensitivityLabel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sensitivityLabel = SensitivityLabelData.DeserializeSensitivityLabelData(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SensitivityLabelUpdate(id, name, type, systemData.Value, Optional.ToNullable(op), schema.Value, table.Value, column.Value, sensitivityLabel.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                if (Name.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Name}'''");
                }
                else
                {
                    builder.AppendLine($" '{Name}'");
                }
            }

            if (Optional.IsDefined(Id))
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id.ToString()}'");
            }

            if (Optional.IsDefined(SystemData))
            {
                builder.Append("  systemData:");
                builder.AppendLine($" '{SystemData.ToString()}'");
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            if (Optional.IsDefined(Op))
            {
                builder.Append("    op:");
                builder.AppendLine($" '{Op.Value.ToSerialString()}'");
            }

            if (Optional.IsDefined(Schema))
            {
                builder.Append("    schema:");
                if (Schema.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Schema}'''");
                }
                else
                {
                    builder.AppendLine($" '{Schema}'");
                }
            }

            if (Optional.IsDefined(Table))
            {
                builder.Append("    table:");
                if (Table.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Table}'''");
                }
                else
                {
                    builder.AppendLine($" '{Table}'");
                }
            }

            if (Optional.IsDefined(Column))
            {
                builder.Append("    column:");
                if (Column.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Column}'''");
                }
                else
                {
                    builder.AppendLine($" '{Column}'");
                }
            }

            if (Optional.IsDefined(SensitivityLabel))
            {
                builder.Append("    sensitivityLabel:");
                AppendChildObject(builder, SensitivityLabel, options, 4, false);
            }

            builder.AppendLine("  }");
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

        BinaryData IPersistableModel<SensitivityLabelUpdate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SensitivityLabelUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SensitivityLabelUpdate)} does not support '{options.Format}' format.");
            }
        }

        SensitivityLabelUpdate IPersistableModel<SensitivityLabelUpdate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SensitivityLabelUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSensitivityLabelUpdate(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SensitivityLabelUpdate)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SensitivityLabelUpdate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
