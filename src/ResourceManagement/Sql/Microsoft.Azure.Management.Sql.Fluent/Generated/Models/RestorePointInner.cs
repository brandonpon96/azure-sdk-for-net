// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Sql;
    using Microsoft.Azure.Management.Sql.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents an Azure SQL Database restore point.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RestorePointInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the RestorePointInner class.
        /// </summary>
        public RestorePointInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RestorePointInner class.
        /// </summary>
        /// <param name="restorePointType">The restore point type of the Azure
        /// SQL database restore point. Possible values include: 'DISCRETE',
        /// 'CONTINUOUS'</param>
        /// <param name="restorePointCreationDate">Restore point creation time
        /// (ISO8601 format). Populated when restorePointType = CONTINUOUS.
        /// Null otherwise.</param>
        /// <param name="earliestRestoreDate">Earliest restore time (ISO8601
        /// format). Populated when restorePointType = DISCRETE. Null
        /// otherwise.</param>
        public RestorePointInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), RestorePointTypes? restorePointType = default(RestorePointTypes?), System.DateTime? restorePointCreationDate = default(System.DateTime?), System.DateTime? earliestRestoreDate = default(System.DateTime?))
            : base(location, id, name, type, tags)
        {
            RestorePointType = restorePointType;
            RestorePointCreationDate = restorePointCreationDate;
            EarliestRestoreDate = earliestRestoreDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the restore point type of the Azure SQL database restore
        /// point. Possible values include: 'DISCRETE', 'CONTINUOUS'
        /// </summary>
        [JsonProperty(PropertyName = "properties.restorePointType")]
        public RestorePointTypes? RestorePointType { get; private set; }

        /// <summary>
        /// Gets restore point creation time (ISO8601 format). Populated when
        /// restorePointType = CONTINUOUS. Null otherwise.
        /// </summary>
        [JsonProperty(PropertyName = "properties.restorePointCreationDate")]
        public System.DateTime? RestorePointCreationDate { get; private set; }

        /// <summary>
        /// Gets earliest restore time (ISO8601 format). Populated when
        /// restorePointType = DISCRETE. Null otherwise.
        /// </summary>
        [JsonProperty(PropertyName = "properties.earliestRestoreDate")]
        public System.DateTime? EarliestRestoreDate { get; private set; }

    }
}