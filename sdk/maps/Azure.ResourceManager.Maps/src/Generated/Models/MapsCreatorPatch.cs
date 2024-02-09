// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Maps.Models
{
    /// <summary> Parameters used to update an existing Creator resource. </summary>
    public partial class MapsCreatorPatch
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

        /// <summary> Initializes a new instance of <see cref="MapsCreatorPatch"/>. </summary>
        public MapsCreatorPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="MapsCreatorPatch"/>. </summary>
        /// <param name="tags"> Gets or sets a list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. </param>
        /// <param name="provisioningState"> The state of the resource provisioning, terminal states: Succeeded, Failed, Canceled. </param>
        /// <param name="storageUnits"> The storage units to be allocated. Integer values from 1 to 100, inclusive. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MapsCreatorPatch(IDictionary<string, string> tags, string provisioningState, int? storageUnits, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            ProvisioningState = provisioningState;
            StorageUnits = storageUnits;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets a list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The state of the resource provisioning, terminal states: Succeeded, Failed, Canceled. </summary>
        public string ProvisioningState { get; }
        /// <summary> The storage units to be allocated. Integer values from 1 to 100, inclusive. </summary>
        public int? StorageUnits { get; set; }
    }
}
