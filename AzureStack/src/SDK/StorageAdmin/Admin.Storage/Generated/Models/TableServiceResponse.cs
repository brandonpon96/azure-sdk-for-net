// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.AzureStack.Storage.Admin.Models
{
    using Microsoft.AzureStack;
    using Microsoft.AzureStack.Storage;
    using Microsoft.AzureStack.Storage.Admin;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// TODO
    /// </summary>
    public partial class TableServiceResponse : ServiceResponse
    {
        /// <summary>
        /// Initializes a new instance of the TableServiceResponse class.
        /// </summary>
        public TableServiceResponse()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TableServiceResponse class.
        /// </summary>
        /// <param name="version">TODO</param>
        /// <param name="healthStatus">Possible values include: 'Unknown',
        /// 'Healthy', 'Warning', 'Critical'</param>
        public TableServiceResponse(string version = default(string), HealthStatus? healthStatus = default(HealthStatus?), TableServiceSettings properties = default(TableServiceSettings))
            : base(version, healthStatus)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public TableServiceSettings Properties { get; set; }

    }
}