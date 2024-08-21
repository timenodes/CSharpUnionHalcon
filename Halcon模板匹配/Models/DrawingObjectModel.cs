using HalconDotNet;

namespace Halcon模板匹配.Models
{
    /// <summary>
    /// 绘制对象（ROI）模型
    /// </summary>
    public class DrawingObjectModel
    {
        /// <summary>
        /// 绘制对象（ROI）参数
        /// </summary>
        public HTuple[] RoiParams {  get; set; }

        /// <summary>
        /// 绘制对象（ROI）类型
        /// </summary>
        public RoiTypeModel RoiType { get; set; }

        /// <summary>
        /// 绘制对象（ROI）对象
        /// </summary>
        public HDrawingObject DrawObject { get; set; }

        /// <summary>
        /// 绘制对象（ROI）ID
        /// </summary>
        public HTuple DrawID { get; set; }

        /// <summary>
        /// 绘制对象（ROI）执行操作
        /// </summary>
        public RoiOperateModel Operate { get; set; }
        public DrawingObjectModel(RoiTypeModel roiType, HDrawingObject drawObj, HTuple drawID ,HTuple[] roiParams)
        {
            this.RoiParams = roiParams;
            this.RoiType = roiType;
            this.DrawObject = drawObj;
            this.DrawID = drawID;
            this.Operate = RoiOperateModel.None;
        }
        public DrawingObjectModel(RoiOperateModel Operate, HTuple drawID)
        {
            this.Operate = Operate;
            this.DrawID = drawID;
        }
    }
}
