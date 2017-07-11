// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.AzureStack.Infra.Admin.Models
{
    using Microsoft.AzureStack;
    using Microsoft.AzureStack.Infra;
    using Microsoft.AzureStack.Infra.Admin;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class InfraRoleInstanceProperties
    {
        /// <summary>
        /// Initializes a new instance of the InfraRoleInstanceProperties
        /// class.
        /// </summary>
        public InfraRoleInstanceProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InfraRoleInstanceProperties
        /// class.
        /// </summary>
        /// <param name="scaleUnit">URI to the scale unit</param>
        /// <param name="scaleUnitNode">URI to the scaleUnitNode</param>
        public InfraRoleInstanceProperties(string scaleUnit = default(string), string scaleUnitNode = default(string), object size = default(object), string state = default(string))
        {
            ScaleUnit = scaleUnit;
            ScaleUnitNode = scaleUnitNode;
            Size = size;
            State = state;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets URI to the scale unit
        /// </summary>
        [JsonProperty(PropertyName = "scaleUnit")]
        public string ScaleUnit { get; set; }

        /// <summary>
        /// Gets or sets URI to the scaleUnitNode
        /// </summary>
        [JsonProperty(PropertyName = "scaleUnitNode")]
        public string ScaleUnitNode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public object Size { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

    }
}
