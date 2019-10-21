// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace CosmosDb
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DatabaseAccountRegion.
    /// </summary>
    public static partial class DatabaseAccountRegionExtensions
    {
            /// <summary>
            /// Retrieves the metrics determined by the given filter for the given database
            /// account and region.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// Cosmos DB database account name.
            /// </param>
            /// <param name='region'>
            /// Cosmos DB region, with spaces between words and each word capitalized.
            /// </param>
            /// <param name='filter'>
            /// An OData filter expression that describes a subset of metrics to return.
            /// The parameters that can be filtered are name.value (name of the metric, can
            /// have an or of multiple names), startTime, endTime, and timeGrain. The
            /// supported operator is eq.
            /// </param>
            public static MetricListResult ListMetrics(this IDatabaseAccountRegion operations, string resourceGroupName, string accountName, string region, string filter)
            {
                return operations.ListMetricsAsync(resourceGroupName, accountName, region, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves the metrics determined by the given filter for the given database
            /// account and region.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// Cosmos DB database account name.
            /// </param>
            /// <param name='region'>
            /// Cosmos DB region, with spaces between words and each word capitalized.
            /// </param>
            /// <param name='filter'>
            /// An OData filter expression that describes a subset of metrics to return.
            /// The parameters that can be filtered are name.value (name of the metric, can
            /// have an or of multiple names), startTime, endTime, and timeGrain. The
            /// supported operator is eq.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MetricListResult> ListMetricsAsync(this IDatabaseAccountRegion operations, string resourceGroupName, string accountName, string region, string filter, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListMetricsWithHttpMessagesAsync(resourceGroupName, accountName, region, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
