using CommandLine;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using System;

namespace DotnetT4
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandLine.Parser.Default.ParseArguments<Options>(args)
               .WithParsed<Options>(opts => RunOptions(opts));
        }

        static void RunOptions(Options options)
        {
            using (Image<Rgba32> image = Image.Load(options.ImageFile))
            {
                RuntimeTextTemplate1 t = new RuntimeTextTemplate1(image);
                string text = t.TransformText();
                System.IO.File.WriteAllText(options.OutputFile, text);
                Console.WriteLine(text);
            }
        }
    }
}
