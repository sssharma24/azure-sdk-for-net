// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing the CloudServiceRoleInstance data model.
    /// Describes the cloud service role instance.
    /// </summary>
    public partial class CloudServiceRoleInstanceData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CloudServiceRoleInstanceData"/>. </summary>
        internal CloudServiceRoleInstanceData()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="CloudServiceRoleInstanceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource Location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="sku"> The role instance SKU. </param>
        /// <param name="networkProfile"> Describes the network profile for the role instance. </param>
        /// <param name="instanceView"> The instance view of the role instance. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CloudServiceRoleInstanceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, IReadOnlyDictionary<string, string> tags, InstanceSku sku, RoleInstanceNetworkProfile networkProfile, RoleInstanceView instanceView, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Location = location;
            Tags = tags;
            Sku = sku;
            NetworkProfile = networkProfile;
            InstanceView = instanceView;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource Location. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Resource tags. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
        /// <summary> The role instance SKU. </summary>
        public InstanceSku Sku { get; }
        /// <summary> Describes the network profile for the role instance. </summary>
        internal RoleInstanceNetworkProfile NetworkProfile { get; }
        /// <summary> Specifies the list of resource Ids for the network interfaces associated with the role instance. </summary>
        public IReadOnlyList<WritableSubResource> NetworkInterfaces
        {
            get => NetworkProfile?.NetworkInterfaces;
        }

        /// <summary> The instance view of the role instance. </summary>
        public RoleInstanceView InstanceView { get; }
    }
}
