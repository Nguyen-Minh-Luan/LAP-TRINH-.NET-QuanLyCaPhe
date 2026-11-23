using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace QuanLyCaPhe.Utils;

public static class ImageHelper
{
    public static byte[]? ChuyenAnhSangByteArray(Image? img, int maxWidth = 250, int maxHeight = 200)
    {
        if (img == null) return null;

        try
        {
            double tiLeWidth = (double)maxWidth / img.Width;
            double tiLeHeight = (double)maxHeight / img.Height;
            double tiLe = Math.Min(tiLeWidth, tiLeHeight);
            if (tiLe > 1.0) tiLe = 1.0;

            int chieuRongMoi = Math.Max(1, (int)(img.Width * tiLe));
            int chieuCaoMoi = Math.Max(1, (int)(img.Height * tiLe));

            using var bmp = new Bitmap(chieuRongMoi, chieuCaoMoi);
            using (var g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.DrawImage(img, 0, 0, chieuRongMoi, chieuCaoMoi);
            }

            using var ms = new MemoryStream();
            bmp.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }
        catch
        {
            return null;
        }
    }

    public static Image? ChuyenByteArraySangAnh(byte[]? bytes)
    {
        if (bytes == null || bytes.Length == 0) return null;

        try
        {
            using var ms = new MemoryStream(bytes);
            using var img = Image.FromStream(ms);
            return new Bitmap(img);
        }
        catch
        {
            return null;
        }
    }
}
