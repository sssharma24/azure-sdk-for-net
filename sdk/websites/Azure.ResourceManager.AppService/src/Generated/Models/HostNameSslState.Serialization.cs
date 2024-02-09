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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class HostNameSslState : IUtf8JsonSerializable, IJsonModel<HostNameSslState>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HostNameSslState>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HostNameSslState>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostNameSslState>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HostNameSslState)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(SslState))
            {
                writer.WritePropertyName("sslState"u8);
                writer.WriteStringValue(SslState.Value.ToSerialString());
            }
            if (Optional.IsDefined(VirtualIP))
            {
                writer.WritePropertyName("virtualIP"u8);
                writer.WriteStringValue(VirtualIP);
            }
            if (Optional.IsDefined(ThumbprintString))
            {
                writer.WritePropertyName("thumbprint"u8);
                writer.WriteStringValue(ThumbprintString);
            }
            if (Optional.IsDefined(ToUpdate))
            {
                if (ToUpdate != null)
                {
                    writer.WritePropertyName("toUpdate"u8);
                    writer.WriteBooleanValue(ToUpdate.Value);
                }
                else
                {
                    writer.WriteNull("toUpdate");
                }
            }
            if (Optional.IsDefined(HostType))
            {
                writer.WritePropertyName("hostType"u8);
                writer.WriteStringValue(HostType.Value.ToSerialString());
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

        HostNameSslState IJsonModel<HostNameSslState>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostNameSslState>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HostNameSslState)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHostNameSslState(document.RootElement, options);
        }

        internal static HostNameSslState DeserializeHostNameSslState(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<HostNameBindingSslState> sslState = default;
            Optional<string> virtualIP = default;
            Optional<string> thumbprint = default;
            Optional<bool?> toUpdate = default;
            Optional<AppServiceHostType> hostType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sslState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sslState = property.Value.GetString().ToHostNameBindingSslState();
                    continue;
                }
                if (property.NameEquals("virtualIP"u8))
                {
                    virtualIP = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("thumbprint"u8))
                {
                    thumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("toUpdate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        toUpdate = null;
                        continue;
                    }
                    toUpdate = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("hostType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hostType = property.Value.GetString().ToAppServiceHostType();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HostNameSslState(name.Value, Optional.ToNullable(sslState), virtualIP.Value, thumbprint.Value, Optional.ToNullable(toUpdate), Optional.ToNullable(hostType), serializedAdditionalRawData);
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

            if (Optional.IsDefined(SslState))
            {
                builder.Append("  sslState:");
                builder.AppendLine($" '{SslState.Value.ToSerialString()}'");
            }

            if (Optional.IsDefined(VirtualIP))
            {
                builder.Append("  virtualIP:");
                if (VirtualIP.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{VirtualIP}'''");
                }
                else
                {
                    builder.AppendLine($" '{VirtualIP}'");
                }
            }

            if (Optional.IsDefined(ThumbprintString))
            {
                builder.Append("  thumbprint:");
                if (ThumbprintString.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{ThumbprintString}'''");
                }
                else
                {
                    builder.AppendLine($" '{ThumbprintString}'");
                }
            }

            if (Optional.IsDefined(ToUpdate))
            {
                builder.Append("  toUpdate:");
                var boolValue = ToUpdate.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(HostType))
            {
                builder.Append("  hostType:");
                builder.AppendLine($" '{HostType.Value.ToSerialString()}'");
            }

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

        BinaryData IPersistableModel<HostNameSslState>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostNameSslState>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(HostNameSslState)} does not support '{options.Format}' format.");
            }
        }

        HostNameSslState IPersistableModel<HostNameSslState>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostNameSslState>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHostNameSslState(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(HostNameSslState)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HostNameSslState>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
