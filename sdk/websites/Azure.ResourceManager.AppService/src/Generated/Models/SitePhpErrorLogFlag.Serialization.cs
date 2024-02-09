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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class SitePhpErrorLogFlag : IUtf8JsonSerializable, IJsonModel<SitePhpErrorLogFlag>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SitePhpErrorLogFlag>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SitePhpErrorLogFlag>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SitePhpErrorLogFlag>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SitePhpErrorLogFlag)} does not support '{format}' format.");
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
            if (Optional.IsDefined(LocalLogErrors))
            {
                writer.WritePropertyName("localLogErrors"u8);
                writer.WriteStringValue(LocalLogErrors);
            }
            if (Optional.IsDefined(MasterLogErrors))
            {
                writer.WritePropertyName("masterLogErrors"u8);
                writer.WriteStringValue(MasterLogErrors);
            }
            if (Optional.IsDefined(LocalLogErrorsMaxLength))
            {
                writer.WritePropertyName("localLogErrorsMaxLength"u8);
                writer.WriteStringValue(LocalLogErrorsMaxLength);
            }
            if (Optional.IsDefined(MasterLogErrorsMaxLength))
            {
                writer.WritePropertyName("masterLogErrorsMaxLength"u8);
                writer.WriteStringValue(MasterLogErrorsMaxLength);
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

        SitePhpErrorLogFlag IJsonModel<SitePhpErrorLogFlag>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SitePhpErrorLogFlag>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SitePhpErrorLogFlag)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSitePhpErrorLogFlag(document.RootElement, options);
        }

        internal static SitePhpErrorLogFlag DeserializeSitePhpErrorLogFlag(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<string> localLogErrors = default;
            Optional<string> masterLogErrors = default;
            Optional<string> localLogErrorsMaxLength = default;
            Optional<string> masterLogErrorsMaxLength = default;
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
                        if (property0.NameEquals("localLogErrors"u8))
                        {
                            localLogErrors = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("masterLogErrors"u8))
                        {
                            masterLogErrors = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("localLogErrorsMaxLength"u8))
                        {
                            localLogErrorsMaxLength = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("masterLogErrorsMaxLength"u8))
                        {
                            masterLogErrorsMaxLength = property0.Value.GetString();
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
            return new SitePhpErrorLogFlag(id, name, type, systemData.Value, localLogErrors.Value, masterLogErrors.Value, localLogErrorsMaxLength.Value, masterLogErrorsMaxLength.Value, kind.Value, serializedAdditionalRawData);
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
            if (Optional.IsDefined(LocalLogErrors))
            {
                builder.Append("    localLogErrors:");
                if (LocalLogErrors.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{LocalLogErrors}'''");
                }
                else
                {
                    builder.AppendLine($" '{LocalLogErrors}'");
                }
            }

            if (Optional.IsDefined(MasterLogErrors))
            {
                builder.Append("    masterLogErrors:");
                if (MasterLogErrors.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{MasterLogErrors}'''");
                }
                else
                {
                    builder.AppendLine($" '{MasterLogErrors}'");
                }
            }

            if (Optional.IsDefined(LocalLogErrorsMaxLength))
            {
                builder.Append("    localLogErrorsMaxLength:");
                if (LocalLogErrorsMaxLength.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{LocalLogErrorsMaxLength}'''");
                }
                else
                {
                    builder.AppendLine($" '{LocalLogErrorsMaxLength}'");
                }
            }

            if (Optional.IsDefined(MasterLogErrorsMaxLength))
            {
                builder.Append("    masterLogErrorsMaxLength:");
                if (MasterLogErrorsMaxLength.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{MasterLogErrorsMaxLength}'''");
                }
                else
                {
                    builder.AppendLine($" '{MasterLogErrorsMaxLength}'");
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

        BinaryData IPersistableModel<SitePhpErrorLogFlag>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SitePhpErrorLogFlag>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SitePhpErrorLogFlag)} does not support '{options.Format}' format.");
            }
        }

        SitePhpErrorLogFlag IPersistableModel<SitePhpErrorLogFlag>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SitePhpErrorLogFlag>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSitePhpErrorLogFlag(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SitePhpErrorLogFlag)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SitePhpErrorLogFlag>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
