using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;
using YouTube.Models;

namespace YouTube
{
    public partial class Api
    {
        public async ValueTask<Playlists> Playlists(string channelId, int maxResults = 50, string pageToken = "")
        {
            var data = new List<Item<Playlist>>();

            var response = await GetPlaylists(channelId, 50, null);
            data.AddRange(response.Items);

            while (!string.IsNullOrEmpty(response.NextPageToken) && data.Count < maxResults)
            {
                response = await GetPlaylists(channelId, 50, response.NextPageToken);

                data.AddRange(response.Items);
            }

            response.Items = data;

            return response;

            async ValueTask<Playlists> GetPlaylists(string channelId, int maxResults = 50, string pageToken = "")
            { 
                var parameters = new Parameters(this._apiKey);

                parameters.Add("channelId", channelId);
                parameters.Add("maxResults", maxResults);
                if (!string.IsNullOrEmpty(pageToken)) parameters.Add("pageToken", pageToken);

                var url = $"https://www.googleapis.com/youtube/v3/playlists?{parameters}";

                return await _http.GetFromJsonAsync<Playlists>(url);
            }
        }

        public async ValueTask<Playlists> Playlists(IEnumerable<string> playlistIds, int maxResults = 50, string pageToken = "")
        {
            var data = new List<Item<Playlist>>();

            var response = await GetPlaylists(playlistIds, 50, null);
            data.AddRange(response.Items);

            while (!string.IsNullOrEmpty(response.NextPageToken) && data.Count < maxResults)
            {
                response = await GetPlaylists(playlistIds, 50, response.NextPageToken);

                data.AddRange(response.Items);
            }

            response.Items = data;

            return response;

            async ValueTask<Playlists> GetPlaylists(IEnumerable<string> playlistIds, int maxResults = 50, string pageToken = "")
            { 
                var parameters = new Parameters(this._apiKey);

                parameters.Add("id", string.Join(",", playlistIds));
                parameters.Add("maxResults", maxResults);
                if (!string.IsNullOrEmpty(pageToken)) parameters.Add("pageToken", pageToken);

                var url = $"https://www.googleapis.com/youtube/v3/playlists?{parameters}";

                return await _http.GetFromJsonAsync<Playlists>(url);
            }
        }
    }
}