using System;
using System.Drawing;

namespace CompAndDel.Filters
{
    public class SaveFilter : IFilter
    {
        /// <summary>
        /// Guarda la imagen intermedia entre los filtros
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public IPicture Filter(IPicture image)
        {
            PictureProvider pictureProvider = new PictureProvider();
            pictureProvider.SavePicture(image, "SaveIntermedio.jpg");
            return image;
        }
    }
}