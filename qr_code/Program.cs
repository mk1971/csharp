using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronBarCode;

namespace qr_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeneratedBarcode Qrcode = IronBarCode.QRCodeWriter.CreateQrCode("https://ironsoftware.com/csharp/barcode/docs/");
            Qrcode.SaveAsPng("QrCode.png");
        }
    }
}
