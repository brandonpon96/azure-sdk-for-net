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

    public partial class Update
    {
        /// <summary>
        /// Initializes a new instance of the Update class.
        /// </summary>
        public Update()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Update class.
        /// </summary>
        public Update(object updateName = default(object), object version = default(object), object isApplicable = default(object), object description = default(object), object state = default(object), object isDownloaded = default(object), object packageSizeInMb = default(object), object kblink = default(object))
        {
            UpdateName = updateName;
            Version = version;
            IsApplicable = isApplicable;
            Description = description;
            State = state;
            IsDownloaded = isDownloaded;
            PackageSizeInMb = packageSizeInMb;
            Kblink = kblink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "updateName")]
        public object UpdateName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public object Version { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isApplicable")]
        public object IsApplicable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public object Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public object State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isDownloaded")]
        public object IsDownloaded { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "packageSizeInMb")]
        public object PackageSizeInMb { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "kblink")]
        public object Kblink { get; set; }

    }
}
