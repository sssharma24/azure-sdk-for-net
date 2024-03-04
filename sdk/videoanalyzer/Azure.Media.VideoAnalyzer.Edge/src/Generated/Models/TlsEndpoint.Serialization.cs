// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Media.VideoAnalyzer.Edge;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class TlsEndpoint : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TrustedCertificates))
            {
                writer.WritePropertyName("trustedCertificates"u8);
                writer.WriteObjectValue(TrustedCertificates);
            }
            if (Optional.IsDefined(ValidationOptions))
            {
                writer.WritePropertyName("validationOptions"u8);
                writer.WriteObjectValue(ValidationOptions);
            }
            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Credentials))
            {
                writer.WritePropertyName("credentials"u8);
                writer.WriteObjectValue(Credentials);
            }
            writer.WritePropertyName("url"u8);
            writer.WriteStringValue(Url);
            writer.WriteEndObject();
        }

        internal static TlsEndpoint DeserializeTlsEndpoint(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CertificateSource trustedCertificates = default;
            TlsValidationOptions validationOptions = default;
            string type = default;
            CredentialsBase credentials = default;
            string url = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("trustedCertificates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trustedCertificates = CertificateSource.DeserializeCertificateSource(property.Value);
                    continue;
                }
                if (property.NameEquals("validationOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validationOptions = TlsValidationOptions.DeserializeTlsValidationOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("@type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("credentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    credentials = CredentialsBase.DeserializeCredentialsBase(property.Value);
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    url = property.Value.GetString();
                    continue;
                }
            }
            return new TlsEndpoint(type, credentials, url, trustedCertificates, validationOptions);
        }
    }
}
