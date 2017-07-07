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

    public partial class WritableSettings
    {
        /// <summary>
        /// Initializes a new instance of the WritableSettings class.
        /// </summary>
        public WritableSettings()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WritableSettings class.
        /// </summary>
        /// <param name="frontEndCallbackThreadsCount">TODO</param>
        /// <param
        /// name="frontEndCpuBasedKeepAliveThrottlingEnabled">TODO</param>
        /// <param
        /// name="frontEndCpuBasedKeepAliveThrottlingPercentCpuThreshold">TODO</param>
        /// <param
        /// name="frontEndCpuBasedKeepAliveThrottlingPercentRequestsToThrottle">TODO</param>
        /// <param
        /// name="frontEndCpuBasedKeepAliveThrottlingCpuMonitorIntervalInSeconds">TODO</param>
        /// <param name="frontEndMemoryThrottlingEnabled">TODO</param>
        /// <param
        /// name="frontEndMaxMillisecondsBetweenMemorySamples">TODO</param>
        /// <param name="frontEndMemoryThrottleThresholdSettings">TODO</param>
        /// <param name="frontEndMinThreadPoolThreads">TODO</param>
        /// <param
        /// name="frontEndThreadPoolBasedKeepAliveIOCompletionThreshold">TODO</param>
        /// <param
        /// name="frontEndThreadPoolBasedKeepAliveWorkerThreadThreshold">TODO</param>
        /// <param
        /// name="frontEndThreadPoolBasedKeepAliveMonitorIntervalInSeconds">TODO</param>
        /// <param
        /// name="frontEndThreadPoolBasedKeepAlivePercentage">TODO</param>
        /// <param name="frontEndUseSlaTimeInAvailability">TODO</param>
        public WritableSettings(int? frontEndCallbackThreadsCount = default(int?), bool? frontEndCpuBasedKeepAliveThrottlingEnabled = default(bool?), double? frontEndCpuBasedKeepAliveThrottlingPercentCpuThreshold = default(double?), double? frontEndCpuBasedKeepAliveThrottlingPercentRequestsToThrottle = default(double?), int? frontEndCpuBasedKeepAliveThrottlingCpuMonitorIntervalInSeconds = default(int?), bool? frontEndMemoryThrottlingEnabled = default(bool?), int? frontEndMaxMillisecondsBetweenMemorySamples = default(int?), string frontEndMemoryThrottleThresholdSettings = default(string), int? frontEndMinThreadPoolThreads = default(int?), int? frontEndThreadPoolBasedKeepAliveIOCompletionThreshold = default(int?), int? frontEndThreadPoolBasedKeepAliveWorkerThreadThreshold = default(int?), int? frontEndThreadPoolBasedKeepAliveMonitorIntervalInSeconds = default(int?), double? frontEndThreadPoolBasedKeepAlivePercentage = default(double?), bool? frontEndUseSlaTimeInAvailability = default(bool?))
        {
            FrontEndCallbackThreadsCount = frontEndCallbackThreadsCount;
            FrontEndCpuBasedKeepAliveThrottlingEnabled = frontEndCpuBasedKeepAliveThrottlingEnabled;
            FrontEndCpuBasedKeepAliveThrottlingPercentCpuThreshold = frontEndCpuBasedKeepAliveThrottlingPercentCpuThreshold;
            FrontEndCpuBasedKeepAliveThrottlingPercentRequestsToThrottle = frontEndCpuBasedKeepAliveThrottlingPercentRequestsToThrottle;
            FrontEndCpuBasedKeepAliveThrottlingCpuMonitorIntervalInSeconds = frontEndCpuBasedKeepAliveThrottlingCpuMonitorIntervalInSeconds;
            FrontEndMemoryThrottlingEnabled = frontEndMemoryThrottlingEnabled;
            FrontEndMaxMillisecondsBetweenMemorySamples = frontEndMaxMillisecondsBetweenMemorySamples;
            FrontEndMemoryThrottleThresholdSettings = frontEndMemoryThrottleThresholdSettings;
            FrontEndMinThreadPoolThreads = frontEndMinThreadPoolThreads;
            FrontEndThreadPoolBasedKeepAliveIOCompletionThreshold = frontEndThreadPoolBasedKeepAliveIOCompletionThreshold;
            FrontEndThreadPoolBasedKeepAliveWorkerThreadThreshold = frontEndThreadPoolBasedKeepAliveWorkerThreadThreshold;
            FrontEndThreadPoolBasedKeepAliveMonitorIntervalInSeconds = frontEndThreadPoolBasedKeepAliveMonitorIntervalInSeconds;
            FrontEndThreadPoolBasedKeepAlivePercentage = frontEndThreadPoolBasedKeepAlivePercentage;
            FrontEndUseSlaTimeInAvailability = frontEndUseSlaTimeInAvailability;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "frontEndCallbackThreadsCount")]
        public int? FrontEndCallbackThreadsCount { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "frontEndCpuBasedKeepAliveThrottlingEnabled")]
        public bool? FrontEndCpuBasedKeepAliveThrottlingEnabled { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "frontEndCpuBasedKeepAliveThrottlingPercentCpuThreshold")]
        public double? FrontEndCpuBasedKeepAliveThrottlingPercentCpuThreshold { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "frontEndCpuBasedKeepAliveThrottlingPercentRequestsToThrottle")]
        public double? FrontEndCpuBasedKeepAliveThrottlingPercentRequestsToThrottle { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "frontEndCpuBasedKeepAliveThrottlingCpuMonitorIntervalInSeconds")]
        public int? FrontEndCpuBasedKeepAliveThrottlingCpuMonitorIntervalInSeconds { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "frontEndMemoryThrottlingEnabled")]
        public bool? FrontEndMemoryThrottlingEnabled { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "frontEndMaxMillisecondsBetweenMemorySamples")]
        public int? FrontEndMaxMillisecondsBetweenMemorySamples { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "frontEndMemoryThrottleThresholdSettings")]
        public string FrontEndMemoryThrottleThresholdSettings { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "frontEndMinThreadPoolThreads")]
        public int? FrontEndMinThreadPoolThreads { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "frontEndThreadPoolBasedKeepAliveIOCompletionThreshold")]
        public int? FrontEndThreadPoolBasedKeepAliveIOCompletionThreshold { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "frontEndThreadPoolBasedKeepAliveWorkerThreadThreshold")]
        public int? FrontEndThreadPoolBasedKeepAliveWorkerThreadThreshold { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "frontEndThreadPoolBasedKeepAliveMonitorIntervalInSeconds")]
        public int? FrontEndThreadPoolBasedKeepAliveMonitorIntervalInSeconds { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "frontEndThreadPoolBasedKeepAlivePercentage")]
        public double? FrontEndThreadPoolBasedKeepAlivePercentage { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "frontEndUseSlaTimeInAvailability")]
        public bool? FrontEndUseSlaTimeInAvailability { get; set; }

    }
}
