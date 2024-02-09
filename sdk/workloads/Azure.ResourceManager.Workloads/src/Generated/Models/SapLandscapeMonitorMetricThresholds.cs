// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Gets or sets the Threshold Values for Top Metrics Health. </summary>
    public partial class SapLandscapeMonitorMetricThresholds
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

        /// <summary> Initializes a new instance of <see cref="SapLandscapeMonitorMetricThresholds"/>. </summary>
        public SapLandscapeMonitorMetricThresholds()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SapLandscapeMonitorMetricThresholds"/>. </summary>
        /// <param name="name"> Gets or sets the name of the threshold. </param>
        /// <param name="green"> Gets or sets the threshold value for Green. </param>
        /// <param name="yellow"> Gets or sets the threshold value for Yellow. </param>
        /// <param name="red"> Gets or sets the threshold value for Red. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SapLandscapeMonitorMetricThresholds(string name, float? green, float? yellow, float? red, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Green = green;
            Yellow = yellow;
            Red = red;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the name of the threshold. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the threshold value for Green. </summary>
        public float? Green { get; set; }
        /// <summary> Gets or sets the threshold value for Yellow. </summary>
        public float? Yellow { get; set; }
        /// <summary> Gets or sets the threshold value for Red. </summary>
        public float? Red { get; set; }
    }
}
