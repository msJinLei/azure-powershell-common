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
    /// Properties of the table, including Id, resource name, resource type.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Table : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Table class.
        /// </summary>
        public Table()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Table class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="tableName">Table name under the specified
        /// account</param>
        public Table(string id = default(string), string name = default(string), string type = default(string), string tableName = default(string))
            : base(id, name, type)
        {
            TableName = tableName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets table name under the specified account
        /// </summary>
        [JsonProperty(PropertyName = "properties.tableName")]
        public string TableName { get; private set; }

    }
}
