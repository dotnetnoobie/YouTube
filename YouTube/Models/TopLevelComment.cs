using System.Text.Json.Serialization;

namespace YouTube.Models
{
    public class TopLevelComment
    {
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        [JsonPropertyName("etag")]
        public string Etag { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("snippet")]
        public Snippet2 Snippet { get; set; }
    }
}