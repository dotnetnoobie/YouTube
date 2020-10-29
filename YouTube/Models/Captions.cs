using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace YouTube.Models
{
    public class Captions
    {
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        [JsonPropertyName("etag")]
        public string Etag { get; set; }

        [JsonPropertyName("items")]
        public IList<Item<Caption>> Items { get; set; }
    }
}