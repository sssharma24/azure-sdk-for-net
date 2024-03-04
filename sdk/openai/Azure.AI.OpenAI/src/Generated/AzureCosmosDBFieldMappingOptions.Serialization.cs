// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    public partial class AzureCosmosDBFieldMappingOptions : IUtf8JsonSerializable, IJsonModel<AzureCosmosDBFieldMappingOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureCosmosDBFieldMappingOptions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureCosmosDBFieldMappingOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureCosmosDBFieldMappingOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureCosmosDBFieldMappingOptions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TitleFieldName))
            {
                writer.WritePropertyName("titleField"u8);
                writer.WriteStringValue(TitleFieldName);
            }
            if (Optional.IsDefined(UrlFieldName))
            {
                writer.WritePropertyName("urlField"u8);
                writer.WriteStringValue(UrlFieldName);
            }
            if (Optional.IsDefined(FilepathFieldName))
            {
                writer.WritePropertyName("filepathField"u8);
                writer.WriteStringValue(FilepathFieldName);
            }
            writer.WritePropertyName("contentFields"u8);
            writer.WriteStartArray();
            foreach (var item in ContentFieldNames)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(ContentFieldSeparator))
            {
                writer.WritePropertyName("contentFieldsSeparator"u8);
                writer.WriteStringValue(ContentFieldSeparator);
            }
            writer.WritePropertyName("vectorFields"u8);
            writer.WriteStartArray();
            foreach (var item in VectorFieldNames)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
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

        AzureCosmosDBFieldMappingOptions IJsonModel<AzureCosmosDBFieldMappingOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureCosmosDBFieldMappingOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureCosmosDBFieldMappingOptions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureCosmosDBFieldMappingOptions(document.RootElement, options);
        }

        internal static AzureCosmosDBFieldMappingOptions DeserializeAzureCosmosDBFieldMappingOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string titleField = default;
            string urlField = default;
            string filepathField = default;
            IList<string> contentFields = default;
            string contentFieldsSeparator = default;
            IList<string> vectorFields = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("titleField"u8))
                {
                    titleField = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("urlField"u8))
                {
                    urlField = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filepathField"u8))
                {
                    filepathField = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentFields"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    contentFields = array;
                    continue;
                }
                if (property.NameEquals("contentFieldsSeparator"u8))
                {
                    contentFieldsSeparator = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vectorFields"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    vectorFields = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureCosmosDBFieldMappingOptions(
                titleField,
                urlField,
                filepathField,
                contentFields,
                contentFieldsSeparator,
                vectorFields,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AzureCosmosDBFieldMappingOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureCosmosDBFieldMappingOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureCosmosDBFieldMappingOptions)} does not support '{options.Format}' format.");
            }
        }

        AzureCosmosDBFieldMappingOptions IPersistableModel<AzureCosmosDBFieldMappingOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureCosmosDBFieldMappingOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureCosmosDBFieldMappingOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureCosmosDBFieldMappingOptions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureCosmosDBFieldMappingOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AzureCosmosDBFieldMappingOptions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAzureCosmosDBFieldMappingOptions(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
