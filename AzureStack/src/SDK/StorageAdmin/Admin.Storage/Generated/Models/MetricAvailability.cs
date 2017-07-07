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

    public partial class MetricAvailability
    {
        /// <summary>
        /// Initializes a new instance of the MetricAvailability class.
        /// </summary>
        public MetricAvailability()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricAvailability class.
        /// </summary>
        public MetricAvailability(string timeGrain = default(string), string retention = default(string))
        {
            TimeGrain = timeGrain;
            Retention = retention;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timeGrain")]
        public string TimeGrain { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "retention")]
        public string Retention { get; set; }

    }
}
