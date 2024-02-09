// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing the AseV3NetworkingConfiguration data model.
    /// Full view of networking configuration for an ASE.
    /// </summary>
    public partial class AseV3NetworkingConfigurationData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="AseV3NetworkingConfigurationData"/>. </summary>
        public AseV3NetworkingConfigurationData()
        {
            WindowsOutboundIPAddresses = new ChangeTrackingList<IPAddress>();
            LinuxOutboundIPAddresses = new ChangeTrackingList<IPAddress>();
            ExternalInboundIPAddresses = new ChangeTrackingList<IPAddress>();
            InternalInboundIPAddresses = new ChangeTrackingList<IPAddress>();
        }

        /// <summary> Initializes a new instance of <see cref="AseV3NetworkingConfigurationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="windowsOutboundIPAddresses"></param>
        /// <param name="linuxOutboundIPAddresses"></param>
        /// <param name="externalInboundIPAddresses"></param>
        /// <param name="internalInboundIPAddresses"></param>
        /// <param name="allowNewPrivateEndpointConnections"> Property to enable and disable new private endpoint connection creation on ASE. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AseV3NetworkingConfigurationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IReadOnlyList<IPAddress> windowsOutboundIPAddresses, IReadOnlyList<IPAddress> linuxOutboundIPAddresses, IReadOnlyList<IPAddress> externalInboundIPAddresses, IReadOnlyList<IPAddress> internalInboundIPAddresses, bool? allowNewPrivateEndpointConnections, string kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            WindowsOutboundIPAddresses = windowsOutboundIPAddresses;
            LinuxOutboundIPAddresses = linuxOutboundIPAddresses;
            ExternalInboundIPAddresses = externalInboundIPAddresses;
            InternalInboundIPAddresses = internalInboundIPAddresses;
            AllowNewPrivateEndpointConnections = allowNewPrivateEndpointConnections;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the windows outbound ip addresses. </summary>
        public IReadOnlyList<IPAddress> WindowsOutboundIPAddresses { get; }
        /// <summary> Gets the linux outbound ip addresses. </summary>
        public IReadOnlyList<IPAddress> LinuxOutboundIPAddresses { get; }
        /// <summary> Gets the external inbound ip addresses. </summary>
        public IReadOnlyList<IPAddress> ExternalInboundIPAddresses { get; }
        /// <summary> Gets the internal inbound ip addresses. </summary>
        public IReadOnlyList<IPAddress> InternalInboundIPAddresses { get; }
        /// <summary> Property to enable and disable new private endpoint connection creation on ASE. </summary>
        public bool? AllowNewPrivateEndpointConnections { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
