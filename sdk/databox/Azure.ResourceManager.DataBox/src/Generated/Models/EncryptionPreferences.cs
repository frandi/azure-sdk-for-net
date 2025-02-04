// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Preferences related to the Encryption. </summary>
    internal partial class EncryptionPreferences
    {
        /// <summary> Initializes a new instance of EncryptionPreferences. </summary>
        public EncryptionPreferences()
        {
        }

        /// <summary> Initializes a new instance of EncryptionPreferences. </summary>
        /// <param name="doubleEncryption"> Defines secondary layer of software-based encryption enablement. </param>
        internal EncryptionPreferences(DoubleEncryption? doubleEncryption)
        {
            DoubleEncryption = doubleEncryption;
        }

        /// <summary> Defines secondary layer of software-based encryption enablement. </summary>
        public DoubleEncryption? DoubleEncryption { get; set; }
    }
}
