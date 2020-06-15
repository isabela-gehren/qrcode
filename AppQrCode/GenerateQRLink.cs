using QRCoder;
using System;
using System.Drawing;

namespace AppQrCode
{
    public class GenerateQRLink
    {
        public static void Generate(string url, string fileName)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            qrCodeImage.Save(AppDomain.CurrentDomain.BaseDirectory + $"\\{fileName}.PNG", System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}