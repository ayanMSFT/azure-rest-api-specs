// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace CosmosDb.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The object that represents the operation.
    /// </summary>
    public partial class OperationDisplay
    {
        /// <summary>
        /// Initializes a new instance of the OperationDisplay class.
        /// </summary>
        public OperationDisplay()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationDisplay class.
        /// </summary>
        /// <param name="provider">Service provider:
        /// Microsoft.ResourceProvider</param>
        /// <param name="resource">Resource on which the operation is
        /// performed: Profile, endpoint, etc.</param>
        /// <param name="operation">Operation type: Read, write, delete,
        /// etc.</param>
        /// <param name="description">Description of operation</param>
        public OperationDisplay(string provider = default(string), string resource = default(string), string operation = default(string), string description = default(string))
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets service provider: Microsoft.ResourceProvider
        /// </summary>
        [JsonProperty(PropertyName = "Provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets resource on which the operation is performed: Profile,
        /// endpoint, etc.
        /// </summary>
        [JsonProperty(PropertyName = "Resource")]
        public string Resource { get; set; }

        /// <summary>
        /// Gets or sets operation type: Read, write, delete, etc.
        /// </summary>
        [JsonProperty(PropertyName = "Operation")]
        public string Operation { get; set; }

        /// <summary>
        /// Gets or sets description of operation
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

    }
}
