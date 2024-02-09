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
    public partial class AppServiceAadRegistration : IUtf8JsonSerializable, IJsonModel<AppServiceAadRegistration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppServiceAadRegistration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppServiceAadRegistration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceAadRegistration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceAadRegistration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(OpenIdIssuer))
            {
                writer.WritePropertyName("openIdIssuer"u8);
                writer.WriteStringValue(OpenIdIssuer);
            }
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteStringValue(ClientId);
            }
            if (Optional.IsDefined(ClientSecretSettingName))
            {
                writer.WritePropertyName("clientSecretSettingName"u8);
                writer.WriteStringValue(ClientSecretSettingName);
            }
            if (Optional.IsDefined(ClientSecretCertificateThumbprintString))
            {
                writer.WritePropertyName("clientSecretCertificateThumbprint"u8);
                writer.WriteStringValue(ClientSecretCertificateThumbprintString);
            }
            if (Optional.IsDefined(ClientSecretCertificateSubjectAlternativeName))
            {
                writer.WritePropertyName("clientSecretCertificateSubjectAlternativeName"u8);
                writer.WriteStringValue(ClientSecretCertificateSubjectAlternativeName);
            }
            if (Optional.IsDefined(ClientSecretCertificateIssuer))
            {
                writer.WritePropertyName("clientSecretCertificateIssuer"u8);
                writer.WriteStringValue(ClientSecretCertificateIssuer);
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

        AppServiceAadRegistration IJsonModel<AppServiceAadRegistration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceAadRegistration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceAadRegistration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceAadRegistration(document.RootElement, options);
        }

        internal static AppServiceAadRegistration DeserializeAppServiceAadRegistration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> openIdIssuer = default;
            Optional<string> clientId = default;
            Optional<string> clientSecretSettingName = default;
            Optional<string> clientSecretCertificateThumbprint = default;
            Optional<string> clientSecretCertificateSubjectAlternativeName = default;
            Optional<string> clientSecretCertificateIssuer = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("openIdIssuer"u8))
                {
                    openIdIssuer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientId"u8))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecretSettingName"u8))
                {
                    clientSecretSettingName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecretCertificateThumbprint"u8))
                {
                    clientSecretCertificateThumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecretCertificateSubjectAlternativeName"u8))
                {
                    clientSecretCertificateSubjectAlternativeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecretCertificateIssuer"u8))
                {
                    clientSecretCertificateIssuer = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppServiceAadRegistration(openIdIssuer.Value, clientId.Value, clientSecretSettingName.Value, clientSecretCertificateThumbprint.Value, clientSecretCertificateSubjectAlternativeName.Value, clientSecretCertificateIssuer.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(OpenIdIssuer))
            {
                builder.Append("  openIdIssuer:");
                if (OpenIdIssuer.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{OpenIdIssuer}'''");
                }
                else
                {
                    builder.AppendLine($" '{OpenIdIssuer}'");
                }
            }

            if (Optional.IsDefined(ClientId))
            {
                builder.Append("  clientId:");
                if (ClientId.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{ClientId}'''");
                }
                else
                {
                    builder.AppendLine($" '{ClientId}'");
                }
            }

            if (Optional.IsDefined(ClientSecretSettingName))
            {
                builder.Append("  clientSecretSettingName:");
                if (ClientSecretSettingName.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{ClientSecretSettingName}'''");
                }
                else
                {
                    builder.AppendLine($" '{ClientSecretSettingName}'");
                }
            }

            if (Optional.IsDefined(ClientSecretCertificateThumbprintString))
            {
                builder.Append("  clientSecretCertificateThumbprint:");
                if (ClientSecretCertificateThumbprintString.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{ClientSecretCertificateThumbprintString}'''");
                }
                else
                {
                    builder.AppendLine($" '{ClientSecretCertificateThumbprintString}'");
                }
            }

            if (Optional.IsDefined(ClientSecretCertificateSubjectAlternativeName))
            {
                builder.Append("  clientSecretCertificateSubjectAlternativeName:");
                if (ClientSecretCertificateSubjectAlternativeName.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{ClientSecretCertificateSubjectAlternativeName}'''");
                }
                else
                {
                    builder.AppendLine($" '{ClientSecretCertificateSubjectAlternativeName}'");
                }
            }

            if (Optional.IsDefined(ClientSecretCertificateIssuer))
            {
                builder.Append("  clientSecretCertificateIssuer:");
                if (ClientSecretCertificateIssuer.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{ClientSecretCertificateIssuer}'''");
                }
                else
                {
                    builder.AppendLine($" '{ClientSecretCertificateIssuer}'");
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

        BinaryData IPersistableModel<AppServiceAadRegistration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceAadRegistration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AppServiceAadRegistration)} does not support '{options.Format}' format.");
            }
        }

        AppServiceAadRegistration IPersistableModel<AppServiceAadRegistration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceAadRegistration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppServiceAadRegistration(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(AppServiceAadRegistration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppServiceAadRegistration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
