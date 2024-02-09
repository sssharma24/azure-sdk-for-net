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
    public partial class JobStepOutput : IUtf8JsonSerializable, IJsonModel<JobStepOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<JobStepOutput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<JobStepOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobStepOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JobStepOutput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(OutputType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(OutputType.Value.ToString());
            }
            if (Optional.IsDefined(SubscriptionId))
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId.Value);
            }
            if (Optional.IsDefined(ResourceGroupName))
            {
                writer.WritePropertyName("resourceGroupName"u8);
                writer.WriteStringValue(ResourceGroupName);
            }
            writer.WritePropertyName("serverName"u8);
            writer.WriteStringValue(ServerName);
            writer.WritePropertyName("databaseName"u8);
            writer.WriteStringValue(DatabaseName);
            if (Optional.IsDefined(SchemaName))
            {
                writer.WritePropertyName("schemaName"u8);
                writer.WriteStringValue(SchemaName);
            }
            writer.WritePropertyName("tableName"u8);
            writer.WriteStringValue(TableName);
            writer.WritePropertyName("credential"u8);
            writer.WriteStringValue(Credential);
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

        JobStepOutput IJsonModel<JobStepOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobStepOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JobStepOutput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeJobStepOutput(document.RootElement, options);
        }

        internal static JobStepOutput DeserializeJobStepOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<JobStepOutputType> type = default;
            Optional<Guid> subscriptionId = default;
            Optional<string> resourceGroupName = default;
            string serverName = default;
            string databaseName = default;
            Optional<string> schemaName = default;
            string tableName = default;
            string credential = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new JobStepOutputType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subscriptionId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("resourceGroupName"u8))
                {
                    resourceGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverName"u8))
                {
                    serverName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schemaName"u8))
                {
                    schemaName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tableName"u8))
                {
                    tableName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("credential"u8))
                {
                    credential = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new JobStepOutput(Optional.ToNullable(type), Optional.ToNullable(subscriptionId), resourceGroupName.Value, serverName, databaseName, schemaName.Value, tableName, credential, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(SubscriptionId))
            {
                builder.Append("  subscriptionId:");
                builder.AppendLine($" '{SubscriptionId.Value.ToString()}'");
            }

            if (Optional.IsDefined(ResourceGroupName))
            {
                builder.Append("  resourceGroupName:");
                if (ResourceGroupName.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{ResourceGroupName}'''");
                }
                else
                {
                    builder.AppendLine($" '{ResourceGroupName}'");
                }
            }

            if (Optional.IsDefined(ServerName))
            {
                builder.Append("  serverName:");
                if (ServerName.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{ServerName}'''");
                }
                else
                {
                    builder.AppendLine($" '{ServerName}'");
                }
            }

            if (Optional.IsDefined(DatabaseName))
            {
                builder.Append("  databaseName:");
                if (DatabaseName.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{DatabaseName}'''");
                }
                else
                {
                    builder.AppendLine($" '{DatabaseName}'");
                }
            }

            if (Optional.IsDefined(SchemaName))
            {
                builder.Append("  schemaName:");
                if (SchemaName.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{SchemaName}'''");
                }
                else
                {
                    builder.AppendLine($" '{SchemaName}'");
                }
            }

            if (Optional.IsDefined(TableName))
            {
                builder.Append("  tableName:");
                if (TableName.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{TableName}'''");
                }
                else
                {
                    builder.AppendLine($" '{TableName}'");
                }
            }

            if (Optional.IsDefined(Credential))
            {
                builder.Append("  credential:");
                if (Credential.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Credential}'''");
                }
                else
                {
                    builder.AppendLine($" '{Credential}'");
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

        BinaryData IPersistableModel<JobStepOutput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobStepOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(JobStepOutput)} does not support '{options.Format}' format.");
            }
        }

        JobStepOutput IPersistableModel<JobStepOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobStepOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeJobStepOutput(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(JobStepOutput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<JobStepOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
