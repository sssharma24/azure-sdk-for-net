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

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SyncFullSchemaTableColumn : IUtf8JsonSerializable, IJsonModel<SyncFullSchemaTableColumn>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SyncFullSchemaTableColumn>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SyncFullSchemaTableColumn>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncFullSchemaTableColumn>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SyncFullSchemaTableColumn)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(DataSize))
            {
                writer.WritePropertyName("dataSize"u8);
                writer.WriteStringValue(DataSize);
            }
            if (options.Format != "W" && Optional.IsDefined(DataType))
            {
                writer.WritePropertyName("dataType"u8);
                writer.WriteStringValue(DataType);
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorId))
            {
                writer.WritePropertyName("errorId"u8);
                writer.WriteStringValue(ErrorId);
            }
            if (options.Format != "W" && Optional.IsDefined(HasError))
            {
                writer.WritePropertyName("hasError"u8);
                writer.WriteBooleanValue(HasError.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsPrimaryKey))
            {
                writer.WritePropertyName("isPrimaryKey"u8);
                writer.WriteBooleanValue(IsPrimaryKey.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(QuotedName))
            {
                writer.WritePropertyName("quotedName"u8);
                writer.WriteStringValue(QuotedName);
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

        SyncFullSchemaTableColumn IJsonModel<SyncFullSchemaTableColumn>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncFullSchemaTableColumn>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SyncFullSchemaTableColumn)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSyncFullSchemaTableColumn(document.RootElement, options);
        }

        internal static SyncFullSchemaTableColumn DeserializeSyncFullSchemaTableColumn(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> dataSize = default;
            Optional<string> dataType = default;
            Optional<string> errorId = default;
            Optional<bool> hasError = default;
            Optional<bool> isPrimaryKey = default;
            Optional<string> name = default;
            Optional<string> quotedName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataSize"u8))
                {
                    dataSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataType"u8))
                {
                    dataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorId"u8))
                {
                    errorId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hasError"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasError = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isPrimaryKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPrimaryKey = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quotedName"u8))
                {
                    quotedName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SyncFullSchemaTableColumn(dataSize.Value, dataType.Value, errorId.Value, Optional.ToNullable(hasError), Optional.ToNullable(isPrimaryKey), name.Value, quotedName.Value, serializedAdditionalRawData);
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

            if (Optional.IsDefined(DataSize))
            {
                builder.Append("  dataSize:");
                if (DataSize.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{DataSize}'''");
                }
                else
                {
                    builder.AppendLine($" '{DataSize}'");
                }
            }

            if (Optional.IsDefined(DataType))
            {
                builder.Append("  dataType:");
                if (DataType.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{DataType}'''");
                }
                else
                {
                    builder.AppendLine($" '{DataType}'");
                }
            }

            if (Optional.IsDefined(ErrorId))
            {
                builder.Append("  errorId:");
                if (ErrorId.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{ErrorId}'''");
                }
                else
                {
                    builder.AppendLine($" '{ErrorId}'");
                }
            }

            if (Optional.IsDefined(HasError))
            {
                builder.Append("  hasError:");
                var boolValue = HasError.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(IsPrimaryKey))
            {
                builder.Append("  isPrimaryKey:");
                var boolValue = IsPrimaryKey.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(QuotedName))
            {
                builder.Append("  quotedName:");
                if (QuotedName.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{QuotedName}'''");
                }
                else
                {
                    builder.AppendLine($" '{QuotedName}'");
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

        BinaryData IPersistableModel<SyncFullSchemaTableColumn>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncFullSchemaTableColumn>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SyncFullSchemaTableColumn)} does not support '{options.Format}' format.");
            }
        }

        SyncFullSchemaTableColumn IPersistableModel<SyncFullSchemaTableColumn>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncFullSchemaTableColumn>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSyncFullSchemaTableColumn(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SyncFullSchemaTableColumn)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SyncFullSchemaTableColumn>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
