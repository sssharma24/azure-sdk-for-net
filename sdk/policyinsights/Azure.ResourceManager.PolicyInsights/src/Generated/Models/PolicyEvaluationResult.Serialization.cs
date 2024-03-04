// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.PolicyInsights;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class PolicyEvaluationResult : IUtf8JsonSerializable, IJsonModel<PolicyEvaluationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicyEvaluationResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PolicyEvaluationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyEvaluationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyEvaluationResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(PolicyInfo))
            {
                writer.WritePropertyName("policyInfo"u8);
                writer.WriteObjectValue(PolicyInfo);
            }
            if (options.Format != "W" && Optional.IsDefined(EvaluationResult))
            {
                writer.WritePropertyName("evaluationResult"u8);
                writer.WriteStringValue(EvaluationResult);
            }
            if (options.Format != "W" && Optional.IsDefined(EvaluationDetails))
            {
                writer.WritePropertyName("evaluationDetails"u8);
                writer.WriteObjectValue(EvaluationDetails);
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

        PolicyEvaluationResult IJsonModel<PolicyEvaluationResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyEvaluationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyEvaluationResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyEvaluationResult(document.RootElement, options);
        }

        internal static PolicyEvaluationResult DeserializePolicyEvaluationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PolicyReference policyInfo = default;
            string evaluationResult = default;
            PolicyEvaluationDetails evaluationDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policyInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyInfo = PolicyReference.DeserializePolicyReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("evaluationResult"u8))
                {
                    evaluationResult = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("evaluationDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    evaluationDetails = PolicyEvaluationDetails.DeserializePolicyEvaluationDetails(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PolicyEvaluationResult(policyInfo, evaluationResult, evaluationDetails, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PolicyEvaluationResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyEvaluationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PolicyEvaluationResult)} does not support '{options.Format}' format.");
            }
        }

        PolicyEvaluationResult IPersistableModel<PolicyEvaluationResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyEvaluationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePolicyEvaluationResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PolicyEvaluationResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PolicyEvaluationResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
