// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CustomerInsights
{
    using Azure;
    using Management;
    using Rest;
    using Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RelationshipsOperations.
    /// </summary>
    public static partial class RelationshipsOperationsExtensions
    {
            /// <summary>
            /// Creates a relationship or updates an existing relationship within a hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='relationshipName'>
            /// The name of the Relationship.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate Relationship operation.
            /// </param>
            public static RelationshipResourceFormat CreateOrUpdate(this IRelationshipsOperations operations, string resourceGroupName, string hubName, string relationshipName, RelationshipResourceFormat parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, hubName, relationshipName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a relationship or updates an existing relationship within a hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='relationshipName'>
            /// The name of the Relationship.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate Relationship operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RelationshipResourceFormat> CreateOrUpdateAsync(this IRelationshipsOperations operations, string resourceGroupName, string hubName, string relationshipName, RelationshipResourceFormat parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, hubName, relationshipName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets information about the specified relationship.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='relationshipName'>
            /// The name of the relationship.
            /// </param>
            public static RelationshipResourceFormat Get(this IRelationshipsOperations operations, string resourceGroupName, string hubName, string relationshipName)
            {
                return operations.GetAsync(resourceGroupName, hubName, relationshipName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about the specified relationship.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='relationshipName'>
            /// The name of the relationship.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RelationshipResourceFormat> GetAsync(this IRelationshipsOperations operations, string resourceGroupName, string hubName, string relationshipName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, hubName, relationshipName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a relationship within a hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='relationshipName'>
            /// The name of the relationship.
            /// </param>
            public static void Delete(this IRelationshipsOperations operations, string resourceGroupName, string hubName, string relationshipName)
            {
                operations.DeleteAsync(resourceGroupName, hubName, relationshipName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a relationship within a hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='relationshipName'>
            /// The name of the relationship.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IRelationshipsOperations operations, string resourceGroupName, string hubName, string relationshipName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, hubName, relationshipName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets all relationships in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            public static IPage<RelationshipResourceFormat> ListByHub(this IRelationshipsOperations operations, string resourceGroupName, string hubName)
            {
                return operations.ListByHubAsync(resourceGroupName, hubName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all relationships in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RelationshipResourceFormat>> ListByHubAsync(this IRelationshipsOperations operations, string resourceGroupName, string hubName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByHubWithHttpMessagesAsync(resourceGroupName, hubName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a relationship or updates an existing relationship within a hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='relationshipName'>
            /// The name of the Relationship.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate Relationship operation.
            /// </param>
            public static RelationshipResourceFormat BeginCreateOrUpdate(this IRelationshipsOperations operations, string resourceGroupName, string hubName, string relationshipName, RelationshipResourceFormat parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, hubName, relationshipName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a relationship or updates an existing relationship within a hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='relationshipName'>
            /// The name of the Relationship.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate Relationship operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RelationshipResourceFormat> BeginCreateOrUpdateAsync(this IRelationshipsOperations operations, string resourceGroupName, string hubName, string relationshipName, RelationshipResourceFormat parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, hubName, relationshipName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a relationship within a hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='relationshipName'>
            /// The name of the relationship.
            /// </param>
            public static void BeginDelete(this IRelationshipsOperations operations, string resourceGroupName, string hubName, string relationshipName)
            {
                operations.BeginDeleteAsync(resourceGroupName, hubName, relationshipName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a relationship within a hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='relationshipName'>
            /// The name of the relationship.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IRelationshipsOperations operations, string resourceGroupName, string hubName, string relationshipName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, hubName, relationshipName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets all relationships in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<RelationshipResourceFormat> ListByHubNext(this IRelationshipsOperations operations, string nextPageLink)
            {
                return operations.ListByHubNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all relationships in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RelationshipResourceFormat>> ListByHubNextAsync(this IRelationshipsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByHubNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

