// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Encapsulates Managed Identity related information. </summary>
    public partial class BackupIdentityInfo
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

        /// <summary> Initializes a new instance of <see cref="BackupIdentityInfo"/>. </summary>
        public BackupIdentityInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BackupIdentityInfo"/>. </summary>
        /// <param name="isSystemAssignedIdentity"> To differentiate if the managed identity is system assigned or user assigned. </param>
        /// <param name="managedIdentityResourceId">
        /// Managed Identity Resource Id
        /// Optional: Might not be required in the case of system assigned managed identity
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BackupIdentityInfo(bool? isSystemAssignedIdentity, ResourceIdentifier managedIdentityResourceId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsSystemAssignedIdentity = isSystemAssignedIdentity;
            ManagedIdentityResourceId = managedIdentityResourceId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> To differentiate if the managed identity is system assigned or user assigned. </summary>
        public bool? IsSystemAssignedIdentity { get; set; }
        /// <summary>
        /// Managed Identity Resource Id
        /// Optional: Might not be required in the case of system assigned managed identity
        /// </summary>
        public ResourceIdentifier ManagedIdentityResourceId { get; set; }
    }
}
