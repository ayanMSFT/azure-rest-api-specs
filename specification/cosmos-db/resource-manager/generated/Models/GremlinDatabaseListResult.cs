// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace CosmosDb.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The List operation response, that contains the Gremlin databases and
    /// their properties.
    /// </summary>
    public partial class GremlinDatabaseListResult
    {
        /// <summary>
        /// Initializes a new instance of the GremlinDatabaseListResult class.
        /// </summary>
        public GremlinDatabaseListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GremlinDatabaseListResult class.
        /// </summary>
        /// <param name="value">List of Gremlin databases and their
        /// properties.</param>
        public GremlinDatabaseListResult(IList<GremlinDatabaseGetResults> value = default(IList<GremlinDatabaseGetResults>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets list of Gremlin databases and their properties.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<GremlinDatabaseGetResults> Value { get; private set; }

    }
}
