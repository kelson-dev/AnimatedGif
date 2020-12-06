using System.Drawing;
using AnimatedGif;

namespace AnimatedGif.Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 33ms delay (~30fps)
            using var gif = AnimatedGif.Create("gif.gif", 33);
            var img1 = Image.FromFile("Img1.png");
            gif.AddFrame(img1, delay: -1, quality: GifQuality.Bit8);
            var img2 = Image.FromFile("Img2.png");
            gif.AddFrame(img2, delay: -1, quality: GifQuality.Bit8);
            var img3 = Image.FromFile("Img3.png");
            gif.AddFrame(img3, delay: -1, quality: GifQuality.Bit8);
        }
    }
}
