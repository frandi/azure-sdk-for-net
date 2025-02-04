// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Kusto
{
    internal class ScriptOperationSource : IOperationSource<ScriptResource>
    {
        private readonly ArmClient _client;

        internal ScriptOperationSource(ArmClient client)
        {
            _client = client;
        }

        ScriptResource IOperationSource<ScriptResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ScriptData.DeserializeScriptData(document.RootElement);
            return new ScriptResource(_client, data);
        }

        async ValueTask<ScriptResource> IOperationSource<ScriptResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ScriptData.DeserializeScriptData(document.RootElement);
            return new ScriptResource(_client, data);
        }
    }
}
