using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;
using Path = System.IO.Path;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ej. 1:

            PictureProvider pictureProvider = new PictureProvider();
            IPicture picture = pictureProvider.GetPicture(@"luke.jpg");
            IFilter greyscale = new FilterGreyscale();
            IFilter negative = new FilterNegative();
            IPipe pipeN = new PipeNull();
            IPipe pipeNegative = new PipeSerial(negative, pipeN);
            IPicture imageNegative = pipeNegative.Send(picture);
            IPipe pipeGrey = new PipeSerial(greyscale, pipeNegative);
            IPicture image = pipeGrey.Send(imageNegative);
            PictureProvider provider = new PictureProvider();
            provider.SavePicture(image, @"luke2.jpg");
        }
    }
}