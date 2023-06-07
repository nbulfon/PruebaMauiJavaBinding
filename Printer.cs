using Android.Graphics;
using Com.Marcomaldonado.Sunmiv2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMauiJavaBinding
{
    public class Printer 
        //: IPrinter
    {
        private SunmiPrinter sunmi = SunmiPrinter.Instance;

        public void PrintImage(byte[] bitmap)
        {
            var _bitmap = BitmapFactory.DecodeByteArray(bitmap, 0, bitmap.Length);
            sunmi.PrintBitmap(_bitmap, null);
        }

        public void PrintText(string text)
        {
            sunmi.PrintText(text, null);
        }
    }
    //public interface IPrinter
    //{
    //    public void PrintText(string text);
    //    public void PrintImage(byte[] image);
    //}
}
