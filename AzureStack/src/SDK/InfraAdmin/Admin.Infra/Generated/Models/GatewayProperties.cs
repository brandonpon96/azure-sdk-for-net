// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.AzureStack.Infra.Admin.Models
{
    using Microsoft.AzureStack;
    using Microsoft.AzureStack.Infra;
    using Microsoft.AzureStack.Infra.Admin;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class GatewayProperties
    {
        /// <summary>
        /// Initializes a new instance of the GatewayProperties class.
        /// </summary>
        public GatewayProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GatewayProperties class.
        /// </summary>
        public GatewayProperties(string gatewayType = default(string), int? numberOfGateways = default(int?), int? redundantGatewayCount = default(int?), int? gatewayCapacityKiloBitsPerSecond = default(int?), string publicIpAddress = default(string), string greVipSubnet = default(string), IList<string> edgeGateways = default(IList<string>))
        {
            GatewayType = gatewayType;
            NumberOfGateways = numberOfGateways;
            RedundantGatewayCount = redundantGatewayCount;
            GatewayCapacityKiloBitsPerSecond = gatewayCapacityKiloBitsPerSecond;
            PublicIpAddress = publicIpAddress;
            GreVipSubnet = greVipSubnet;
            EdgeGateways = edgeGateways;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gatewayType")]
        public string GatewayType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "numberOfGateways")]
        public int? NumberOfGateways { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "redundantGatewayCount")]
        public int? RedundantGatewayCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gatewayCapacityKiloBitsPerSecond")]
        public int? GatewayCapacityKiloBitsPerSecond { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "publicIpAddress")]
        public string PublicIpAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "greVipSubnet")]
        public string GreVipSubnet { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "edgeGateways")]
        public IList<string> EdgeGateways { get; set; }

    }
}
