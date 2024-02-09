// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Metadata for the resource. This property is READ-ONLY. </summary>
    public partial class DataCollectionEndpointMetadata : DataCollectionRuleRelatedResourceMetadata
    {
        /// <summary> Initializes a new instance of <see cref="DataCollectionEndpointMetadata"/>. </summary>
        internal DataCollectionEndpointMetadata()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataCollectionEndpointMetadata"/>. </summary>
        /// <param name="provisionedBy"> Azure offering managing this resource on-behalf-of customer. </param>
        /// <param name="provisionedByResourceId"> Resource Id of azure offering managing this resource on-behalf-of customer. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataCollectionEndpointMetadata(string provisionedBy, string provisionedByResourceId, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(provisionedBy, provisionedByResourceId, serializedAdditionalRawData)
        {
        }
    }
}
