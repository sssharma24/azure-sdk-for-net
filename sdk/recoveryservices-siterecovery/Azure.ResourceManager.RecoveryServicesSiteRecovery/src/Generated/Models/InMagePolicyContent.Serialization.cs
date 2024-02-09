// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMagePolicyContent : IUtf8JsonSerializable, IJsonModel<InMagePolicyContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMagePolicyContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InMagePolicyContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMagePolicyContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMagePolicyContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryPointThresholdInMinutes))
            {
                writer.WritePropertyName("recoveryPointThresholdInMinutes"u8);
                writer.WriteNumberValue(RecoveryPointThresholdInMinutes.Value);
            }
            if (Optional.IsDefined(RecoveryPointHistory))
            {
                writer.WritePropertyName("recoveryPointHistory"u8);
                writer.WriteNumberValue(RecoveryPointHistory.Value);
            }
            if (Optional.IsDefined(AppConsistentFrequencyInMinutes))
            {
                writer.WritePropertyName("appConsistentFrequencyInMinutes"u8);
                writer.WriteNumberValue(AppConsistentFrequencyInMinutes.Value);
            }
            writer.WritePropertyName("multiVmSyncStatus"u8);
            writer.WriteStringValue(MultiVmSyncStatus.ToString());
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        InMagePolicyContent IJsonModel<InMagePolicyContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMagePolicyContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMagePolicyContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMagePolicyContent(document.RootElement, options);
        }

        internal static InMagePolicyContent DeserializeInMagePolicyContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> recoveryPointThresholdInMinutes = default;
            Optional<int> recoveryPointHistory = default;
            Optional<int> appConsistentFrequencyInMinutes = default;
            SetMultiVmSyncStatus multiVmSyncStatus = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPointThresholdInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointThresholdInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("recoveryPointHistory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointHistory = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("appConsistentFrequencyInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appConsistentFrequencyInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("multiVmSyncStatus"u8))
                {
                    multiVmSyncStatus = new SetMultiVmSyncStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InMagePolicyContent(instanceType, serializedAdditionalRawData, Optional.ToNullable(recoveryPointThresholdInMinutes), Optional.ToNullable(recoveryPointHistory), Optional.ToNullable(appConsistentFrequencyInMinutes), multiVmSyncStatus);
        }

        BinaryData IPersistableModel<InMagePolicyContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMagePolicyContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InMagePolicyContent)} does not support '{options.Format}' format.");
            }
        }

        InMagePolicyContent IPersistableModel<InMagePolicyContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMagePolicyContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInMagePolicyContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InMagePolicyContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InMagePolicyContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
