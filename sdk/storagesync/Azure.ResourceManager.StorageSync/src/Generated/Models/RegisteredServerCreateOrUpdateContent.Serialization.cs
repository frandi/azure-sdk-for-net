// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class RegisteredServerCreateOrUpdateContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ServerCertificate))
            {
                writer.WritePropertyName("serverCertificate");
                writer.WriteStringValue(ServerCertificate);
            }
            if (Optional.IsDefined(AgentVersion))
            {
                writer.WritePropertyName("agentVersion");
                writer.WriteStringValue(AgentVersion);
            }
            if (Optional.IsDefined(ServerOSVersion))
            {
                writer.WritePropertyName("serverOSVersion");
                writer.WriteStringValue(ServerOSVersion);
            }
            if (Optional.IsDefined(LastHeartBeat))
            {
                writer.WritePropertyName("lastHeartBeat");
                writer.WriteStringValue(LastHeartBeat);
            }
            if (Optional.IsDefined(ServerRole))
            {
                writer.WritePropertyName("serverRole");
                writer.WriteStringValue(ServerRole);
            }
            if (Optional.IsDefined(ClusterId))
            {
                writer.WritePropertyName("clusterId");
                writer.WriteStringValue(ClusterId);
            }
            if (Optional.IsDefined(ClusterName))
            {
                writer.WritePropertyName("clusterName");
                writer.WriteStringValue(ClusterName);
            }
            if (Optional.IsDefined(ServerId))
            {
                writer.WritePropertyName("serverId");
                writer.WriteStringValue(ServerId);
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName");
                writer.WriteStringValue(FriendlyName);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static RegisteredServerCreateOrUpdateContent DeserializeRegisteredServerCreateOrUpdateContent(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> serverCertificate = default;
            Optional<string> agentVersion = default;
            Optional<string> serverOSVersion = default;
            Optional<string> lastHeartBeat = default;
            Optional<string> serverRole = default;
            Optional<string> clusterId = default;
            Optional<string> clusterName = default;
            Optional<string> serverId = default;
            Optional<string> friendlyName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("serverCertificate"))
                        {
                            serverCertificate = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("agentVersion"))
                        {
                            agentVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverOSVersion"))
                        {
                            serverOSVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastHeartBeat"))
                        {
                            lastHeartBeat = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverRole"))
                        {
                            serverRole = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterId"))
                        {
                            clusterId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterName"))
                        {
                            clusterName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverId"))
                        {
                            serverId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RegisteredServerCreateOrUpdateContent(id, name, type, systemData.Value, serverCertificate.Value, agentVersion.Value, serverOSVersion.Value, lastHeartBeat.Value, serverRole.Value, clusterId.Value, clusterName.Value, serverId.Value, friendlyName.Value);
        }
    }
}
