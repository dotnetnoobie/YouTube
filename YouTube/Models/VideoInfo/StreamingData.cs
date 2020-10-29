 using System.Collections.Generic;
using System.Text.Json.Serialization; 

namespace YouTube.Models.VideoInfo
{
    public class StreamingData
    {
        [JsonPropertyName("expiresInSeconds")]
        public string ExpiresInSeconds { get; set; }

        [JsonPropertyName("formats")]
        public List<Format> Formats { get; set; }

        [JsonPropertyName("adaptiveFormats")]
        public List<AdaptiveFormat> AdaptiveFormats { get; set; }
    }
}