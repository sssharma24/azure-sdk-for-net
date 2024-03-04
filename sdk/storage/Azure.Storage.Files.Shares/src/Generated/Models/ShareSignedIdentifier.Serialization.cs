// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Xml;
using System.Xml.Linq;
using Azure.Core;
using Azure.Storage.Files.Shares;

namespace Azure.Storage.Files.Shares.Models
{
    public partial class ShareSignedIdentifier : IXmlSerializable
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "SignedIdentifier");
            writer.WriteStartElement("Id");
            writer.WriteValue(Id);
            writer.WriteEndElement();
            if (Optional.IsDefined(AccessPolicy))
            {
                writer.WriteObjectValue(AccessPolicy, "AccessPolicy");
            }
            writer.WriteEndElement();
        }

        internal static ShareSignedIdentifier DeserializeShareSignedIdentifier(XElement element)
        {
            string id = default;
            ShareAccessPolicy accessPolicy = default;
            if (element.Element("Id") is XElement idElement)
            {
                id = (string)idElement;
            }
            if (element.Element("AccessPolicy") is XElement accessPolicyElement)
            {
                accessPolicy = ShareAccessPolicy.DeserializeShareAccessPolicy(accessPolicyElement);
            }
            return new ShareSignedIdentifier(id, accessPolicy);
        }
    }
}
