
using HalconDotNet;
using System.Drawing;
using System;
using System.Drawing.Imaging;
using System.IO;

namespace Halcon模板匹配
{
    /// <summary>
    /// 图像转换类
    /// </summary>
    public class ImageFormatTools
    {
        #region 判断图像的正确格式
        /// <summary>
        /// 图像格式工具：获取正确的图像格式，通过图像文件的二进制头部图像格式标识。
        /// </summary>
        public static ImageFormat GetImageFormat(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    // 读取文件的前几个字节
                    byte[] headerBytes = br.ReadBytes(16);

                    // 根据文件的前几个字节判断图像的实际格式
                    if (IsJpeg(headerBytes))
                    {
                        return ImageFormat.Jpeg;
                    }
                    else if (IsPng(headerBytes))
                    {
                        return ImageFormat.Png;
                    }
                    else if (IsGif(headerBytes))
                    {
                        return ImageFormat.Gif;
                    }
                    else if (IsBmp(headerBytes))
                    {
                        return ImageFormat.Bmp;
                    }
                    else
                    {
                        // 默认返回未知格式
                        return null;
                    }
                }
            }
        }

        /// <summary>
        /// 判断是否为 Jpeg 图像
        /// </summary>
        private static bool IsJpeg(byte[] headerBytes)
        {
            // JPEG 文件的前两个字节是 0xFF, 0xD8
            return headerBytes.Length >= 2 && headerBytes[0] == 0xFF && headerBytes[1] == 0xD8;
        }
        /// <summary>
        /// 判断是否为 Png 图像
        /// </summary>
        private static bool IsPng(byte[] headerBytes)
        {
            // PNG 文件的前八个字节是固定的签名：137 80 78 71 13 10 26 10
            return headerBytes.Length >= 8 && headerBytes[0] == 137
                    && headerBytes[1] == 80 && headerBytes[2] == 78
                    && headerBytes[3] == 71 && headerBytes[4] == 13
                    && headerBytes[5] == 10 && headerBytes[6] == 26
                    && headerBytes[7] == 10;
        }

        /// <summary>
        /// 判断是否为 gif 图像
        /// </summary>
        private static bool IsGif(byte[] headerBytes)
        {
            // GIF 文件的前三个字节是 "GIF"
            return headerBytes.Length >= 3 && headerBytes[0] == 71
                    && headerBytes[1] == 73 && headerBytes[2] == 70;
        }

        /// <summary>
        /// 判断是否为 bmp 图像
        /// </summary>
        private static bool IsBmp(byte[] headerBytes)
        {
            // BMP 文件的前两个字节是 "BM"
            return headerBytes.Length >= 2 && headerBytes[0] == 66
                && headerBytes[1] == 77;
        }
        #endregion

        /// <summary>
        /// 获取图像通道数、图像像素格式。
        /// </summary>
        public static int GetImageChannelCount(string imagePath ,out Bitmap bitmap,out PixelFormat format)
        {
            try
            {
                Image image = Image.FromFile(imagePath);
                bitmap = new Bitmap(image);
                format = bitmap.PixelFormat;  // 获取图像像素格式
                image.Dispose();       
                switch (format)//据PixelFormat判断通道数
                {
                    case PixelFormat.Format8bppIndexed: // 灰度图
                        return 1;
                    case PixelFormat.Format24bppRgb: // RGB图
                        return 3;
                    case PixelFormat.Format32bppRgb: // 
                    case PixelFormat.Format32bppArgb: // RGBA图 RGB + Alpha
                        return 4;
                    default:
                        return -1;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"获取图像通道数->参数异常：{ex.Message}");
            }
        }

        /// <summary>
        /// 读取图像，并返回读取信息：输入图像路径，返回HImage图像（8，24，32位（1，3，4通道））
        /// </summary>
        public static void ReadImage(string path,out HImage hImage,out string info)
        {
            hImage = new HImage();
            info = null;
            GetImageChannelCount(path, out Bitmap bitmap, out PixelFormat pixelFormat);
            ImageFormat imageFormat = GetImageFormat(path);
            switch (pixelFormat)
            {
                case PixelFormat.Format8bppIndexed: //8位单通道
                    try
                    {
                        hImage.ReadImage(path);
                    }
                    catch (Exception ex)
                    {
                        BitmapToHImageBpp8(bitmap, out hImage);
                        info = $"图像原格式：{imageFormat}，当前后缀：{Path.GetExtension(path)}： {ex.Message}";
                    }
                    break;
                case PixelFormat.Format24bppRgb://24位3通道
                    try
                    {
                        hImage.ReadImage(path);
                    }
                    catch (Exception ex)
                    {
                        BitmapToHImageBpp24(bitmap, out hImage);
                        info = $"图像原格式：{imageFormat}，当前后缀：{Path.GetExtension(path)}： {ex.Message}";
                    }
                    break;
                case PixelFormat.Format32bppRgb://32位3通道
                case PixelFormat.Format32bppArgb://32位4通道
                    try
                    {
                        hImage.ReadImage(path);
                    }
                    catch (Exception ex)
                    {
                        BitmapToHImageBpp32(bitmap, out hImage, pixelFormat);
                        info = $"图像原格式：{imageFormat}，当前后缀：{Path.GetExtension(path)}： {ex.Message}";
                    }
                    break;

                default: //8位单通道
                    try
                    {
                        hImage.ReadImage(path);
                    }
                    catch (Exception ex)
                    {
                        BitmapToHImageBpp8(bitmap, out hImage);
                        info = $"图像原格式：{imageFormat}，当前后缀：{Path.GetExtension(path)}： {ex.Message}";
                    }
                    break;
            }
        }
        ///<summary>
        /// Bitmap转HImage(24位3通道)
        /// </summary>
        public static void BitmapToHImageBpp24(Bitmap bmp, out HImage image)
        {
            try
            {
                image = new HImage();
                Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                BitmapData srcBmpData = bmp.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                image.GenImageInterleaved(srcBmpData.Scan0, "rgb", bmp.Width, bmp.Height, 0, "byte", bmp.Width, bmp.Height, 0, 0, -1, 0);
                bmp.UnlockBits(srcBmpData);
            }
            catch (Exception ex)
            {
                image = null;
            }
        }

        ///<summary>
        /// Bitmap转HImage(32位4通道)
        /// </summary>
        public static void BitmapToHImageBpp32(Bitmap bmp, out HImage image, PixelFormat pixelFormat)
        {
            try
            {
                image = new HImage();
                Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                BitmapData srcBmpData = bmp.LockBits(rect, ImageLockMode.ReadOnly, pixelFormat);
                image.GenImageInterleaved(srcBmpData.Scan0, "bgrx", bmp.Width, bmp.Height, 0, "byte", bmp.Width, bmp.Height, 0, 0, -1, 0);
                bmp.UnlockBits(srcBmpData);
            }
            catch (Exception ex)
            {
                image = null;
            }
        }
        /// <summary>
        /// Bitmap转HImage(8位单通道)
        /// </summary>
        public static void BitmapToHImageBpp8(Bitmap bmp,out HImage image)
        {
            try
            {
                image = new HImage();
                Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                BitmapData srcBmpData = bmp.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);
                image.GenImage1("byte", bmp.Width, bmp.Height, srcBmpData.Scan0);
                bmp.UnlockBits(srcBmpData);
            }
            catch (Exception ex)
            {
                image = null;
            }
        }
    }
}
