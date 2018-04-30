using CommandLine;

namespace DotnetT4
{
    public class Options
    {
        [Option('i', "image", Default = "t.jpg", HelpText = "Input image file to be processed.")]
        public string ImageFile { get; set; }

        [Option('o', "output", Default = "t.txt", HelpText = "Output file to write.")]
        public string OutputFile { get; set; }
    }
}
