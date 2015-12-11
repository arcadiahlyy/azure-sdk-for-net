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
    /// Describes if a resource name is available
    /// </summary>
    public partial class ResourceNameAvailability
    {
        /// <summary>
        /// Initializes a new instance of the ResourceNameAvailability class.
        /// </summary>
        public ResourceNameAvailability() { }

        /// <summary>
        /// Initializes a new instance of the ResourceNameAvailability class.
        /// </summary>
        public ResourceNameAvailability(bool? nameAvailable = default(bool?), string reason = default(string), string message = default(string))
        {
            NameAvailable = nameAvailable;
            Reason = reason;
            Message = message;
        }

        /// <summary>
        /// True indicates name is valid and available.  False indicates the
        /// name is invalid, unavailable, or both.
        /// </summary>
        [JsonProperty(PropertyName = "nameAvailable")]
        public bool? NameAvailable { get; set; }

        /// <summary>
        /// Required if nameAvailable is false. 'Invalid' indicates the name
        /// provided does not match Azure WebApp serviceâ€™s naming
        /// requirements. 'AlreadyExists' indicates that the name is already
        /// in use and is therefore unavailable.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}
