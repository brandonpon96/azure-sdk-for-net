// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.TrafficManager.Fluent
{
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Azure.Management.Resource.Fluent.Core;
    using Microsoft.Azure.Management.Resource.Fluent.Core.CollectionActions;
    using Microsoft.Azure.Management.Resource.Fluent;

    internal partial class TrafficManagerProfilesImpl 
    {
        /// <summary>
        /// Begins a definition for a new resource.
        /// This is the beginning of the builder pattern used to create top level resources
        /// in Azure. The final method completing the definition and starting the actual resource creation
        /// process in Azure is Creatable.create().
        /// Note that the Creatable.create() method is
        /// only available at the stage of the resource definition that has the minimum set of input
        /// parameters specified. If you do not see Creatable.create() among the available methods, it
        /// means you have not yet specified all the required input settings. Input settings generally begin
        /// with the word "with", for example: <code>.withNewResourceGroup()</code> and return the next stage
        /// of the resource definition, as an interface in the "fluent interface" style.
        /// </summary>
        /// <param name="name">The name of the new resource.</param>
        /// <return>The first stage of the new resource definition.</return>
        TrafficManagerProfile.Definition.IBlank Microsoft.Azure.Management.Resource.Fluent.Core.CollectionActions.ISupportsCreating<TrafficManagerProfile.Definition.IBlank>.Define(string name)
        {
            return this.Define(name) as TrafficManagerProfile.Definition.IBlank;
        }

        /// <summary>
        /// Lists resources of the specified type in the specified resource group.
        /// </summary>
        /// <param name="resourceGroupName">The name of the resource group to list the resources from.</param>
        /// <return>The list of resources.</return>
        Microsoft.Azure.Management.Resource.Fluent.Core.PagedList<Microsoft.Azure.Management.TrafficManager.Fluent.ITrafficManagerProfile> Microsoft.Azure.Management.Resource.Fluent.Core.CollectionActions.ISupportsListingByGroup<Microsoft.Azure.Management.TrafficManager.Fluent.ITrafficManagerProfile>.ListByGroup(string resourceGroupName)
        {
            return this.ListByGroup(resourceGroupName) as Microsoft.Azure.Management.Resource.Fluent.Core.PagedList<Microsoft.Azure.Management.TrafficManager.Fluent.ITrafficManagerProfile>;
        }

        /// <summary>
        /// Gets the information about a resource from Azure based on the resource name and the name of its resource group.
        /// </summary>
        /// <param name="resourceGroupName">The name of the resource group the resource is in.</param>
        /// <param name="name">The name of the resource. (Note, this is not the ID).</param>
        /// <return>An immutable representation of the resource.</return>
        async Task<Microsoft.Azure.Management.TrafficManager.Fluent.ITrafficManagerProfile> Microsoft.Azure.Management.Resource.Fluent.Core.CollectionActions.ISupportsGettingByGroup<Microsoft.Azure.Management.TrafficManager.Fluent.ITrafficManagerProfile>.GetByGroupAsync(string resourceGroupName, string name, CancellationToken cancellationToken)
        {
            return await this.GetByGroupAsync(resourceGroupName, name, cancellationToken) as Microsoft.Azure.Management.TrafficManager.Fluent.ITrafficManagerProfile;
        }

        /// <summary>
        /// Asynchronously delete a resource from Azure, identifying it by its name and its resource group.
        /// </summary>
        /// <param name="groupName">The group the resource is part of.</param>
        /// <param name="name">The name of the resource.</param>
        /// <return>An observable to the request.</return>
        async Task Microsoft.Azure.Management.Resource.Fluent.Core.CollectionActions.ISupportsDeletingByGroup.DeleteByGroupAsync(string groupName, string name, CancellationToken cancellationToken)
        {
            await this.DeleteByGroupAsync(groupName, name, cancellationToken);
        }

        /// <summary>
        /// Lists all the resources of the specified type in the currently selected subscription.
        /// </summary>
        /// <return>List of resources.</return>
        Microsoft.Azure.Management.Resource.Fluent.Core.PagedList<Microsoft.Azure.Management.TrafficManager.Fluent.ITrafficManagerProfile> Microsoft.Azure.Management.Resource.Fluent.Core.CollectionActions.ISupportsListing<Microsoft.Azure.Management.TrafficManager.Fluent.ITrafficManagerProfile>.List()
        {
            return this.List() as Microsoft.Azure.Management.Resource.Fluent.Core.PagedList<Microsoft.Azure.Management.TrafficManager.Fluent.ITrafficManagerProfile>;
        }

        /// <summary>
        /// Checks that the DNS name is valid for traffic manager profile and is not in use.
        /// </summary>
        /// <param name="dnsNameLabel">The DNS name to check.</param>
        /// <return>Whether the DNS is available to be used for a traffic manager profile and other info if not.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.CheckProfileDnsNameAvailabilityResult Microsoft.Azure.Management.TrafficManager.Fluent.ITrafficManagerProfiles.CheckDnsNameAvailability(string dnsNameLabel)
        {
            return this.CheckDnsNameAvailability(dnsNameLabel) as Microsoft.Azure.Management.TrafficManager.Fluent.CheckProfileDnsNameAvailabilityResult;
        }
    }
}