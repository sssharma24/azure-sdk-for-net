// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class AutomationRulePropertyArrayChangedValuesCondition : IUtf8JsonSerializable, IJsonModel<AutomationRulePropertyArrayChangedValuesCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutomationRulePropertyArrayChangedValuesCondition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AutomationRulePropertyArrayChangedValuesCondition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationRulePropertyArrayChangedValuesCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationRulePropertyArrayChangedValuesCondition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ArrayType))
            {
                writer.WritePropertyName("arrayType"u8);
                writer.WriteStringValue(ArrayType.Value.ToString());
            }
            if (Optional.IsDefined(ChangeType))
            {
                writer.WritePropertyName("changeType"u8);
                writer.WriteStringValue(ChangeType.Value.ToString());
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

        AutomationRulePropertyArrayChangedValuesCondition IJsonModel<AutomationRulePropertyArrayChangedValuesCondition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationRulePropertyArrayChangedValuesCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationRulePropertyArrayChangedValuesCondition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomationRulePropertyArrayChangedValuesCondition(document.RootElement, options);
        }

        internal static AutomationRulePropertyArrayChangedValuesCondition DeserializeAutomationRulePropertyArrayChangedValuesCondition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AutomationRulePropertyArrayChangedConditionSupportedArrayType? arrayType = default;
            AutomationRulePropertyArrayChangedConditionSupportedChangeType? changeType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("arrayType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    arrayType = new AutomationRulePropertyArrayChangedConditionSupportedArrayType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("changeType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    changeType = new AutomationRulePropertyArrayChangedConditionSupportedChangeType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AutomationRulePropertyArrayChangedValuesCondition(arrayType, changeType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutomationRulePropertyArrayChangedValuesCondition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationRulePropertyArrayChangedValuesCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutomationRulePropertyArrayChangedValuesCondition)} does not support '{options.Format}' format.");
            }
        }

        AutomationRulePropertyArrayChangedValuesCondition IPersistableModel<AutomationRulePropertyArrayChangedValuesCondition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationRulePropertyArrayChangedValuesCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutomationRulePropertyArrayChangedValuesCondition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutomationRulePropertyArrayChangedValuesCondition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutomationRulePropertyArrayChangedValuesCondition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
