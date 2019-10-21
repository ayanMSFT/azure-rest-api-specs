// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace CosmosDb.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Cosmos DB SQL database resource object
    /// </summary>
    public partial class SqlDatabaseResource
    {
        /// <summary>
        /// Initializes a new instance of the SqlDatabaseResource class.
        /// </summary>
        public SqlDatabaseResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlDatabaseResource class.
        /// </summary>
        /// <param name="id">Name of the Cosmos DB SQL database</param>
        public SqlDatabaseResource(string id)
        {
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the Cosmos DB SQL database
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
        }
    }
}
