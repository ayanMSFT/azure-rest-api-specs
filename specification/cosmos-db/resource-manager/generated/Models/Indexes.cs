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
    /// The indexes for the path.
    /// </summary>
    public partial class Indexes
    {
        /// <summary>
        /// Initializes a new instance of the Indexes class.
        /// </summary>
        public Indexes()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Indexes class.
        /// </summary>
        /// <param name="dataType">The datatype for which the indexing behavior
        /// is applied to. Possible values include: 'String', 'Number',
        /// 'Point', 'Polygon', 'LineString', 'MultiPolygon'</param>
        /// <param name="precision">The precision of the index. -1 is maximum
        /// precision.</param>
        /// <param name="kind">Indicates the type of index. Possible values
        /// include: 'Hash', 'Range', 'Spatial'</param>
        public Indexes(string dataType = default(string), int? precision = default(int?), string kind = default(string))
        {
            DataType = dataType;
            Precision = precision;
            Kind = kind;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the datatype for which the indexing behavior is
        /// applied to. Possible values include: 'String', 'Number', 'Point',
        /// 'Polygon', 'LineString', 'MultiPolygon'
        /// </summary>
        [JsonProperty(PropertyName = "dataType")]
        public string DataType { get; set; }

        /// <summary>
        /// Gets or sets the precision of the index. -1 is maximum precision.
        /// </summary>
        [JsonProperty(PropertyName = "precision")]
        public int? Precision { get; set; }

        /// <summary>
        /// Gets or sets indicates the type of index. Possible values include:
        /// 'Hash', 'Range', 'Spatial'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

    }
}
