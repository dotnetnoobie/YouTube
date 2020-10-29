using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace YouTube.Models.VideoInfo
{
    public class Thumbnails
    {
        [JsonPropertyName("thumbnails")]
        public List<Thumbnail> Images { get; set; }
    }
}