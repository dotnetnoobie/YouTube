 using System.Text.Json.Serialization; 

namespace YouTube.Models.VideoInfo
{
    public class InitRange
    {
        [JsonPropertyName("start")]
        public string Start { get; set; }

        [JsonPropertyName("end")]
        public string End { get; set; }
    }
}