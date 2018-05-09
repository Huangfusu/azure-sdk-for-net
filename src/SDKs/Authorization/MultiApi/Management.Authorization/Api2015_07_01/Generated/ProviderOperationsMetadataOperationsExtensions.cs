// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Authorization.Api2015_07_01
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ProviderOperationsMetadataOperations.
    /// </summary>
    public static partial class ProviderOperationsMetadataOperationsExtensions
    {
            /// <summary>
            /// Gets provider operations metadata for the specified resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for the operation.
            /// </param>
            /// <param name='expand'>
            /// Specifies whether to expand the values.
            /// </param>
            public static ProviderOperationsMetadata Get(this IProviderOperationsMetadataOperations operations, string resourceProviderNamespace, string apiVersion, string expand = "resourceTypes")
            {
                return operations.GetAsync(resourceProviderNamespace, apiVersion, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets provider operations metadata for the specified resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for the operation.
            /// </param>
            /// <param name='expand'>
            /// Specifies whether to expand the values.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProviderOperationsMetadata> GetAsync(this IProviderOperationsMetadataOperations operations, string resourceProviderNamespace, string apiVersion, string expand = "resourceTypes", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceProviderNamespace, apiVersion, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets provider operations metadata for all resource providers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            /// <param name='expand'>
            /// Specifies whether to expand the values.
            /// </param>
            public static ProviderOperationsMetadataListResult List(this IProviderOperationsMetadataOperations operations, string apiVersion, string expand = "resourceTypes")
            {
                return operations.ListAsync(apiVersion, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets provider operations metadata for all resource providers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            /// <param name='expand'>
            /// Specifies whether to expand the values.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProviderOperationsMetadataListResult> ListAsync(this IProviderOperationsMetadataOperations operations, string apiVersion, string expand = "resourceTypes", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(apiVersion, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
