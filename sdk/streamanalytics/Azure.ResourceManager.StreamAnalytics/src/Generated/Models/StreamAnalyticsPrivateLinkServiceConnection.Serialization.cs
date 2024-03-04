// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.StreamAnalytics;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class StreamAnalyticsPrivateLinkServiceConnection : IUtf8JsonSerializable, IJsonModel<StreamAnalyticsPrivateLinkServiceConnection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamAnalyticsPrivateLinkServiceConnection>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StreamAnalyticsPrivateLinkServiceConnection>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsPrivateLinkServiceConnection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamAnalyticsPrivateLinkServiceConnection)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PrivateLinkServiceId))
            {
                writer.WritePropertyName("privateLinkServiceId"u8);
                writer.WriteStringValue(PrivateLinkServiceId);
            }
            if (Optional.IsCollectionDefined(GroupIds))
            {
                writer.WritePropertyName("groupIds"u8);
                writer.WriteStartArray();
                foreach (var item in GroupIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(RequestMessage))
            {
                writer.WritePropertyName("requestMessage"u8);
                writer.WriteStringValue(RequestMessage);
            }
            if (Optional.IsDefined(PrivateLinkServiceConnectionState))
            {
                writer.WritePropertyName("privateLinkServiceConnectionState"u8);
                writer.WriteObjectValue(PrivateLinkServiceConnectionState);
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

        StreamAnalyticsPrivateLinkServiceConnection IJsonModel<StreamAnalyticsPrivateLinkServiceConnection>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsPrivateLinkServiceConnection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamAnalyticsPrivateLinkServiceConnection)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamAnalyticsPrivateLinkServiceConnection(document.RootElement, options);
        }

        internal static StreamAnalyticsPrivateLinkServiceConnection DeserializeStreamAnalyticsPrivateLinkServiceConnection(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier privateLinkServiceId = default;
            IList<string> groupIds = default;
            string requestMessage = default;
            StreamAnalyticsPrivateLinkConnectionState privateLinkServiceConnectionState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("privateLinkServiceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateLinkServiceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("groupIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            groupIds = array;
                            continue;
                        }
                        if (property0.NameEquals("requestMessage"u8))
                        {
                            requestMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateLinkServiceConnectionState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateLinkServiceConnectionState = StreamAnalyticsPrivateLinkConnectionState.DeserializeStreamAnalyticsPrivateLinkConnectionState(property0.Value, options);
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
            return new StreamAnalyticsPrivateLinkServiceConnection(privateLinkServiceId, groupIds ?? new ChangeTrackingList<string>(), requestMessage, privateLinkServiceConnectionState, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StreamAnalyticsPrivateLinkServiceConnection>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsPrivateLinkServiceConnection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StreamAnalyticsPrivateLinkServiceConnection)} does not support '{options.Format}' format.");
            }
        }

        StreamAnalyticsPrivateLinkServiceConnection IPersistableModel<StreamAnalyticsPrivateLinkServiceConnection>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsPrivateLinkServiceConnection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStreamAnalyticsPrivateLinkServiceConnection(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamAnalyticsPrivateLinkServiceConnection)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamAnalyticsPrivateLinkServiceConnection>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
