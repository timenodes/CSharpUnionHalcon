

namespace Halcon模板匹配.HalconModelSet_Ex
{
    /// <summary>
    /// 匹配缩放模板参数：建议将所有匹配模板的参数都设置
    /// </summary>
    public class FindScaledShapeModel : TemplateBase
    {
        private double angleStart = -180;
        private double angleExtent = 360;
        private double scaleMin = 0.8;              //最小缩放比
        private double scaleMax = 1.2;              //最大缩放比
        private double minScore = 5;
        private double maxOverlap = 0.5;
        private double greediness = 0.9;
        private int numMatches = 0;
        private int numLevels = 2;
        private string subPixel = "least_squares";

        /// <summary>
        /// 起始角度
        /// </summary>
        public double AngleStart { get => angleStart; set => angleStart = value; }
        /// <summary>
        /// 角度范围（大于起始角度，大于1）
        /// </summary>
        public double AngleExtent { get => angleExtent; set => angleExtent = value; }
        /// <summary>
        /// 最小缩放范围
        /// </summary>
        public double ScaleMin { get => scaleMin; set => scaleMin = value; }
        /// <summary>
        /// 最大缩放范围
        /// </summary>
        public double ScaleMax { get => scaleMax; set => scaleMax = value; }
        /// <summary>
        /// 最小分数
        /// </summary>
        public double MinScore { get => minScore; set => minScore = value; }
        /// <summary>
        /// 最大重叠率
        /// </summary>
        public double MaxOverlap { get => maxOverlap; set => maxOverlap = value; }
        /// <summary>
        /// 贪婪度（速度尺度）
        /// </summary>
        public double Greediness { get => greediness; set => greediness = value; }
        /// <summary>
        /// 匹配个数
        /// </summary>
        public int NumMatches { get => numMatches; set => numMatches = value; }
        /// <summary>
        /// 金字塔层数
        /// </summary>
        public int NumLevels { get => numLevels; set => numLevels = value; }
        /// <summary>
        /// 匹配精度
        /// </summary>
        public string SubPixel { get => subPixel; set => subPixel = value; }
    }
}
