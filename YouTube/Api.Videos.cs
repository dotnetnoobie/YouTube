using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using YouTube.Models;

namespace YouTube
{
    public partial class Api
    {
        public async ValueTask<Videos> Videos(IEnumerable<string> videosIds, int maxResults = 50, string pageToken = "")
        { 
            var parameters = new Parameters(this._apiKey);
            parameters.Add("id", string.Join(",", videosIds));
            parameters.Add("maxResults", maxResults);
            if (!string.IsNullOrEmpty(pageToken)) parameters.Add("pageToken", pageToken);

            var url = $"https://www.googleapis.com/youtube/v3/videos?{parameters}";

            return await _http.GetFromJsonAsync<Videos>(url);
        }

        public async ValueTask<Video> Video(string videoId)
        { 
            var parameters = new Parameters(this._apiKey);
            parameters.Add("id", videoId);

            var url = $"https://www.googleapis.com/youtube/v3/videos?{parameters}";

            var response = await _http.GetFromJsonAsync<Videos>(url);

            return response.Items.FirstOrDefault().Snippet;
        }
    }
}