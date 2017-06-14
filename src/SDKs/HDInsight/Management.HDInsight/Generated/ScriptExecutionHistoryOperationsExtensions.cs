// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.HDInsight
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ScriptExecutionHistoryOperations.
    /// </summary>
    public static partial class ScriptExecutionHistoryOperationsExtensions
    {
            /// <summary>
            /// Gets the script execution detail for the given script execution ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            /// <param name='scriptExecutionId'>
            /// The script execution Id
            /// </param>
            public static RuntimeScriptActionDetail Get(this IScriptExecutionHistoryOperations operations, string resourceGroupName, string clusterName, string scriptExecutionId)
            {
                return operations.GetAsync(resourceGroupName, clusterName, scriptExecutionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the script execution detail for the given script execution ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            /// <param name='scriptExecutionId'>
            /// The script execution Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RuntimeScriptActionDetail> GetAsync(this IScriptExecutionHistoryOperations operations, string resourceGroupName, string clusterName, string scriptExecutionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, clusterName, scriptExecutionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all scripts' execution history for the specified cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            public static IPage<RuntimeScriptActionDetail> List(this IScriptExecutionHistoryOperations operations, string resourceGroupName, string clusterName)
            {
                return operations.ListAsync(resourceGroupName, clusterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all scripts' execution history for the specified cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RuntimeScriptActionDetail>> ListAsync(this IScriptExecutionHistoryOperations operations, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, clusterName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Promotes the specified ad-hoc script execution to a persisted script.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            /// <param name='scriptExecutionId'>
            /// The script execution ID.
            /// </param>
            public static void Promote(this IScriptExecutionHistoryOperations operations, string resourceGroupName, string clusterName, long scriptExecutionId)
            {
                operations.PromoteAsync(resourceGroupName, clusterName, scriptExecutionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Promotes the specified ad-hoc script execution to a persisted script.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            /// <param name='scriptExecutionId'>
            /// The script execution ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PromoteAsync(this IScriptExecutionHistoryOperations operations, string resourceGroupName, string clusterName, long scriptExecutionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PromoteWithHttpMessagesAsync(resourceGroupName, clusterName, scriptExecutionId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all scripts' execution history for the specified cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<RuntimeScriptActionDetail> ListNext(this IScriptExecutionHistoryOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all scripts' execution history for the specified cluster.
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
            public static async Task<IPage<RuntimeScriptActionDetail>> ListNextAsync(this IScriptExecutionHistoryOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}