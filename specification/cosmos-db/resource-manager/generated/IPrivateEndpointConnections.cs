// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace CosmosDb
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// PrivateEndpointConnections operations.
    /// </summary>
    public partial interface IPrivateEndpointConnections
    {
        /// <summary>
        /// List all private endpoint connections on a Cosmos DB account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure resource group.
        /// </param>
        /// <param name='accountName'>
        /// Cosmos DB database account name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<PrivateEndpointConnectionListResult>> ListByDatabaseAccountWithHttpMessagesAsync(string resourceGroupName, string accountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a private endpoint connection.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure resource group.
        /// </param>
        /// <param name='accountName'>
        /// Cosmos DB database account name.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// The name of the private endpoint connection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<PrivateEndpointConnection>> GetWithHttpMessagesAsync(string resourceGroupName, string accountName, string privateEndpointConnectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Approve or reject a private endpoint connection with a given name.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure resource group.
        /// </param>
        /// <param name='accountName'>
        /// Cosmos DB database account name.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// The name of the private endpoint connection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<PrivateEndpointConnection>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string accountName, string privateEndpointConnectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a private endpoint connection with a given name.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure resource group.
        /// </param>
        /// <param name='accountName'>
        /// Cosmos DB database account name.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// The name of the private endpoint connection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, string privateEndpointConnectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
