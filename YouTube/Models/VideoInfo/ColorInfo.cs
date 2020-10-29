using System.Text.Json.Serialization;

namespace YouTube.Models.VideoInfo
{
    public class ColorInfo
    {
        [JsonPropertyName("transferCharacteristics")]
        public string TransferCharacteristics { get; set; }
    }
}