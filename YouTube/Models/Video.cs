using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace YouTube.Models
{
    public class Video
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

        [JsonPropertyName("tags")]
        public IList<string> Tags { get; set; }

        [JsonPropertyName("categoryId")]
        public string CategoryId { get; set; }

        [JsonPropertyName("liveBroadcastContent")]
        public string LiveBroadcastContent { get; set; }

        [JsonPropertyName("localized")]
        public Localized Localized { get; set; }

        [JsonPropertyName("defaultAudioLanguage")]
        public string DefaultAudioLanguage { get; set; }
    }
}