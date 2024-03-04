// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    public partial class IdpsSignatureResult : IUtf8JsonSerializable, IJsonModel<IdpsSignatureResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IdpsSignatureResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IdpsSignatureResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IdpsSignatureResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IdpsSignatureResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SignatureId))
            {
                writer.WritePropertyName("signatureId"u8);
                writer.WriteNumberValue(SignatureId.Value);
            }
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteNumberValue((int)Mode.Value);
            }
            if (Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteNumberValue((int)Severity.Value);
            }
            if (Optional.IsDefined(Direction))
            {
                writer.WritePropertyName("direction"u8);
                writer.WriteNumberValue((int)Direction.Value);
            }
            if (Optional.IsDefined(Group))
            {
                writer.WritePropertyName("group"u8);
                writer.WriteStringValue(Group);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol);
            }
            if (Optional.IsCollectionDefined(SourcePorts))
            {
                writer.WritePropertyName("sourcePorts"u8);
                writer.WriteStartArray();
                foreach (var item in SourcePorts)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DestinationPorts))
            {
                writer.WritePropertyName("destinationPorts"u8);
                writer.WriteStartArray();
                foreach (var item in DestinationPorts)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LastUpdated))
            {
                writer.WritePropertyName("lastUpdated"u8);
                writer.WriteStringValue(LastUpdated);
            }
            if (Optional.IsDefined(InheritedFromParentPolicy))
            {
                writer.WritePropertyName("inheritedFromParentPolicy"u8);
                writer.WriteBooleanValue(InheritedFromParentPolicy.Value);
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

        IdpsSignatureResult IJsonModel<IdpsSignatureResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IdpsSignatureResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IdpsSignatureResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIdpsSignatureResult(document.RootElement, options);
        }

        internal static IdpsSignatureResult DeserializeIdpsSignatureResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? signatureId = default;
            FirewallPolicyIdpsSignatureMode? mode = default;
            FirewallPolicyIdpsSignatureSeverity? severity = default;
            FirewallPolicyIdpsSignatureDirection? direction = default;
            string group = default;
            string description = default;
            string protocol = default;
            IReadOnlyList<string> sourcePorts = default;
            IReadOnlyList<string> destinationPorts = default;
            string lastUpdated = default;
            bool? inheritedFromParentPolicy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("signatureId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    signatureId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = property.Value.GetInt32().ToFirewallPolicyIdpsSignatureMode();
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    severity = property.Value.GetInt32().ToFirewallPolicyIdpsSignatureSeverity();
                    continue;
                }
                if (property.NameEquals("direction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    direction = property.Value.GetInt32().ToFirewallPolicyIdpsSignatureDirection();
                    continue;
                }
                if (property.NameEquals("group"u8))
                {
                    group = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    protocol = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourcePorts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    sourcePorts = array;
                    continue;
                }
                if (property.NameEquals("destinationPorts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    destinationPorts = array;
                    continue;
                }
                if (property.NameEquals("lastUpdated"u8))
                {
                    lastUpdated = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inheritedFromParentPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    inheritedFromParentPolicy = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IdpsSignatureResult(
                signatureId,
                mode,
                severity,
                direction,
                group,
                description,
                protocol,
                sourcePorts ?? new ChangeTrackingList<string>(),
                destinationPorts ?? new ChangeTrackingList<string>(),
                lastUpdated,
                inheritedFromParentPolicy,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IdpsSignatureResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IdpsSignatureResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IdpsSignatureResult)} does not support '{options.Format}' format.");
            }
        }

        IdpsSignatureResult IPersistableModel<IdpsSignatureResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IdpsSignatureResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIdpsSignatureResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IdpsSignatureResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IdpsSignatureResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
