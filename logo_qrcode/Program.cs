using IronBarCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logo_qrcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var MyQRWithLogo = QRCodeWriter.CreateQrCodeWithLogo("https://ironsoftware.com/csharp/barcode/", "CSharp-logo.png", 500);
            MyQRWithLogo.SaveAsPng("Qr-Code-with-logo.png");
        }
    }
}
