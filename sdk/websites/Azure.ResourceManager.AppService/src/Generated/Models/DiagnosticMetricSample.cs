// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Class representing Diagnostic Metric. </summary>
    public partial class DiagnosticMetricSample
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

        /// <summary> Initializes a new instance of <see cref="DiagnosticMetricSample"/>. </summary>
        public DiagnosticMetricSample()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DiagnosticMetricSample"/>. </summary>
        /// <param name="timestamp"> Time at which metric is measured. </param>
        /// <param name="roleInstance">
        /// Role Instance. Null if this counter is not per instance
        /// This is returned and should be whichever instance name we desire to be returned
        /// i.e. CPU and Memory return RDWORKERNAME (LargeDed..._IN_0)
        /// where RDWORKERNAME is Machine name below and RoleInstance name in parenthesis
        /// </param>
        /// <param name="total"> Total value of the metric. If multiple measurements are made this will have sum of all. </param>
        /// <param name="maximum"> Maximum of the metric sampled during the time period. </param>
        /// <param name="minimum"> Minimum of the metric sampled during the time period. </param>
        /// <param name="isAggregated"> Whether the values are aggregates across all workers or not. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DiagnosticMetricSample(DateTimeOffset? timestamp, string roleInstance, double? total, double? maximum, double? minimum, bool? isAggregated, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Timestamp = timestamp;
            RoleInstance = roleInstance;
            Total = total;
            Maximum = maximum;
            Minimum = minimum;
            IsAggregated = isAggregated;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Time at which metric is measured. </summary>
        public DateTimeOffset? Timestamp { get; set; }
        /// <summary>
        /// Role Instance. Null if this counter is not per instance
        /// This is returned and should be whichever instance name we desire to be returned
        /// i.e. CPU and Memory return RDWORKERNAME (LargeDed..._IN_0)
        /// where RDWORKERNAME is Machine name below and RoleInstance name in parenthesis
        /// </summary>
        public string RoleInstance { get; set; }
        /// <summary> Total value of the metric. If multiple measurements are made this will have sum of all. </summary>
        public double? Total { get; set; }
        /// <summary> Maximum of the metric sampled during the time period. </summary>
        public double? Maximum { get; set; }
        /// <summary> Minimum of the metric sampled during the time period. </summary>
        public double? Minimum { get; set; }
        /// <summary> Whether the values are aggregates across all workers or not. </summary>
        public bool? IsAggregated { get; set; }
    }
}
