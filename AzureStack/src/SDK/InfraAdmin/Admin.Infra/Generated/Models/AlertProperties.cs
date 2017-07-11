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

    public partial class AlertProperties
    {
        /// <summary>
        /// Initializes a new instance of the AlertProperties class.
        /// </summary>
        public AlertProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AlertProperties class.
        /// </summary>
        public AlertProperties(string component = default(string), string storageAccountName = default(string), string exceptionType = default(string), string exceptionMessage = default(string))
        {
            Component = component;
            StorageAccountName = storageAccountName;
            ExceptionType = exceptionType;
            ExceptionMessage = exceptionMessage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "component")]
        public string Component { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountName")]
        public string StorageAccountName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exceptionType")]
        public string ExceptionType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exceptionMessage")]
        public string ExceptionMessage { get; set; }

    }
}