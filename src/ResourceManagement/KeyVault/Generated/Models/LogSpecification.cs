// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.KeyVault.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Log specification of operation.
    /// </summary>
    public partial class LogSpecification
    {
        /// <summary>
        /// Initializes a new instance of the LogSpecification class.
        /// </summary>
        public LogSpecification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LogSpecification class.
        /// </summary>
        /// <param name="name">Name of log specification.</param>
        /// <param name="displayName">Display name of log
        /// specification.</param>
        /// <param name="blobDuration">Blob duration of specification.</param>
        public LogSpecification(string name = default(string), string displayName = default(string), string blobDuration = default(string))
        {
            Name = name;
            DisplayName = displayName;
            BlobDuration = blobDuration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of log specification.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets display name of log specification.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets blob duration of specification.
        /// </summary>
        [JsonProperty(PropertyName = "blobDuration")]
        public string BlobDuration { get; set; }

    }
}
