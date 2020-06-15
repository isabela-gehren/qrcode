using System;
using System.IO;
using ZXing.QrCode;

namespace AppQrCode
{
    public class GenerateQRText
    {
        public static void Generate(string QrcodeContent, string fileName)
        {
            // Tamanho da imagem
            var width = 250; // width of the Qr Code
            var height = 250; // height of the Qr Code
            var margin = 0;

            // Configurando o QR Code 
            var qrCodeWriter = new ZXing.BarcodeWriterPixelData
            {
                Format = ZXing.BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions { Height = height, Width = width, Margin = margin }
            };
            // Gerando o QR Code
            var pixelData = qrCodeWriter.Write(QrcodeContent);


            using (var bitmap = new System.Drawing.Bitmap(pixelData.Width, pixelData.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb))
            using (var ms = new MemoryStream())
            {
                var bitmapData = bitmap.LockBits(new System.Drawing.Rectangle(0, 0, pixelData.Width, pixelData.Height),
                System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
                try
                {
                    // assumimos que o passo da linha do bitmap está alinhado com 4 bytes multiplicado pela largura da imagem
                    System.Runtime.InteropServices.Marshal.Copy(pixelData.Pixels, 0, bitmapData.Scan0,
                    pixelData.Pixels.Length);
                }
                finally
                {
                    bitmap.UnlockBits(bitmapData);
                }
                // salvar para transmitir como PNG
                bitmap.Save(AppDomain.CurrentDomain.BaseDirectory + $"\\{fileName}.PNG", System.Drawing.Imaging.ImageFormat.Png);
            }
        }
    }
}
