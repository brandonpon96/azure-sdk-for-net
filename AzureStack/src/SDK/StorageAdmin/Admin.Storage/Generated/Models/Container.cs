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

    public partial class Container
    {
        /// <summary>
        /// Initializes a new instance of the Container class.
        /// </summary>
        public Container()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Container class.
        /// </summary>
        /// <param name="sharename">Name of the share container is
        /// located.</param>
        /// <param name="accountname">Name of account container belongs
        /// too.</param>
        /// <param name="containername">Name of the container.</param>
        /// <param name="containerid">TODO</param>
        /// <param name="accountid">GUID of account.</param>
        /// <param name="usedBytesInPrimaryVolume">Number of bytes used by the
        /// primary volume.</param>
        /// <param name="containerState">TODO</param>
        public Container(string sharename = default(string), string accountname = default(string), string containername = default(string), int? containerid = default(int?), string accountid = default(string), int? usedBytesInPrimaryVolume = default(int?), string containerState = default(string))
        {
            Sharename = sharename;
            Accountname = accountname;
            Containername = containername;
            Containerid = containerid;
            Accountid = accountid;
            UsedBytesInPrimaryVolume = usedBytesInPrimaryVolume;
            ContainerState = containerState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the share container is located.
        /// </summary>
        [JsonProperty(PropertyName = "sharename")]
        public string Sharename { get; set; }

        /// <summary>
        /// Gets or sets name of account container belongs too.
        /// </summary>
        [JsonProperty(PropertyName = "accountname")]
        public string Accountname { get; set; }

        /// <summary>
        /// Gets or sets name of the container.
        /// </summary>
        [JsonProperty(PropertyName = "containername")]
        public string Containername { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "containerid")]
        public int? Containerid { get; set; }

        /// <summary>
        /// Gets or sets GUID of account.
        /// </summary>
        [JsonProperty(PropertyName = "accountid")]
        public string Accountid { get; set; }

        /// <summary>
        /// Gets or sets number of bytes used by the primary volume.
        /// </summary>
        [JsonProperty(PropertyName = "usedBytesInPrimaryVolume")]
        public int? UsedBytesInPrimaryVolume { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "containerState")]
        public string ContainerState { get; set; }

    }
}
