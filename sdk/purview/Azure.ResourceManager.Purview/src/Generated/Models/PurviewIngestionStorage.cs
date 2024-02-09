// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Purview.Models
{
    /// <summary> Ingestion Storage Account Info. </summary>
    public partial class PurviewIngestionStorage
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

        /// <summary> Initializes a new instance of <see cref="PurviewIngestionStorage"/>. </summary>
        public PurviewIngestionStorage()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PurviewIngestionStorage"/>. </summary>
        /// <param name="id"> Gets or sets the Id. </param>
        /// <param name="primaryEndpoint"> Gets or sets the primary endpoint. </param>
        /// <param name="publicNetworkAccess"> Gets or sets the public network access setting. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PurviewIngestionStorage(string id, string primaryEndpoint, PurviewPublicNetworkAccess? publicNetworkAccess, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            PrimaryEndpoint = primaryEndpoint;
            PublicNetworkAccess = publicNetworkAccess;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the Id. </summary>
        public string Id { get; }
        /// <summary> Gets or sets the primary endpoint. </summary>
        public string PrimaryEndpoint { get; }
        /// <summary> Gets or sets the public network access setting. </summary>
        public PurviewPublicNetworkAccess? PublicNetworkAccess { get; set; }
    }
}
