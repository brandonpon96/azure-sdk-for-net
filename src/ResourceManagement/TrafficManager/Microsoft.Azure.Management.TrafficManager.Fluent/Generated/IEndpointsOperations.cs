// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.TrafficManager.Fluent
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// EndpointsOperations operations.
    /// </summary>
    public partial interface IEndpointsOperations
    {
        /// <summary>
        /// Update a Traffic Manager endpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Traffic Manager
        /// endpoint to be updated.
        /// </param>
        /// <param name='profileName'>
        /// The name of the Traffic Manager profile.
        /// </param>
        /// <param name='endpointType'>
        /// The type of the Traffic Manager endpoint to be updated.
        /// </param>
        /// <param name='endpointName'>
        /// The name of the Traffic Manager endpoint to be updated.
        /// </param>
        /// <param name='parameters'>
        /// The Traffic Manager endpoint parameters supplied to the Update
        /// operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<EndpointInner>> UpdateWithHttpMessagesAsync(string resourceGroupName, string profileName, string endpointType, string endpointName, EndpointInner parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets a Traffic Manager endpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Traffic Manager
        /// endpoint.
        /// </param>
        /// <param name='profileName'>
        /// The name of the Traffic Manager profile.
        /// </param>
        /// <param name='endpointType'>
        /// The type of the Traffic Manager endpoint.
        /// </param>
        /// <param name='endpointName'>
        /// The name of the Traffic Manager endpoint.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<EndpointInner>> GetWithHttpMessagesAsync(string resourceGroupName, string profileName, string endpointType, string endpointName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Create or update a Traffic Manager endpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Traffic Manager
        /// endpoint to be created or updated.
        /// </param>
        /// <param name='profileName'>
        /// The name of the Traffic Manager profile.
        /// </param>
        /// <param name='endpointType'>
        /// The type of the Traffic Manager endpoint to be created or updated.
        /// </param>
        /// <param name='endpointName'>
        /// The name of the Traffic Manager endpoint to be created or updated.
        /// </param>
        /// <param name='parameters'>
        /// The Traffic Manager endpoint parameters supplied to the
        /// CreateOrUpdate operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<EndpointInner>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string profileName, string endpointType, string endpointName, EndpointInner parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Deletes a Traffic Manager endpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Traffic Manager
        /// endpoint to be deleted.
        /// </param>
        /// <param name='profileName'>
        /// The name of the Traffic Manager profile.
        /// </param>
        /// <param name='endpointType'>
        /// The type of the Traffic Manager endpoint to be deleted.
        /// </param>
        /// <param name='endpointName'>
        /// The name of the Traffic Manager endpoint to be deleted.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string profileName, string endpointType, string endpointName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}