
using System.Text.Json.Serialization;

namespace YouTube.Models
{
    public class ChannelSection
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("style")]
        public string Style { get; set; }

        [JsonPropertyName("channelId")]
        public string ChannelId { get; set; }

        [JsonPropertyName("position")]
        public int Position { get; set; }
    }
}