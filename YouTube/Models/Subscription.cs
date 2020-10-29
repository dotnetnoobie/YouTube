using System.Text.Json.Serialization;

namespace YouTube.Models
{
    public class Subscription
    {
        [JsonPropertyName("publishedAt")]
        public string PublishedAt { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; } 

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("resourceId")]
        public SubscriptionResourceId ResourceId { get; set; }

        [JsonPropertyName("channelId")]
        public string ChannelId { get; set; }

        [JsonPropertyName("thumbnails")]
        public Thumbnails Thumbnails { get; set; }
    }
}