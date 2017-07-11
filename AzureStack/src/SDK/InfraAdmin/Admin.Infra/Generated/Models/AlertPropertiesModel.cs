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

    public partial class AlertPropertiesModel
    {
        /// <summary>
        /// Initializes a new instance of the AlertPropertiesModel class.
        /// </summary>
        public AlertPropertiesModel()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AlertPropertiesModel class.
        /// </summary>
        public AlertPropertiesModel(object closedTimestamp = default(object), object createdTimestamp = default(object), IList<object> description = default(IList<object>), string faultId = default(string), string alertId = default(string), string faultTypeId = default(string), string lastUpdatedTimestamp = default(string), AlertProperties alertProperties = default(AlertProperties), object remediation = default(object), string resourceRegistrationId = default(string), string resourceProviderRegistrationId = default(string), string severity = default(string), string state = default(string), string title = default(string), string impactedResourceId = default(string), string impactedResourceDisplayName = default(string), string closedByUserAlias = default(string))
        {
            ClosedTimestamp = closedTimestamp;
            CreatedTimestamp = createdTimestamp;
            Description = description;
            FaultId = faultId;
            AlertId = alertId;
            FaultTypeId = faultTypeId;
            LastUpdatedTimestamp = lastUpdatedTimestamp;
            AlertProperties = alertProperties;
            Remediation = remediation;
            ResourceRegistrationId = resourceRegistrationId;
            ResourceProviderRegistrationId = resourceProviderRegistrationId;
            Severity = severity;
            State = state;
            Title = title;
            ImpactedResourceId = impactedResourceId;
            ImpactedResourceDisplayName = impactedResourceDisplayName;
            ClosedByUserAlias = closedByUserAlias;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "closedTimestamp")]
        public object ClosedTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdTimestamp")]
        public object CreatedTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public IList<object> Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "faultId")]
        public string FaultId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "alertId")]
        public string AlertId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "faultTypeId")]
        public string FaultTypeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdatedTimestamp")]
        public string LastUpdatedTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "alertProperties")]
        public AlertProperties AlertProperties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "remediation")]
        public object Remediation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourceRegistrationId")]
        public string ResourceRegistrationId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourceProviderRegistrationId")]
        public string ResourceProviderRegistrationId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        public string Severity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "impactedResourceId")]
        public string ImpactedResourceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "impactedResourceDisplayName")]
        public string ImpactedResourceDisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "closedByUserAlias")]
        public string ClosedByUserAlias { get; set; }

    }
}