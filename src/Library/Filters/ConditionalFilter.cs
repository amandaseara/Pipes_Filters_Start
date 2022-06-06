using System;
using System.Drawing;
using CognitiveCoreUCU;

namespace CompAndDel.Filters
{
    public class ConditionalFilter : IFilter
    {
        public IPicture Filter(IPicture image)
        {
            PictureProvider provider = new PictureProvider();
            provider.SavePicture(image, @"Face");

            CognitiveFace cog = new CognitiveFace();
            cog.Recognize(@"face");
            bool face = cog.FaceFound;
            
            return image;
        }
    }
}