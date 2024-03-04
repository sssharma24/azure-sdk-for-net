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
    public partial class PolicyEvent : IUtf8JsonSerializable, IJsonModel<PolicyEvent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicyEvent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PolicyEvent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyEvent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyEvent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ODataId))
            {
                writer.WritePropertyName("@odata.id"u8);
                writer.WriteStringValue(ODataId);
            }
            if (Optional.IsDefined(ODataContext))
            {
                writer.WritePropertyName("@odata.context"u8);
                writer.WriteStringValue(ODataContext);
            }
            if (Optional.IsDefined(Timestamp))
            {
                writer.WritePropertyName("timestamp"u8);
                writer.WriteStringValue(Timestamp.Value, "O");
            }
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(PolicyAssignmentId))
            {
                writer.WritePropertyName("policyAssignmentId"u8);
                writer.WriteStringValue(PolicyAssignmentId);
            }
            if (Optional.IsDefined(PolicyDefinitionId))
            {
                writer.WritePropertyName("policyDefinitionId"u8);
                writer.WriteStringValue(PolicyDefinitionId);
            }
            if (Optional.IsDefined(EffectiveParameters))
            {
                writer.WritePropertyName("effectiveParameters"u8);
                writer.WriteStringValue(EffectiveParameters);
            }
            if (Optional.IsDefined(IsCompliant))
            {
                writer.WritePropertyName("isCompliant"u8);
                writer.WriteBooleanValue(IsCompliant.Value);
            }
            if (Optional.IsDefined(SubscriptionId))
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (Optional.IsDefined(ResourceTypeString))
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(ResourceTypeString);
            }
            if (Optional.IsDefined(ResourceLocation))
            {
                writer.WritePropertyName("resourceLocation"u8);
                writer.WriteStringValue(ResourceLocation.Value);
            }
            if (Optional.IsDefined(ResourceGroup))
            {
                writer.WritePropertyName("resourceGroup"u8);
                writer.WriteStringValue(ResourceGroup);
            }
            if (Optional.IsDefined(ResourceTags))
            {
                writer.WritePropertyName("resourceTags"u8);
                writer.WriteStringValue(ResourceTags);
            }
            if (Optional.IsDefined(PolicyAssignmentName))
            {
                writer.WritePropertyName("policyAssignmentName"u8);
                writer.WriteStringValue(PolicyAssignmentName);
            }
            if (Optional.IsDefined(PolicyAssignmentOwner))
            {
                writer.WritePropertyName("policyAssignmentOwner"u8);
                writer.WriteStringValue(PolicyAssignmentOwner);
            }
            if (Optional.IsDefined(PolicyAssignmentParameters))
            {
                writer.WritePropertyName("policyAssignmentParameters"u8);
                writer.WriteStringValue(PolicyAssignmentParameters);
            }
            if (Optional.IsDefined(PolicyAssignmentScope))
            {
                writer.WritePropertyName("policyAssignmentScope"u8);
                writer.WriteStringValue(PolicyAssignmentScope);
            }
            if (Optional.IsDefined(PolicyDefinitionName))
            {
                writer.WritePropertyName("policyDefinitionName"u8);
                writer.WriteStringValue(PolicyDefinitionName);
            }
            if (Optional.IsDefined(PolicyDefinitionAction))
            {
                writer.WritePropertyName("policyDefinitionAction"u8);
                writer.WriteStringValue(PolicyDefinitionAction);
            }
            if (Optional.IsDefined(PolicyDefinitionCategory))
            {
                writer.WritePropertyName("policyDefinitionCategory"u8);
                writer.WriteStringValue(PolicyDefinitionCategory);
            }
            if (Optional.IsDefined(PolicySetDefinitionId))
            {
                writer.WritePropertyName("policySetDefinitionId"u8);
                writer.WriteStringValue(PolicySetDefinitionId);
            }
            if (Optional.IsDefined(PolicySetDefinitionName))
            {
                writer.WritePropertyName("policySetDefinitionName"u8);
                writer.WriteStringValue(PolicySetDefinitionName);
            }
            if (Optional.IsDefined(PolicySetDefinitionOwner))
            {
                writer.WritePropertyName("policySetDefinitionOwner"u8);
                writer.WriteStringValue(PolicySetDefinitionOwner);
            }
            if (Optional.IsDefined(PolicySetDefinitionCategory))
            {
                writer.WritePropertyName("policySetDefinitionCategory"u8);
                writer.WriteStringValue(PolicySetDefinitionCategory);
            }
            if (Optional.IsDefined(PolicySetDefinitionParameters))
            {
                writer.WritePropertyName("policySetDefinitionParameters"u8);
                writer.WriteStringValue(PolicySetDefinitionParameters);
            }
            if (Optional.IsDefined(ManagementGroupIds))
            {
                writer.WritePropertyName("managementGroupIds"u8);
                writer.WriteStringValue(ManagementGroupIds);
            }
            if (Optional.IsDefined(PolicyDefinitionReferenceId))
            {
                writer.WritePropertyName("policyDefinitionReferenceId"u8);
                writer.WriteStringValue(PolicyDefinitionReferenceId);
            }
            if (Optional.IsDefined(ComplianceState))
            {
                writer.WritePropertyName("complianceState"u8);
                writer.WriteStringValue(ComplianceState);
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsDefined(PrincipalOid))
            {
                writer.WritePropertyName("principalOid"u8);
                writer.WriteStringValue(PrincipalOid);
            }
            if (Optional.IsCollectionDefined(Components))
            {
                writer.WritePropertyName("components"u8);
                writer.WriteStartArray();
                foreach (var item in Components)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
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

        PolicyEvent IJsonModel<PolicyEvent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyEvent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyEvent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyEvent(document.RootElement, options);
        }

        internal static PolicyEvent DeserializePolicyEvent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string odataId = default;
            string odataContext = default;
            DateTimeOffset? timestamp = default;
            ResourceIdentifier resourceId = default;
            ResourceIdentifier policyAssignmentId = default;
            ResourceIdentifier policyDefinitionId = default;
            string effectiveParameters = default;
            bool? isCompliant = default;
            string subscriptionId = default;
            string resourceType = default;
            AzureLocation? resourceLocation = default;
            string resourceGroup = default;
            string resourceTags = default;
            string policyAssignmentName = default;
            string policyAssignmentOwner = default;
            string policyAssignmentParameters = default;
            string policyAssignmentScope = default;
            string policyDefinitionName = default;
            string policyDefinitionAction = default;
            string policyDefinitionCategory = default;
            ResourceIdentifier policySetDefinitionId = default;
            string policySetDefinitionName = default;
            string policySetDefinitionOwner = default;
            string policySetDefinitionCategory = default;
            string policySetDefinitionParameters = default;
            string managementGroupIds = default;
            string policyDefinitionReferenceId = default;
            string complianceState = default;
            Guid? tenantId = default;
            string principalOid = default;
            IReadOnlyList<ComponentEventDetails> components = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.id"u8))
                {
                    odataId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@odata.context"u8))
                {
                    odataContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyAssignmentId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    policyAssignmentId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyDefinitionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    policyDefinitionId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("effectiveParameters"u8))
                {
                    effectiveParameters = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isCompliant"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isCompliant = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceGroup"u8))
                {
                    resourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceTags"u8))
                {
                    resourceTags = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyAssignmentName"u8))
                {
                    policyAssignmentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyAssignmentOwner"u8))
                {
                    policyAssignmentOwner = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyAssignmentParameters"u8))
                {
                    policyAssignmentParameters = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyAssignmentScope"u8))
                {
                    policyAssignmentScope = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyDefinitionName"u8))
                {
                    policyDefinitionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyDefinitionAction"u8))
                {
                    policyDefinitionAction = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyDefinitionCategory"u8))
                {
                    policyDefinitionCategory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policySetDefinitionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    policySetDefinitionId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policySetDefinitionName"u8))
                {
                    policySetDefinitionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policySetDefinitionOwner"u8))
                {
                    policySetDefinitionOwner = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policySetDefinitionCategory"u8))
                {
                    policySetDefinitionCategory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policySetDefinitionParameters"u8))
                {
                    policySetDefinitionParameters = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managementGroupIds"u8))
                {
                    managementGroupIds = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyDefinitionReferenceId"u8))
                {
                    policyDefinitionReferenceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("complianceState"u8))
                {
                    complianceState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("principalOid"u8))
                {
                    principalOid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("components"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ComponentEventDetails> array = new List<ComponentEventDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ComponentEventDetails.DeserializeComponentEventDetails(item, options));
                    }
                    components = array;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new PolicyEvent(
                odataId,
                odataContext,
                timestamp,
                resourceId,
                policyAssignmentId,
                policyDefinitionId,
                effectiveParameters,
                isCompliant,
                subscriptionId,
                resourceType,
                resourceLocation,
                resourceGroup,
                resourceTags,
                policyAssignmentName,
                policyAssignmentOwner,
                policyAssignmentParameters,
                policyAssignmentScope,
                policyDefinitionName,
                policyDefinitionAction,
                policyDefinitionCategory,
                policySetDefinitionId,
                policySetDefinitionName,
                policySetDefinitionOwner,
                policySetDefinitionCategory,
                policySetDefinitionParameters,
                managementGroupIds,
                policyDefinitionReferenceId,
                complianceState,
                tenantId,
                principalOid,
                components ?? new ChangeTrackingList<ComponentEventDetails>(),
                additionalProperties);
        }

        BinaryData IPersistableModel<PolicyEvent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyEvent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PolicyEvent)} does not support '{options.Format}' format.");
            }
        }

        PolicyEvent IPersistableModel<PolicyEvent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyEvent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePolicyEvent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PolicyEvent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PolicyEvent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
