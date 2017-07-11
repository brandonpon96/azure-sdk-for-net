// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.AzureStack.Infra.Admin
{
    using Microsoft.AzureStack;
    using Microsoft.AzureStack.Infra;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PoolsOperations.
    /// </summary>
    public static partial class PoolsOperationsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='region'>
            /// TODO
            /// </param>
            public static string ListIP(this IPoolsOperations operations, string region)
            {
                return operations.ListIPAsync(region).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='region'>
            /// TODO
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> ListIPAsync(this IPoolsOperations operations, string region, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListIPWithHttpMessagesAsync(region, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='region'>
            /// TODO
            /// </param>
            public static string ListMac(this IPoolsOperations operations, string region)
            {
                return operations.ListMacAsync(region).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='region'>
            /// TODO
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> ListMacAsync(this IPoolsOperations operations, string region, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListMacWithHttpMessagesAsync(region, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='region'>
            /// TODO
            /// </param>
            public static GatewayList ListGateways(this IPoolsOperations operations, string region)
            {
                return operations.ListGatewaysAsync(region).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='region'>
            /// TODO
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GatewayList> ListGatewaysAsync(this IPoolsOperations operations, string region, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListGatewaysWithHttpMessagesAsync(region, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='region'>
            /// TODO
            /// </param>
            public static string ListSlbMux(this IPoolsOperations operations, string region)
            {
                return operations.ListSlbMuxAsync(region).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='region'>
            /// TODO
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> ListSlbMuxAsync(this IPoolsOperations operations, string region, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListSlbMuxWithHttpMessagesAsync(region, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='region'>
            /// TODO
            /// </param>
            public static string GetGateway(this IPoolsOperations operations, string region)
            {
                return operations.GetGatewayAsync(region).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='region'>
            /// TODO
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> GetGatewayAsync(this IPoolsOperations operations, string region, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetGatewayWithHttpMessagesAsync(region, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='region'>
            /// TODO
            /// </param>
            /// <param name='ipPoolparameter'>
            /// IpPool parameter.
            /// </param>
            public static string CreateOrUpdateIpPool(this IPoolsOperations operations, string region, IpPool ipPoolparameter)
            {
                return operations.CreateOrUpdateIpPoolAsync(region, ipPoolparameter).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='region'>
            /// TODO
            /// </param>
            /// <param name='ipPoolparameter'>
            /// IpPool parameter.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> CreateOrUpdateIpPoolAsync(this IPoolsOperations operations, string region, IpPool ipPoolparameter, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateIpPoolWithHttpMessagesAsync(region, ipPoolparameter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
