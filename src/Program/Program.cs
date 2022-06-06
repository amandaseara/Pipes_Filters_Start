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

            /*
            int i = 1;
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"luke.jpg");

            IFilter greyscale = new FilterGreyscale();
            IFilter negative = new FilterNegative();
            IPipe pipeN = new PipeNull();

            IPipe pipeNegative = new PipeSerial(negative, pipeN);
            IPicture imageNegative = pipeNegative.Send(picture);

            IPipe pipeGrey = new PipeSerial(greyscale, pipeNegative);
            IPicture image = pipeGrey.Send(imageNegative);

            provider.SavePicture(image, @$"luke{i}.jpg");
            i = i + 1;*/

            //Ej. 2:

            /*int i = 1;
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"beer.jpg");

            IFilter greyscale = new FilterGreyscale();
            IFilter negative = new FilterNegative();
            IFilter save = new SaveFilter();
            IPipe pipeN = new PipeNull();

            IPipe pipeNegative = new PipeSerial(negative, pipeN);
            IPipe pipeSave = new PipeSerial(save, pipeNegative);
            IPipe pipeGrey = new PipeSerial(greyscale, pipeSave);

            IPicture picture2 = pipeGrey.Send(picture);
            provider.SavePicture(picture2, @$"beer{i}.jpg");
            i = i + 1;*/

            //Ej. 3:

            /*int i = 1;
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"luke.jpg");

            IFilter greyscale = new FilterGreyscale();
            IFilter negative = new FilterNegative();
            IFilter save = new SaveFilter();
            IFilter tw = new TwitterFilter();
            IPipe pipeN = new PipeNull();

            IPipe pipeTw = new PipeSerial(tw, pipeN);
            IPipe pipeNegative = new PipeSerial(negative, pipeTw);
            IPipe pipeSave = new PipeSerial(save, pipeNegative);
            IPipe pipeGrey = new PipeSerial(greyscale, pipeSave);

            IPicture picture2 = pipeGrey.Send(picture);
            provider.SavePicture(picture2, @$"luke{i}.jpg");
            i = i + 1; */

            //Ej. 4: NO TERMINADO

            /*PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"luke.jpg");
            IPicture picture2 = provider.GetPicture(@"beer.jpg");*/

            
        }
    }
}