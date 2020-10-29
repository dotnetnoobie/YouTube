using System.Collections.Generic;
using System.Linq;

namespace YouTube
{
    public class Parameters : Dictionary<string, object>
    {
        public Parameters(string apiKey = null)
        {
            if (!string.IsNullOrEmpty(apiKey)) this.Add("key", apiKey);
            this.Add("part", "snippet");
            this.Add("prettyPrint", false);
        }

        public override string ToString()
        {
            return string.Join("&", this
                .Where(p => !string.IsNullOrEmpty(p.Key) && !string.IsNullOrEmpty(p.Value?.ToString()))
                .Select(p => $"{p.Key}={p.Value}"));
        }
    }
}