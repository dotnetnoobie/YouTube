using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using YouTube.Models;

namespace YouTube
{
    public partial class Api
    {
        public async ValueTask<Channel> Channels(string channelId)
        { 
            var parameters = new Parameters(this._apiKey);
            parameters.Add("id", channelId);

            var url = $"https://www.googleapis.com/youtube/v3/channels?{parameters}";

            // return await _http.GetFromJsonAsync<Channels>(url);

            var response = await _http.GetFromJsonAsync<Channels>(url);

            return response.Items.FirstOrDefault().Snippet;
        }
    }
}