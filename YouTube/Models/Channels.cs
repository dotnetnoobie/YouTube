using System.Collections.Generic;
using System.Text.Json.Serialization; 

namespace YouTube.Models
{
    public class Channels
    {
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        [JsonPropertyName("etag")]
        public string Etag { get; set; }

        [JsonPropertyName("pageInfo")]
        public PageInfo PageInfo { get; set; }

        [JsonPropertyName("items")]
        public IList<Item<Channel>> Items { get; set; }
    }
}