using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace DotnetT4
{
    public partial class RuntimeTextTemplate1 : RuntimeTextTemplate1Base
    {
        public Image<Rgba32> Image { get; }

        public RuntimeTextTemplate1(Image<Rgba32> image)
        {
            Image = image;
        }
    }
}
