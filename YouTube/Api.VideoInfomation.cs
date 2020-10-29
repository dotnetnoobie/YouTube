using System.Text.Json;
using System.Threading.Tasks;
using System.Web;
using YouTube.Models;

namespace YouTube
{
    public partial class Api
    {
        public async ValueTask<VideoInfomation> VideoInfo(string url)
        {
            var videoID = url.GetVideoId() ?? url;

            var videoInfoUrl = "https://cors-anywhere.herokuapp.com/https://www.youtube.com/get_video_info?video_id=" + videoID;
            var stream = await _http.GetStringAsync(videoInfoUrl);
            var data = HttpUtility.HtmlDecode(stream);
            var videoParams = HttpUtility.ParseQueryString(data);
            var videoURLs = videoParams["player_response"];
            var response = JsonSerializer.Deserialize<VideoInfomation>(videoURLs);

            return response;
        }
    }
}