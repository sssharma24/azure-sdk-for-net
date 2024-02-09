// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Purview;

namespace Azure.ResourceManager.Purview.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmPurviewModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Purview.PurviewAccountData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> Gets or sets the Sku. </param>
        /// <param name="accountStatus"> Gets or sets the status of the account. </param>
        /// <param name="cloudConnectorsAwsExternalId"> External Cloud Service connectors. </param>
        /// <param name="createdOn"> Gets the time at which the entity was created. </param>
        /// <param name="createdBy"> Gets the creator of the entity. </param>
        /// <param name="createdByObjectId"> Gets the creators of the entity's object id. </param>
        /// <param name="endpoints"> The URIs that are the public endpoints of the account. </param>
        /// <param name="friendlyName"> Gets or sets the friendly name. </param>
        /// <param name="ingestionStorage"> Ingestion Storage Account Info. </param>
        /// <param name="managedEventHubState"> Gets or sets the state of managed eventhub. If enabled managed eventhub will be created, if disabled the managed eventhub will be removed. </param>
        /// <param name="managedResourceGroupName"> Gets or sets the managed resource group name. </param>
        /// <param name="managedResources"> Gets the resource identifiers of the managed resources. </param>
        /// <param name="managedResourcesPublicNetworkAccess"> Gets or sets the public network access for managed resources. </param>
        /// <param name="privateEndpointConnections"> Gets the private endpoint connections information. </param>
        /// <param name="provisioningState"> Gets or sets the state of the provisioning. </param>
        /// <param name="publicNetworkAccess"> Gets or sets the public network access. </param>
        /// <param name="identity"> The Managed Identity of the resource. Current supported identity types: None, SystemAssigned, UserAssigned. </param>
        /// <returns> A new <see cref="Purview.PurviewAccountData"/> instance for mocking. </returns>
        public static PurviewAccountData PurviewAccountData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, PurviewAccountSku sku = null, PurviewAccountStatus accountStatus = null, string cloudConnectorsAwsExternalId = null, DateTimeOffset? createdOn = null, string createdBy = null, string createdByObjectId = null, PurviewAccountEndpoint endpoints = null, string friendlyName = null, PurviewIngestionStorage ingestionStorage = null, PurviewManagedEventHubState? managedEventHubState = null, string managedResourceGroupName = null, PurviewManagedResource managedResources = null, ManagedResourcesPublicNetworkAccess? managedResourcesPublicNetworkAccess = null, IEnumerable<PurviewPrivateEndpointConnectionData> privateEndpointConnections = null, PurviewProvisioningState? provisioningState = null, PurviewPublicNetworkAccess? publicNetworkAccess = null, ManagedServiceIdentity identity = null)
        {
            tags ??= new Dictionary<string, string>();
            privateEndpointConnections ??= new List<PurviewPrivateEndpointConnectionData>();

            return new PurviewAccountData(id, name, resourceType, systemData, tags, location, sku, accountStatus, cloudConnectorsAwsExternalId != null ? new CloudConnectors(cloudConnectorsAwsExternalId, serializedAdditionalRawData: null) : null, createdOn, createdBy, createdByObjectId, endpoints, friendlyName, ingestionStorage, managedEventHubState, managedResourceGroupName, managedResources, managedResourcesPublicNetworkAccess, privateEndpointConnections?.ToList(), provisioningState, publicNetworkAccess, identity, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PurviewAccountProperties"/>. </summary>
        /// <param name="accountStatus"> Gets or sets the status of the account. </param>
        /// <param name="cloudConnectorsAwsExternalId"> External Cloud Service connectors. </param>
        /// <param name="createdOn"> Gets the time at which the entity was created. </param>
        /// <param name="createdBy"> Gets the creator of the entity. </param>
        /// <param name="createdByObjectId"> Gets the creators of the entity's object id. </param>
        /// <param name="endpoints"> The URIs that are the public endpoints of the account. </param>
        /// <param name="friendlyName"> Gets or sets the friendly name. </param>
        /// <param name="ingestionStorage"> Ingestion Storage Account Info. </param>
        /// <param name="managedEventHubState"> Gets or sets the state of managed eventhub. If enabled managed eventhub will be created, if disabled the managed eventhub will be removed. </param>
        /// <param name="managedResourceGroupName"> Gets or sets the managed resource group name. </param>
        /// <param name="managedResources"> Gets the resource identifiers of the managed resources. </param>
        /// <param name="managedResourcesPublicNetworkAccess"> Gets or sets the public network access for managed resources. </param>
        /// <param name="privateEndpointConnections"> Gets the private endpoint connections information. </param>
        /// <param name="provisioningState"> Gets or sets the state of the provisioning. </param>
        /// <param name="publicNetworkAccess"> Gets or sets the public network access. </param>
        /// <returns> A new <see cref="Models.PurviewAccountProperties"/> instance for mocking. </returns>
        public static PurviewAccountProperties PurviewAccountProperties(PurviewAccountStatus accountStatus = null, string cloudConnectorsAwsExternalId = null, DateTimeOffset? createdOn = null, string createdBy = null, string createdByObjectId = null, PurviewAccountEndpoint endpoints = null, string friendlyName = null, PurviewIngestionStorage ingestionStorage = null, PurviewManagedEventHubState? managedEventHubState = null, string managedResourceGroupName = null, PurviewManagedResource managedResources = null, ManagedResourcesPublicNetworkAccess? managedResourcesPublicNetworkAccess = null, IEnumerable<PurviewPrivateEndpointConnectionData> privateEndpointConnections = null, PurviewProvisioningState? provisioningState = null, PurviewPublicNetworkAccess? publicNetworkAccess = null)
        {
            privateEndpointConnections ??= new List<PurviewPrivateEndpointConnectionData>();

            return new PurviewAccountProperties(accountStatus, cloudConnectorsAwsExternalId != null ? new CloudConnectors(cloudConnectorsAwsExternalId, serializedAdditionalRawData: null) : null, createdOn, createdBy, createdByObjectId, endpoints, friendlyName, ingestionStorage, managedEventHubState, managedResourceGroupName, managedResources, managedResourcesPublicNetworkAccess, privateEndpointConnections?.ToList(), provisioningState, publicNetworkAccess, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PurviewAccountStatus"/>. </summary>
        /// <param name="accountProvisioningState"> Gets the account status code. </param>
        /// <param name="errorDetails"> Gets the account error details. </param>
        /// <returns> A new <see cref="Models.PurviewAccountStatus"/> instance for mocking. </returns>
        public static PurviewAccountStatus PurviewAccountStatus(PurviewAccountProvisioningState? accountProvisioningState = null, ResponseError errorDetails = null)
        {
            return new PurviewAccountStatus(accountProvisioningState, errorDetails, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PurviewIngestionStorage"/>. </summary>
        /// <param name="id"> Gets or sets the Id. </param>
        /// <param name="primaryEndpoint"> Gets or sets the primary endpoint. </param>
        /// <param name="publicNetworkAccess"> Gets or sets the public network access setting. </param>
        /// <returns> A new <see cref="Models.PurviewIngestionStorage"/> instance for mocking. </returns>
        public static PurviewIngestionStorage PurviewIngestionStorage(string id = null, string primaryEndpoint = null, PurviewPublicNetworkAccess? publicNetworkAccess = null)
        {
            return new PurviewIngestionStorage(id, primaryEndpoint, publicNetworkAccess, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PurviewManagedResource"/>. </summary>
        /// <param name="eventHubNamespace"> Gets the managed event hub namespace resource identifier. </param>
        /// <param name="resourceGroup"> Gets the managed resource group resource identifier. This resource group will host resource dependencies for the account. </param>
        /// <param name="storageAccount"> Gets the managed storage account resource identifier. </param>
        /// <returns> A new <see cref="Models.PurviewManagedResource"/> instance for mocking. </returns>
        public static PurviewManagedResource PurviewManagedResource(ResourceIdentifier eventHubNamespace = null, ResourceIdentifier resourceGroup = null, ResourceIdentifier storageAccount = null)
        {
            return new PurviewManagedResource(eventHubNamespace, resourceGroup, storageAccount, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Purview.PurviewPrivateEndpointConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="privateEndpointId"> The private endpoint information. </param>
        /// <param name="connectionState"> The private link service connection state. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <returns> A new <see cref="Purview.PurviewPrivateEndpointConnectionData"/> instance for mocking. </returns>
        public static PurviewPrivateEndpointConnectionData PurviewPrivateEndpointConnectionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ResourceIdentifier privateEndpointId = null, PurviewPrivateLinkServiceConnectionState connectionState = null, string provisioningState = null)
        {
            return new PurviewPrivateEndpointConnectionData(id, name, resourceType, systemData, privateEndpointId != null ? ResourceManagerModelFactory.WritableSubResource(privateEndpointId) : null, connectionState, provisioningState, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PurviewAccountSku"/>. </summary>
        /// <param name="capacity"> Gets or sets the sku capacity. </param>
        /// <param name="name"> Gets or sets the sku name. </param>
        /// <returns> A new <see cref="Models.PurviewAccountSku"/> instance for mocking. </returns>
        public static PurviewAccountSku PurviewAccountSku(int? capacity = null, PurviewAccountSkuName? name = null)
        {
            return new PurviewAccountSku(capacity, name, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PurviewAccountAccessKey"/>. </summary>
        /// <param name="atlasKafkaPrimaryEndpoint"> Gets or sets the primary connection string. </param>
        /// <param name="atlasKafkaSecondaryEndpoint"> Gets or sets the secondary connection string. </param>
        /// <returns> A new <see cref="Models.PurviewAccountAccessKey"/> instance for mocking. </returns>
        public static PurviewAccountAccessKey PurviewAccountAccessKey(string atlasKafkaPrimaryEndpoint = null, string atlasKafkaSecondaryEndpoint = null)
        {
            return new PurviewAccountAccessKey(atlasKafkaPrimaryEndpoint, atlasKafkaSecondaryEndpoint, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PurviewBatchFeatureStatus"/>. </summary>
        /// <param name="features"> Features with enabled status. </param>
        /// <returns> A new <see cref="Models.PurviewBatchFeatureStatus"/> instance for mocking. </returns>
        public static PurviewBatchFeatureStatus PurviewBatchFeatureStatus(IReadOnlyDictionary<string, bool> features = null)
        {
            features ??= new Dictionary<string, bool>();

            return new PurviewBatchFeatureStatus(features, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PrivateEndpointConnectionStatusUpdateResult"/>. </summary>
        /// <param name="privateEndpointId"> The private endpoint resource identifier. </param>
        /// <param name="status"> The private endpoint connection status. </param>
        /// <returns> A new <see cref="Models.PrivateEndpointConnectionStatusUpdateResult"/> instance for mocking. </returns>
        public static PrivateEndpointConnectionStatusUpdateResult PrivateEndpointConnectionStatusUpdateResult(string privateEndpointId = null, string status = null)
        {
            return new PrivateEndpointConnectionStatusUpdateResult(privateEndpointId, status, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Purview.PurviewKafkaConfigurationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="consumerGroup"> Consumer group for hook event hub. </param>
        /// <param name="credentials"> Credentials to access the event streaming service attached to the purview account. </param>
        /// <param name="eventHubPartitionId"> Optional partition Id for notification event hub. If not set, all partitions will be leveraged. </param>
        /// <param name="eventHubResourceId"></param>
        /// <param name="eventHubType"> The event hub type. </param>
        /// <param name="eventStreamingState"> The state of the event streaming service. </param>
        /// <param name="eventStreamingType"> The event streaming service type. </param>
        /// <returns> A new <see cref="Purview.PurviewKafkaConfigurationData"/> instance for mocking. </returns>
        public static PurviewKafkaConfigurationData PurviewKafkaConfigurationData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string consumerGroup = null, PurviewCredentials credentials = null, string eventHubPartitionId = null, ResourceIdentifier eventHubResourceId = null, PurviewKafkaEventHubType? eventHubType = null, PurviewEventStreamingState? eventStreamingState = null, PurviewEventStreamingType? eventStreamingType = null)
        {
            return new PurviewKafkaConfigurationData(id, name, resourceType, systemData, consumerGroup, credentials, eventHubPartitionId, eventHubResourceId, eventHubType, eventStreamingState, eventStreamingType, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Purview.PurviewPrivateLinkResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The private link resource properties. </param>
        /// <returns> A new <see cref="Purview.PurviewPrivateLinkResourceData"/> instance for mocking. </returns>
        public static PurviewPrivateLinkResourceData PurviewPrivateLinkResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, PurviewPrivateLinkResourceProperties properties = null)
        {
            return new PurviewPrivateLinkResourceData(id, name, resourceType, systemData, properties, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PurviewPrivateLinkResourceProperties"/>. </summary>
        /// <param name="groupId"> The private link resource group identifier. </param>
        /// <param name="requiredMembers"> This translates to how many Private IPs should be created for each privately linkable resource. </param>
        /// <param name="requiredZoneNames"> The required zone names for private link resource. </param>
        /// <returns> A new <see cref="Models.PurviewPrivateLinkResourceProperties"/> instance for mocking. </returns>
        public static PurviewPrivateLinkResourceProperties PurviewPrivateLinkResourceProperties(string groupId = null, IEnumerable<string> requiredMembers = null, IEnumerable<string> requiredZoneNames = null)
        {
            requiredMembers ??= new List<string>();
            requiredZoneNames ??= new List<string>();

            return new PurviewPrivateLinkResourceProperties(groupId, requiredMembers?.ToList(), requiredZoneNames?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PurviewAccountNameAvailabilityResult"/>. </summary>
        /// <param name="message"> Error message. </param>
        /// <param name="isNameAvailable"> Indicates if name is valid and available. </param>
        /// <param name="reason"> The reason the name is not available. </param>
        /// <returns> A new <see cref="Models.PurviewAccountNameAvailabilityResult"/> instance for mocking. </returns>
        public static PurviewAccountNameAvailabilityResult PurviewAccountNameAvailabilityResult(string message = null, bool? isNameAvailable = null, PurviewAccountNameUnavailableReason? reason = null)
        {
            return new PurviewAccountNameAvailabilityResult(message, isNameAvailable, reason, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PurviewUsage"/>. </summary>
        /// <param name="currentValue"> Current usage quota value. </param>
        /// <param name="id"> Fully qualified resource Id. </param>
        /// <param name="limit"> Usage quota limit. </param>
        /// <param name="name"> Quota name. </param>
        /// <param name="unit"> Quota usage unit. </param>
        /// <returns> A new <see cref="Models.PurviewUsage"/> instance for mocking. </returns>
        public static PurviewUsage PurviewUsage(int? currentValue = null, string id = null, int? limit = null, PurviewUsageName name = null, string unit = null)
        {
            return new PurviewUsage(currentValue, id, limit, name, unit, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PurviewUsageName"/>. </summary>
        /// <param name="localizedValue"> Gets or sets the localized name value. </param>
        /// <param name="value"> Gets or sets the name value. </param>
        /// <returns> A new <see cref="Models.PurviewUsageName"/> instance for mocking. </returns>
        public static PurviewUsageName PurviewUsageName(string localizedValue = null, string value = null)
        {
            return new PurviewUsageName(localizedValue, value, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PurviewQuotaName"/>. </summary>
        /// <param name="localizedValue"> Gets or sets the localized name value. </param>
        /// <param name="value"> Gets or sets the name value. </param>
        /// <returns> A new <see cref="Models.PurviewQuotaName"/> instance for mocking. </returns>
        public static PurviewQuotaName PurviewQuotaName(string localizedValue = null, string value = null)
        {
            return new PurviewQuotaName(localizedValue, value, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="T:Azure.ResourceManager.Purview.PurviewAccountData" />. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> Gets or sets the Sku. </param>
        /// <param name="cloudConnectorsAwsExternalId">
        /// Cloud connectors.
        /// External cloud identifier used as part of scanning configuration.
        /// </param>
        /// <param name="createdOn"> Gets the time at which the entity was created. </param>
        /// <param name="createdBy"> Gets the creator of the entity. </param>
        /// <param name="createdByObjectId"> Gets the creators of the entity's object id. </param>
        /// <param name="endpoints"> The URIs that are the public endpoints of the account. </param>
        /// <param name="friendlyName"> Gets or sets the friendly name. </param>
        /// <param name="managedResourceGroupName"> Gets or sets the managed resource group name. </param>
        /// <param name="managedResources"> Gets the resource identifiers of the managed resources. </param>
        /// <param name="privateEndpointConnections"> Gets the private endpoint connections information. </param>
        /// <param name="provisioningState"> Gets or sets the state of the provisioning. </param>
        /// <param name="publicNetworkAccess"> Gets or sets the public network access. </param>
        /// <param name="identity"> Identity Info on the tracked resource. Current supported identity types: None, SystemAssigned, UserAssigned. </param>
        /// <returns> A new <see cref="T:Azure.ResourceManager.Purview.PurviewAccountData" /> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static PurviewAccountData PurviewAccountData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, PurviewAccountSku sku, string cloudConnectorsAwsExternalId, DateTimeOffset? createdOn, string createdBy, string createdByObjectId, PurviewAccountEndpoint endpoints, string friendlyName, string managedResourceGroupName, PurviewManagedResource managedResources, IEnumerable<PurviewPrivateEndpointConnectionData> privateEndpointConnections, PurviewProvisioningState? provisioningState, PurviewPublicNetworkAccess? publicNetworkAccess, ManagedServiceIdentity identity)
        {
            return PurviewAccountData(id: id, name: name, resourceType: resourceType, systemData: systemData, tags: tags, location: location, sku: sku, accountStatus: default, cloudConnectorsAwsExternalId: cloudConnectorsAwsExternalId, createdOn: createdOn, createdBy: createdBy, createdByObjectId: createdByObjectId, endpoints: endpoints, friendlyName: friendlyName, ingestionStorage: default, managedEventHubState: default, managedResourceGroupName: managedResourceGroupName, managedResources: managedResources, managedResourcesPublicNetworkAccess: default, privateEndpointConnections: privateEndpointConnections, provisioningState: provisioningState, publicNetworkAccess: publicNetworkAccess, identity: identity);
        }
    }
}
