// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.AzureStack.Storage.Admin
{
    using Microsoft.AzureStack;
    using Microsoft.AzureStack.Storage;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AcquisitionsOperations.
    /// </summary>
    public static partial class AcquisitionsOperationsExtensions
    {
            /// <summary>
            /// TODO
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// Th name of the farm.
            /// </param>
            public static void Delete(this IAcquisitionsOperations operations, string resourceGroupName, string farmId)
            {
                operations.DeleteAsync(resourceGroupName, farmId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// TODO
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// Th name of the farm.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IAcquisitionsOperations operations, string resourceGroupName, string farmId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, farmId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// TODO
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// Th name of the farm.
            /// </param>
            public static object Get(this IAcquisitionsOperations operations, string resourceGroupName, string farmId)
            {
                return operations.GetAsync(resourceGroupName, farmId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// TODO
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// Th name of the farm.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetAsync(this IAcquisitionsOperations operations, string resourceGroupName, string farmId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, farmId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a list of acquistions
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// Th name of the farm.
            /// </param>
            /// <param name='filter'>
            /// TODO
            /// </param>
            public static object List(this IAcquisitionsOperations operations, string resourceGroupName, string farmId, string filter)
            {
                return operations.ListAsync(resourceGroupName, farmId, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of acquistions
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// Th name of the farm.
            /// </param>
            /// <param name='filter'>
            /// TODO
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> ListAsync(this IAcquisitionsOperations operations, string resourceGroupName, string farmId, string filter, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, farmId, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}