// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// </summary>
    public partial class VirtualApplication
    {
        /// <summary>
        /// Initializes a new instance of the VirtualApplication class.
        /// </summary>
        public VirtualApplication() { }

        /// <summary>
        /// Initializes a new instance of the VirtualApplication class.
        /// </summary>
        public VirtualApplication(string virtualPath = default(string), string physicalPath = default(string), bool? preloadEnabled = default(bool?), IList<VirtualDirectory> virtualDirectories = default(IList<VirtualDirectory>))
        {
            VirtualPath = virtualPath;
            PhysicalPath = physicalPath;
            PreloadEnabled = preloadEnabled;
            VirtualDirectories = virtualDirectories;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "virtualPath")]
        public string VirtualPath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "physicalPath")]
        public string PhysicalPath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "preloadEnabled")]
        public bool? PreloadEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "virtualDirectories")]
        public IList<VirtualDirectory> VirtualDirectories { get; set; }

    }
}
