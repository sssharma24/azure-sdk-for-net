// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    [PersistableModelProxy(typeof(UnknownCustomSetupBase))]
    public partial class SynapseCustomSetupBase : IUtf8JsonSerializable, IJsonModel<SynapseCustomSetupBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseCustomSetupBase>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseCustomSetupBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseCustomSetupBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseCustomSetupBase)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(CustomSetupBaseType);
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

        SynapseCustomSetupBase IJsonModel<SynapseCustomSetupBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseCustomSetupBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseCustomSetupBase)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseCustomSetupBase(document.RootElement, options);
        }

        internal static SynapseCustomSetupBase DeserializeSynapseCustomSetupBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "CmdkeySetup": return SynapseCmdkeySetup.DeserializeSynapseCmdkeySetup(element);
                    case "ComponentSetup": return SynapseComponentSetup.DeserializeSynapseComponentSetup(element);
                    case "EnvironmentVariableSetup": return SynapseEnvironmentVariableSetup.DeserializeSynapseEnvironmentVariableSetup(element);
                }
            }
            return UnknownCustomSetupBase.DeserializeUnknownCustomSetupBase(element);
        }

        BinaryData IPersistableModel<SynapseCustomSetupBase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseCustomSetupBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseCustomSetupBase)} does not support '{options.Format}' format.");
            }
        }

        SynapseCustomSetupBase IPersistableModel<SynapseCustomSetupBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseCustomSetupBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseCustomSetupBase(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseCustomSetupBase)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseCustomSetupBase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
