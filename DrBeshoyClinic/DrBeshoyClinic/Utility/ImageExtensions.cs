using System.Drawing;
using System.IO;

namespace DrBeshoyClinic.Utility
{
    public static class ImageExtensions
    {
        public static Image ToImage(this byte[] bytes)
        {
            using (var ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }
    }
}