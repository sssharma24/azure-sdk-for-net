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
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ArmApplicationJitAccessPolicy : IUtf8JsonSerializable, IJsonModel<ArmApplicationJitAccessPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ArmApplicationJitAccessPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ArmApplicationJitAccessPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmApplicationJitAccessPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmApplicationJitAccessPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("jitAccessEnabled"u8);
            writer.WriteBooleanValue(JitAccessEnabled);
            if (Optional.IsDefined(JitApprovalMode))
            {
                writer.WritePropertyName("jitApprovalMode"u8);
                writer.WriteStringValue(JitApprovalMode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(JitApprovers))
            {
                writer.WritePropertyName("jitApprovers"u8);
                writer.WriteStartArray();
                foreach (var item in JitApprovers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MaximumJitAccessDuration))
            {
                writer.WritePropertyName("maximumJitAccessDuration"u8);
                writer.WriteStringValue(MaximumJitAccessDuration.Value, "P");
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

        ArmApplicationJitAccessPolicy IJsonModel<ArmApplicationJitAccessPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmApplicationJitAccessPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmApplicationJitAccessPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeArmApplicationJitAccessPolicy(document.RootElement, options);
        }

        internal static ArmApplicationJitAccessPolicy DeserializeArmApplicationJitAccessPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool jitAccessEnabled = default;
            Optional<JitApprovalMode> jitApprovalMode = default;
            Optional<IList<JitApprover>> jitApprovers = default;
            Optional<TimeSpan> maximumJitAccessDuration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jitAccessEnabled"u8))
                {
                    jitAccessEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("jitApprovalMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jitApprovalMode = new JitApprovalMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("jitApprovers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<JitApprover> array = new List<JitApprover>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JitApprover.DeserializeJitApprover(item));
                    }
                    jitApprovers = array;
                    continue;
                }
                if (property.NameEquals("maximumJitAccessDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximumJitAccessDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ArmApplicationJitAccessPolicy(jitAccessEnabled, Optional.ToNullable(jitApprovalMode), Optional.ToList(jitApprovers), Optional.ToNullable(maximumJitAccessDuration), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(JitAccessEnabled))
            {
                builder.Append("  jitAccessEnabled:");
                var boolValue = JitAccessEnabled == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(JitApprovalMode))
            {
                builder.Append("  jitApprovalMode:");
                builder.AppendLine($" '{JitApprovalMode.Value.ToString()}'");
            }

            if (Optional.IsCollectionDefined(JitApprovers))
            {
                if (JitApprovers.Any())
                {
                    builder.Append("  jitApprovers:");
                    builder.AppendLine(" [");
                    foreach (var item in JitApprovers)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsDefined(MaximumJitAccessDuration))
            {
                builder.Append("  maximumJitAccessDuration:");
                var formattedTimeSpan = TypeFormatters.ToString(MaximumJitAccessDuration.Value, "P");
                builder.AppendLine($" '{formattedTimeSpan}'");
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

        BinaryData IPersistableModel<ArmApplicationJitAccessPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmApplicationJitAccessPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ArmApplicationJitAccessPolicy)} does not support '{options.Format}' format.");
            }
        }

        ArmApplicationJitAccessPolicy IPersistableModel<ArmApplicationJitAccessPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmApplicationJitAccessPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeArmApplicationJitAccessPolicy(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ArmApplicationJitAccessPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ArmApplicationJitAccessPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
