using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using YouTube.Models;

namespace YouTube
{
    public interface IApi
    {
        string ChannelRss(string channelId);
        string PlaylistRss(string playlistId);
        string UserRss(string userId);

        //Task<Channels> Channels(string channelId);
        ValueTask<Models.Channel> Channels(string channelId);
        ValueTask<ChannelSections> ChannelSections(string channelId);
        ValueTask<PlaylistItems> PlaylistItems(string playlistId, int maxResults = 50, string pageToken = "");
        ValueTask<Playlists> Playlists(IEnumerable<string> playlistIds, int maxResults = 50, string pageToken = "");
        ValueTask<Playlists> Playlists(string channelId, int maxResults = 50, string pageToken = "");
        ValueTask<Searchs> Search(string q, SearchType searchType = SearchType.channel, int maxResults = 50);
        ValueTask<Subscriptions> Subscriptions(int maxResults = 50, string pageToken = "");
        ValueTask<Subscriptions> Subscriptions(string channelId, int maxResults = 50, string pageToken = "");
        ValueTask<Models.Video> Video(string videoId);
        ValueTask<VideoCategories> VideoCategories();
        ValueTask<VideoInfomation> VideoInfo(string url);
        ValueTask<Videos> Videos(IEnumerable<string> videosIds, int maxResults = 50, string pageToken = "");
    }

    public partial class Api : IApi
    {
        private readonly string _apiKey;
        private readonly HttpClient _http;

        public Api(HttpClient http, string apiKey = null)
        {
            this._http = http;
            if (!string.IsNullOrEmpty(apiKey)) this._apiKey = apiKey;
        }
    }
}




        //public Api(IHttpClientFactory httpClientFactory, IAccessTokenProvider accessTokenProvider)
        //{
        //    this._http = new Lazy<HttpClient>(async()=> {
        //        var tokenResult = await accessTokenProvider.RequestAccessToken();

        //        if (tokenResult.TryGetToken(out var token))
        //        {
        //            var httpClient = httpClientFactory.CreateClient();
        //            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Value);
        //            httpClient.DefaultRequestHeaders.Accept.ParseAdd("application/json");

        //            return httpClient;
        //        }

        //        //this.Api = new YouTube.Api(httpClient);
        //    });
        //}

        //public Api(HttpClient http, string apiKey)
        //{
        //    this._http = http;
        //    if (!string.IsNullOrEmpty(apiKey)) this._apiKey = apiKey;
        //}

        //public Api(HttpClient http, string apiKey = null, string version = "v3")
        //{
        //    this._http = http;
        //    if (!string.IsNullOrEmpty(apiKey)) this._apiKey = apiKey;
        //}