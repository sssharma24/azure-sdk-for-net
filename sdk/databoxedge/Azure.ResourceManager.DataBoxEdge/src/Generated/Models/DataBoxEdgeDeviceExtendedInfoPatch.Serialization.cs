// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class DataBoxEdgeDeviceExtendedInfoPatch : IUtf8JsonSerializable, IJsonModel<DataBoxEdgeDeviceExtendedInfoPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxEdgeDeviceExtendedInfoPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataBoxEdgeDeviceExtendedInfoPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeDeviceExtendedInfoPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeDeviceExtendedInfoPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ClientSecretStoreId))
            {
                writer.WritePropertyName("clientSecretStoreId"u8);
                writer.WriteStringValue(ClientSecretStoreId);
            }
            if (Optional.IsDefined(ClientSecretStoreUri))
            {
                writer.WritePropertyName("clientSecretStoreUrl"u8);
                writer.WriteStringValue(ClientSecretStoreUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ChannelIntegrityKeyName))
            {
                writer.WritePropertyName("channelIntegrityKeyName"u8);
                writer.WriteStringValue(ChannelIntegrityKeyName);
            }
            if (Optional.IsDefined(ChannelIntegrityKeyVersion))
            {
                writer.WritePropertyName("channelIntegrityKeyVersion"u8);
                writer.WriteStringValue(ChannelIntegrityKeyVersion);
            }
            if (Optional.IsDefined(SyncStatus))
            {
                writer.WritePropertyName("syncStatus"u8);
                writer.WriteStringValue(SyncStatus.Value.ToString());
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

        DataBoxEdgeDeviceExtendedInfoPatch IJsonModel<DataBoxEdgeDeviceExtendedInfoPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeDeviceExtendedInfoPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeDeviceExtendedInfoPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxEdgeDeviceExtendedInfoPatch(document.RootElement, options);
        }

        internal static DataBoxEdgeDeviceExtendedInfoPatch DeserializeDataBoxEdgeDeviceExtendedInfoPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier clientSecretStoreId = default;
            Uri clientSecretStoreUrl = default;
            string channelIntegrityKeyName = default;
            string channelIntegrityKeyVersion = default;
            EdgeKeyVaultSyncStatus? syncStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientSecretStoreId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientSecretStoreId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("clientSecretStoreUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientSecretStoreUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("channelIntegrityKeyName"u8))
                {
                    channelIntegrityKeyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelIntegrityKeyVersion"u8))
                {
                    channelIntegrityKeyVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("syncStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    syncStatus = new EdgeKeyVaultSyncStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataBoxEdgeDeviceExtendedInfoPatch(
                clientSecretStoreId,
                clientSecretStoreUrl,
                channelIntegrityKeyName,
                channelIntegrityKeyVersion,
                syncStatus,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataBoxEdgeDeviceExtendedInfoPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeDeviceExtendedInfoPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeDeviceExtendedInfoPatch)} does not support '{options.Format}' format.");
            }
        }

        DataBoxEdgeDeviceExtendedInfoPatch IPersistableModel<DataBoxEdgeDeviceExtendedInfoPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeDeviceExtendedInfoPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxEdgeDeviceExtendedInfoPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeDeviceExtendedInfoPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxEdgeDeviceExtendedInfoPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
