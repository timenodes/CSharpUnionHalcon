
namespace Halcon模板匹配.Models
{
    /// <summary>
    /// ROI类型枚举模型
    /// </summary>
    public enum RoiTypeModel
    {
        
        /// <summary>
        /// 矩形
        /// </summary>
        RECTANGLE1,
        /// <summary>
        /// 方向矩形
        /// </summary>
        RECTANGLE2,
        /// <summary>
        /// 圆
        /// </summary>
        CIRCLE,
        /// <summary>
        /// 椭圆
        /// </summary>
        ELLIPSE,
        /// <summary>
        /// 圆扇
        /// </summary>
        CIRCLE_SECTOR,
        /// <summary>
        /// 椭圆扇
        /// </summary>
        ELLIPSE_SECTOR,
        /// <summary>
        /// 线
        /// </summary>
        LINE,
        /// <summary>
        /// 轮廓
        /// </summary>
        XLD_CONTOUR,
        /// <summary>
        /// 文本
        /// </summary>
        TEXT,
        /// <summary>
        /// 没有返回,放最后面，否则转换时报错
        /// </summary>
        NONE,

    }
}
