using System.Net.Http.Json;
using System.Threading.Tasks;
using YouTube.Models;

namespace YouTube
{
    public partial class Api
    {
        public async ValueTask<VideoCategories> VideoCategories()
        { 
            var parameters = new Parameters(this._apiKey);
            parameters.Add("regionCode", "AU");

            var url = $"https://www.googleapis.com/youtube/v3/videoCategories?{parameters}";

            return await _http.GetFromJsonAsync<VideoCategories>(url);
        }
    }
}