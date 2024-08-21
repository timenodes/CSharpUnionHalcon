using HalconDotNet;
using Halcon模板匹配.HalconModelSet_Ex;
using Halcon模板匹配.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Halcon模板匹配.HalconTools
{
    public class RoiTools
    {
        #region 事件定义、声明、绑定
        /// <summary>
        /// 消息更新事件
        /// </summary>
        public event EventHandler<string> MessageUpdateEvents;
        /// <summary>
        /// 绘制对象（ROI）变更事件
        /// </summary>
        public event EventHandler<DrawingObjectModel> DrawObjectChangedEvents;

        /// <summary>
        /// 取消所有事件绑定
        /// </summary>
        public void UnEventBinding()
        {
            MessageUpdateEvents = null;
            DrawObjectChangedEvents = null;
        }
        #endregion

        #region 字段、属性、集合
        //ROI模型集合
        private List<DrawingObjectModel> _roiList = new List<DrawingObjectModel>();
        /// <summary>
        /// ROI模型集合
        /// </summary>
        public List<DrawingObjectModel> RoiList
        {
            get => _roiList;
            private set => _roiList = value;
        }
        #endregion

        #region ROI添加、删除
        /// <summary>
        /// 绘制ROI:根据ROI类型，绘制ROI到指定窗体ID
        /// </summary>
        public void DrawROI(RoiTypeModel type, HWindow windowID)
        {
            HTuple[] param;
            HOperatorSet.SetColor(windowID, "blue");
            HOperatorSet.SetLineWidth(windowID, 1);
            switch (type)
            {
                case RoiTypeModel.RECTANGLE1:
                    param = new HTuple[] { 100, 100, 200, 200 };
                    GenROI(type, param, windowID);
                    break;
                case RoiTypeModel.RECTANGLE2:
                    param = new HTuple[] { 200, 200, 0, 100, 100 };
                    GenROI(type, param, windowID);
                    break;
                case RoiTypeModel.CIRCLE:
                    param = new HTuple[] { 100, 100, 100 };
                    GenROI(type, param, windowID);
                    break;
                case RoiTypeModel.ELLIPSE:
                    param = new HTuple[] { 100, 100, 50, 50, 50 };
                    GenROI(type, param, windowID);
                    break;
                case RoiTypeModel.CIRCLE_SECTOR:
                    break;
                case RoiTypeModel.ELLIPSE_SECTOR:
                    break;
                case RoiTypeModel.LINE:
                    break;
                case RoiTypeModel.XLD_CONTOUR:
                    param = new HTuple[] { 200, 200 };
                    param[0].Append(new HTuple(100, 200));
                    param[1].Append(new HTuple(300, 300));
                    GenROI(type, param, windowID);
                    break;
                case RoiTypeModel.TEXT:
                    break;
                default:
                    param = new HTuple[] { 100, 100, 200, 200 };
                    GenROI(type, param, windowID);
                    break;
            }
        }

        /// <summary>
        /// 移除ROI对象: 移除指定窗体上的指定ROI句柄。
        /// </summary>
        public void DetachtROI(HWindow windowID, Int64 drawID)
        {
            var drawObj = RoiList.FirstOrDefault(drawobj => drawobj.DrawID == drawID);
            if (drawObj != null)
            {
                HOperatorSet.DetachDrawingObjectFromWindow(windowID, drawObj.DrawObject);
                RoiList.Remove(drawObj);
                OnDrawObjectChangedEvents(new DrawingObjectModel(RoiOperateModel.删除, drawID));
            }
        }

        /// <summary>
        /// 重新加载ROI
        /// </summary>
        public void ReAttachROI(HWindow windowID, Int64 drawID)
        {
            var drawObj = RoiList.FirstOrDefault(drawobj => drawobj.DrawID == drawID);
            if (drawObj != null)
            {
                HOperatorSet.AttachDrawingObjectToWindow(windowID, drawObj.DrawObject);
                OnDrawObjectChangedEvents(new DrawingObjectModel(RoiOperateModel.重画, drawID));
            }
        }
        /// <summary>
        /// 生成ROI：根据ROI类型和ROI参数，在指定窗体中生成ROI
        /// </summary>
        public void GenROI(RoiTypeModel type, HTuple[] param, HWindow windowID)
        {
            if (RoiList.Count < 10)
            {
                HDrawingObject hDrawObject;
                if (type == RoiTypeModel.XLD_CONTOUR)
                {
                    HOperatorSet.CreateDrawingObjectXld(param[0], param[1], out HTuple drawID);
                    hDrawObject = new HDrawingObject(drawID.H);
                }
                else
                {
                    hDrawObject = CreateROIObject(type, param);
                }
                ///绑定事件：ROI：拖拽、调整大小、解除附加、选中
                hDrawObject.OnDrag(OnDragDrawObjectCallback);
                hDrawObject.OnResize(OnResizeDrawObjectCallback);
                hDrawObject.OnDetach(OnDetachDrawObjectCallback);
                hDrawObject.OnSelect(OnSelectDrawObjectCallback);
                
                //创建并实例化绘制模型对象
                DrawingObjectModel drawModelObject = new DrawingObjectModel(type, hDrawObject, hDrawObject.ID, param);
                drawModelObject.Operate = RoiOperateModel.添加;
                ///添加到集合
                RoiList.Add(drawModelObject);
                //附加对象到窗体
                HOperatorSet.AttachDrawingObjectToWindow(windowID, hDrawObject);

                //打印日志
                OnMessageUpdateEvents($"添加一个{type}ROI：ID = [{hDrawObject.ID}]");
                OnDrawObjectChangedEvents(drawModelObject);
            }
            else
            {
                OnMessageUpdateEvents($"添加矩形ROI失败,最多创建10个，当前个数：{RoiList.Count}");
            }
        }

        /// <summary>
        /// 创建ROI对象：根据ROI类型及参数，返回一个ROI(Halcon 绘制)对象。
        /// </summary>
        public HDrawingObject CreateROIObject(RoiTypeModel type,  HTuple[] param)
        {
            return HDrawingObject.CreateDrawingObject(EnumConvert(type), param);
        }

        /// <summary>
        /// 枚举转换：传入自定义ROI类型，转换成Halcon的ROI类型（Halcon的调用太长了...）。
        /// </summary>
        private HDrawingObject.HDrawingObjectType EnumConvert(RoiTypeModel type)
        {
            return (HDrawingObject.HDrawingObjectType)type;
        }
        #endregion

        #region 获取ROI参数
        /// <summary>
        /// 获取ROI参数：输入：绘制对象，ROI类型; 输出：ROI参数结果，ROI形状。
        /// </summary>
        public void GetROIParams(HDrawingObject drawingObject, RoiTypeModel roiType,
            out double[] RoiShapeParamResult, out HObject RoiShapeObj)
        {
            HTuple paramName = new HTuple();
            HTuple paramValue = new HTuple();
            switch (roiType)
            {
                case RoiTypeModel.RECTANGLE1:  //矩形1
                    paramName = DrawObjectParamModel.RECT1;
                    paramValue = drawingObject.GetDrawingObjectParams(paramName);
                    HOperatorSet.GenRectangle1(out RoiShapeObj, paramValue.DArr[0], paramValue.DArr[1], paramValue.DArr[2], paramValue.DArr[3]);
                    RoiShapeParamResult = paramValue.DArr;
                    break;
                case RoiTypeModel.RECTANGLE2:  //方向矩形
                    paramName = DrawObjectParamModel.RECT2;
                    paramValue = drawingObject.GetDrawingObjectParams(paramName);
                    HOperatorSet.GenRectangle2(out RoiShapeObj, paramValue.DArr[0], paramValue.DArr[1], paramValue.DArr[2], paramValue.DArr[3], paramValue.DArr[4]);
                    RoiShapeParamResult = paramValue.DArr;
                    break;
                case RoiTypeModel.CIRCLE:  //圆形
                    paramName = DrawObjectParamModel.CIRCLE;
                    paramValue = drawingObject.GetDrawingObjectParams(paramName);
                    HOperatorSet.GenCircle(out RoiShapeObj, paramValue.DArr[0], paramValue.DArr[1], paramValue.DArr[2]);
                    RoiShapeParamResult = paramValue.DArr;
                    break;
                case RoiTypeModel.ELLIPSE:  //圆形
                    paramName = DrawObjectParamModel.ELLIPSE;
                    paramValue = drawingObject.GetDrawingObjectParams(paramName);
                    HOperatorSet.GenEllipse(out RoiShapeObj, paramValue.DArr[0], paramValue.DArr[1], paramValue.DArr[2], paramValue.DArr[3], paramValue.DArr[4]);
                    RoiShapeParamResult = paramValue.DArr;
                    break;
                case RoiTypeModel.XLD_CONTOUR:  //圆形
                    paramName = DrawObjectParamModel.ELLIPSE;
                    paramValue = drawingObject.GetDrawingObjectParams(paramName);
                    HOperatorSet.GenEllipse(out RoiShapeObj, paramValue.DArr[0], paramValue.DArr[1], paramValue.DArr[2], paramValue.DArr[3], paramValue.DArr[4]);
                    RoiShapeParamResult = paramValue.DArr;
                    break;
                default:
                    RoiShapeParamResult = new double[] { 0 };
                    RoiShapeObj = null;
                    break;
            }
        }

        /// <summary>
        /// 获取ROI参数：输入=>ROI的ID（句柄）；输出<=ROI参数数组；返回：ROI形状对象
        /// </summary>
        public HObject GetROIParams(Int64 roiID, out double[] RoiShapeParamResul)
        {
            //遍历获取集合中首个，与输入的ROI的ID相同绘制对象，如果没找到，返回null
            var drawObj = RoiList.FirstOrDefault(id => id.DrawObject.ID.Equals(roiID));
            if (drawObj != null)
            {
                GetROIParams(drawObj.DrawObject, drawObj.RoiType, out RoiShapeParamResul, out HObject roiShapeObj);
                //消息：参数
                string data = "[";
                for (int i = 0; i < RoiShapeParamResul.Length; i++)
                {
                    if (i != RoiShapeParamResul.Length - 1) data += RoiShapeParamResul[i].ToString("0.000") + ",";
                    else data += RoiShapeParamResul[i].ToString("0.000") + "]";
                }
                OnMessageUpdateEvents($"{drawObj.RoiType} ROI 参数 {data}");
                return roiShapeObj;
            }
            else
            {
                RoiShapeParamResul = new double[] { 0 };
                return null;
            }
        }

        /// <summary>
        /// 获取ROI参数：输入=>ROI的ID（句柄）；输出<=ROI参数数组、ROI形状对象；返回：ROI类型
        /// </summary>
        public RoiTypeModel  GetRoiObjParams(Int64 roiID,out double[] RoiShapeParamResul,out HObject roiShapeObj)
        {
            //遍历获取集合中首个，与输入的ROI的ID相同绘制对象，如果没找到，返回null
            var drawObj = RoiList.FirstOrDefault(id => id.DrawObject.ID.Equals(roiID));
            if (drawObj != null)
            {
                GetROIParams(drawObj.DrawObject, drawObj.RoiType, out RoiShapeParamResul, out  roiShapeObj);
                string data = "[";
                for (int i = 0; i < RoiShapeParamResul.Length; i++)
                {
                    if (i != RoiShapeParamResul.Length - 1) data += RoiShapeParamResul[i].ToString("0.000") + ",";
                    else data += RoiShapeParamResul[i].ToString("0.000") + "]";
                }
                OnMessageUpdateEvents($"{drawObj.RoiType} ROI 参数 {data}");
                return drawObj.RoiType;
            }
            else
            {
                RoiShapeParamResul = new double[] { 0 };
                roiShapeObj =null;
                return RoiTypeModel.NONE;
            }
        }


        #endregion

        #region ROI信息变更回调（拖拽、调整大小、选择...）
        /// <summary>
        /// 移除ROI时触发
        /// </summary>
        private void OnDetachDrawObjectCallback(HDrawingObject drawid, HWindow window, string type)
        {
            OnMessageUpdateEvents($"移除矩形ROI：ID = [{drawid.ID}]");
        }
        /// <summary>
        /// 选中ROI时触发
        /// </summary>
        private void OnSelectDrawObjectCallback(HDrawingObject drawid, HWindow window, string type)
        {
            OnMessageUpdateEvents($"选择矩形ROI：ID = [{drawid.ID}]");
            var drawObj = RoiList.FirstOrDefault(drawobj => drawobj.DrawID == drawid.ID);
            if (drawObj != null)
            {
                OnDrawObjectChangedEvents(new DrawingObjectModel(RoiOperateModel.查询, drawObj.DrawID));
            }
        }
        /// <summary>
        /// 拖拽ROI时触发
        /// </summary>
        private void OnDragDrawObjectCallback(HDrawingObject drawid, HWindow window, string type)
        {
            
        }
        /// <summary>
        /// 调整ROI大小时触发
        /// </summary>
        private void OnResizeDrawObjectCallback(HDrawingObject drawid, HWindow window, string type)
        {
            
        }
        #endregion

        #region 模板工具
        /// <summary>
        /// 创建模板:输入 图像（）
        /// </summary>
        public int CreateTeamplate(HObject grayImage, TemplateBase templateObj, out HObject contoursAffinTrans,
            out HTuple modelID, out HObject reduceImage )
        {
            modelID = null;
            reduceImage =null;
            RoiTypeModel roiType = RoiTypeModel.NONE ;
            double[] drawObjResultParam=null;
            foreach (DrawingObjectModel drawObj in RoiList)
            {
                roiType = GetRoiObjParams(drawObj.DrawObject.ID, out drawObjResultParam, out HObject region);
                HOperatorSet.ReduceDomain(grayImage, region,out reduceImage);
            }
            CreateScaledShapeModel modelParam = templateObj as CreateScaledShapeModel;
            if (templateObj.ModelCreatingMethod==1)
            {
                HOperatorSet.CreateShapeModel(reduceImage,
                                        modelParam.NumLevels,
                                        modelParam.AngleStart, modelParam.AngleExtent, modelParam.AngleStep,
                                        modelParam.Optimization, modelParam.Metric,
                                        modelParam.Contrast, modelParam.MinContrast,
                                        out modelID);
            }
            else if(templateObj.ModelCreatingMethod == 0)
            {
                HOperatorSet.CreateScaledShapeModel(reduceImage, modelParam.NumLevels,
                    modelParam.AngleStart, modelParam.AngleExtent, modelParam.AngleStep, 
                    modelParam.ScaleMin, modelParam.ScaleMax, modelParam.ScaleStep, 
                    modelParam.Optimization, modelParam.Metric, 
                    modelParam.Contrast, modelParam.MinContrast, out modelID);
            }
            HTuple row =new HTuple();
            HTuple column = new HTuple();
            HTuple angle = 0;
            switch (roiType)
            {
                case RoiTypeModel.RECTANGLE1:
                    row = (drawObjResultParam[0] + drawObjResultParam[2]) / 2.0;
                    column = (drawObjResultParam[1] + drawObjResultParam[3]) / 2.0;
                    break;
                case RoiTypeModel.RECTANGLE2:
                    row = drawObjResultParam[0];
                    column = drawObjResultParam[1];
                    angle = drawObjResultParam[2];
                    break;
                case RoiTypeModel.CIRCLE:
                    row = drawObjResultParam[0];
                    column = drawObjResultParam[1];
                    break;
                case RoiTypeModel.ELLIPSE:
                    row = drawObjResultParam[0];
                    column = drawObjResultParam[1];
                    angle = (drawObjResultParam[2] * 180 / Math.PI);
                    break;
                case RoiTypeModel.XLD_CONTOUR:
                    break;
                default:
                    break;
            }
            //创建变换矩阵
            HOperatorSet.VectorAngleToRigid(0, 0, 0, row, column, angle, out HTuple hv_HomMat2D);
            //获取轮廓
            HOperatorSet.GetShapeModelContours(out HObject ho_ModelContours, modelID, 1);
            //根据轮廓和变换矩阵获得变换后的轮廓。
            HOperatorSet.AffineTransContourXld(ho_ModelContours, out contoursAffinTrans, hv_HomMat2D);
            OnMessageUpdateEvents($"模板创建成功：ID = {modelID}");
            return 0;
        }
        /// <summary>
        /// 查找模板
        /// </summary>
        public void FindTeamplate(HObject findImage,  HTuple modelID,TemplateBase templateObj ,out List<HObject> contoursAffinTrans,
            out HTuple row, out HTuple column, out HTuple angle, out HTuple scale, out HTuple score)
        {
            HOperatorSet.SetShapeModelParam(modelID,"timeout",5000);         //设置匹配超时时间5s
            FindScaledShapeModel matchModel = templateObj as FindScaledShapeModel;
            contoursAffinTrans = new List<HObject>();
            if (templateObj.ModelCreatingMethod==1)
            {
                HOperatorSet.FindShapeModel(findImage, modelID,
                    matchModel.AngleStart, matchModel.AngleExtent,
                    matchModel.MinScore, matchModel.NumMatches, matchModel.MaxOverlap,
                    matchModel.SubPixel, matchModel.NumLevels, matchModel.Greediness,
                    out row, out column, out angle, out score);
                    scale = null;
            }
            else if(templateObj is FindScaledShapeModel)
            {
                HOperatorSet.FindScaledShapeModel(findImage, modelID, 
                    matchModel.AngleStart,matchModel.AngleExtent,
                    matchModel.ScaleMin,matchModel.ScaleMax,
                    matchModel.MinScore,matchModel.NumMatches,matchModel.MaxOverlap,
                    matchModel.SubPixel,matchModel.NumLevels,matchModel.Greediness,
                    out row,out column,out angle,out scale,out score);
            }
            else
            {
                row = new HTuple();
                column = new HTuple();
                angle = new HTuple();
                score = new HTuple();
                scale =new HTuple();
            }

            
            if (row.Length > 0)
            {
                try
                {
                    for (int i = 0; i < row.Length; i++)
                    {
                        HOperatorSet.VectorAngleToRigid(0, 0, 0, row[i], column[i], angle[i], out HTuple hv_HomMat2D);
                        HOperatorSet.GetShapeModelContours(out HObject ho_ModelContours, modelID, 1);
                        HOperatorSet.AffineTransContourXld(ho_ModelContours, out HObject contours, hv_HomMat2D);
                        contoursAffinTrans.Add(contours);
                    }
                }
                catch (HOperatorException ex)
                {
                    throw new Exception($"仿射变换参数异常： {ex.Message}");
                }
            }
        }
        #endregion

        #region 触发事件
        /// <summary>
        /// 触发事件：消息更新
        /// </summary>
        public void OnMessageUpdateEvents(string message)
        {
            MessageUpdateEvents?.Invoke(this, message);
        }
        /// <summary>
        /// 触发事件：绘制对象变更
        /// </summary>
        public void OnDrawObjectChangedEvents(DrawingObjectModel drawObj)
        {
            DrawObjectChangedEvents?.Invoke(this, drawObj);
        }
        #endregion
    }
}
