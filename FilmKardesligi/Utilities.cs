using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmKardesligi
{
    public static class Utilities
    {
        public static string Yildizla(int derece)
        {

            return new string('\x2605', derece) + new string('\x2606', 5 - derece);

        }
        public static string Virgulle(this IEnumerable<string> kaynak)
        {
            return string.Join(", ", kaynak);
        }

        public static byte[] ImageToByteArray(Image image)
        {
            return (byte[])new ImageConverter().ConvertTo(image, typeof(byte[]));
        }

        public static Image ByteArrayToImage(byte[] jpegByteArray)
        {
            return (Bitmap)new ImageConverter().ConvertFrom(jpegByteArray);
        }
    }
}
