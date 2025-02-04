// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    internal partial class ListReplications
    {
        internal static ListReplications DeserializeListReplications(JsonElement element)
        {
            Optional<IReadOnlyList<Replication>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Replication> array = new List<Replication>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Replication.DeserializeReplication(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ListReplications(Optional.ToList(value));
        }
    }
}
