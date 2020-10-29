using System.Net.Http.Json;
using System.Threading.Tasks;
using YouTube.Models;

namespace YouTube
{
    public enum SearchType
    {
        channel,
        playlist,
        video
    }

    public enum VideoEmbeddable
    {
        any, @true
    }

    public enum VideoLicense
    {
        any, creativeCommon, youtube
    }

    public enum VideoSyndicated
    {
        any, @true
    }

    public enum VideoType
    {
        any, episode, movie
    }

    public enum VideoDuration
    {
        any, @long, medium, @short
    }

    public enum VideoDimension
    {
        any, TwoD, ThreeD
    }

    public enum VideoDefinition
    {
        any, high, standard
    }

    public enum VideoCaption
    {
        any, closedCaption, none
    }

    public enum SafeSearch
    {
        moderate, none, strict
    }

    public partial class Api
    {
        public async ValueTask<Searchs> Search(string q, SearchType searchType = SearchType.channel, int maxResults = 50)
        {   
            var parameters = new Parameters(this._apiKey);

            parameters.Add("q", q);
            parameters.Add("type", searchType.ToString());
            parameters.Add("maxResults", 50);
            // parameters.Add("part", "snippet");
            // parameters.Add("videoEmbeddable", videoEmbeddable.ToString());
            // parameters.Add("fields", "items(id,snippet(customUrl,thumbnails,title,description))");
            // parameters.Add("key", apiKey);
             
            var url = $"https://www.googleapis.com/youtube/v3/search?{parameters}";

            return await _http.GetFromJsonAsync<Searchs>(url);
        }
    }
}