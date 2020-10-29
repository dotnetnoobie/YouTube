using System.Text.Json.Serialization;

namespace YouTube.Models
{
    public class VideoCategory
    {
        [JsonPropertyName("channelId")]
        public string ChannelId { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("assignable")]
        public bool Assignable { get; set; }
    }
}