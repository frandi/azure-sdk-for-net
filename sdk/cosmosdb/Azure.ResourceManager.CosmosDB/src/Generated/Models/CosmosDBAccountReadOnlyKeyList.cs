// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The read-only access keys for the given database account. </summary>
    public partial class CosmosDBAccountReadOnlyKeyList
    {
        /// <summary> Initializes a new instance of CosmosDBAccountReadOnlyKeyList. </summary>
        internal CosmosDBAccountReadOnlyKeyList()
        {
        }

        /// <summary> Initializes a new instance of CosmosDBAccountReadOnlyKeyList. </summary>
        /// <param name="primaryReadonlyMasterKey"> Base 64 encoded value of the primary read-only key. </param>
        /// <param name="secondaryReadonlyMasterKey"> Base 64 encoded value of the secondary read-only key. </param>
        internal CosmosDBAccountReadOnlyKeyList(string primaryReadonlyMasterKey, string secondaryReadonlyMasterKey)
        {
            PrimaryReadonlyMasterKey = primaryReadonlyMasterKey;
            SecondaryReadonlyMasterKey = secondaryReadonlyMasterKey;
        }

        /// <summary> Base 64 encoded value of the primary read-only key. </summary>
        public string PrimaryReadonlyMasterKey { get; }
        /// <summary> Base 64 encoded value of the secondary read-only key. </summary>
        public string SecondaryReadonlyMasterKey { get; }
    }
}
