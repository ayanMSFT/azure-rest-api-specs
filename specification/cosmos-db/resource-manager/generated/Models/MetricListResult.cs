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
    /// The response to a list metrics request.
    /// </summary>
    public partial class MetricListResult
    {
        /// <summary>
        /// Initializes a new instance of the MetricListResult class.
        /// </summary>
        public MetricListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricListResult class.
        /// </summary>
        /// <param name="value">The list of metrics for the account.</param>
        public MetricListResult(IList<Metric> value = default(IList<Metric>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the list of metrics for the account.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Metric> Value { get; private set; }

    }
}
