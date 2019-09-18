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
    /// Extension methods for GremlinResources.
    /// </summary>
    public static partial class GremlinResourcesExtensions
    {
            /// <summary>
            /// Lists the Gremlin databases under an existing Azure Cosmos DB database
            /// account.
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
            public static GremlinDatabaseListResult ListGremlinDatabases(this IGremlinResources operations, string resourceGroupName, string accountName)
            {
                return operations.ListGremlinDatabasesAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the Gremlin databases under an existing Azure Cosmos DB database
            /// account.
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GremlinDatabaseListResult> ListGremlinDatabasesAsync(this IGremlinResources operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListGremlinDatabasesWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the Gremlin databases under an existing Azure Cosmos DB database
            /// account with the provided name.
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
            /// <param name='databaseName'>
            /// Cosmos DB database name.
            /// </param>
            public static GremlinDatabaseGetResults GetGremlinDatabase(this IGremlinResources operations, string resourceGroupName, string accountName, string databaseName)
            {
                return operations.GetGremlinDatabaseAsync(resourceGroupName, accountName, databaseName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the Gremlin databases under an existing Azure Cosmos DB database
            /// account with the provided name.
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
            /// <param name='databaseName'>
            /// Cosmos DB database name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GremlinDatabaseGetResults> GetGremlinDatabaseAsync(this IGremlinResources operations, string resourceGroupName, string accountName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetGremlinDatabaseWithHttpMessagesAsync(resourceGroupName, accountName, databaseName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update an Azure Cosmos DB Gremlin database
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
            /// <param name='databaseName'>
            /// Cosmos DB database name.
            /// </param>
            /// <param name='createUpdateGremlinDatabaseParameters'>
            /// The parameters to provide for the current Gremlin database.
            /// </param>
            public static GremlinDatabaseGetResults CreateUpdateGremlinDatabase(this IGremlinResources operations, string resourceGroupName, string accountName, string databaseName, GremlinDatabaseCreateUpdateParameters createUpdateGremlinDatabaseParameters)
            {
                return operations.CreateUpdateGremlinDatabaseAsync(resourceGroupName, accountName, databaseName, createUpdateGremlinDatabaseParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update an Azure Cosmos DB Gremlin database
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
            /// <param name='databaseName'>
            /// Cosmos DB database name.
            /// </param>
            /// <param name='createUpdateGremlinDatabaseParameters'>
            /// The parameters to provide for the current Gremlin database.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GremlinDatabaseGetResults> CreateUpdateGremlinDatabaseAsync(this IGremlinResources operations, string resourceGroupName, string accountName, string databaseName, GremlinDatabaseCreateUpdateParameters createUpdateGremlinDatabaseParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateUpdateGremlinDatabaseWithHttpMessagesAsync(resourceGroupName, accountName, databaseName, createUpdateGremlinDatabaseParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an existing Azure Cosmos DB Gremlin database.
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
            /// <param name='databaseName'>
            /// Cosmos DB database name.
            /// </param>
            public static void DeleteGremlinDatabase(this IGremlinResources operations, string resourceGroupName, string accountName, string databaseName)
            {
                operations.DeleteGremlinDatabaseAsync(resourceGroupName, accountName, databaseName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing Azure Cosmos DB Gremlin database.
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
            /// <param name='databaseName'>
            /// Cosmos DB database name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteGremlinDatabaseAsync(this IGremlinResources operations, string resourceGroupName, string accountName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteGremlinDatabaseWithHttpMessagesAsync(resourceGroupName, accountName, databaseName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the RUs per second of the Gremlin database under an existing Azure
            /// Cosmos DB database account with the provided name.
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
            /// <param name='databaseName'>
            /// Cosmos DB database name.
            /// </param>
            public static ThroughputSettingsGetResults GetGremlinDatabaseThroughput(this IGremlinResources operations, string resourceGroupName, string accountName, string databaseName)
            {
                return operations.GetGremlinDatabaseThroughputAsync(resourceGroupName, accountName, databaseName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the RUs per second of the Gremlin database under an existing Azure
            /// Cosmos DB database account with the provided name.
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
            /// <param name='databaseName'>
            /// Cosmos DB database name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ThroughputSettingsGetResults> GetGremlinDatabaseThroughputAsync(this IGremlinResources operations, string resourceGroupName, string accountName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetGremlinDatabaseThroughputWithHttpMessagesAsync(resourceGroupName, accountName, databaseName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update RUs per second of an Azure Cosmos DB Gremlin database
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
            /// <param name='databaseName'>
            /// Cosmos DB database name.
            /// </param>
            /// <param name='updateThroughputParameters'>
            /// The RUs per second of the parameters to provide for the current Gremlin
            /// database.
            /// </param>
            public static ThroughputSettingsGetResults UpdateGremlinDatabaseThroughput(this IGremlinResources operations, string resourceGroupName, string accountName, string databaseName, ThroughputSettingsUpdateParameters updateThroughputParameters)
            {
                return operations.UpdateGremlinDatabaseThroughputAsync(resourceGroupName, accountName, databaseName, updateThroughputParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update RUs per second of an Azure Cosmos DB Gremlin database
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
            /// <param name='databaseName'>
            /// Cosmos DB database name.
            /// </param>
            /// <param name='updateThroughputParameters'>
            /// The RUs per second of the parameters to provide for the current Gremlin
            /// database.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ThroughputSettingsGetResults> UpdateGremlinDatabaseThroughputAsync(this IGremlinResources operations, string resourceGroupName, string accountName, string databaseName, ThroughputSettingsUpdateParameters updateThroughputParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateGremlinDatabaseThroughputWithHttpMessagesAsync(resourceGroupName, accountName, databaseName, updateThroughputParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the Gremlin graph under an existing Azure Cosmos DB database account.
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
            /// <param name='databaseName'>
            /// Cosmos DB database name.
            /// </param>
            public static GremlinGraphListResult ListGremlinGraphs(this IGremlinResources operations, string resourceGroupName, string accountName, string databaseName)
            {
                return operations.ListGremlinGraphsAsync(resourceGroupName, accountName, databaseName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the Gremlin graph under an existing Azure Cosmos DB database account.
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
            /// <param name='databaseName'>
            /// Cosmos DB database name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GremlinGraphListResult> ListGremlinGraphsAsync(this IGremlinResources operations, string resourceGroupName, string accountName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListGremlinGraphsWithHttpMessagesAsync(resourceGroupName, accountName, databaseName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the Gremlin graph under an existing Azure Cosmos DB database account.
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
            /// <param name='databaseName'>
            /// Cosmos DB database name.
            /// </param>
            /// <param name='graphName'>
            /// Cosmos DB graph name.
            /// </param>
            public static GremlinGraphGetResults GetGremlinGraph(this IGremlinResources operations, string resourceGroupName, string accountName, string databaseName, string graphName)
            {
                return operations.GetGremlinGraphAsync(resourceGroupName, accountName, databaseName, graphName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the Gremlin graph under an existing Azure Cosmos DB database account.
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
            /// <param name='databaseName'>
            /// Cosmos DB database name.
            /// </param>
            /// <param name='graphName'>
            /// Cosmos DB graph name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GremlinGraphGetResults> GetGremlinGraphAsync(this IGremlinResources operations, string resourceGroupName, string accountName, string databaseName, string graphName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetGremlinGraphWithHttpMessagesAsync(resourceGroupName, accountName, databaseName, graphName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update an Azure Cosmos DB Gremlin graph
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
            /// <param name='databaseName'>
            /// Cosmos DB database name.
            /// </param>
            /// <param name='graphName'>
            /// Cosmos DB graph name.
            /// </param>
            /// <param name='createUpdateGremlinGraphParameters'>
            /// The parameters to provide for the current Gremlin graph.
            /// </param>
            public static GremlinGraphGetResults CreateUpdateGremlinGraph(this IGremlinResources operations, string resourceGroupName, string accountName, string databaseName, string graphName, GremlinGraphCreateUpdateParameters createUpdateGremlinGraphParameters)
            {
                return operations.CreateUpdateGremlinGraphAsync(resourceGroupName, accountName, databaseName, graphName, createUpdateGremlinGraphParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update an Azure Cosmos DB Gremlin graph
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
            /// <param name='databaseName'>
            /// Cosmos DB database name.
            /// </param>
            /// <param name='graphName'>
            /// Cosmos DB graph name.
            /// </param>
            /// <param name='createUpdateGremlinGraphParameters'>
            /// The parameters to provide for the current Gremlin graph.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GremlinGraphGetResults> CreateUpdateGremlinGraphAsync(this IGremlinResources operations, string resourceGroupName, string accountName, string databaseName, string graphName, GremlinGraphCreateUpdateParameters createUpdateGremlinGraphParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateUpdateGremlinGraphWithHttpMessagesAsync(resourceGroupName, accountName, databaseName, graphName, createUpdateGremlinGraphParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an existing Azure Cosmos DB Gremlin graph.
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
            /// <param name='databaseName'>
            /// Cosmos DB database name.
            /// </param>
            /// <param name='graphName'>
            /// Cosmos DB graph name.
            /// </param>
            public static void DeleteGremlinGraph(this IGremlinResources operations, string resourceGroupName, string accountName, string databaseName, string graphName)
            {
                operations.DeleteGremlinGraphAsync(resourceGroupName, accountName, databaseName, graphName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing Azure Cosmos DB Gremlin graph.
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
            /// <param name='databaseName'>
            /// Cosmos DB database name.
            /// </param>
            /// <param name='graphName'>
            /// Cosmos DB graph name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteGremlinGraphAsync(this IGremlinResources operations, string resourceGroupName, string accountName, string databaseName, string graphName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteGremlinGraphWithHttpMessagesAsync(resourceGroupName, accountName, databaseName, graphName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the Gremlin graph throughput under an existing Azure Cosmos DB
            /// database account with the provided name.
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
            /// <param name='databaseName'>
            /// Cosmos DB database name.
            /// </param>
            /// <param name='graphName'>
            /// Cosmos DB graph name.
            /// </param>
            public static ThroughputSettingsGetResults GetGremlinGraphThroughput(this IGremlinResources operations, string resourceGroupName, string accountName, string databaseName, string graphName)
            {
                return operations.GetGremlinGraphThroughputAsync(resourceGroupName, accountName, databaseName, graphName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the Gremlin graph throughput under an existing Azure Cosmos DB
            /// database account with the provided name.
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
            /// <param name='databaseName'>
            /// Cosmos DB database name.
            /// </param>
            /// <param name='graphName'>
            /// Cosmos DB graph name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ThroughputSettingsGetResults> GetGremlinGraphThroughputAsync(this IGremlinResources operations, string resourceGroupName, string accountName, string databaseName, string graphName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetGremlinGraphThroughputWithHttpMessagesAsync(resourceGroupName, accountName, databaseName, graphName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update RUs per second of an Azure Cosmos DB Gremlin graph
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
            /// <param name='databaseName'>
            /// Cosmos DB database name.
            /// </param>
            /// <param name='graphName'>
            /// Cosmos DB graph name.
            /// </param>
            /// <param name='updateThroughputParameters'>
            /// The RUs per second of the parameters to provide for the current Gremlin
            /// graph.
            /// </param>
            public static ThroughputSettingsGetResults UpdateGremlinGraphThroughput(this IGremlinResources operations, string resourceGroupName, string accountName, string databaseName, string graphName, ThroughputSettingsUpdateParameters updateThroughputParameters)
            {
                return operations.UpdateGremlinGraphThroughputAsync(resourceGroupName, accountName, databaseName, graphName, updateThroughputParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update RUs per second of an Azure Cosmos DB Gremlin graph
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
            /// <param name='databaseName'>
            /// Cosmos DB database name.
            /// </param>
            /// <param name='graphName'>
            /// Cosmos DB graph name.
            /// </param>
            /// <param name='updateThroughputParameters'>
            /// The RUs per second of the parameters to provide for the current Gremlin
            /// graph.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ThroughputSettingsGetResults> UpdateGremlinGraphThroughputAsync(this IGremlinResources operations, string resourceGroupName, string accountName, string databaseName, string graphName, ThroughputSettingsUpdateParameters updateThroughputParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateGremlinGraphThroughputWithHttpMessagesAsync(resourceGroupName, accountName, databaseName, graphName, updateThroughputParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
