// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ContainerService;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterAadProfile : IUtf8JsonSerializable, IJsonModel<ManagedClusterAadProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterAadProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedClusterAadProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterAadProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterAadProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsManagedAadEnabled))
            {
                writer.WritePropertyName("managed"u8);
                writer.WriteBooleanValue(IsManagedAadEnabled.Value);
            }
            if (Optional.IsDefined(IsAzureRbacEnabled))
            {
                writer.WritePropertyName("enableAzureRBAC"u8);
                writer.WriteBooleanValue(IsAzureRbacEnabled.Value);
            }
            if (Optional.IsCollectionDefined(AdminGroupObjectIds))
            {
                writer.WritePropertyName("adminGroupObjectIDs"u8);
                writer.WriteStartArray();
                foreach (var item in AdminGroupObjectIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ClientAppId))
            {
                writer.WritePropertyName("clientAppID"u8);
                writer.WriteStringValue(ClientAppId.Value);
            }
            if (Optional.IsDefined(ServerAppId))
            {
                writer.WritePropertyName("serverAppID"u8);
                writer.WriteStringValue(ServerAppId.Value);
            }
            if (Optional.IsDefined(ServerAppSecret))
            {
                writer.WritePropertyName("serverAppSecret"u8);
                writer.WriteStringValue(ServerAppSecret);
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantID"u8);
                writer.WriteStringValue(TenantId.Value);
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

        ManagedClusterAadProfile IJsonModel<ManagedClusterAadProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterAadProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterAadProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterAadProfile(document.RootElement, options);
        }

        internal static ManagedClusterAadProfile DeserializeManagedClusterAadProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? managed = default;
            bool? enableAzureRBAC = default;
            IList<Guid> adminGroupObjectIds = default;
            Guid? clientAppId = default;
            Guid? serverAppId = default;
            string serverAppSecret = default;
            Guid? tenantId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managed = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableAzureRBAC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableAzureRBAC = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("adminGroupObjectIDs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Guid> array = new List<Guid>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetGuid());
                    }
                    adminGroupObjectIds = array;
                    continue;
                }
                if (property.NameEquals("clientAppID"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientAppId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("serverAppID"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serverAppId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("serverAppSecret"u8))
                {
                    serverAppSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantID"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedClusterAadProfile(
                managed,
                enableAzureRBAC,
                adminGroupObjectIds ?? new ChangeTrackingList<Guid>(),
                clientAppId,
                serverAppId,
                serverAppSecret,
                tenantId,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedClusterAadProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterAadProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterAadProfile)} does not support '{options.Format}' format.");
            }
        }

        ManagedClusterAadProfile IPersistableModel<ManagedClusterAadProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterAadProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterAadProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterAadProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterAadProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
