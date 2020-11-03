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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A tag of the LegalHold of a blob container.
    /// </summary>
    public partial class TagProperty
    {
        /// <summary>
        /// Initializes a new instance of the TagProperty class.
        /// </summary>
        public TagProperty()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TagProperty class.
        /// </summary>
        /// <param name="tag">The tag value.</param>
        /// <param name="timestamp">Returns the date and time the tag was
        /// added.</param>
        /// <param name="objectIdentifier">Returns the Object ID of the user
        /// who added the tag.</param>
        /// <param name="tenantId">Returns the Tenant ID that issued the token
        /// for the user who added the tag.</param>
        /// <param name="upn">Returns the User Principal Name of the user who
        /// added the tag.</param>
        public TagProperty(string tag = default(string), System.DateTime? timestamp = default(System.DateTime?), string objectIdentifier = default(string), string tenantId = default(string), string upn = default(string))
        {
            Tag = tag;
            Timestamp = timestamp;
            ObjectIdentifier = objectIdentifier;
            TenantId = tenantId;
            Upn = upn;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the tag value.
        /// </summary>
        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; private set; }

        /// <summary>
        /// Gets returns the date and time the tag was added.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public System.DateTime? Timestamp { get; private set; }

        /// <summary>
        /// Gets returns the Object ID of the user who added the tag.
        /// </summary>
        [JsonProperty(PropertyName = "objectIdentifier")]
        public string ObjectIdentifier { get; private set; }

        /// <summary>
        /// Gets returns the Tenant ID that issued the token for the user who
        /// added the tag.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; private set; }

        /// <summary>
        /// Gets returns the User Principal Name of the user who added the tag.
        /// </summary>
        [JsonProperty(PropertyName = "upn")]
        public string Upn { get; private set; }

    }
}
