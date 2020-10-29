using System.Text.Json.Serialization;

namespace YouTube.Models
{
    public class SearchId
    {
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        [JsonPropertyName("channelId")]
        public string ChannelId { get; set; }

        [JsonPropertyName("videoId")]
        public string VideoId { get; set; }
    }
}