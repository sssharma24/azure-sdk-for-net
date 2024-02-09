// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> IpAddressPool represents a pool of IP addresses that can be allocated to a service. </summary>
    public partial class IPAddressPool
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

        /// <summary> Initializes a new instance of <see cref="IPAddressPool"/>. </summary>
        /// <param name="addresses"> The list of IP address ranges. Each range can be a either a subnet in CIDR format or an explicit start-end range of IP addresses. </param>
        /// <param name="name"> The name used to identify this IP address pool for association with a BGP advertisement. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="addresses"/> or <paramref name="name"/> is null. </exception>
        public IPAddressPool(IEnumerable<string> addresses, string name)
        {
            Argument.AssertNotNull(addresses, nameof(addresses));
            Argument.AssertNotNull(name, nameof(name));

            Addresses = addresses.ToList();
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="IPAddressPool"/>. </summary>
        /// <param name="addresses"> The list of IP address ranges. Each range can be a either a subnet in CIDR format or an explicit start-end range of IP addresses. </param>
        /// <param name="autoAssign"> The indicator to determine if automatic allocation from the pool should occur. </param>
        /// <param name="name"> The name used to identify this IP address pool for association with a BGP advertisement. </param>
        /// <param name="onlyUseHostIPs"> The indicator to prevent the use of IP addresses ending with .0 and .255 for this pool. Enabling this option will only use IP addresses between .1 and .254 inclusive. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IPAddressPool(IList<string> addresses, BfdEnabled? autoAssign, string name, BfdEnabled? onlyUseHostIPs, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Addresses = addresses;
            AutoAssign = autoAssign;
            Name = name;
            OnlyUseHostIPs = onlyUseHostIPs;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IPAddressPool"/> for deserialization. </summary>
        internal IPAddressPool()
        {
        }

        /// <summary> The list of IP address ranges. Each range can be a either a subnet in CIDR format or an explicit start-end range of IP addresses. </summary>
        public IList<string> Addresses { get; }
        /// <summary> The indicator to determine if automatic allocation from the pool should occur. </summary>
        public BfdEnabled? AutoAssign { get; set; }
        /// <summary> The name used to identify this IP address pool for association with a BGP advertisement. </summary>
        public string Name { get; set; }
        /// <summary> The indicator to prevent the use of IP addresses ending with .0 and .255 for this pool. Enabling this option will only use IP addresses between .1 and .254 inclusive. </summary>
        public BfdEnabled? OnlyUseHostIPs { get; set; }
    }
}
