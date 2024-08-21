using HalconDotNet;
using System;

namespace Halcon模板匹配.Models
{
    public class ImageModel: ModelsBase
    {
        /// <summary>
        /// 图像ID
        /// </summary>
        public Int64 ID {  get; set; }
        /// <summary>
        /// 图像文件名（路径）
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 图像目录
        /// </summary>
        public string Directory { get; set; }
        /// <summary>
        /// 原图
        /// </summary>
        public HImage SourceImage { get; set; }
        /// <summary>
        /// 灰度图
        /// </summary>
        public HImage GrayImage { get; set; }
    }
}
