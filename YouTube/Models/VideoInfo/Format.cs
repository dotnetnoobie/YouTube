using System.Text.Json.Serialization; 

namespace YouTube.Models.VideoInfo
{
    public class Format
    {
        [JsonPropertyName("itag")]
        public int Itag { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("mimeType")]
        public string MimeType { get; set; }

        [JsonPropertyName("bitrate")]
        public int Bitrate { get; set; }

        [JsonPropertyName("width")]
        public int Width { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("lastModified")]
        //[JsonConverter(typeof(DateTimeConverter))]
        public string LastModified { get; set; }

        [JsonPropertyName("contentLength")]
        public string ContentLength { get; set; }

        [JsonPropertyName("quality")]
        public string Quality { get; set; }

        [JsonPropertyName("fps")]
        public int Fps { get; set; }

        [JsonPropertyName("qualityLabel")]
        public string QualityLabel { get; set; }

        [JsonPropertyName("projectionType")]
        public string ProjectionType { get; set; }

        [JsonPropertyName("averageBitrate")]
        public int AverageBitrate { get; set; }

        [JsonPropertyName("audioQuality")]
        public string AudioQuality { get; set; }

        [JsonPropertyName("approxDurationMs")]
        public string ApproxDurationMs { get; set; }

        [JsonPropertyName("audioSampleRate")]
        public string AudioSampleRate { get; set; }

        [JsonPropertyName("audioChannels")]
        public int AudioChannels { get; set; }
    }
}