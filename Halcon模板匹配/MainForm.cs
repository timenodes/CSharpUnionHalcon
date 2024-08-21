using HalconDotNet;
using Halcon模板匹配.HalconModelSet_Ex;
using Halcon模板匹配.HalconTools;
using Halcon模板匹配.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Halcon模板匹配
{
    public partial class MainForm : Form
    {
        #region 字段、属性、集合
        //初始路径debug
        private string InitImagePath = Environment.CurrentDirectory + "\\1.png";    //初始图像路径
        private string CurrentImagePath;                    //当前图像路径
        private HWindow WindowID = null;                    //窗口ID
        private HImage _sourceImage;                        //原图
        private HImage _grayImage;                          //灰度图
        private HImage _currentImage;                       //当前图像
        private HImage _backgroudImage;                      //空白背景图
        private HImage _matchResultImage;                      //空白背景图
        private int _imageChannels = 1;                     //图像通道
        private int _drawObjIndex = -1;                     //绘制对象索引
        private HTuple ModelID;                             //模板ID
        private HObject ModelImage;                         //模板图像
        private List<HObject> MatchingContoursAffinTrans;   //匹配轮廓
        private HObject CreateContours;                     //创建的模板轮廓
        private HObject MatchUnitContours;                  //匹配到的合并的轮廓
        private string removeItemID = "";                   //移除ROI?
        private string[] _imageName = { "原图", "灰度图","模板图像", "模板轮廓图", "匹配结果图" };           //图像选择显示
        private string[] _drawObjectList = { "矩形1", "矩形2", "圆形", "椭圆", "多边形" };  //ROI显示选择
        private RoiTools RoiTools = new RoiTools();         //ROI工具

        private bool _isGrayConvert = true;         //是否获取灰度图

        //消息日志显示颜色
        private Color[] MessageColors = new Color[] {System.Drawing.Color.Black, System.Drawing.Color.Aqua, System.Drawing.Color.DodgerBlue, System.Drawing.Color.DarkGreen };

        /// <summary>
        /// 当前图像
        /// </summary>
        public HImage CurrentImage
        {
            get { return _currentImage; }
            private set { 
                _currentImage = value;
                if (_imageChannels==1)
                {
                    HImage tempImage = _currentImage.Clone();
                    HOperatorSet.GetImagePointer1(tempImage, out HTuple pointer, out HTuple type, out HTuple width, out HTuple height);
                    _matchResultImage = new HImage();
                    _backgroudImage = new HImage("byte", width, height);
                    _matchResultImage.GenImage3( type, width, height, pointer, pointer, pointer);
                }
                else
                {
                    _matchResultImage = _currentImage.Clone();
                    HOperatorSet.GetImageSize(_currentImage, out HTuple width, out HTuple height);
                    _backgroudImage = new HImage("byte", width, height);
                }
                
            }
        }
        /// <summary>
        /// 原图
        /// </summary>
        public HImage SourceImage
        {
            get { return _sourceImage; }
            private set { _sourceImage = value; }
        }
        /// <summary>
        /// 灰度图
        /// </summary>
        public HImage GrayImage
        {
            get { return _grayImage; }
            private set { _grayImage = value; }
        }

        public HImage MatchResultImage { get => _matchResultImage; set => _matchResultImage = value; }

        /// <summary>
        /// 图像集合
        /// </summary>
        public List<ModelsBase> ImageModelList = new List<ModelsBase>();

        /// <summary>
        /// 模板参数模型（创建模板时的参数）
        /// </summary>
        private CreateScaledShapeModel createScaledShapeModel = new CreateScaledShapeModel();

        /// <summary>
        /// 模板匹配参数模型（查找时的参数）
        /// </summary>
        private FindScaledShapeModel findScaledShapeModel = new FindScaledShapeModel();



        #endregion

        #region 窗体初始化、加载

        public MainForm()
        {
            InitializeComponent();
            this.Height = 800;
            this.CenterToParent();
            this.CenterToScreen();
            WindowID = ImageWindow.HalconWindow;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //事件绑定
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(CustomMouseWheel);
            this.ImageWindow.HMouseMove += ImageWindow_HMouseMove;
            this.RoiTools.MessageUpdateEvents += OnUpdateMessageCallback;
            this.RoiTools.DrawObjectChangedEvents += OnDrawObjectChangedCallback;
            

            ///初始化控件值
            cbx_ImageList.DataSource = _imageName;
            cbx_ImageList.SelectedIndex = 1;
            cbx_DrawObjectList.DataSource = _drawObjectList;
            cbx_DrawObjectList.SelectedIndex = 0;
            tbx_LoadImage.Text = InitImagePath;
            SetValueCreating();
        }
        


        /// <summary>
        /// 窗体关闭
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            RoiTools.UnEventBinding();
        }
        #endregion

        /// <summary>
        /// 加载图像按钮
        /// </summary>
        private void btn_ImageLoad_Click(object sender, EventArgs e)
        {
            LoadImage(tbx_LoadImage.Text);
        }

        /// <summary>
        /// 图像窗口移动鼠标
        /// </summary>
        private void ImageWindow_HMouseMove(object sender, HMouseEventArgs e)
        {
            MoveShowImageInfo(e);
        }
        /// <summary>
        /// 放大缩小图像
        /// </summary>
        private void CustomMouseWheel(object sender, MouseEventArgs e)
        {
            System.Drawing.Point pt = this.Location;
            int leftBorder = ImageWindow.Location.X;
            int rightBorder = ImageWindow.Location.X + ImageWindow.Size.Width;
            int topBorder = ImageWindow.Location.Y;
            int bottomBorder = ImageWindow.Location.Y + ImageWindow.Size.Height;
            //判断鼠标指针是否在控件内部
            if (e.X > leftBorder && e.X < rightBorder && e.Y > topBorder && e.Y < bottomBorder)
            {
                MouseEventArgs newe = new MouseEventArgs(e.Button, e.Clicks, e.X - pt.X, e.Y - pt.Y, e.Delta);
                ImageWindow.HSmartWindowControl_MouseWheel(sender, newe);
            }
        }

        #region 图像加载
        /// <summary>
        /// 加载图像
        /// </summary>
        public void LoadImage(string path)
        {
            CurrentImagePath = path;
            OpenFileDialog openFile = new OpenFileDialog();
            //判断设置初始目录
            openFile.InitialDirectory = Environment.CurrentDirectory;
            if (Directory.Exists(CurrentImagePath)) openFile.InitialDirectory = CurrentImagePath;
            if (Directory.Exists("D:\\Image")) openFile.InitialDirectory = "D:\\Image";
            if (Directory.Exists(CurrentImagePath)) openFile.InitialDirectory = CurrentImagePath;
            if (File.Exists(CurrentImagePath)) openFile.InitialDirectory = System.IO.Path.GetDirectoryName(CurrentImagePath);
            //判断读取图像
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                CurrentImagePath = openFile.FileName;
                tbx_LoadImage.Text = openFile.FileName;
                try
                {
                    ImageFormatTools.ReadImage(CurrentImagePath, out _sourceImage,out string info);
                    
                    if (info != null)
                    {
                        UpdateMessage($"图像直接加载异常{info}!!");
                        UpdateMessage($"使用Bitmap转换图像,图像路径：{CurrentImagePath}");
                    }
                    //设置当前图像显示：原图
                    CurrentImage = SourceImage.Clone();
                    //灰度转换
                    if (_isGrayConvert)
                    {
                        _grayImage = _sourceImage.Rgb1ToGray();
                        CurrentImage = _grayImage.Clone();  //设置当前图像显示：原图
                        UpdateMessage($"执行图像灰度转换：{CurrentImagePath}");
                    }
                    HOperatorSet.DispObj(CurrentImage, WindowID);
                    UpdateMessage($"图像加载完成，图像路径：{CurrentImagePath}");
                    GetImageChannel(CurrentImage);
                    ImageModelList.Clear();     //先清空图像
                    //添加图像到集合
                    ImageModel imageModels = new ImageModel();
                    imageModels.FileName = CurrentImagePath;
                    imageModels.Directory = System.IO.Path.GetDirectoryName(CurrentImagePath);
                    imageModels.SourceImage = _sourceImage.Clone();
                    imageModels.GrayImage = _grayImage?.Clone();
                    imageModels.ID = ImageModelList.Count;
                    ImageModelList.Add(imageModels);
                }
                catch (Exception ex)
                {
                    UpdateMessage($"图像加载失败：{ex.Message}");
                }
            }
        }
        #endregion

        #region 获取灰度值
        /// <summary>
        /// 图像信息显示
        /// </summary>
        private void MoveShowImageInfo(HMouseEventArgs e)
        {
            if (SourceImage == null) return;
            try
            {
                // 获取鼠标位置及所在位置的灰度值
                if (GrayImage != null)
                {
                    GetGrayValue((int)e.X, (int)e.Y);
                }
            }
            catch (Exception ex)
            {
                UpdateMessage($"Mouse Move 异常：{ex.Message}");
            }
        }
        /// <summary>
        /// 获取鼠标位置，及所在位置的灰度值。
        /// </summary>
        private void GetGrayValue(int mouseX, int mouseY)
        {
            HOperatorSet.GetImageSize((HObject)GrayImage, out HTuple width, out HTuple height);
            // 确保鼠标位置在图像范围内
            if (mouseX >= 0 && mouseX < width && mouseY >= 0 && mouseY < height)
            {
                HTuple hv_GrayValue;
                HOperatorSet.GetGrayval((HObject)GrayImage, mouseY, mouseX, out hv_GrayValue);
                // 显示当前点位和灰度值
                string text = $"$(W:{width},H:{height})\t" +
                    $"X: ({mouseX},Y: {mouseY})   " +
                    $"(R:{hv_GrayValue},G:{hv_GrayValue},B:{hv_GrayValue})";
                Console.WriteLine(text);
                tbx_WindowState.Text = text;
            }
        }
        #endregion

        #region 消息更新方法
        /// <summary>
        /// 更新消息
        /// </summary>
        private void UpdateMessage(string message)
        {
            rtbx_MessageLog.Invoke(new Action(() =>
            {
                if (rtbx_MessageLog.Lines.Length > 5000)
                {
                    rtbx_MessageLog.Clear();
                }
                
                int index = rtbx_MessageLog.Lines.Length;
                string msg = $"{(index == 0 ? 1 : index)}\t" + $"{DateTime.Now.ToString()}： {message}{Environment.NewLine}";
                rtbx_MessageLog.AppendText(msg); ;
                rtbx_MessageLog.SelectionStart = rtbx_MessageLog.Text.Length;
                rtbx_MessageLog.Focus();
            }));
        }
        /// <summary>
        /// 更新消息,异常显示红色(error level = 1)。正常显示其他颜色
        /// </summary>
        private void UpdateMessage(string message,int errorLevel)
        {
            rtbx_MessageLog.Invoke(new Action(() =>
            {
                if (rtbx_MessageLog.Lines.Length > 5000)
                {
                    rtbx_MessageLog.Clear();
                }

                int index = rtbx_MessageLog.Lines.Length;

                string msg = $"{(index == 0 ? 1 : index)}\t" + $"{DateTime.Now.ToString()}： {message}{Environment.NewLine}";

                int startIndex = rtbx_MessageLog.Text.Length;
                rtbx_MessageLog.AppendText(msg);
                int length = rtbx_MessageLog.Text.Length;
                if (errorLevel == 1) //异常定义
                {
                    // 设置选定文本的颜色为红色
                    rtbx_MessageLog.Select(startIndex, length); // 选择前 lengthToHighlight 个字符
                    rtbx_MessageLog.SelectionColor = Color.Red; // 设置颜色为红色

                    // 取消选择
                    rtbx_MessageLog.Select(rtbx_MessageLog.Text.Length, 0); // 取消选择
                    rtbx_MessageLog.SelectionColor = Color.Black; // 恢复后续文本颜色
                }
                else
                {
                    Random random = new Random();
                    int indexColor = random.Next(MessageColors.Length);
                    // 设置选定文本的颜色为红色
                    rtbx_MessageLog.Select(startIndex, length); // 选择前 lengthToHighlight 个字符
                    rtbx_MessageLog.SelectionColor = MessageColors[indexColor]; // 设置颜色为红色

                    // 取消选择
                    rtbx_MessageLog.Select(rtbx_MessageLog.Text.Length, 0); // 取消选择
                    rtbx_MessageLog.SelectionColor = Color.Black; // 恢复后续文本颜色
                }


                rtbx_MessageLog.SelectionStart = rtbx_MessageLog.Text.Length;
                rtbx_MessageLog.Focus();
            }));
        }

        /// <summary>
        ///  消息更新回调
        /// </summary>
        private void OnUpdateMessageCallback(object sender, string message)
        {
            UpdateMessage(message,0);
        }
        /// <summary>
        /// 响应：绘制对象变更回调（事件被触发后响应）
        /// </summary>
        private void OnDrawObjectChangedCallback(object sender, DrawingObjectModel drawObj)
        {
            if (drawObj != null)
            {
                switch (drawObj.Operate)
                {
                    case RoiOperateModel.None:
                        break;
                    case RoiOperateModel.添加:
                        lbx_RoiList.Items.Add($"ROI_{drawObj.DrawID.ToString()}");
                        break;
                    case RoiOperateModel.删除:
                        string id = drawObj.DrawID.ToString();

                        foreach (var item in lbx_RoiList.Items)
                        {
                            UpdateMessage(item.ToString());
                        }
                        lbx_RoiList.Items.Remove(id);

                        break;
                    case RoiOperateModel.修改:
                        break;
                    case RoiOperateModel.查询:
                        if (lbx_RoiList.Items.Contains($"ROI_{drawObj.DrawID}"))
                        {
                            lbx_RoiList.SelectedItem = $"ROI_{drawObj.DrawID}";
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        /// <summary>
        /// 获取图像通道数
        /// </summary>
        private void GetImageChannel(HImage hImage)
        {
            HOperatorSet.CountChannels(hImage, out HTuple channels);
            _imageChannels = channels;
        }

        /// <summary>
        /// 选择显示的图像
        /// </summary>
        private void cbx_ImageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentImage == null) return;
            switch (cbx_ImageList.SelectedIndex)
            {
                 case 0:
                        CurrentImage = SourceImage.Clone();
                    UpdateMessage("设置当前图像为原图！");
                    break;
                 case 1:
                        CurrentImage = GrayImage.Clone();
                    UpdateMessage("设置当前图像为灰度图！");
                    break;
                case 2:
                    if (ModelImage == null) return;
                    HOperatorSet.DispObj(_backgroudImage, WindowID); 
                    HOperatorSet.DispObj(ModelImage, WindowID);
                    UpdateMessage("设置当前图像为模板图图像！");
                    return;
                case 3:
                    HOperatorSet.DispObj(CurrentImage,WindowID);
                    DispContoursRegion(CreateContours);
                    UpdateMessage("设置当前图像为匹配结果图像！");
                    return;
                case 4:
                    CurrentImage = MatchResultImage.Clone();
                    DispContoursRegion(MatchUnitContours);
                    UpdateMessage("设置当前图像为匹配结果图像！");
                    return;
                default:
                    break;
            }
            HOperatorSet.DispObj(CurrentImage, WindowID);
        }

        /// <summary>
        /// 清空log消息
        /// </summary>
        private void 清空内容ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbx_MessageLog.Clear();
        }

        /// <summary>
        /// 消息栏区域鼠标按下：显示右键菜单
        /// </summary>
        private void rtbx_MessageLog_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmsx_RightMenu.Show(rtbx_MessageLog, e.X, e.Y);
            }
        }

        /// <summary>
        /// 绘制ROI
        /// </summary>
        private void btn_DrawROI_Click(object sender, EventArgs e)
        {
            if (SourceImage == null) return;
            switch (_drawObjIndex)
            {
                case 0:
                    RoiTools.DrawROI(RoiTypeModel.RECTANGLE1,WindowID);
                    break;
                case 1:
                    RoiTools.DrawROI(RoiTypeModel.RECTANGLE2, WindowID);
                    break;
                case 2:
                    RoiTools.DrawROI(RoiTypeModel.CIRCLE, WindowID);
                    break;
                case 3:
                    RoiTools.DrawROI(RoiTypeModel.ELLIPSE, WindowID);
                    break;
                case 4:
                    RoiTools.DrawROI(RoiTypeModel.XLD_CONTOUR, WindowID);
                    break;
                default:
                    RoiTools.DrawROI(RoiTypeModel.RECTANGLE1, WindowID);
                    break;
            }
        }

        /// <summary>
        /// 绘制对象（ROI）类型索引
        /// </summary>
        private void cbx_DrawObjectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            _drawObjIndex = cbx_DrawObjectList.SelectedIndex;
            
        }
        
        /// <summary>
        /// 删除ROI
        /// </summary>
        private void 删除ROItoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int64 id = Int64.Parse(removeItemID.Split('_')[1]);
            var draw = RoiTools.RoiList.FirstOrDefault(obj => obj.DrawObject.ID == id);
            if (draw != null)
            {
                lbx_RoiList.Items.Remove(removeItemID);
                RoiTools.DetachtROI(WindowID, id);
            }
        }
        /// <summary>
        /// ROI列表区域鼠标按下
        /// </summary>
        private void lbx_RoiList_MouseDown(object sender, MouseEventArgs e)
        {
            // 检查是否是右键按下
            if (e.Button == MouseButtons.Right)
            {
                // 获取鼠标点击的位置
                int index = lbx_RoiList.IndexFromPoint(e.Location);
                if (index != System.Windows.Forms.ListBox.NoMatches) // 确保点击的是有效项
                {
                    if (index != System.Windows.Forms.ListBox.NoMatches) // 确保点击的是有效项
                    {
                        // 记录选中的项
                        removeItemID = lbx_RoiList.Items[index].ToString();
                        // 在鼠标位置显示右键菜单
                        cmsx_RoiRightMenu.Show(lbx_RoiList, e.Location);
                    }
                }
            }
        }


        /// <summary>
        /// 创建模板
        /// </summary>
        private void btn_CreateTemplate_Click(object sender, EventArgs e)
        {
            UpdateMessage("创建模板",0);
            if (GrayImage == null) return;
            if (RoiTools.RoiList.Count < 1) return;
            HOperatorSet.DispObj(CurrentImage,WindowID);
            int result = -1;
            switch (cbx_MatchingModelMethod.SelectedIndex)
            {
                case 0:
                    createScaledShapeModel.ModelCreatingMethod = 0;
                    result = RoiTools.CreateTeamplate(GrayImage, createScaledShapeModel , out CreateContours, out ModelID, out ModelImage);
                    break;
                case 1:
                    createScaledShapeModel.ModelCreatingMethod = 1;
                    result = RoiTools.CreateTeamplate(GrayImage, createScaledShapeModel, out CreateContours,
                out ModelID, out ModelImage);
                    break;
                default : 
                    break;
            }
            if (result == 0)
            {
                MatchingContoursAffinTrans = null;
                DispContoursRegion(CreateContours);
            }
            
        }
        /// <summary>
        /// 查找模板
        /// </summary>
        private void btn_FindTeamplate_Click(object sender, EventArgs e)
        {
            //执行模板匹配
            UpdateMessage("执行模板匹配",0);
            if (ModelImage == null || ModelID == null) return;
            try
            {
                SetValueMatching();
                HOperatorSet.DispObj(CurrentImage, WindowID);

                HTuple row = new HTuple();
                HTuple column = new HTuple();
                HTuple angle = new HTuple();
                HTuple score = new HTuple();
                HTuple scaled = new HTuple();
                switch (createScaledShapeModel.ModelCreatingMethod)
                {
                    case 0:
                        findScaledShapeModel.ModelCreatingMethod = 0;
                        RoiTools.FindTeamplate(CurrentImage, ModelID, findScaledShapeModel, out MatchingContoursAffinTrans, out  row, out  column, out  angle, out scaled, out  score);
                        break;
                    case 1:
                        findScaledShapeModel.ModelCreatingMethod = 1;
                        RoiTools.FindTeamplate(CurrentImage, ModelID, findScaledShapeModel, out MatchingContoursAffinTrans, out row, out column, out angle, out scaled, out score);
                        break;
                    default:
                        break;
                }
                dgvx_MatchResult.Rows.Clear();
                if (score.Length > 0)
                {
                    
                    if (scaled!=null)
                    {
                        for (int i = 0; i < row.Length; i++)
                        {
                            UpdateMessage($"匹配结果：[{row[i].D.ToString("0.000")},{column[i].D.ToString("0.000")},{angle[i].D.ToString("0.000")}],分数： {score[i].D.ToString("0.000")},缩放：[{scaled.D.ToString("0.000")}]",0);
                            dgvx_MatchResult.Rows.Add((i), row[i].D.ToString("0.000"), column[i].D.ToString("0.000"), score[i].D.ToString("0.000"), scaled[i].D.ToString("0.000"));
                        }
                    }
                    else
                    {
                        for (int i = 0; i < row.Length; i++)
                        {
                            UpdateMessage($"匹配结果：[{row[i].D.ToString("0.000")},{column[i].D.ToString("0.000")},{angle[i].D.ToString("0.000")}],分数： {score[i].D.ToString("0.000")}",0);
                            dgvx_MatchResult.Rows.Add((i), row[i].D.ToString("0.000"), column[i].D.ToString("0.000"), score[i].D.ToString("0.000"), scaled[i].D.ToString("0.000"));
                        }
                    }
                    HOperatorSet.GenEmptyRegion(out MatchUnitContours);
                    foreach (var contours in MatchingContoursAffinTrans)
                    {
                        //生成轮廓xld区域
                        HOperatorSet.GenRegionContourXld(contours, out HObject Region,"margin");
                        HOperatorSet.Union2(MatchUnitContours, Region,out MatchUnitContours);
                    }
                    HOperatorSet.DispRegion(MatchUnitContours, WindowID);
                }
                else 
                    UpdateMessage($"匹配失败,模板ID:{ModelID}。请检查参数?",1);
            }
            catch (Exception ex)
            {
                UpdateMessage($"匹配失败,{ex.Message}",1);
            }
        }
        /// <summary>
        /// 显示轮廓
        /// </summary>
        public void DispContoursRegion(HObject contours)
        {
            if (contours == null) return;
            HOperatorSet.SetColor(WindowID, "green");
            HOperatorSet.SetLineWidth(WindowID, 3);
            if (!(contours is HRegion))
            {
                HOperatorSet.GenRegionContourXld(contours,out HObject region,"margin");
                HOperatorSet.DispRegion(region, WindowID);
            }
            else
            {
                HOperatorSet.DispRegion(contours, WindowID);
            }
        }
        /// <summary>
        /// 刷新参数显示
        /// </summary>
        private void btn_FlushCreateingParams_Click(object sender, EventArgs e)
        {
            DisplyValueCreating();
        }
        /// <summary>
        /// 确认创建模板参数
        /// </summary>
        private void btn_ConfirmParam_Click(object sender, EventArgs e)
        {
            SetValueCreating();
        }

        #region 参数设置
        /// <summary>
        /// 设置创建模板参数
        /// </summary>
        private void SetValueCreating()
        {
            createScaledShapeModel.AngleStart = double.Parse(tbx_AngleStart_Creating.Text);
            createScaledShapeModel.AngleExtent = double.Parse(tbx_AngleExtent_Creating.Text);
            createScaledShapeModel.AngleStep = double.Parse(tbx_AngleStep_Creating.Text);
            createScaledShapeModel.Optimization = cbx_Optimization_Creating.Text;
            createScaledShapeModel.Metric = cbx_Metric_Creating.Text;
            createScaledShapeModel.NumLevels = int.Parse(dudx__NumLevels_Creating.Text);
            createScaledShapeModel.Contrast = int.Parse(dudx_Contrast_Creating.Text);
            createScaledShapeModel.MinContrast = int.Parse(dudx_MinContrast_Creating.Text);
            createScaledShapeModel.ScaleMin = double.Parse(dudx_ScaledMin_Creating.Text);
            createScaledShapeModel.ScaleMax = double.Parse(dudx_ScaledMax_Creating.Text);
            createScaledShapeModel.ScaleStep = 0.01;
            UpdateMessage($"设置对象参数：{createScaledShapeModel.GetType().Name}", 0);
        }
        /// <summary>
        /// 获取创建模板参数
        /// </summary>
        private void DisplyValueCreating()
        {
            tbx_AngleStart_Creating.Text = createScaledShapeModel.AngleStart.ToString();
            tbx_AngleExtent_Creating.Text = createScaledShapeModel.AngleExtent.ToString();
            tbx_AngleStep_Creating.Text = createScaledShapeModel.AngleStep.ToString();
            cbx_Optimization_Creating.Text = createScaledShapeModel.Optimization;
            cbx_Metric_Creating.Text = createScaledShapeModel.Metric;
            dudx__NumLevels_Creating.Text = createScaledShapeModel.NumLevels.ToString();
            dudx_Contrast_Creating.Text = createScaledShapeModel.Contrast.ToString();
            dudx_MinContrast_Creating.Text = createScaledShapeModel.MinContrast.ToString();

            dudx_ScaledMin_Creating.Text = createScaledShapeModel.ScaleMin.ToString();
            dudx_ScaledMax_Creating.Text = createScaledShapeModel.ScaleMax.ToString();
            UpdateMessage($"更新参数值到UI：{createScaledShapeModel.GetType().Name}", 0);
        }

        /// <summary>
        /// 设置查找模板参数
        /// </summary>
        private void SetValueMatching()
        {
            findScaledShapeModel.AngleStart = double.Parse(tbx_AngleStart_Matching.Text);
            findScaledShapeModel.AngleExtent = double.Parse(tbx_AngleExtent_Matching.Text);
            findScaledShapeModel.MinScore = double.Parse(dudx_MinScore_Matching.Text);
            findScaledShapeModel.NumMatches = int.Parse(nudx_NumMatches_Matching.Value.ToString());
            if (int.TryParse(dudx_NumLevels_Matching.Text, out int reuslt))
                findScaledShapeModel.NumLevels = reuslt;
            findScaledShapeModel.SubPixel = cbx_SubPixel_Matching.Text;
            findScaledShapeModel.MaxOverlap = double.Parse(dudx_MaxOverlap_Matching.Text);
            findScaledShapeModel.Greediness = double.Parse(dudx_Greediness_Matching.Text);
            findScaledShapeModel.ScaleMin = double.Parse(dudx_MixScale_Matching.Text);
            findScaledShapeModel.ScaleMax = double.Parse(dudx_MaxScale_Matching.Text);
        }
        #endregion

        /// <summary>
        /// ROI列表控件选择变更
        /// </summary>
        private void lbx_RoiList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Int64 drawID = long.Parse(lbx_RoiList.SelectedItem.ToString().Split('_')[1]);
            //var drawObj = RoiTools.RoiList.FirstOrDefault(x => x.DrawObject.ID.Equals(drawID));
            //HOperatorSet.DetachDrawingObjectFromWindow(WindowID, drawObj.DrawObject);
            
        }
    }
}
