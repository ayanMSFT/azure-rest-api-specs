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
    /// The read-only access keys for the given database account.
    /// </summary>
    public partial class DatabaseAccountListReadOnlyKeysResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DatabaseAccountListReadOnlyKeysResult class.
        /// </summary>
        public DatabaseAccountListReadOnlyKeysResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DatabaseAccountListReadOnlyKeysResult class.
        /// </summary>
        /// <param name="primaryReadonlyMasterKey">Base 64 encoded value of the
        /// primary read-only key.</param>
        /// <param name="secondaryReadonlyMasterKey">Base 64 encoded value of
        /// the secondary read-only key.</param>
        public DatabaseAccountListReadOnlyKeysResult(string primaryReadonlyMasterKey = default(string), string secondaryReadonlyMasterKey = default(string))
        {
            PrimaryReadonlyMasterKey = primaryReadonlyMasterKey;
            SecondaryReadonlyMasterKey = secondaryReadonlyMasterKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets base 64 encoded value of the primary read-only key.
        /// </summary>
        [JsonProperty(PropertyName = "primaryReadonlyMasterKey")]
        public string PrimaryReadonlyMasterKey { get; private set; }

        /// <summary>
        /// Gets base 64 encoded value of the secondary read-only key.
        /// </summary>
        [JsonProperty(PropertyName = "secondaryReadonlyMasterKey")]
        public string SecondaryReadonlyMasterKey { get; private set; }

    }
}
