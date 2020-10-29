using System.Text.Json.Serialization;
using YouTube.Models.VideoInfo;

namespace YouTube.Models
{
    public class VideoInfomation
    {
        //[JsonProperty("responseContext")]
        //public ResponseContext ResponseContext { get; set; }

        //[JsonProperty("playabilityStatus")]
        //public PlayabilityStatus PlayabilityStatus { get; set; }

        [JsonPropertyName("streamingData")]
        public StreamingData StreamingData { get; set; }

        //[JsonProperty("playbackTracking")]
        //public PlaybackTracking PlaybackTracking { get; set; }

        //[JsonPropertyName("captions")]
        //public Captions Captions { get; set; }

        [JsonPropertyName("videoDetails")]
        public VideoDetails VideoDetails { get; set; }

        //[JsonProperty("annotations")]
        //public IList<Annotation> Annotations { get; set; }

        //[JsonProperty("playerConfig")]
        //public PlayerConfig PlayerConfig { get; set; }

        //[JsonProperty("storyboards")]
        //public Storyboards Storyboards { get; set; }

        //[JsonProperty("microformat")]
        //public Microformat Microformat { get; set; }

        //[JsonProperty("trackingParams")]
        //public string TrackingParams { get; set; }

        //[JsonProperty("attestation")]
        //public Attestation Attestation { get; set; }

        //[JsonProperty("videoQualityPromoSupportedRenderers")]
        //public VideoQualityPromoSupportedRenderers VideoQualityPromoSupportedRenderers { get; set; }

        //[JsonProperty("messages")]
        //public IList<Message> Messages { get; set; }
    }
}