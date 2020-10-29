using System.Text.Json.Serialization;

namespace YouTube.Models
{
    public class Caption
    {
        [JsonPropertyName("videoId")]
        public string VideoId { get; set; }

        [JsonPropertyName("lastUpdated")]
        public string LastUpdated { get; set; }

        [JsonPropertyName("trackKind")]
        public string TrackKind { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("audioTrackType")]
        public string AudioTrackType { get; set; }

        [JsonPropertyName("isCC")]
        public bool IsCC { get; set; }

        [JsonPropertyName("isLarge")]
        public bool IsLarge { get; set; }

        [JsonPropertyName("isEasyReader")]
        public bool IsEasyReader { get; set; }

        [JsonPropertyName("isDraft")]
        public bool IsDraft { get; set; }

        [JsonPropertyName("isAutoSynced")]
        public bool IsAutoSynced { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}