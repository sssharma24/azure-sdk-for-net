// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> Resource information. </summary>
    public partial class GenericResourceData : TrackedResource<TenantResourceIdentifier>
    {
        /// <summary> Initializes a new instance of GenericResource. </summary>
        public GenericResourceData()
        {
        }

        /// <summary> Initializes a new instance of GenericResource. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="plan"> The plan of the resource. </param>
        /// <param name="properties"> The resource properties. </param>
        /// <param name="kind"> The kind of the resource. </param>
        /// <param name="managedBy"> ID of the resource that manages this resource. </param>
        /// <param name="sku"> The SKU of the resource. </param>
        /// <param name="identity"> The identity of the resource. </param>
        internal GenericResourceData(string id, string name, string type, string location, IDictionary<string, string> tags, Plan plan, object properties, string kind, string managedBy, Sku sku, ResourceIdentity identity) : base(id, name, type, location, tags)
        {
            Plan = plan;
            Properties = properties;
            Kind = kind;
            ManagedBy = managedBy;
            Sku = sku;
            Identity = identity;
        }

        /// <summary> The plan of the resource. </summary>
        public Plan Plan { get; set; }
        /// <summary> The resource properties. </summary>
        public object Properties { get; set; }
        /// <summary> The kind of the resource. </summary>
        public string Kind { get; set; }
        /// <summary> ID of the resource that manages this resource. </summary>
        public string ManagedBy { get; set; }
        /// <summary> The SKU of the resource. </summary>
        public Sku Sku { get; set; }
        /// <summary> The identity of the resource. </summary>
        public ResourceIdentity Identity { get; set; }
    }
}
