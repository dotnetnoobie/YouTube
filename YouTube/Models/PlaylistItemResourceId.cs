using System.Text.Json.Serialization;

namespace YouTube.Models
{
    public class PlaylistItemResourceId
    {
        [JsonPropertyName("kind")]
        public string Kind { get; set; }
          
        [JsonPropertyName("videoId")]
        public string VideoId { get; set; }
    }
}