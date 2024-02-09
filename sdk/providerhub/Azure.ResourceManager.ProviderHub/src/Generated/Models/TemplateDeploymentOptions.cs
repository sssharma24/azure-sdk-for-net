// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The TemplateDeploymentOptions. </summary>
    public partial class TemplateDeploymentOptions
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

        /// <summary> Initializes a new instance of <see cref="TemplateDeploymentOptions"/>. </summary>
        public TemplateDeploymentOptions()
        {
            PreflightOptions = new ChangeTrackingList<PreflightOption>();
        }

        /// <summary> Initializes a new instance of <see cref="TemplateDeploymentOptions"/>. </summary>
        /// <param name="isPreflightSupported"></param>
        /// <param name="preflightOptions"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TemplateDeploymentOptions(bool? isPreflightSupported, IList<PreflightOption> preflightOptions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsPreflightSupported = isPreflightSupported;
            PreflightOptions = preflightOptions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the is preflight supported. </summary>
        public bool? IsPreflightSupported { get; set; }
        /// <summary> Gets the preflight options. </summary>
        public IList<PreflightOption> PreflightOptions { get; }
    }
}
