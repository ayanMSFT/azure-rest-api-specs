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
    /// An Azure Cosmos DB resource throughput.
    /// </summary>
    [JsonTransformation]
    public partial class ThroughputSettingsGetResults : ARMResourceProperties
    {
        /// <summary>
        /// Initializes a new instance of the ThroughputSettingsGetResults
        /// class.
        /// </summary>
        public ThroughputSettingsGetResults()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ThroughputSettingsGetResults
        /// class.
        /// </summary>
        /// <param name="throughput">Value of the Cosmos DB resource
        /// throughput</param>
        /// <param name="id">The unique resource identifier of the ARM
        /// resource.</param>
        /// <param name="name">The name of the ARM resource.</param>
        /// <param name="type">The type of Azure resource.</param>
        /// <param name="location">The location of the resource group to which
        /// the resource belongs.</param>
        /// <param name="minimumThroughput">The minimum throughput of the
        /// resource</param>
        /// <param name="offerReplacePending">The throughput replace is
        /// pending</param>
        public ThroughputSettingsGetResults(int throughput, string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string minimumThroughput = default(string), string offerReplacePending = default(string))
            : base(id, name, type, location, tags)
        {
            Throughput = throughput;
            MinimumThroughput = minimumThroughput;
            OfferReplacePending = offerReplacePending;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets value of the Cosmos DB resource throughput
        /// </summary>
        [JsonProperty(PropertyName = "properties.throughput")]
        public int Throughput { get; set; }

        /// <summary>
        /// Gets the minimum throughput of the resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.minimumThroughput")]
        public string MinimumThroughput { get; private set; }

        /// <summary>
        /// Gets the throughput replace is pending
        /// </summary>
        [JsonProperty(PropertyName = "properties.offerReplacePending")]
        public string OfferReplacePending { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
