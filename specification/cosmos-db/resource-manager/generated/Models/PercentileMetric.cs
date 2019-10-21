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
    /// Percentile Metric data
    /// </summary>
    public partial class PercentileMetric
    {
        /// <summary>
        /// Initializes a new instance of the PercentileMetric class.
        /// </summary>
        public PercentileMetric()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PercentileMetric class.
        /// </summary>
        /// <param name="startTime">The start time for the metric (ISO-8601
        /// format).</param>
        /// <param name="endTime">The end time for the metric (ISO-8601
        /// format).</param>
        /// <param name="timeGrain">The time grain to be used to summarize the
        /// metric values.</param>
        /// <param name="unit">The unit of the metric. Possible values include:
        /// 'Count', 'Bytes', 'Seconds', 'Percent', 'CountPerSecond',
        /// 'BytesPerSecond', 'Milliseconds'</param>
        /// <param name="name">The name information for the metric.</param>
        /// <param name="metricValues">The percentile metric values for the
        /// specified time window and timestep.</param>
        public PercentileMetric(System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), string timeGrain = default(string), string unit = default(string), MetricName name = default(MetricName), IList<PercentileMetricValue> metricValues = default(IList<PercentileMetricValue>))
        {
            StartTime = startTime;
            EndTime = endTime;
            TimeGrain = timeGrain;
            Unit = unit;
            Name = name;
            MetricValues = metricValues;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the start time for the metric (ISO-8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; private set; }

        /// <summary>
        /// Gets the end time for the metric (ISO-8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; private set; }

        /// <summary>
        /// Gets the time grain to be used to summarize the metric values.
        /// </summary>
        [JsonProperty(PropertyName = "timeGrain")]
        public string TimeGrain { get; private set; }

        /// <summary>
        /// Gets or sets the unit of the metric. Possible values include:
        /// 'Count', 'Bytes', 'Seconds', 'Percent', 'CountPerSecond',
        /// 'BytesPerSecond', 'Milliseconds'
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Gets the name information for the metric.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public MetricName Name { get; private set; }

        /// <summary>
        /// Gets the percentile metric values for the specified time window and
        /// timestep.
        /// </summary>
        [JsonProperty(PropertyName = "metricValues")]
        public IList<PercentileMetricValue> MetricValues { get; private set; }

    }
}
