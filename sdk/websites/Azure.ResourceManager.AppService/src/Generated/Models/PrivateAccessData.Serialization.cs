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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class PrivateAccessData : IUtf8JsonSerializable, IJsonModel<PrivateAccessData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PrivateAccessData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PrivateAccessData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateAccessData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateAccessData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
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
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsCollectionDefined(VirtualNetworks))
            {
                writer.WritePropertyName("virtualNetworks"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualNetworks)
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

        PrivateAccessData IJsonModel<PrivateAccessData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateAccessData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateAccessData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateAccessData(document.RootElement, options);
        }

        internal static PrivateAccessData DeserializePrivateAccessData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<bool> enabled = default;
            Optional<IList<PrivateAccessVirtualNetwork>> virtualNetworks = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("enabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PrivateAccessVirtualNetwork> array = new List<PrivateAccessVirtualNetwork>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PrivateAccessVirtualNetwork.DeserializePrivateAccessVirtualNetwork(item));
                            }
                            virtualNetworks = array;
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
            return new PrivateAccessData(id, name, type, systemData.Value, Optional.ToNullable(enabled), Optional.ToList(virtualNetworks), kind.Value, serializedAdditionalRawData);
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

            if (Optional.IsDefined(Kind))
            {
                builder.Append("  kind:");
                if (Kind.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Kind}'''");
                }
                else
                {
                    builder.AppendLine($" '{Kind}'");
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
            if (Optional.IsDefined(IsEnabled))
            {
                builder.Append("    enabled:");
                var boolValue = IsEnabled.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsCollectionDefined(VirtualNetworks))
            {
                if (VirtualNetworks.Any())
                {
                    builder.Append("    virtualNetworks:");
                    builder.AppendLine(" [");
                    foreach (var item in VirtualNetworks)
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

        BinaryData IPersistableModel<PrivateAccessData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateAccessData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(PrivateAccessData)} does not support '{options.Format}' format.");
            }
        }

        PrivateAccessData IPersistableModel<PrivateAccessData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateAccessData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePrivateAccessData(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(PrivateAccessData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PrivateAccessData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
