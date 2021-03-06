// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.TrafficManager.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.TrafficManager;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class representing a Traffic Manager profile.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Profile : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Profile class.
        /// </summary>
        public Profile()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Profile class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="location">Resource location</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="profileStatus">Gets or sets the status of the Traffic
        /// Manager profile.  Possible values are 'Enabled' and
        /// 'Disabled'.</param>
        /// <param name="trafficRoutingMethod">Gets or sets the traffic routing
        /// method of the Traffic Manager profile.  Possible values are
        /// 'Performance', 'Weighted', 'Priority' or 'Geographic'.</param>
        /// <param name="dnsConfig">Gets or sets the DNS settings of the
        /// Traffic Manager profile.</param>
        /// <param name="monitorConfig">Gets or sets the endpoint monitoring
        /// settings of the Traffic Manager profile.</param>
        /// <param name="endpoints">Gets or sets the list of endpoints in the
        /// Traffic Manager profile.</param>
        public Profile(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string profileStatus = default(string), string trafficRoutingMethod = default(string), DnsConfig dnsConfig = default(DnsConfig), MonitorConfig monitorConfig = default(MonitorConfig), IList<Endpoint> endpoints = default(IList<Endpoint>))
            : base(id, name, type, location, tags)
        {
            ProfileStatus = profileStatus;
            TrafficRoutingMethod = trafficRoutingMethod;
            DnsConfig = dnsConfig;
            MonitorConfig = monitorConfig;
            Endpoints = endpoints;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the status of the Traffic Manager profile.  Possible
        /// values are 'Enabled' and 'Disabled'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.profileStatus")]
        public string ProfileStatus { get; set; }

        /// <summary>
        /// Gets or sets the traffic routing method of the Traffic Manager
        /// profile.  Possible values are 'Performance', 'Weighted', 'Priority'
        /// or 'Geographic'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.trafficRoutingMethod")]
        public string TrafficRoutingMethod { get; set; }

        /// <summary>
        /// Gets or sets the DNS settings of the Traffic Manager profile.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dnsConfig")]
        public DnsConfig DnsConfig { get; set; }

        /// <summary>
        /// Gets or sets the endpoint monitoring settings of the Traffic
        /// Manager profile.
        /// </summary>
        [JsonProperty(PropertyName = "properties.monitorConfig")]
        public MonitorConfig MonitorConfig { get; set; }

        /// <summary>
        /// Gets or sets the list of endpoints in the Traffic Manager profile.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endpoints")]
        public IList<Endpoint> Endpoints { get; set; }

    }
}
