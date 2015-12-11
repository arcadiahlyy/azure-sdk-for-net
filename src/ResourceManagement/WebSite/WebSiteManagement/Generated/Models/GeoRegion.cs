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
    /// Geographical region
    /// </summary>
    public partial class GeoRegion : Resource
    {
        /// <summary>
        /// Initializes a new instance of the GeoRegion class.
        /// </summary>
        public GeoRegion() { }

        /// <summary>
        /// Initializes a new instance of the GeoRegion class.
        /// </summary>
        public GeoRegion(string geoRegionName = default(string), string description = default(string), string displayName = default(string))
        {
            GeoRegionName = geoRegionName;
            Description = description;
            DisplayName = displayName;
        }

        /// <summary>
        /// Region name
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string GeoRegionName { get; set; }

        /// <summary>
        /// Region description
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Display name for region
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
