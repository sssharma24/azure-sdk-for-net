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

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ElasticPoolActivity : IUtf8JsonSerializable, IJsonModel<ElasticPoolActivity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ElasticPoolActivity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ElasticPoolActivity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticPoolActivity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ElasticPoolActivity)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
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
            if (options.Format != "W" && Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorCode))
            {
                writer.WritePropertyName("errorCode"u8);
                writer.WriteNumberValue(ErrorCode.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorMessage))
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorSeverity))
            {
                writer.WritePropertyName("errorSeverity"u8);
                writer.WriteNumberValue(ErrorSeverity.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Operation))
            {
                writer.WritePropertyName("operation"u8);
                writer.WriteStringValue(Operation);
            }
            if (options.Format != "W" && Optional.IsDefined(OperationId))
            {
                writer.WritePropertyName("operationId"u8);
                writer.WriteStringValue(OperationId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PercentComplete))
            {
                writer.WritePropertyName("percentComplete"u8);
                writer.WriteNumberValue(PercentComplete.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(RequestedDatabaseDtuMax))
            {
                writer.WritePropertyName("requestedDatabaseDtuMax"u8);
                writer.WriteNumberValue(RequestedDatabaseDtuMax.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(RequestedDatabaseDtuMin))
            {
                writer.WritePropertyName("requestedDatabaseDtuMin"u8);
                writer.WriteNumberValue(RequestedDatabaseDtuMin.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(RequestedDtu))
            {
                writer.WritePropertyName("requestedDtu"u8);
                writer.WriteNumberValue(RequestedDtu.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(RequestedElasticPoolName))
            {
                writer.WritePropertyName("requestedElasticPoolName"u8);
                writer.WriteStringValue(RequestedElasticPoolName);
            }
            if (options.Format != "W" && Optional.IsDefined(RequestedStorageLimitInGB))
            {
                writer.WritePropertyName("requestedStorageLimitInGB"u8);
                writer.WriteNumberValue(RequestedStorageLimitInGB.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ElasticPoolName))
            {
                writer.WritePropertyName("elasticPoolName"u8);
                writer.WriteStringValue(ElasticPoolName);
            }
            if (options.Format != "W" && Optional.IsDefined(ServerName))
            {
                writer.WritePropertyName("serverName"u8);
                writer.WriteStringValue(ServerName);
            }
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
            }
            if (options.Format != "W" && Optional.IsDefined(RequestedStorageLimitInMB))
            {
                writer.WritePropertyName("requestedStorageLimitInMB"u8);
                writer.WriteNumberValue(RequestedStorageLimitInMB.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(RequestedDatabaseDtuGuarantee))
            {
                writer.WritePropertyName("requestedDatabaseDtuGuarantee"u8);
                writer.WriteNumberValue(RequestedDatabaseDtuGuarantee.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(RequestedDatabaseDtuCap))
            {
                writer.WritePropertyName("requestedDatabaseDtuCap"u8);
                writer.WriteNumberValue(RequestedDatabaseDtuCap.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(RequestedDtuGuarantee))
            {
                writer.WritePropertyName("requestedDtuGuarantee"u8);
                writer.WriteNumberValue(RequestedDtuGuarantee.Value);
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

        ElasticPoolActivity IJsonModel<ElasticPoolActivity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticPoolActivity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ElasticPoolActivity)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeElasticPoolActivity(document.RootElement, options);
        }

        internal static ElasticPoolActivity DeserializeElasticPoolActivity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<int> errorCode = default;
            Optional<string> errorMessage = default;
            Optional<int> errorSeverity = default;
            Optional<string> operation = default;
            Optional<Guid> operationId = default;
            Optional<int> percentComplete = default;
            Optional<int> requestedDatabaseDtuMax = default;
            Optional<int> requestedDatabaseDtuMin = default;
            Optional<int> requestedDtu = default;
            Optional<string> requestedElasticPoolName = default;
            Optional<long> requestedStorageLimitInGB = default;
            Optional<string> elasticPoolName = default;
            Optional<string> serverName = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<string> state = default;
            Optional<int> requestedStorageLimitInMB = default;
            Optional<int> requestedDatabaseDtuGuarantee = default;
            Optional<int> requestedDatabaseDtuCap = default;
            Optional<int> requestedDtuGuarantee = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("endTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("errorCode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            errorCode = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("errorMessage"u8))
                        {
                            errorMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("errorSeverity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            errorSeverity = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("operation"u8))
                        {
                            operation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("operationId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            operationId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("percentComplete"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            percentComplete = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("requestedDatabaseDtuMax"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            requestedDatabaseDtuMax = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("requestedDatabaseDtuMin"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            requestedDatabaseDtuMin = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("requestedDtu"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            requestedDtu = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("requestedElasticPoolName"u8))
                        {
                            requestedElasticPoolName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("requestedStorageLimitInGB"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            requestedStorageLimitInGB = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("elasticPoolName"u8))
                        {
                            elasticPoolName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverName"u8))
                        {
                            serverName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("startTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            state = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("requestedStorageLimitInMB"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            requestedStorageLimitInMB = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("requestedDatabaseDtuGuarantee"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            requestedDatabaseDtuGuarantee = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("requestedDatabaseDtuCap"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            requestedDatabaseDtuCap = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("requestedDtuGuarantee"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            requestedDtuGuarantee = property0.Value.GetInt32();
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
            return new ElasticPoolActivity(id, name, type, systemData.Value, Optional.ToNullable(location), Optional.ToNullable(endTime), Optional.ToNullable(errorCode), errorMessage.Value, Optional.ToNullable(errorSeverity), operation.Value, Optional.ToNullable(operationId), Optional.ToNullable(percentComplete), Optional.ToNullable(requestedDatabaseDtuMax), Optional.ToNullable(requestedDatabaseDtuMin), Optional.ToNullable(requestedDtu), requestedElasticPoolName.Value, Optional.ToNullable(requestedStorageLimitInGB), elasticPoolName.Value, serverName.Value, Optional.ToNullable(startTime), state.Value, Optional.ToNullable(requestedStorageLimitInMB), Optional.ToNullable(requestedDatabaseDtuGuarantee), Optional.ToNullable(requestedDatabaseDtuCap), Optional.ToNullable(requestedDtuGuarantee), serializedAdditionalRawData);
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

            if (Optional.IsDefined(Location))
            {
                builder.Append("  location:");
                builder.AppendLine($" '{Location.Value.ToString()}'");
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
            if (Optional.IsDefined(EndOn))
            {
                builder.Append("    endTime:");
                var formattedDateTimeString = TypeFormatters.ToString(EndOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(ErrorCode))
            {
                builder.Append("    errorCode:");
                builder.AppendLine($" {ErrorCode.Value}");
            }

            if (Optional.IsDefined(ErrorMessage))
            {
                builder.Append("    errorMessage:");
                if (ErrorMessage.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{ErrorMessage}'''");
                }
                else
                {
                    builder.AppendLine($" '{ErrorMessage}'");
                }
            }

            if (Optional.IsDefined(ErrorSeverity))
            {
                builder.Append("    errorSeverity:");
                builder.AppendLine($" {ErrorSeverity.Value}");
            }

            if (Optional.IsDefined(Operation))
            {
                builder.Append("    operation:");
                if (Operation.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Operation}'''");
                }
                else
                {
                    builder.AppendLine($" '{Operation}'");
                }
            }

            if (Optional.IsDefined(OperationId))
            {
                builder.Append("    operationId:");
                builder.AppendLine($" '{OperationId.Value.ToString()}'");
            }

            if (Optional.IsDefined(PercentComplete))
            {
                builder.Append("    percentComplete:");
                builder.AppendLine($" {PercentComplete.Value}");
            }

            if (Optional.IsDefined(RequestedDatabaseDtuMax))
            {
                builder.Append("    requestedDatabaseDtuMax:");
                builder.AppendLine($" {RequestedDatabaseDtuMax.Value}");
            }

            if (Optional.IsDefined(RequestedDatabaseDtuMin))
            {
                builder.Append("    requestedDatabaseDtuMin:");
                builder.AppendLine($" {RequestedDatabaseDtuMin.Value}");
            }

            if (Optional.IsDefined(RequestedDtu))
            {
                builder.Append("    requestedDtu:");
                builder.AppendLine($" {RequestedDtu.Value}");
            }

            if (Optional.IsDefined(RequestedElasticPoolName))
            {
                builder.Append("    requestedElasticPoolName:");
                if (RequestedElasticPoolName.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{RequestedElasticPoolName}'''");
                }
                else
                {
                    builder.AppendLine($" '{RequestedElasticPoolName}'");
                }
            }

            if (Optional.IsDefined(RequestedStorageLimitInGB))
            {
                builder.Append("    requestedStorageLimitInGB:");
                builder.AppendLine($" '{RequestedStorageLimitInGB.Value.ToString()}'");
            }

            if (Optional.IsDefined(ElasticPoolName))
            {
                builder.Append("    elasticPoolName:");
                if (ElasticPoolName.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{ElasticPoolName}'''");
                }
                else
                {
                    builder.AppendLine($" '{ElasticPoolName}'");
                }
            }

            if (Optional.IsDefined(ServerName))
            {
                builder.Append("    serverName:");
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

            if (Optional.IsDefined(StartOn))
            {
                builder.Append("    startTime:");
                var formattedDateTimeString = TypeFormatters.ToString(StartOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(State))
            {
                builder.Append("    state:");
                if (State.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{State}'''");
                }
                else
                {
                    builder.AppendLine($" '{State}'");
                }
            }

            if (Optional.IsDefined(RequestedStorageLimitInMB))
            {
                builder.Append("    requestedStorageLimitInMB:");
                builder.AppendLine($" {RequestedStorageLimitInMB.Value}");
            }

            if (Optional.IsDefined(RequestedDatabaseDtuGuarantee))
            {
                builder.Append("    requestedDatabaseDtuGuarantee:");
                builder.AppendLine($" {RequestedDatabaseDtuGuarantee.Value}");
            }

            if (Optional.IsDefined(RequestedDatabaseDtuCap))
            {
                builder.Append("    requestedDatabaseDtuCap:");
                builder.AppendLine($" {RequestedDatabaseDtuCap.Value}");
            }

            if (Optional.IsDefined(RequestedDtuGuarantee))
            {
                builder.Append("    requestedDtuGuarantee:");
                builder.AppendLine($" {RequestedDtuGuarantee.Value}");
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

        BinaryData IPersistableModel<ElasticPoolActivity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticPoolActivity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ElasticPoolActivity)} does not support '{options.Format}' format.");
            }
        }

        ElasticPoolActivity IPersistableModel<ElasticPoolActivity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticPoolActivity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeElasticPoolActivity(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ElasticPoolActivity)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ElasticPoolActivity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
