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
    public partial class LocationMetadata : IUtf8JsonSerializable, IJsonModel<LocationMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LocationMetadata>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LocationMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LocationMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LocationMetadata)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(RegionType))
            {
                writer.WritePropertyName("regionType"u8);
                writer.WriteStringValue(RegionType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(RegionCategory))
            {
                writer.WritePropertyName("regionCategory"u8);
                writer.WriteStringValue(RegionCategory.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Geography))
            {
                writer.WritePropertyName("geography"u8);
                writer.WriteStringValue(Geography);
            }
            if (options.Format != "W" && Optional.IsDefined(GeographyGroup))
            {
                writer.WritePropertyName("geographyGroup"u8);
                writer.WriteStringValue(GeographyGroup);
            }
            if (options.Format != "W" && Optional.IsDefined(Longitude))
            {
                writer.WritePropertyName("longitude"u8);
                WriteLongitude(writer);
            }
            if (options.Format != "W" && Optional.IsDefined(Latitude))
            {
                writer.WritePropertyName("latitude"u8);
                WriteLatitude(writer);
            }
            if (options.Format != "W" && Optional.IsDefined(PhysicalLocation))
            {
                writer.WritePropertyName("physicalLocation"u8);
                writer.WriteStringValue(PhysicalLocation);
            }
            if (Optional.IsCollectionDefined(PairedRegions))
            {
                writer.WritePropertyName("pairedRegion"u8);
                writer.WriteStartArray();
                foreach (var item in PairedRegions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(HomeLocation))
            {
                writer.WritePropertyName("homeLocation"u8);
                writer.WriteStringValue(HomeLocation);
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

        LocationMetadata IJsonModel<LocationMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LocationMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LocationMetadata)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLocationMetadata(document.RootElement, options);
        }

        internal static LocationMetadata DeserializeLocationMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<RegionType> regionType = default;
            Optional<RegionCategory> regionCategory = default;
            Optional<string> geography = default;
            Optional<string> geographyGroup = default;
            Optional<double> longitude = default;
            Optional<double> latitude = default;
            Optional<string> physicalLocation = default;
            Optional<IReadOnlyList<PairedRegion>> pairedRegion = default;
            Optional<string> homeLocation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("regionType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    regionType = new RegionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("regionCategory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    regionCategory = new RegionCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("geography"u8))
                {
                    geography = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("geographyGroup"u8))
                {
                    geographyGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("longitude"u8))
                {
                    ReadLongitude(property, ref longitude);
                    continue;
                }
                if (property.NameEquals("latitude"u8))
                {
                    ReadLatitude(property, ref latitude);
                    continue;
                }
                if (property.NameEquals("physicalLocation"u8))
                {
                    physicalLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pairedRegion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PairedRegion> array = new List<PairedRegion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PairedRegion.DeserializePairedRegion(item));
                    }
                    pairedRegion = array;
                    continue;
                }
                if (property.NameEquals("homeLocation"u8))
                {
                    homeLocation = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LocationMetadata(Optional.ToNullable(regionType), Optional.ToNullable(regionCategory), geography.Value, geographyGroup.Value, Optional.ToNullable(longitude), Optional.ToNullable(latitude), physicalLocation.Value, Optional.ToList(pairedRegion), homeLocation.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(RegionType))
            {
                builder.Append("  regionType:");
                builder.AppendLine($" '{RegionType.Value.ToString()}'");
            }

            if (Optional.IsDefined(RegionCategory))
            {
                builder.Append("  regionCategory:");
                builder.AppendLine($" '{RegionCategory.Value.ToString()}'");
            }

            if (Optional.IsDefined(Geography))
            {
                builder.Append("  geography:");
                if (Geography.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Geography}'''");
                }
                else
                {
                    builder.AppendLine($" '{Geography}'");
                }
            }

            if (Optional.IsDefined(GeographyGroup))
            {
                builder.Append("  geographyGroup:");
                if (GeographyGroup.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{GeographyGroup}'''");
                }
                else
                {
                    builder.AppendLine($" '{GeographyGroup}'");
                }
            }

            if (Optional.IsDefined(Longitude))
            {
                builder.Append("  longitude:");
                builder.AppendLine($" '{Longitude.Value.ToString()}'");
            }

            if (Optional.IsDefined(Latitude))
            {
                builder.Append("  latitude:");
                builder.AppendLine($" '{Latitude.Value.ToString()}'");
            }

            if (Optional.IsDefined(PhysicalLocation))
            {
                builder.Append("  physicalLocation:");
                if (PhysicalLocation.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{PhysicalLocation}'''");
                }
                else
                {
                    builder.AppendLine($" '{PhysicalLocation}'");
                }
            }

            if (Optional.IsCollectionDefined(PairedRegions))
            {
                if (PairedRegions.Any())
                {
                    builder.Append("  pairedRegion:");
                    builder.AppendLine(" [");
                    foreach (var item in PairedRegions)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsDefined(HomeLocation))
            {
                builder.Append("  homeLocation:");
                if (HomeLocation.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{HomeLocation}'''");
                }
                else
                {
                    builder.AppendLine($" '{HomeLocation}'");
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

        BinaryData IPersistableModel<LocationMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LocationMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(LocationMetadata)} does not support '{options.Format}' format.");
            }
        }

        LocationMetadata IPersistableModel<LocationMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LocationMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLocationMetadata(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(LocationMetadata)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LocationMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
