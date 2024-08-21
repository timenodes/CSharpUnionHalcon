
namespace Halcon模板匹配.Models
{
    /// <summary>
    /// ROI绘制形状参数模型：获取对应形状的参数值时使用
    /// </summary>
    public class DrawObjectParamModel
    {
        /// <summary>
        /// 圆形参数
        /// </summary>
        public readonly static string[] CIRCLE = { "row", "column", "radius" };
        /// <summary>
        /// 椭圆参数
        /// </summary>
        public readonly static string[] ELLIPSE = { "row", "column", "phi", "radius1", "radius2" };
        /// <summary>
        /// 矩形1参数
        /// </summary>
        public readonly static string[] RECT1 = { "row1", "column1", "row2", "column2" };
        /// <summary>
        /// 矩形2参数
        /// </summary>
        public readonly static string[] RECT2 = { "row", "column", "phi", "length1", "length2" };
    }
}
