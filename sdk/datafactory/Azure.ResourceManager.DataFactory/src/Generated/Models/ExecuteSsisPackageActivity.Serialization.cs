// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class ExecuteSsisPackageActivity : IUtf8JsonSerializable, IJsonModel<ExecuteSsisPackageActivity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExecuteSsisPackageActivity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExecuteSsisPackageActivity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecuteSsisPackageActivity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExecuteSsisPackageActivity)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(LinkedServiceName))
            {
                writer.WritePropertyName("linkedServiceName"u8);
                JsonSerializer.Serialize(writer, LinkedServiceName);
            }
            if (Optional.IsDefined(Policy))
            {
                writer.WritePropertyName("policy"u8);
                writer.WriteObjectValue(Policy);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ActivityType);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(OnInactiveMarkAs))
            {
                writer.WritePropertyName("onInactiveMarkAs"u8);
                writer.WriteStringValue(OnInactiveMarkAs.Value.ToString());
            }
            if (Optional.IsCollectionDefined(DependsOn))
            {
                writer.WritePropertyName("dependsOn"u8);
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(UserProperties))
            {
                writer.WritePropertyName("userProperties"u8);
                writer.WriteStartArray();
                foreach (var item in UserProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("packageLocation"u8);
            writer.WriteObjectValue(PackageLocation);
            if (Optional.IsDefined(Runtime))
            {
                writer.WritePropertyName("runtime"u8);
                JsonSerializer.Serialize(writer, Runtime);
            }
            if (Optional.IsDefined(LoggingLevel))
            {
                writer.WritePropertyName("loggingLevel"u8);
                JsonSerializer.Serialize(writer, LoggingLevel);
            }
            if (Optional.IsDefined(EnvironmentPath))
            {
                writer.WritePropertyName("environmentPath"u8);
                JsonSerializer.Serialize(writer, EnvironmentPath);
            }
            if (Optional.IsDefined(ExecutionCredential))
            {
                writer.WritePropertyName("executionCredential"u8);
                writer.WriteObjectValue(ExecutionCredential);
            }
            writer.WritePropertyName("connectVia"u8);
            writer.WriteObjectValue(ConnectVia);
            if (Optional.IsCollectionDefined(ProjectParameters))
            {
                writer.WritePropertyName("projectParameters"u8);
                writer.WriteStartObject();
                foreach (var item in ProjectParameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(PackageParameters))
            {
                writer.WritePropertyName("packageParameters"u8);
                writer.WriteStartObject();
                foreach (var item in PackageParameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(ProjectConnectionManagers))
            {
                writer.WritePropertyName("projectConnectionManagers"u8);
                writer.WriteStartObject();
                foreach (var item in ProjectConnectionManagers)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartObject();
                    foreach (var item0 in item.Value)
                    {
                        writer.WritePropertyName(item0.Key);
                        writer.WriteObjectValue(item0.Value);
                    }
                    writer.WriteEndObject();
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(PackageConnectionManagers))
            {
                writer.WritePropertyName("packageConnectionManagers"u8);
                writer.WriteStartObject();
                foreach (var item in PackageConnectionManagers)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartObject();
                    foreach (var item0 in item.Value)
                    {
                        writer.WritePropertyName(item0.Key);
                        writer.WriteObjectValue(item0.Value);
                    }
                    writer.WriteEndObject();
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(PropertyOverrides))
            {
                writer.WritePropertyName("propertyOverrides"u8);
                writer.WriteStartObject();
                foreach (var item in PropertyOverrides)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(LogLocation))
            {
                writer.WritePropertyName("logLocation"u8);
                writer.WriteObjectValue(LogLocation);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        ExecuteSsisPackageActivity IJsonModel<ExecuteSsisPackageActivity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecuteSsisPackageActivity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExecuteSsisPackageActivity)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExecuteSsisPackageActivity(document.RootElement, options);
        }

        internal static ExecuteSsisPackageActivity DeserializeExecuteSsisPackageActivity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryLinkedServiceReference linkedServiceName = default;
            PipelineActivityPolicy policy = default;
            string name = default;
            string type = default;
            string description = default;
            PipelineActivityState? state = default;
            ActivityOnInactiveMarkAs? onInactiveMarkAs = default;
            IList<PipelineActivityDependency> dependsOn = default;
            IList<PipelineActivityUserProperty> userProperties = default;
            SsisPackageLocation packageLocation = default;
            DataFactoryElement<string> runtime = default;
            DataFactoryElement<string> loggingLevel = default;
            DataFactoryElement<string> environmentPath = default;
            SsisExecutionCredential executionCredential = default;
            IntegrationRuntimeReference connectVia = default;
            IDictionary<string, SsisExecutionParameter> projectParameters = default;
            IDictionary<string, SsisExecutionParameter> packageParameters = default;
            IDictionary<string, IDictionary<string, SsisExecutionParameter>> projectConnectionManagers = default;
            IDictionary<string, IDictionary<string, SsisExecutionParameter>> packageConnectionManagers = default;
            IDictionary<string, SsisPropertyOverride> propertyOverrides = default;
            SsisLogLocation logLocation = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedServiceName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkedServiceName = JsonSerializer.Deserialize<DataFactoryLinkedServiceReference>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("policy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policy = PipelineActivityPolicy.DeserializePipelineActivityPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new PipelineActivityState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("onInactiveMarkAs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onInactiveMarkAs = new ActivityOnInactiveMarkAs(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dependsOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PipelineActivityDependency> array = new List<PipelineActivityDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PipelineActivityDependency.DeserializePipelineActivityDependency(item, options));
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("userProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PipelineActivityUserProperty> array = new List<PipelineActivityUserProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PipelineActivityUserProperty.DeserializePipelineActivityUserProperty(item, options));
                    }
                    userProperties = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("packageLocation"u8))
                        {
                            packageLocation = SsisPackageLocation.DeserializeSsisPackageLocation(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("runtime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            runtime = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("loggingLevel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            loggingLevel = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("environmentPath"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            environmentPath = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("executionCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            executionCredential = SsisExecutionCredential.DeserializeSsisExecutionCredential(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("connectVia"u8))
                        {
                            connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("projectParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, SsisExecutionParameter> dictionary = new Dictionary<string, SsisExecutionParameter>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, SsisExecutionParameter.DeserializeSsisExecutionParameter(property1.Value, options));
                            }
                            projectParameters = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("packageParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, SsisExecutionParameter> dictionary = new Dictionary<string, SsisExecutionParameter>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, SsisExecutionParameter.DeserializeSsisExecutionParameter(property1.Value, options));
                            }
                            packageParameters = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("projectConnectionManagers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, IDictionary<string, SsisExecutionParameter>> dictionary = new Dictionary<string, IDictionary<string, SsisExecutionParameter>>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    Dictionary<string, SsisExecutionParameter> dictionary0 = new Dictionary<string, SsisExecutionParameter>();
                                    foreach (var property2 in property1.Value.EnumerateObject())
                                    {
                                        dictionary0.Add(property2.Name, SsisExecutionParameter.DeserializeSsisExecutionParameter(property2.Value, options));
                                    }
                                    dictionary.Add(property1.Name, dictionary0);
                                }
                            }
                            projectConnectionManagers = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("packageConnectionManagers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, IDictionary<string, SsisExecutionParameter>> dictionary = new Dictionary<string, IDictionary<string, SsisExecutionParameter>>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    Dictionary<string, SsisExecutionParameter> dictionary0 = new Dictionary<string, SsisExecutionParameter>();
                                    foreach (var property2 in property1.Value.EnumerateObject())
                                    {
                                        dictionary0.Add(property2.Name, SsisExecutionParameter.DeserializeSsisExecutionParameter(property2.Value, options));
                                    }
                                    dictionary.Add(property1.Name, dictionary0);
                                }
                            }
                            packageConnectionManagers = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("propertyOverrides"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, SsisPropertyOverride> dictionary = new Dictionary<string, SsisPropertyOverride>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, SsisPropertyOverride.DeserializeSsisPropertyOverride(property1.Value, options));
                            }
                            propertyOverrides = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("logLocation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            logLocation = SsisLogLocation.DeserializeSsisLogLocation(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ExecuteSsisPackageActivity(
                name,
                type,
                description,
                state,
                onInactiveMarkAs,
                dependsOn ?? new ChangeTrackingList<PipelineActivityDependency>(),
                userProperties ?? new ChangeTrackingList<PipelineActivityUserProperty>(),
                additionalProperties,
                linkedServiceName,
                policy,
                packageLocation,
                runtime,
                loggingLevel,
                environmentPath,
                executionCredential,
                connectVia,
                projectParameters ?? new ChangeTrackingDictionary<string, SsisExecutionParameter>(),
                packageParameters ?? new ChangeTrackingDictionary<string, SsisExecutionParameter>(),
                projectConnectionManagers ?? new ChangeTrackingDictionary<string, IDictionary<string, SsisExecutionParameter>>(),
                packageConnectionManagers ?? new ChangeTrackingDictionary<string, IDictionary<string, SsisExecutionParameter>>(),
                propertyOverrides ?? new ChangeTrackingDictionary<string, SsisPropertyOverride>(),
                logLocation);
        }

        BinaryData IPersistableModel<ExecuteSsisPackageActivity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecuteSsisPackageActivity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExecuteSsisPackageActivity)} does not support '{options.Format}' format.");
            }
        }

        ExecuteSsisPackageActivity IPersistableModel<ExecuteSsisPackageActivity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecuteSsisPackageActivity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExecuteSsisPackageActivity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExecuteSsisPackageActivity)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExecuteSsisPackageActivity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
