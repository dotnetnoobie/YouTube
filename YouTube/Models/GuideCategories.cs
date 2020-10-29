using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace YouTube.Models
{
    public class GuideCategories
    {
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        [JsonPropertyName("etag")]
        public string Etag { get; set; }

        [JsonPropertyName("items")]
        public IList<Item<GuideCategorie>> Items { get; set; }
    }
}