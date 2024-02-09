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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class SyncMemberData : IUtf8JsonSerializable, IJsonModel<SyncMemberData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SyncMemberData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SyncMemberData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncMemberData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SyncMemberData)} does not support '{format}' format.");
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
            if (Optional.IsDefined(DatabaseType))
            {
                writer.WritePropertyName("databaseType"u8);
                writer.WriteStringValue(DatabaseType.Value.ToString());
            }
            if (Optional.IsDefined(SyncAgentId))
            {
                writer.WritePropertyName("syncAgentId"u8);
                writer.WriteStringValue(SyncAgentId);
            }
            if (Optional.IsDefined(SqlServerDatabaseId))
            {
                writer.WritePropertyName("sqlServerDatabaseId"u8);
                writer.WriteStringValue(SqlServerDatabaseId.Value);
            }
            if (Optional.IsDefined(SyncMemberAzureDatabaseResourceId))
            {
                writer.WritePropertyName("syncMemberAzureDatabaseResourceId"u8);
                writer.WriteStringValue(SyncMemberAzureDatabaseResourceId);
            }
            if (Optional.IsDefined(UsePrivateLinkConnection))
            {
                writer.WritePropertyName("usePrivateLinkConnection"u8);
                writer.WriteBooleanValue(UsePrivateLinkConnection.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PrivateEndpointName))
            {
                writer.WritePropertyName("privateEndpointName"u8);
                writer.WriteStringValue(PrivateEndpointName);
            }
            if (Optional.IsDefined(ServerName))
            {
                writer.WritePropertyName("serverName"u8);
                writer.WriteStringValue(ServerName);
            }
            if (Optional.IsDefined(DatabaseName))
            {
                writer.WritePropertyName("databaseName"u8);
                writer.WriteStringValue(DatabaseName);
            }
            if (Optional.IsDefined(UserName))
            {
                writer.WritePropertyName("userName"u8);
                writer.WriteStringValue(UserName);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            if (Optional.IsDefined(SyncDirection))
            {
                writer.WritePropertyName("syncDirection"u8);
                writer.WriteStringValue(SyncDirection.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(SyncState))
            {
                writer.WritePropertyName("syncState"u8);
                writer.WriteStringValue(SyncState.Value.ToString());
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

        SyncMemberData IJsonModel<SyncMemberData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncMemberData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SyncMemberData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSyncMemberData(document.RootElement, options);
        }

        internal static SyncMemberData DeserializeSyncMemberData(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<SyncMemberDbType> databaseType = default;
            Optional<ResourceIdentifier> syncAgentId = default;
            Optional<Guid> sqlServerDatabaseId = default;
            Optional<ResourceIdentifier> syncMemberAzureDatabaseResourceId = default;
            Optional<bool> usePrivateLinkConnection = default;
            Optional<string> privateEndpointName = default;
            Optional<string> serverName = default;
            Optional<string> databaseName = default;
            Optional<string> userName = default;
            Optional<string> password = default;
            Optional<SyncDirection> syncDirection = default;
            Optional<SyncMemberState> syncState = default;
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
                        if (property0.NameEquals("databaseType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            databaseType = new SyncMemberDbType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("syncAgentId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            syncAgentId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sqlServerDatabaseId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sqlServerDatabaseId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("syncMemberAzureDatabaseResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            syncMemberAzureDatabaseResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("usePrivateLinkConnection"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            usePrivateLinkConnection = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointName"u8))
                        {
                            privateEndpointName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverName"u8))
                        {
                            serverName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("databaseName"u8))
                        {
                            databaseName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("userName"u8))
                        {
                            userName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("password"u8))
                        {
                            password = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("syncDirection"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            syncDirection = new SyncDirection(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("syncState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            syncState = new SyncMemberState(property0.Value.GetString());
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
            return new SyncMemberData(id, name, type, systemData.Value, Optional.ToNullable(databaseType), syncAgentId.Value, Optional.ToNullable(sqlServerDatabaseId), syncMemberAzureDatabaseResourceId.Value, Optional.ToNullable(usePrivateLinkConnection), privateEndpointName.Value, serverName.Value, databaseName.Value, userName.Value, password.Value, Optional.ToNullable(syncDirection), Optional.ToNullable(syncState), serializedAdditionalRawData);
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
            if (Optional.IsDefined(DatabaseType))
            {
                builder.Append("    databaseType:");
                builder.AppendLine($" '{DatabaseType.Value.ToString()}'");
            }

            if (Optional.IsDefined(SyncAgentId))
            {
                builder.Append("    syncAgentId:");
                builder.AppendLine($" '{SyncAgentId.ToString()}'");
            }

            if (Optional.IsDefined(SqlServerDatabaseId))
            {
                builder.Append("    sqlServerDatabaseId:");
                builder.AppendLine($" '{SqlServerDatabaseId.Value.ToString()}'");
            }

            if (Optional.IsDefined(SyncMemberAzureDatabaseResourceId))
            {
                builder.Append("    syncMemberAzureDatabaseResourceId:");
                builder.AppendLine($" '{SyncMemberAzureDatabaseResourceId.ToString()}'");
            }

            if (Optional.IsDefined(UsePrivateLinkConnection))
            {
                builder.Append("    usePrivateLinkConnection:");
                var boolValue = UsePrivateLinkConnection.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(PrivateEndpointName))
            {
                builder.Append("    privateEndpointName:");
                if (PrivateEndpointName.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{PrivateEndpointName}'''");
                }
                else
                {
                    builder.AppendLine($" '{PrivateEndpointName}'");
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

            if (Optional.IsDefined(DatabaseName))
            {
                builder.Append("    databaseName:");
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

            if (Optional.IsDefined(UserName))
            {
                builder.Append("    userName:");
                if (UserName.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{UserName}'''");
                }
                else
                {
                    builder.AppendLine($" '{UserName}'");
                }
            }

            if (Optional.IsDefined(Password))
            {
                builder.Append("    password:");
                if (Password.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Password}'''");
                }
                else
                {
                    builder.AppendLine($" '{Password}'");
                }
            }

            if (Optional.IsDefined(SyncDirection))
            {
                builder.Append("    syncDirection:");
                builder.AppendLine($" '{SyncDirection.Value.ToString()}'");
            }

            if (Optional.IsDefined(SyncState))
            {
                builder.Append("    syncState:");
                builder.AppendLine($" '{SyncState.Value.ToString()}'");
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

        BinaryData IPersistableModel<SyncMemberData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncMemberData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SyncMemberData)} does not support '{options.Format}' format.");
            }
        }

        SyncMemberData IPersistableModel<SyncMemberData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncMemberData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSyncMemberData(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SyncMemberData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SyncMemberData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
