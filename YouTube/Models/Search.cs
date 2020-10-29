using System.Text.Json.Serialization;

namespace YouTube.Models
{
    public class Search
    {
        [JsonPropertyName("publishedAt")]
        public string PublishedAt { get; set; }

        [JsonPropertyName("channelId")]
        public string ChannelId { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("thumbnails")]
        public Thumbnails Thumbnails { get; set; }

        [JsonPropertyName("channelTitle")]
        public string ChannelTitle { get; set; }

        [JsonPropertyName("liveBroadcastContent")]
        public string LiveBroadcastContent { get; set; }
    }
}