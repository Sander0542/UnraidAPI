using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public interface IUserAccount
    {
        [JsonPropertyName("id")]
        string Id { get; set; }

        [JsonPropertyName("name")]
        string Name { get; set; }

        [JsonPropertyName("description")]
        string Description { get; set; }

        [JsonPropertyName("role")]
        string Role { get; set; }
    }
}
