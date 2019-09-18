// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace CosmosDb.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An Azure Cosmos DB Cassandra keyspace.
    /// </summary>
    [JsonTransformation]
    public partial class CassandraKeyspaceGetResults : ARMResourceProperties
    {
        /// <summary>
        /// Initializes a new instance of the CassandraKeyspaceGetResults
        /// class.
        /// </summary>
        public CassandraKeyspaceGetResults()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CassandraKeyspaceGetResults
        /// class.
        /// </summary>
        /// <param name="cassandraKeyspaceGetResultsId">Name of the Cosmos DB
        /// Cassandra keyspace</param>
        /// <param name="id">The unique resource identifier of the ARM
        /// resource.</param>
        /// <param name="name">The name of the ARM resource.</param>
        /// <param name="type">The type of Azure resource.</param>
        /// <param name="location">The location of the resource group to which
        /// the resource belongs.</param>
        /// <param name="_rid">A system generated property. A unique
        /// identifier.</param>
        /// <param name="_ts">A system generated property that denotes the last
        /// updated timestamp of the resource.</param>
        /// <param name="_etag">A system generated property representing the
        /// resource etag required for optimistic concurrency control.</param>
        public CassandraKeyspaceGetResults(string cassandraKeyspaceGetResultsId, string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string _rid = default(string), object _ts = default(object), string _etag = default(string))
            : base(id, name, type, location, tags)
        {
            CassandraKeyspaceGetResultsId = cassandraKeyspaceGetResultsId;
            this._rid = _rid;
            this._ts = _ts;
            this._etag = _etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the Cosmos DB Cassandra keyspace
        /// </summary>
        [JsonProperty(PropertyName = "properties.id")]
        public string CassandraKeyspaceGetResultsId { get; set; }

        /// <summary>
        /// Gets a system generated property. A unique identifier.
        /// </summary>
        [JsonProperty(PropertyName = "properties._rid")]
        public string _rid { get; private set; }

        /// <summary>
        /// Gets a system generated property that denotes the last updated
        /// timestamp of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties._ts")]
        public object _ts { get; private set; }

        /// <summary>
        /// Gets a system generated property representing the resource etag
        /// required for optimistic concurrency control.
        /// </summary>
        [JsonProperty(PropertyName = "properties._etag")]
        public string _etag { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CassandraKeyspaceGetResultsId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CassandraKeyspaceGetResultsId");
            }
        }
    }
}
