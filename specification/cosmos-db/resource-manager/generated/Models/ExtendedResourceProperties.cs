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
    /// The system generated resource properties associated with SQL databases,
    /// SQL containers, Gremlin databases and Gremlin graphs.
    /// </summary>
    public partial class ExtendedResourceProperties
    {
        /// <summary>
        /// Initializes a new instance of the ExtendedResourceProperties class.
        /// </summary>
        public ExtendedResourceProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExtendedResourceProperties class.
        /// </summary>
        /// <param name="_rid">A system generated property. A unique
        /// identifier.</param>
        /// <param name="_ts">A system generated property that denotes the last
        /// updated timestamp of the resource.</param>
        /// <param name="_etag">A system generated property representing the
        /// resource etag required for optimistic concurrency control.</param>
        public ExtendedResourceProperties(string _rid = default(string), object _ts = default(object), string _etag = default(string))
        {
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
        /// Gets a system generated property. A unique identifier.
        /// </summary>
        [JsonProperty(PropertyName = "_rid")]
        public string _rid { get; private set; }

        /// <summary>
        /// Gets a system generated property that denotes the last updated
        /// timestamp of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "_ts")]
        public object _ts { get; private set; }

        /// <summary>
        /// Gets a system generated property representing the resource etag
        /// required for optimistic concurrency control.
        /// </summary>
        [JsonProperty(PropertyName = "_etag")]
        public string _etag { get; private set; }

    }
}
