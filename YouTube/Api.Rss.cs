namespace YouTube
{
    public partial class Api
    {
        public string ChannelRss(string channelId)
        {
            return $"https://www.youtube.com/feeds/videos.xml?channel_id={channelId}";
        }

        public string PlaylistRss(string playlistId)
        {
            return $"https://www.youtube.com/feeds/videos.xml?playlist_id={playlistId}";
        }

        public string UserRss(string userId)
        {
            return $"https://www.youtube.com/feeds/videos.xml?user={userId}";
        }
    }
}