// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The type of alias paths.
    /// </summary>
    public partial class AliasPathType
    {
        /// <summary>
        /// Initializes a new instance of the AliasPathType class.
        /// </summary>
        public AliasPathType() { }

        /// <summary>
        /// Initializes a new instance of the AliasPathType class.
        /// </summary>
        public AliasPathType(string path = default(string), IList<string> apiVersions = default(IList<string>))
        {
            Path = path;
            ApiVersions = apiVersions;
        }

        /// <summary>
        /// The path of an alias.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// The api versions.
        /// </summary>
        [JsonProperty(PropertyName = "apiVersions")]
        public IList<string> ApiVersions { get; set; }

    }
}
