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

    public partial class Alert : ResourceBase
    {
        /// <summary>
        /// Initializes a new instance of the Alert class.
        /// </summary>
        public Alert()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Alert class.
        /// </summary>
        /// <param name="id">TODO</param>
        /// <param name="name">TODO</param>
        /// <param name="type">TODO</param>
        /// <param name="location">TODO</param>
        /// <param name="tags">Gets or sets a list of key value pairs that
        /// describe the resource. These tags can be used for viewing and
        /// grouping this resource (across resource groups). A maximum of 15
        /// tags can be provided for a resource. Each tag must have a key with
        /// a length no greater than 128 characters and a value with a length
        /// no greater than 256 characters.</param>
        public Alert(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), AlertPropertiesModel properties = default(AlertPropertiesModel))
            : base(id, name, type, location, tags)
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
        public AlertPropertiesModel Properties { get; set; }

    }
}
