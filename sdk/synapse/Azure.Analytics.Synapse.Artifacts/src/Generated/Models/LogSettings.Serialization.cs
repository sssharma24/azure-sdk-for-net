// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Analytics.Synapse.Artifacts;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(LogSettingsConverter))]
    public partial class LogSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EnableCopyActivityLog))
            {
                writer.WritePropertyName("enableCopyActivityLog"u8);
                writer.WriteObjectValue(EnableCopyActivityLog);
            }
            if (Optional.IsDefined(CopyActivityLogSettings))
            {
                writer.WritePropertyName("copyActivityLogSettings"u8);
                writer.WriteObjectValue(CopyActivityLogSettings);
            }
            writer.WritePropertyName("logLocationSettings"u8);
            writer.WriteObjectValue(LogLocationSettings);
            writer.WriteEndObject();
        }

        internal static LogSettings DeserializeLogSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            object enableCopyActivityLog = default;
            CopyActivityLogSettings copyActivityLogSettings = default;
            LogLocationSettings logLocationSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enableCopyActivityLog"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableCopyActivityLog = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("copyActivityLogSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    copyActivityLogSettings = CopyActivityLogSettings.DeserializeCopyActivityLogSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("logLocationSettings"u8))
                {
                    logLocationSettings = LogLocationSettings.DeserializeLogLocationSettings(property.Value);
                    continue;
                }
            }
            return new LogSettings(enableCopyActivityLog, copyActivityLogSettings, logLocationSettings);
        }

        internal partial class LogSettingsConverter : JsonConverter<LogSettings>
        {
            public override void Write(Utf8JsonWriter writer, LogSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override LogSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLogSettings(document.RootElement);
            }
        }
    }
}
