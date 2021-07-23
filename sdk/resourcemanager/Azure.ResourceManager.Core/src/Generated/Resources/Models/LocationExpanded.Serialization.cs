// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class LocationExpanded
    {
        internal static LocationExpanded DeserializeLocationExpanded(JsonElement element)
        {
            Location loc = DeserializeLocation(element);
            Optional<LocationMetadata> metadata = default;
            Optional<string> id = default;
            Optional<string> subscriptionId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metadata"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    metadata = LocationMetadata.DeserializeLocationMetadata(property.Value);
                    continue;
                }
            }
            return new LocationExpanded(id.Value, subscriptionId.Value, loc.Name, loc.DisplayName, loc.RegionalDisplayName, metadata.Value);
        }
    }
}
