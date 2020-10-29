using System.Text.Json.Serialization;

namespace YouTube.Models
{
    public class GuideCategorie
    {
        [JsonPropertyName("channelId")]
        public string ChannelId { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}