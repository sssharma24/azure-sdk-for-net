// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Information on the client (user or application) that made some action. </summary>
    public partial class SecurityInsightsClientInfo
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

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsClientInfo"/>. </summary>
        internal SecurityInsightsClientInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsClientInfo"/>. </summary>
        /// <param name="email"> The email of the client. </param>
        /// <param name="name"> The name of the client. </param>
        /// <param name="objectId"> The object id of the client. </param>
        /// <param name="userPrincipalName"> The user principal name of the client. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityInsightsClientInfo(string email, string name, Guid? objectId, string userPrincipalName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Email = email;
            Name = name;
            ObjectId = objectId;
            UserPrincipalName = userPrincipalName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The email of the client. </summary>
        public string Email { get; }
        /// <summary> The name of the client. </summary>
        public string Name { get; }
        /// <summary> The object id of the client. </summary>
        public Guid? ObjectId { get; }
        /// <summary> The user principal name of the client. </summary>
        public string UserPrincipalName { get; }
    }
}
