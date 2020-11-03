// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.Storage.Version2019_06_01.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Encryption Scope resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class EncryptionScope : Resource
    {
        /// <summary>
        /// Initializes a new instance of the EncryptionScope class.
        /// </summary>
        public EncryptionScope()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EncryptionScope class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="source">The provider for the encryption scope.
        /// Possible values (case-insensitive):  Microsoft.Storage,
        /// Microsoft.KeyVault. Possible values include: 'Microsoft.Storage',
        /// 'Microsoft.KeyVault'</param>
        /// <param name="state">The state of the encryption scope. Possible
        /// values (case-insensitive):  Enabled, Disabled. Possible values
        /// include: 'Enabled', 'Disabled'</param>
        /// <param name="creationTime">Gets the creation date and time of the
        /// encryption scope in UTC.</param>
        /// <param name="lastModifiedTime">Gets the last modification date and
        /// time of the encryption scope in UTC.</param>
        /// <param name="keyVaultProperties">The key vault properties for the
        /// encryption scope. This is a required field if encryption scope
        /// 'source' attribute is set to 'Microsoft.KeyVault'.</param>
        public EncryptionScope(string id = default(string), string name = default(string), string type = default(string), string source = default(string), string state = default(string), System.DateTime? creationTime = default(System.DateTime?), System.DateTime? lastModifiedTime = default(System.DateTime?), EncryptionScopeKeyVaultProperties keyVaultProperties = default(EncryptionScopeKeyVaultProperties))
            : base(id, name, type)
        {
            Source = source;
            State = state;
            CreationTime = creationTime;
            LastModifiedTime = lastModifiedTime;
            KeyVaultProperties = keyVaultProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the provider for the encryption scope. Possible values
        /// (case-insensitive):  Microsoft.Storage, Microsoft.KeyVault.
        /// Possible values include: 'Microsoft.Storage', 'Microsoft.KeyVault'
        /// </summary>
        [JsonProperty(PropertyName = "properties.source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets the state of the encryption scope. Possible values
        /// (case-insensitive):  Enabled, Disabled. Possible values include:
        /// 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; set; }

        /// <summary>
        /// Gets the creation date and time of the encryption scope in UTC.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTime? CreationTime { get; private set; }

        /// <summary>
        /// Gets the last modification date and time of the encryption scope in
        /// UTC.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; private set; }

        /// <summary>
        /// Gets or sets the key vault properties for the encryption scope.
        /// This is a required field if encryption scope 'source' attribute is
        /// set to 'Microsoft.KeyVault'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.keyVaultProperties")]
        public EncryptionScopeKeyVaultProperties KeyVaultProperties { get; set; }

    }
}
