using System.Net.Http.Json;
using System.Threading.Tasks;
using YouTube.Models;

namespace YouTube
{
    public partial class Api
    {
        public async ValueTask<ChannelSections> ChannelSections(string channelId)
        { 
            var parameters = new Parameters(this._apiKey); 
            parameters.Add("id", channelId); 

            var url = $"https://www.googleapis.com/youtube/v3/channelSections?{parameters}";

            return await _http.GetFromJsonAsync<ChannelSections>(url);
        }
    }
}