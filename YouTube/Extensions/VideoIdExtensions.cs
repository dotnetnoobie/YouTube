using System.Linq;
using System.Text.RegularExpressions;

namespace YouTube
{
    public static class VideoIdExtensions
    {
        private const string YoutubeLinkRegex = "(?:.+?)?(?:\\/v\\/|watch\\/|\\?v=|\\&v=|youtu\\.be\\/|\\/v=|^youtu\\.be\\/)([a-zA-Z0-9_-]{11})+";

        internal static string GetVideoId(this string input)
        {
            var regex = new Regex(YoutubeLinkRegex, RegexOptions.Compiled);
            foreach (Match match in regex.Matches(input))
            {
                var groups = match.Groups.Cast<Group>()
                            .Where(groupdata => !groupdata.ToString().StartsWith("http://")
                                                && !groupdata.ToString().StartsWith("https://")
                                                && !groupdata.ToString().StartsWith("youtu")
                                                && !groupdata.ToString().StartsWith("www."));
         
                foreach (var groupdata in groups)
                {
                    return groupdata.ToString();
                }
            }

            return null;
        }
    }
}
