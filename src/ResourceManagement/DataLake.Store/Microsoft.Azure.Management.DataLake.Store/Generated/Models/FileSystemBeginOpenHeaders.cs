// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Defines headers for BeginOpen operation.
    /// </summary>
    public partial class FileSystemBeginOpenHeaders
    {
        /// <summary>
        /// Initializes a new instance of the FileSystemBeginOpenHeaders class.
        /// </summary>
        public FileSystemBeginOpenHeaders() { }

        /// <summary>
        /// Initializes a new instance of the FileSystemBeginOpenHeaders class.
        /// </summary>
        public FileSystemBeginOpenHeaders(string location = default(string))
        {
            Location = location;
        }

        /// <summary>
        /// The location of the file to be opened
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

    }
}
