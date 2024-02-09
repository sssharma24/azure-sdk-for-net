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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class InstanceFailoverGroupData : IUtf8JsonSerializable, IJsonModel<InstanceFailoverGroupData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InstanceFailoverGroupData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InstanceFailoverGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InstanceFailoverGroupData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InstanceFailoverGroupData)} does not support '{format}' format.");
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
            if (Optional.IsDefined(SecondaryType))
            {
                writer.WritePropertyName("secondaryType"u8);
                writer.WriteStringValue(SecondaryType.Value.ToString());
            }
            if (Optional.IsDefined(ReadWriteEndpoint))
            {
                writer.WritePropertyName("readWriteEndpoint"u8);
                writer.WriteObjectValue(ReadWriteEndpoint);
            }
            if (Optional.IsDefined(ReadOnlyEndpoint))
            {
                writer.WritePropertyName("readOnlyEndpoint"u8);
                writer.WriteObjectValue(ReadOnlyEndpoint);
            }
            if (options.Format != "W" && Optional.IsDefined(ReplicationRole))
            {
                writer.WritePropertyName("replicationRole"u8);
                writer.WriteStringValue(ReplicationRole.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ReplicationState))
            {
                writer.WritePropertyName("replicationState"u8);
                writer.WriteStringValue(ReplicationState);
            }
            if (Optional.IsCollectionDefined(PartnerRegions))
            {
                writer.WritePropertyName("partnerRegions"u8);
                writer.WriteStartArray();
                foreach (var item in PartnerRegions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ManagedInstancePairs))
            {
                writer.WritePropertyName("managedInstancePairs"u8);
                writer.WriteStartArray();
                foreach (var item in ManagedInstancePairs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        InstanceFailoverGroupData IJsonModel<InstanceFailoverGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InstanceFailoverGroupData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InstanceFailoverGroupData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInstanceFailoverGroupData(document.RootElement, options);
        }

        internal static InstanceFailoverGroupData DeserializeInstanceFailoverGroupData(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<GeoSecondaryInstanceType> secondaryType = default;
            Optional<InstanceFailoverGroupReadWriteEndpoint> readWriteEndpoint = default;
            Optional<InstanceFailoverGroupReadOnlyEndpoint> readOnlyEndpoint = default;
            Optional<InstanceFailoverGroupReplicationRole> replicationRole = default;
            Optional<string> replicationState = default;
            Optional<IList<PartnerRegionInfo>> partnerRegions = default;
            Optional<IList<ManagedInstancePairInfo>> managedInstancePairs = default;
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
                        if (property0.NameEquals("secondaryType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            secondaryType = new GeoSecondaryInstanceType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("readWriteEndpoint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            readWriteEndpoint = InstanceFailoverGroupReadWriteEndpoint.DeserializeInstanceFailoverGroupReadWriteEndpoint(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("readOnlyEndpoint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            readOnlyEndpoint = InstanceFailoverGroupReadOnlyEndpoint.DeserializeInstanceFailoverGroupReadOnlyEndpoint(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("replicationRole"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            replicationRole = new InstanceFailoverGroupReplicationRole(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("replicationState"u8))
                        {
                            replicationState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partnerRegions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PartnerRegionInfo> array = new List<PartnerRegionInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PartnerRegionInfo.DeserializePartnerRegionInfo(item));
                            }
                            partnerRegions = array;
                            continue;
                        }
                        if (property0.NameEquals("managedInstancePairs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ManagedInstancePairInfo> array = new List<ManagedInstancePairInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ManagedInstancePairInfo.DeserializeManagedInstancePairInfo(item));
                            }
                            managedInstancePairs = array;
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
            return new InstanceFailoverGroupData(id, name, type, systemData.Value, Optional.ToNullable(secondaryType), readWriteEndpoint.Value, readOnlyEndpoint.Value, Optional.ToNullable(replicationRole), replicationState.Value, Optional.ToList(partnerRegions), Optional.ToList(managedInstancePairs), serializedAdditionalRawData);
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
            if (Optional.IsDefined(SecondaryType))
            {
                builder.Append("    secondaryType:");
                builder.AppendLine($" '{SecondaryType.Value.ToString()}'");
            }

            if (Optional.IsDefined(ReadWriteEndpoint))
            {
                builder.Append("    readWriteEndpoint:");
                AppendChildObject(builder, ReadWriteEndpoint, options, 4, false);
            }

            if (Optional.IsDefined(ReadOnlyEndpoint))
            {
                builder.Append("    readOnlyEndpoint:");
                AppendChildObject(builder, ReadOnlyEndpoint, options, 4, false);
            }

            if (Optional.IsDefined(ReplicationRole))
            {
                builder.Append("    replicationRole:");
                builder.AppendLine($" '{ReplicationRole.Value.ToString()}'");
            }

            if (Optional.IsDefined(ReplicationState))
            {
                builder.Append("    replicationState:");
                if (ReplicationState.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{ReplicationState}'''");
                }
                else
                {
                    builder.AppendLine($" '{ReplicationState}'");
                }
            }

            if (Optional.IsCollectionDefined(PartnerRegions))
            {
                if (PartnerRegions.Any())
                {
                    builder.Append("    partnerRegions:");
                    builder.AppendLine(" [");
                    foreach (var item in PartnerRegions)
                    {
                        AppendChildObject(builder, item, options, 6, true);
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsCollectionDefined(ManagedInstancePairs))
            {
                if (ManagedInstancePairs.Any())
                {
                    builder.Append("    managedInstancePairs:");
                    builder.AppendLine(" [");
                    foreach (var item in ManagedInstancePairs)
                    {
                        AppendChildObject(builder, item, options, 6, true);
                    }
                    builder.AppendLine("    ]");
                }
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

        BinaryData IPersistableModel<InstanceFailoverGroupData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InstanceFailoverGroupData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(InstanceFailoverGroupData)} does not support '{options.Format}' format.");
            }
        }

        InstanceFailoverGroupData IPersistableModel<InstanceFailoverGroupData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InstanceFailoverGroupData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInstanceFailoverGroupData(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(InstanceFailoverGroupData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InstanceFailoverGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
