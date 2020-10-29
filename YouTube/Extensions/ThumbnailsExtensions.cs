using YouTube.Models;

namespace YouTube
{
    public static class ThumbnailExtensions
    {
        public static Thumbnail Largest(this Thumbnails thumbnails)
        {
            if (thumbnails.Maxres != null)
            {
                return thumbnails.Maxres;
            }
            if (thumbnails.Standard != null)
            {
                return thumbnails.Standard;
            }
            if (thumbnails.High != null)
            {
                return thumbnails.High;
            }
            if (thumbnails.Medium != null)
            {
                return thumbnails.Medium;
            }

            return thumbnails.Default;
        }

        public static Thumbnail Smallest(this Thumbnails thumbnails)
        {
            if (thumbnails.Default != null)
            {
                return thumbnails.Default;
            }
            if (thumbnails.Medium != null)
            {
                return thumbnails.Medium;
            }
            if (thumbnails.High != null)
            {
                return thumbnails.High;
            }
            if (thumbnails.Standard != null)
            {
                return thumbnails.Standard;
            }

            return thumbnails.Maxres;
        }
    }
}