// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Synapse notebook reference type. </summary>
    public partial class SynapseNotebookReference
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

        /// <summary> Initializes a new instance of <see cref="SynapseNotebookReference"/>. </summary>
        /// <param name="notebookReferenceType"> Synapse notebook reference type. </param>
        /// <param name="referenceName"> Reference notebook name. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="referenceName"/> is null. </exception>
        public SynapseNotebookReference(NotebookReferenceType notebookReferenceType, DataFactoryElement<string> referenceName)
        {
            Argument.AssertNotNull(referenceName, nameof(referenceName));

            NotebookReferenceType = notebookReferenceType;
            ReferenceName = referenceName;
        }

        /// <summary> Initializes a new instance of <see cref="SynapseNotebookReference"/>. </summary>
        /// <param name="notebookReferenceType"> Synapse notebook reference type. </param>
        /// <param name="referenceName"> Reference notebook name. Type: string (or Expression with resultType string). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseNotebookReference(NotebookReferenceType notebookReferenceType, DataFactoryElement<string> referenceName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NotebookReferenceType = notebookReferenceType;
            ReferenceName = referenceName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SynapseNotebookReference"/> for deserialization. </summary>
        internal SynapseNotebookReference()
        {
        }

        /// <summary> Synapse notebook reference type. </summary>
        public NotebookReferenceType NotebookReferenceType { get; set; }
        /// <summary> Reference notebook name. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ReferenceName { get; set; }
    }
}
