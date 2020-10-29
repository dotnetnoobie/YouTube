using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;
using YouTube.Models;

namespace YouTube
{
    public partial class Api
    {
        public async ValueTask<Subscriptions> Subscriptions(int maxResults = 50, string pageToken = "")
        {
            var data = new List<Item<Subscription>>();

            var response = await GetSubscriptions(50, pageToken);
            data.AddRange(response.Items);

            while (!string.IsNullOrEmpty(response.NextPageToken) && data.Count < maxResults)
            {
                response = await GetSubscriptions(50, response.NextPageToken);

                data.AddRange(response.Items);
            }

            response.Items = data;

            return response;

            async ValueTask<Subscriptions> GetSubscriptions(int maxResults, string pageToken)
            { 
                var parameters = new Parameters(this._apiKey);

                parameters.Add("mine", true);
                parameters.Add("maxResults", maxResults);
                parameters.Add("pageToken", pageToken);

                var url = $"https://www.googleapis.com/youtube/v3/subscriptions?{parameters}";

                return await _http.GetFromJsonAsync<Subscriptions>(url);
            }

        }

        public async ValueTask<Subscriptions> Subscriptions(string channelId, int maxResults = 50, string pageToken = "")
        {
            var data = new List<Item<Subscription>>();

            var response = await GetSubscriptions(channelId, 50, pageToken);
            data.AddRange(response.Items);

            while (!string.IsNullOrEmpty(response.NextPageToken) && data.Count < maxResults)
            {
                response = await GetSubscriptions(channelId, 50, response.NextPageToken);

                data.AddRange(response.Items);
            }

            response.Items = data;

            return response;

            async ValueTask<Subscriptions> GetSubscriptions(string channelId, int maxResults, string pageToken)
            { 
                var parameters = new Parameters(this._apiKey);

                parameters.Add("id", channelId);
                parameters.Add("maxResults", maxResults);
                parameters.Add("pageToken", pageToken);

                var url = $"https://www.googleapis.com/youtube/v3/subscriptions?{parameters}";

                return await _http.GetFromJsonAsync<Subscriptions>(url);
            }

        }
    }
}