using System.Text.Json.Serialization;

namespace YouTube.Models
{
    public class Localized
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}