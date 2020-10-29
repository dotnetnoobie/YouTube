using System.Text.Json.Serialization;

namespace YouTube.Models
{
    public class Channel
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("customUrl")]
        public string CustomUrl { get; set; }

        [JsonPropertyName("publishedAt")]
        public string PublishedAt { get; set; }

        [JsonPropertyName("thumbnails")]
        public Thumbnails Thumbnails { get; set; }

        [JsonPropertyName("localized")]
        public Localized Localized { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }
    }
}