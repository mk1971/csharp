using IronBarCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supported_qrcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var MyBarCode = QRCodeWriter.CreateQrCode("https://ironsoftware.com/csharp/barcode/");
            MyBarCode.SaveAsImage("MyBarCode.png");
            MyBarCode.SaveAsGif("MyBarCode.gif");
            MyBarCode.SaveAsHtmlFile("MyBarCode.html");
            MyBarCode.SaveAsJpeg("MyBarCode.jpg");
            MyBarCode.SaveAsPdf("MyBarCode.Pdf");
            MyBarCode.SaveAsPng("MyBarCode.png");
            MyBarCode.SaveAsTiff("MyBarCode.tiff");
            MyBarCode.SaveAsWindowsBitmap("MyBarCode.bmp");
        }
    }
}
