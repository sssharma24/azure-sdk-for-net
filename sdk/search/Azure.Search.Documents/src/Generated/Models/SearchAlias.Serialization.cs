// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Search.Documents;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchAlias : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("indexes"u8);
            writer.WriteStartArray();
            foreach (var item in Indexes)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(_etag))
            {
                writer.WritePropertyName("@odata.etag"u8);
                writer.WriteStringValue(_etag);
            }
            writer.WriteEndObject();
        }

        internal static SearchAlias DeserializeSearchAlias(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            IList<string> indexes = default;
            string odataEtag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("indexes"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    indexes = array;
                    continue;
                }
                if (property.NameEquals("@odata.etag"u8))
                {
                    odataEtag = property.Value.GetString();
                    continue;
                }
            }
            return new SearchAlias(name, indexes, odataEtag);
        }
    }
}
