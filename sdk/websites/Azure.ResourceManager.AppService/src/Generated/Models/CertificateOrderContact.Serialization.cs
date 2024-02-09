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
    public partial class CertificateOrderContact : IUtf8JsonSerializable, IJsonModel<CertificateOrderContact>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CertificateOrderContact>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CertificateOrderContact>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CertificateOrderContact>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CertificateOrderContact)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Email))
            {
                writer.WritePropertyName("email"u8);
                writer.WriteStringValue(Email);
            }
            if (Optional.IsDefined(NameFirst))
            {
                writer.WritePropertyName("nameFirst"u8);
                writer.WriteStringValue(NameFirst);
            }
            if (Optional.IsDefined(NameLast))
            {
                writer.WritePropertyName("nameLast"u8);
                writer.WriteStringValue(NameLast);
            }
            if (Optional.IsDefined(Phone))
            {
                writer.WritePropertyName("phone"u8);
                writer.WriteStringValue(Phone);
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

        CertificateOrderContact IJsonModel<CertificateOrderContact>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CertificateOrderContact>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CertificateOrderContact)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCertificateOrderContact(document.RootElement, options);
        }

        internal static CertificateOrderContact DeserializeCertificateOrderContact(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> email = default;
            Optional<string> nameFirst = default;
            Optional<string> nameLast = default;
            Optional<string> phone = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("email"u8))
                {
                    email = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nameFirst"u8))
                {
                    nameFirst = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nameLast"u8))
                {
                    nameLast = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phone"u8))
                {
                    phone = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CertificateOrderContact(email.Value, nameFirst.Value, nameLast.Value, phone.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Email))
            {
                builder.Append("  email:");
                if (Email.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Email}'''");
                }
                else
                {
                    builder.AppendLine($" '{Email}'");
                }
            }

            if (Optional.IsDefined(NameFirst))
            {
                builder.Append("  nameFirst:");
                if (NameFirst.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{NameFirst}'''");
                }
                else
                {
                    builder.AppendLine($" '{NameFirst}'");
                }
            }

            if (Optional.IsDefined(NameLast))
            {
                builder.Append("  nameLast:");
                if (NameLast.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{NameLast}'''");
                }
                else
                {
                    builder.AppendLine($" '{NameLast}'");
                }
            }

            if (Optional.IsDefined(Phone))
            {
                builder.Append("  phone:");
                if (Phone.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Phone}'''");
                }
                else
                {
                    builder.AppendLine($" '{Phone}'");
                }
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

        BinaryData IPersistableModel<CertificateOrderContact>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CertificateOrderContact>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CertificateOrderContact)} does not support '{options.Format}' format.");
            }
        }

        CertificateOrderContact IPersistableModel<CertificateOrderContact>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CertificateOrderContact>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCertificateOrderContact(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(CertificateOrderContact)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CertificateOrderContact>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
