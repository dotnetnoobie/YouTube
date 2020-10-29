using System.Text.Json.Serialization;

namespace YouTube.Models
{
    public class CommentThread
    {
        [JsonPropertyName("channelId")]
        public string ChannelId { get; set; }

        [JsonPropertyName("topLevelComment")]
        public TopLevelComment TopLevelComment { get; set; }

        [JsonPropertyName("canReply")]
        public bool CanReply { get; set; }

        [JsonPropertyName("totalReplyCount")]
        public int TotalReplyCount { get; set; }

        [JsonPropertyName("isPublic")]
        public bool IsPublic { get; set; }
    }
}