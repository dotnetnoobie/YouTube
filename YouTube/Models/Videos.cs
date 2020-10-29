using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace YouTube.Models
{
    public class Videos
    {
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        [JsonPropertyName("etag")]
        public string Etag { get; set; }

        [JsonPropertyName("nextPageToken")]
        public string NextPageToken { get; set; }

        [JsonPropertyName("pageInfo")]
        public PageInfo PageInfo { get; set; }

        [JsonPropertyName("items")]
        public IList<Item<Video>> Items { get; set; }
    }
}