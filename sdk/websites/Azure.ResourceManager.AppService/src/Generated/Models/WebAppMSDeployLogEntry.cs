// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> MSDeploy log entry. </summary>
    public partial class WebAppMSDeployLogEntry
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

        /// <summary> Initializes a new instance of <see cref="WebAppMSDeployLogEntry"/>. </summary>
        internal WebAppMSDeployLogEntry()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WebAppMSDeployLogEntry"/>. </summary>
        /// <param name="time"> Timestamp of log entry. </param>
        /// <param name="entryType"> Log entry type. </param>
        /// <param name="message"> Log entry message. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WebAppMSDeployLogEntry(DateTimeOffset? time, WebAppMSDeployLogEntryType? entryType, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Time = time;
            EntryType = entryType;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Timestamp of log entry. </summary>
        public DateTimeOffset? Time { get; }
        /// <summary> Log entry type. </summary>
        public WebAppMSDeployLogEntryType? EntryType { get; }
        /// <summary> Log entry message. </summary>
        public string Message { get; }
    }
}
