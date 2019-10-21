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
    /// Cosmos DB region to online or offline.
    /// </summary>
    public partial class RegionForOnlineOffline
    {
        /// <summary>
        /// Initializes a new instance of the RegionForOnlineOffline class.
        /// </summary>
        public RegionForOnlineOffline()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RegionForOnlineOffline class.
        /// </summary>
        /// <param name="region">Cosmos DB region, with spaces between words
        /// and each word capitalized.</param>
        public RegionForOnlineOffline(string region)
        {
            Region = region;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets cosmos DB region, with spaces between words and each
        /// word capitalized.
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Region == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Region");
            }
        }
    }
}
