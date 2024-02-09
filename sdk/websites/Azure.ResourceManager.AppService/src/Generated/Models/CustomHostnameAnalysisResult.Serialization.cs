// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class CustomHostnameAnalysisResult : IUtf8JsonSerializable, IJsonModel<CustomHostnameAnalysisResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CustomHostnameAnalysisResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CustomHostnameAnalysisResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomHostnameAnalysisResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomHostnameAnalysisResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(IsHostnameAlreadyVerified))
            {
                writer.WritePropertyName("isHostnameAlreadyVerified"u8);
                writer.WriteBooleanValue(IsHostnameAlreadyVerified.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CustomDomainVerificationTest))
            {
                writer.WritePropertyName("customDomainVerificationTest"u8);
                writer.WriteStringValue(CustomDomainVerificationTest.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(CustomDomainVerificationFailureInfo))
            {
                writer.WritePropertyName("customDomainVerificationFailureInfo"u8);
                JsonSerializer.Serialize(writer, CustomDomainVerificationFailureInfo);
            }
            if (options.Format != "W" && Optional.IsDefined(HasConflictOnScaleUnit))
            {
                writer.WritePropertyName("hasConflictOnScaleUnit"u8);
                writer.WriteBooleanValue(HasConflictOnScaleUnit.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(HasConflictAcrossSubscription))
            {
                writer.WritePropertyName("hasConflictAcrossSubscription"u8);
                writer.WriteBooleanValue(HasConflictAcrossSubscription.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ConflictingAppResourceId))
            {
                writer.WritePropertyName("conflictingAppResourceId"u8);
                writer.WriteStringValue(ConflictingAppResourceId);
            }
            if (Optional.IsCollectionDefined(CNameRecords))
            {
                writer.WritePropertyName("cNameRecords"u8);
                writer.WriteStartArray();
                foreach (var item in CNameRecords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TxtRecords))
            {
                writer.WritePropertyName("txtRecords"u8);
                writer.WriteStartArray();
                foreach (var item in TxtRecords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ARecords))
            {
                writer.WritePropertyName("aRecords"u8);
                writer.WriteStartArray();
                foreach (var item in ARecords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AlternateCNameRecords))
            {
                writer.WritePropertyName("alternateCNameRecords"u8);
                writer.WriteStartArray();
                foreach (var item in AlternateCNameRecords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AlternateTxtRecords))
            {
                writer.WritePropertyName("alternateTxtRecords"u8);
                writer.WriteStartArray();
                foreach (var item in AlternateTxtRecords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        CustomHostnameAnalysisResult IJsonModel<CustomHostnameAnalysisResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomHostnameAnalysisResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomHostnameAnalysisResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomHostnameAnalysisResult(document.RootElement, options);
        }

        internal static CustomHostnameAnalysisResult DeserializeCustomHostnameAnalysisResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<bool> isHostnameAlreadyVerified = default;
            Optional<DnsVerificationTestResult> customDomainVerificationTest = default;
            Optional<ResponseError> customDomainVerificationFailureInfo = default;
            Optional<bool> hasConflictOnScaleUnit = default;
            Optional<bool> hasConflictAcrossSubscription = default;
            Optional<string> conflictingAppResourceId = default;
            Optional<IList<string>> cNameRecords = default;
            Optional<IList<string>> txtRecords = default;
            Optional<IList<string>> aRecords = default;
            Optional<IList<string>> alternateCNameRecords = default;
            Optional<IList<string>> alternateTxtRecords = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("isHostnameAlreadyVerified"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isHostnameAlreadyVerified = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("customDomainVerificationTest"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customDomainVerificationTest = property0.Value.GetString().ToDnsVerificationTestResult();
                            continue;
                        }
                        if (property0.NameEquals("customDomainVerificationFailureInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customDomainVerificationFailureInfo = JsonSerializer.Deserialize<ResponseError>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("hasConflictOnScaleUnit"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hasConflictOnScaleUnit = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("hasConflictAcrossSubscription"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hasConflictAcrossSubscription = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("conflictingAppResourceId"u8))
                        {
                            conflictingAppResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cNameRecords"u8))
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
                            cNameRecords = array;
                            continue;
                        }
                        if (property0.NameEquals("txtRecords"u8))
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
                            txtRecords = array;
                            continue;
                        }
                        if (property0.NameEquals("aRecords"u8))
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
                            aRecords = array;
                            continue;
                        }
                        if (property0.NameEquals("alternateCNameRecords"u8))
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
                            alternateCNameRecords = array;
                            continue;
                        }
                        if (property0.NameEquals("alternateTxtRecords"u8))
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
                            alternateTxtRecords = array;
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
            return new CustomHostnameAnalysisResult(id, name, type, systemData.Value, Optional.ToNullable(isHostnameAlreadyVerified), Optional.ToNullable(customDomainVerificationTest), customDomainVerificationFailureInfo.Value, Optional.ToNullable(hasConflictOnScaleUnit), Optional.ToNullable(hasConflictAcrossSubscription), conflictingAppResourceId.Value, Optional.ToList(cNameRecords), Optional.ToList(txtRecords), Optional.ToList(aRecords), Optional.ToList(alternateCNameRecords), Optional.ToList(alternateTxtRecords), kind.Value, serializedAdditionalRawData);
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

            if (Optional.IsDefined(Kind))
            {
                builder.Append("  kind:");
                if (Kind.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Kind}'''");
                }
                else
                {
                    builder.AppendLine($" '{Kind}'");
                }
            }

            if (Optional.IsDefined(Id))
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id.ToString()}'");
            }

            if (Optional.IsDefined(SystemData))
            {
                builder.Append("  systemData:");
                builder.AppendLine($" '{SystemData.ToString()}'");
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            if (Optional.IsDefined(IsHostnameAlreadyVerified))
            {
                builder.Append("    isHostnameAlreadyVerified:");
                var boolValue = IsHostnameAlreadyVerified.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(CustomDomainVerificationTest))
            {
                builder.Append("    customDomainVerificationTest:");
                builder.AppendLine($" '{CustomDomainVerificationTest.Value.ToSerialString()}'");
            }

            if (Optional.IsDefined(CustomDomainVerificationFailureInfo))
            {
                builder.Append("    customDomainVerificationFailureInfo:");
                AppendChildObject(builder, CustomDomainVerificationFailureInfo, options, 4, false);
            }

            if (Optional.IsDefined(HasConflictOnScaleUnit))
            {
                builder.Append("    hasConflictOnScaleUnit:");
                var boolValue = HasConflictOnScaleUnit.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(HasConflictAcrossSubscription))
            {
                builder.Append("    hasConflictAcrossSubscription:");
                var boolValue = HasConflictAcrossSubscription.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(ConflictingAppResourceId))
            {
                builder.Append("    conflictingAppResourceId:");
                if (ConflictingAppResourceId.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{ConflictingAppResourceId}'''");
                }
                else
                {
                    builder.AppendLine($" '{ConflictingAppResourceId}'");
                }
            }

            if (Optional.IsCollectionDefined(CNameRecords))
            {
                if (CNameRecords.Any())
                {
                    builder.Append("    cNameRecords:");
                    builder.AppendLine(" [");
                    foreach (var item in CNameRecords)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        if (item.Contains(Environment.NewLine))
                        {
                            builder.AppendLine("      '''");
                            builder.AppendLine($"{item}'''");
                        }
                        else
                        {
                            builder.AppendLine($"      '{item}'");
                        }
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsCollectionDefined(TxtRecords))
            {
                if (TxtRecords.Any())
                {
                    builder.Append("    txtRecords:");
                    builder.AppendLine(" [");
                    foreach (var item in TxtRecords)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        if (item.Contains(Environment.NewLine))
                        {
                            builder.AppendLine("      '''");
                            builder.AppendLine($"{item}'''");
                        }
                        else
                        {
                            builder.AppendLine($"      '{item}'");
                        }
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsCollectionDefined(ARecords))
            {
                if (ARecords.Any())
                {
                    builder.Append("    aRecords:");
                    builder.AppendLine(" [");
                    foreach (var item in ARecords)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        if (item.Contains(Environment.NewLine))
                        {
                            builder.AppendLine("      '''");
                            builder.AppendLine($"{item}'''");
                        }
                        else
                        {
                            builder.AppendLine($"      '{item}'");
                        }
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsCollectionDefined(AlternateCNameRecords))
            {
                if (AlternateCNameRecords.Any())
                {
                    builder.Append("    alternateCNameRecords:");
                    builder.AppendLine(" [");
                    foreach (var item in AlternateCNameRecords)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        if (item.Contains(Environment.NewLine))
                        {
                            builder.AppendLine("      '''");
                            builder.AppendLine($"{item}'''");
                        }
                        else
                        {
                            builder.AppendLine($"      '{item}'");
                        }
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsCollectionDefined(AlternateTxtRecords))
            {
                if (AlternateTxtRecords.Any())
                {
                    builder.Append("    alternateTxtRecords:");
                    builder.AppendLine(" [");
                    foreach (var item in AlternateTxtRecords)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        if (item.Contains(Environment.NewLine))
                        {
                            builder.AppendLine("      '''");
                            builder.AppendLine($"{item}'''");
                        }
                        else
                        {
                            builder.AppendLine($"      '{item}'");
                        }
                    }
                    builder.AppendLine("    ]");
                }
            }

            builder.AppendLine("  }");
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

        BinaryData IPersistableModel<CustomHostnameAnalysisResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomHostnameAnalysisResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CustomHostnameAnalysisResult)} does not support '{options.Format}' format.");
            }
        }

        CustomHostnameAnalysisResult IPersistableModel<CustomHostnameAnalysisResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomHostnameAnalysisResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCustomHostnameAnalysisResult(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(CustomHostnameAnalysisResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CustomHostnameAnalysisResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
