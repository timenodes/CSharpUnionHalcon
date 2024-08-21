
namespace Halcon模板匹配.HalconModelSet_Ex
{
    /// <summary>
    /// 模板基类
    /// </summary>
    public abstract class TemplateBase
    {
        private int modelCreatingMethod =0;             //模板创建方式：0默认缩放模板
        private int numLevels = 2;                      //金字塔层数
        private double angleStart = -180;               //起始角度
        private double angleExtent = 360;               //角度范围
        private double angleStep = 0;                   //角度步长
        private double scaleMin = 0.8;                  //最小缩放比
        private double scaleMax = 1.2;                  //最大缩放比
        private double scaleStep = 0.01;                //缩放步长
        private string optimization = "auto";           //模板优化
        private string metric = "use_polarity";         //匹配方法
        private int contrast = 30;                      //对比度
        private int minContrast = 10;                   //最小对比度

        /// <summary>
        /// 金字塔层数
        /// </summary>
        public int NumLevels { get => numLevels; set => numLevels = value; }

        /// <summary>
        /// 起始角度
        /// </summary>
        public double AngleStart { get => angleStart; set => angleStart = value; }

        /// <summary>
        /// 角度范围
        /// </summary>
        public double AngleExtent { get => angleExtent; set => angleExtent = value; }

        /// <summary>
        /// 角度步长
        /// </summary>
        public double AngleStep { get => angleStep; set => angleStep = value; }

        /// <summary>
        /// 最小缩放比
        /// </summary>
        public double ScaleMin { get => scaleMin; set => scaleMin = value; }

        /// <summary>
        /// 最大缩放比
        /// </summary>
        public double ScaleMax { get => scaleMax; set => scaleMax = value; }


        /// <summary>
        /// 缩放步长
        /// </summary>
        public double ScaleStep { get => scaleStep; set => scaleStep = value; }

        /// <summary>
        /// 模板优化
        /// </summary>
        public string Optimization { get => optimization; set => optimization = value; }

        /// <summary>
        /// 匹配方法
        /// </summary>
        public string Metric { get => metric; set => metric = value; }
        /// <summary>
        /// 对比度
        /// </summary>
        public int Contrast { get => contrast; set => contrast = value; }

        /// <summary>
        /// 最小对比度
        /// </summary>
        public int MinContrast { get => minContrast; set => minContrast = value; }
        /// <summary>
        /// 模板创建方式
        /// </summary>
        public int ModelCreatingMethod { get => modelCreatingMethod; set => modelCreatingMethod = value; }
    }
}
