// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace CosmosDb.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DefaultConsistencyLevel.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DefaultConsistencyLevel
    {
        [EnumMember(Value = "Eventual")]
        Eventual,
        [EnumMember(Value = "Session")]
        Session,
        [EnumMember(Value = "BoundedStaleness")]
        BoundedStaleness,
        [EnumMember(Value = "Strong")]
        Strong,
        [EnumMember(Value = "ConsistentPrefix")]
        ConsistentPrefix
    }
    internal static class DefaultConsistencyLevelEnumExtension
    {
        internal static string ToSerializedValue(this DefaultConsistencyLevel? value)
        {
            return value == null ? null : ((DefaultConsistencyLevel)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DefaultConsistencyLevel value)
        {
            switch( value )
            {
                case DefaultConsistencyLevel.Eventual:
                    return "Eventual";
                case DefaultConsistencyLevel.Session:
                    return "Session";
                case DefaultConsistencyLevel.BoundedStaleness:
                    return "BoundedStaleness";
                case DefaultConsistencyLevel.Strong:
                    return "Strong";
                case DefaultConsistencyLevel.ConsistentPrefix:
                    return "ConsistentPrefix";
            }
            return null;
        }

        internal static DefaultConsistencyLevel? ParseDefaultConsistencyLevel(this string value)
        {
            switch( value )
            {
                case "Eventual":
                    return DefaultConsistencyLevel.Eventual;
                case "Session":
                    return DefaultConsistencyLevel.Session;
                case "BoundedStaleness":
                    return DefaultConsistencyLevel.BoundedStaleness;
                case "Strong":
                    return DefaultConsistencyLevel.Strong;
                case "ConsistentPrefix":
                    return DefaultConsistencyLevel.ConsistentPrefix;
            }
            return null;
        }
    }
}
