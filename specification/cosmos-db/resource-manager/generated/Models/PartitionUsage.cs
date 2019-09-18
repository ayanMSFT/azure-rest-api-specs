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
    /// The partition level usage data for a usage request.
    /// </summary>
    public partial class PartitionUsage : Usage
    {
        /// <summary>
        /// Initializes a new instance of the PartitionUsage class.
        /// </summary>
        public PartitionUsage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PartitionUsage class.
        /// </summary>
        /// <param name="unit">The unit of the metric. Possible values include:
        /// 'Count', 'Bytes', 'Seconds', 'Percent', 'CountPerSecond',
        /// 'BytesPerSecond', 'Milliseconds'</param>
        /// <param name="name">The name information for the metric.</param>
        /// <param name="quotaPeriod">The quota period used to summarize the
        /// usage values.</param>
        /// <param name="limit">Maximum value for this metric</param>
        /// <param name="currentValue">Current value for this metric</param>
        /// <param name="partitionId">The partition id (GUID identifier) of the
        /// usages.</param>
        /// <param name="partitionKeyRangeId">The partition key range id
        /// (integer identifier) of the usages.</param>
        public PartitionUsage(string unit = default(string), MetricName name = default(MetricName), string quotaPeriod = default(string), long? limit = default(long?), long? currentValue = default(long?), string partitionId = default(string), string partitionKeyRangeId = default(string))
            : base(unit, name, quotaPeriod, limit, currentValue)
        {
            PartitionId = partitionId;
            PartitionKeyRangeId = partitionKeyRangeId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the partition id (GUID identifier) of the usages.
        /// </summary>
        [JsonProperty(PropertyName = "partitionId")]
        public string PartitionId { get; private set; }

        /// <summary>
        /// Gets the partition key range id (integer identifier) of the usages.
        /// </summary>
        [JsonProperty(PropertyName = "partitionKeyRangeId")]
        public string PartitionKeyRangeId { get; private set; }

    }
}
