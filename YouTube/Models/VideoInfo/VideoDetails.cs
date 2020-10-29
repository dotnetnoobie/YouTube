using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace YouTube.Models.VideoInfo
{
    public class VideoDetails
    {
        [JsonPropertyName("videoId")]
        public string VideoId { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("lengthSeconds")]
        public string LengthSeconds { get; set; }

        [JsonPropertyName("keywords")]
        public IList<string> Keywords { get; set; }

        [JsonPropertyName("channelId")]
        public string ChannelId { get; set; }

        [JsonPropertyName("isOwnerViewing")]
        public bool IsOwnerViewing { get; set; }

        [JsonPropertyName("shortDescription")]
        public string ShortDescription { get; set; }

        [JsonPropertyName("isCrawlable")]
        public bool IsCrawlable { get; set; }

        [JsonPropertyName("thumbnail")]
        public Thumbnails Thumbnails { get; set; }

        [JsonPropertyName("averageRating")]
        public double AverageRating { get; set; }

        [JsonPropertyName("allowRatings")]
        public bool AllowRatings { get; set; }

        [JsonPropertyName("viewCount")]
        public string ViewCount { get; set; }

        [JsonPropertyName("author")]
        public string Author { get; set; }

        [JsonPropertyName("isPrivate")]
        public bool IsPrivate { get; set; }

        [JsonPropertyName("isUnpluggedCorpus")]
        public bool IsUnpluggedCorpus { get; set; }

        [JsonPropertyName("isLiveContent")]
        public bool IsLiveContent { get; set; }
    }
}
