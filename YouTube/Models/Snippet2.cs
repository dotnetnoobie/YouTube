using System.Text.Json.Serialization;

namespace YouTube.Models
{
    public class Snippet2
    {
        [JsonPropertyName("authorDisplayName")]
        public string AuthorDisplayName { get; set; }

        [JsonPropertyName("authorProfileImageUrl")]
        public string AuthorProfileImageUrl { get; set; }

        [JsonPropertyName("authorChannelUrl")]
        public string AuthorChannelUrl { get; set; }

        [JsonPropertyName("authorChannelId")]
        public AuthorChannelId AuthorChannelId { get; set; }

        [JsonPropertyName("channelId")]
        public string ChannelId { get; set; }

        [JsonPropertyName("textDisplay")]
        public string TextDisplay { get; set; }

        [JsonPropertyName("textOriginal")]
        public string TextOriginal { get; set; }

        [JsonPropertyName("canRate")]
        public bool CanRate { get; set; }

        [JsonPropertyName("viewerRating")]
        public string ViewerRating { get; set; }

        [JsonPropertyName("likeCount")]
        public int LikeCount { get; set; }

        [JsonPropertyName("publishedAt")]
        public string PublishedAt { get; set; }

        [JsonPropertyName("updatedAt")]
        public string UpdatedAt { get; set; }
    }
}