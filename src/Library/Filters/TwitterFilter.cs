using System;
using System.Drawing;
using TwitterUCU;

namespace CompAndDel.Filters
{
    public class TwitterFilter : IFilter
    {
        /// <summary>
        /// Publica la imagen en twitter
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public IPicture Filter(IPicture image)
        {
            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter("NewImage", @$"luke2.jpg"));
            return image;
        }
    }
}