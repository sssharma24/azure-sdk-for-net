// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class InternalNetworkStaticRouteConfiguration : IUtf8JsonSerializable, IJsonModel<InternalNetworkStaticRouteConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InternalNetworkStaticRouteConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InternalNetworkStaticRouteConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalNetworkStaticRouteConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalNetworkStaticRouteConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Extension))
            {
                writer.WritePropertyName("extension"u8);
                writer.WriteStringValue(Extension.Value.ToString());
            }
            if (Optional.IsDefined(BfdConfiguration))
            {
                writer.WritePropertyName("bfdConfiguration"u8);
                writer.WriteObjectValue(BfdConfiguration);
            }
            if (Optional.IsCollectionDefined(IPv4Routes))
            {
                writer.WritePropertyName("ipv4Routes"u8);
                writer.WriteStartArray();
                foreach (var item in IPv4Routes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IPv6Routes))
            {
                writer.WritePropertyName("ipv6Routes"u8);
                writer.WriteStartArray();
                foreach (var item in IPv6Routes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        InternalNetworkStaticRouteConfiguration IJsonModel<InternalNetworkStaticRouteConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalNetworkStaticRouteConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalNetworkStaticRouteConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalNetworkStaticRouteConfiguration(document.RootElement, options);
        }

        internal static InternalNetworkStaticRouteConfiguration DeserializeInternalNetworkStaticRouteConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StaticRouteConfigurationExtension? extension = default;
            BfdConfiguration bfdConfiguration = default;
            IList<StaticRouteProperties> ipv4Routes = default;
            IList<StaticRouteProperties> ipv6Routes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extension"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extension = new StaticRouteConfigurationExtension(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("bfdConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bfdConfiguration = BfdConfiguration.DeserializeBfdConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("ipv4Routes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StaticRouteProperties> array = new List<StaticRouteProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StaticRouteProperties.DeserializeStaticRouteProperties(item, options));
                    }
                    ipv4Routes = array;
                    continue;
                }
                if (property.NameEquals("ipv6Routes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StaticRouteProperties> array = new List<StaticRouteProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StaticRouteProperties.DeserializeStaticRouteProperties(item, options));
                    }
                    ipv6Routes = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InternalNetworkStaticRouteConfiguration(bfdConfiguration, ipv4Routes ?? new ChangeTrackingList<StaticRouteProperties>(), ipv6Routes ?? new ChangeTrackingList<StaticRouteProperties>(), serializedAdditionalRawData, extension);
        }

        BinaryData IPersistableModel<InternalNetworkStaticRouteConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalNetworkStaticRouteConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalNetworkStaticRouteConfiguration)} does not support '{options.Format}' format.");
            }
        }

        InternalNetworkStaticRouteConfiguration IPersistableModel<InternalNetworkStaticRouteConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalNetworkStaticRouteConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalNetworkStaticRouteConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalNetworkStaticRouteConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalNetworkStaticRouteConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
