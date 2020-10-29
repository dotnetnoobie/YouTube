using System.Text.Json.Serialization;

namespace YouTube.Models
{
    public class AuthorChannelId
    {
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}