using System.Text.Json.Serialization;

namespace YouTube.Models
{
    public class SubscriptionResourceId
    {
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        [JsonPropertyName("channelId")]
        public string ChannelId { get; set; }
    }
}