using System.Text.Json.Serialization;

namespace CrudEntityFramework.Models
{
    // Convert enum to string
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight = 1,
        Mage = 2,
        Cleric = 3,
    }
}