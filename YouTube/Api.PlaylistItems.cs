using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;
using YouTube.Models;

namespace YouTube
{
    public partial class Api
    {
        public async ValueTask<PlaylistItems> PlaylistItems(string playlistId, int maxResults = 50, string pageToken = "")
        {
            var data = new List<Item<PlaylistItem>>();

            var response = await GetPlaylistItems(playlistId, 50, pageToken);
            data.AddRange(response.Items);

            while (!string.IsNullOrEmpty(response.NextPageToken) && data.Count < maxResults)
            {
                response = await GetPlaylistItems(playlistId, 50, response.NextPageToken);

                data.AddRange(response.Items);
            }

            response.Items = data;

            return response;

            async ValueTask<PlaylistItems> GetPlaylistItems(string playlistId, int maxResults = 50, string pageToken = "")
            { 
                var parameters = new Parameters(this._apiKey); 
                parameters.Add("playlistId", playlistId);
                parameters.Add("maxResults", maxResults);
                if (!string.IsNullOrEmpty(pageToken)) parameters.Add("pageToken", pageToken);

                var url = $"https://www.googleapis.com/youtube/v3/playlistItems?{parameters}";

                return await _http.GetFromJsonAsync<PlaylistItems>(url);
            }
        }
    }
} 