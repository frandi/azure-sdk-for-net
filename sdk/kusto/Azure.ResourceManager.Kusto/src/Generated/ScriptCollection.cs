// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Kusto
{
    /// <summary>
    /// A class representing a collection of <see cref="ScriptResource" /> and their operations.
    /// Each <see cref="ScriptResource" /> in the collection will belong to the same instance of <see cref="DatabaseResource" />.
    /// To get a <see cref="ScriptCollection" /> instance call the GetScripts method from an instance of <see cref="DatabaseResource" />.
    /// </summary>
    public partial class ScriptCollection : ArmCollection, IEnumerable<ScriptResource>, IAsyncEnumerable<ScriptResource>
    {
        private readonly ClientDiagnostics _scriptClientDiagnostics;
        private readonly ScriptsRestOperations _scriptRestClient;

        /// <summary> Initializes a new instance of the <see cref="ScriptCollection"/> class for mocking. </summary>
        protected ScriptCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ScriptCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ScriptCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _scriptClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Kusto", ScriptResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ScriptResource.ResourceType, out string scriptApiVersion);
            _scriptRestClient = new ScriptsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, scriptApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DatabaseResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DatabaseResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a Kusto database script.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/scripts/{scriptName}
        /// Operation Id: Scripts_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="scriptName"> The name of the Kusto database script. </param>
        /// <param name="data"> The Kusto Script parameters contains the KQL to run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ScriptResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string scriptName, ScriptData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptName, nameof(scriptName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scriptClientDiagnostics.CreateScope("ScriptCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _scriptRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scriptName, data, cancellationToken).ConfigureAwait(false);
                var operation = new KustoArmOperation<ScriptResource>(new ScriptOperationSource(Client), _scriptClientDiagnostics, Pipeline, _scriptRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scriptName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a Kusto database script.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/scripts/{scriptName}
        /// Operation Id: Scripts_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="scriptName"> The name of the Kusto database script. </param>
        /// <param name="data"> The Kusto Script parameters contains the KQL to run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ScriptResource> CreateOrUpdate(WaitUntil waitUntil, string scriptName, ScriptData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptName, nameof(scriptName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scriptClientDiagnostics.CreateScope("ScriptCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _scriptRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scriptName, data, cancellationToken);
                var operation = new KustoArmOperation<ScriptResource>(new ScriptOperationSource(Client), _scriptClientDiagnostics, Pipeline, _scriptRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scriptName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Kusto cluster database script.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/scripts/{scriptName}
        /// Operation Id: Scripts_Get
        /// </summary>
        /// <param name="scriptName"> The name of the Kusto database script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> is null. </exception>
        public virtual async Task<Response<ScriptResource>> GetAsync(string scriptName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptName, nameof(scriptName));

            using var scope = _scriptClientDiagnostics.CreateScope("ScriptCollection.Get");
            scope.Start();
            try
            {
                var response = await _scriptRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scriptName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScriptResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Kusto cluster database script.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/scripts/{scriptName}
        /// Operation Id: Scripts_Get
        /// </summary>
        /// <param name="scriptName"> The name of the Kusto database script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> is null. </exception>
        public virtual Response<ScriptResource> Get(string scriptName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptName, nameof(scriptName));

            using var scope = _scriptClientDiagnostics.CreateScope("ScriptCollection.Get");
            scope.Start();
            try
            {
                var response = _scriptRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scriptName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScriptResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the list of database scripts for given database.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/scripts
        /// Operation Id: Scripts_ListByDatabase
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ScriptResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ScriptResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ScriptResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _scriptClientDiagnostics.CreateScope("ScriptCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _scriptRestClient.ListByDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ScriptResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Returns the list of database scripts for given database.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/scripts
        /// Operation Id: Scripts_ListByDatabase
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ScriptResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ScriptResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ScriptResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _scriptClientDiagnostics.CreateScope("ScriptCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _scriptRestClient.ListByDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ScriptResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/scripts/{scriptName}
        /// Operation Id: Scripts_Get
        /// </summary>
        /// <param name="scriptName"> The name of the Kusto database script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string scriptName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptName, nameof(scriptName));

            using var scope = _scriptClientDiagnostics.CreateScope("ScriptCollection.Exists");
            scope.Start();
            try
            {
                var response = await _scriptRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scriptName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/scripts/{scriptName}
        /// Operation Id: Scripts_Get
        /// </summary>
        /// <param name="scriptName"> The name of the Kusto database script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> is null. </exception>
        public virtual Response<bool> Exists(string scriptName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptName, nameof(scriptName));

            using var scope = _scriptClientDiagnostics.CreateScope("ScriptCollection.Exists");
            scope.Start();
            try
            {
                var response = _scriptRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scriptName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ScriptResource> IEnumerable<ScriptResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ScriptResource> IAsyncEnumerable<ScriptResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
