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
    /// The paths that are included in indexing
    /// </summary>
    public partial class IncludedPath
    {
        /// <summary>
        /// Initializes a new instance of the IncludedPath class.
        /// </summary>
        public IncludedPath()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IncludedPath class.
        /// </summary>
        /// <param name="path">The path for which the indexing behavior applies
        /// to. Index paths typically start with root and end with wildcard
        /// (/path/*)</param>
        /// <param name="indexes">List of indexes for this path</param>
        public IncludedPath(string path = default(string), IList<Indexes> indexes = default(IList<Indexes>))
        {
            Path = path;
            Indexes = indexes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the path for which the indexing behavior applies to.
        /// Index paths typically start with root and end with wildcard
        /// (/path/*)
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets list of indexes for this path
        /// </summary>
        [JsonProperty(PropertyName = "indexes")]
        public IList<Indexes> Indexes { get; set; }

    }
}
