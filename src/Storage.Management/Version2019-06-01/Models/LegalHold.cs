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
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The LegalHold property of a blob container.
    /// </summary>
    public partial class LegalHold
    {
        /// <summary>
        /// Initializes a new instance of the LegalHold class.
        /// </summary>
        public LegalHold()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LegalHold class.
        /// </summary>
        /// <param name="tags">Each tag should be 3 to 23 alphanumeric
        /// characters and is normalized to lower case at SRP.</param>
        /// <param name="hasLegalHold">The hasLegalHold public property is set
        /// to true by SRP if there are at least one existing tag. The
        /// hasLegalHold public property is set to false by SRP if all existing
        /// legal hold tags are cleared out. There can be a maximum of 1000
        /// blob containers with hasLegalHold=true for a given account.</param>
        public LegalHold(IList<string> tags, bool? hasLegalHold = default(bool?))
        {
            HasLegalHold = hasLegalHold;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the hasLegalHold public property is set to true by SRP if
        /// there are at least one existing tag. The hasLegalHold public
        /// property is set to false by SRP if all existing legal hold tags are
        /// cleared out. There can be a maximum of 1000 blob containers with
        /// hasLegalHold=true for a given account.
        /// </summary>
        [JsonProperty(PropertyName = "hasLegalHold")]
        public bool? HasLegalHold { get; private set; }

        /// <summary>
        /// Gets or sets each tag should be 3 to 23 alphanumeric characters and
        /// is normalized to lower case at SRP.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Tags == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Tags");
            }
        }
    }
}
