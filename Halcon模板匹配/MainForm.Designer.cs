namespace Halcon模板匹配
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_OperatorBar = new System.Windows.Forms.Panel();
            this.groupBox_Operator = new System.Windows.Forms.GroupBox();
            this.panel_Match = new System.Windows.Forms.Panel();
            this.tabControl_Match = new System.Windows.Forms.TabControl();
            this.tabPage_RoiParams = new System.Windows.Forms.TabPage();
            this.panel_CreateTemplateParam = new System.Windows.Forms.Panel();
            this.dudx_ScaledMax_Creating = new System.Windows.Forms.DomainUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.dudx_ScaledMin_Creating = new System.Windows.Forms.DomainUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.dudx__NumLevels_Creating = new System.Windows.Forms.DomainUpDown();
            this.dudx_MinContrast_Creating = new System.Windows.Forms.DomainUpDown();
            this.dudx_Contrast_Creating = new System.Windows.Forms.DomainUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_Metric_Creating = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_Optimization_Creating = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_AngleStart_Creating = new System.Windows.Forms.TextBox();
            this.tbx_AngleStep_Creating = new System.Windows.Forms.TextBox();
            this.tbx_AngleExtent_Creating = new System.Windows.Forms.TextBox();
            this.panel_CreateTemplateOperate = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.btn_FlushCreateingParams = new System.Windows.Forms.Button();
            this.btn_ConfirmParam = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numUD_EraserSize = new System.Windows.Forms.NumericUpDown();
            this.btn_Eraser = new System.Windows.Forms.Button();
            this.cbx_DrawObjectList = new System.Windows.Forms.ComboBox();
            this.btn_CreateTemplate = new System.Windows.Forms.Button();
            this.btn_DrawROI = new System.Windows.Forms.Button();
            this.tabPage_RoiList = new System.Windows.Forms.TabPage();
            this.lbx_RoiList = new System.Windows.Forms.ListBox();
            this.tabPage_MatchParams = new System.Windows.Forms.TabPage();
            this.panel_FindTemplateParam = new System.Windows.Forms.Panel();
            this.dudx_MaxScale_Matching = new System.Windows.Forms.DomainUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.dudx_MixScale_Matching = new System.Windows.Forms.DomainUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.dudx_Greediness_Matching = new System.Windows.Forms.DomainUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.dudx_MaxOverlap_Matching = new System.Windows.Forms.DomainUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.nudx_NumMatches_Matching = new System.Windows.Forms.NumericUpDown();
            this.dudx_NumLevels_Matching = new System.Windows.Forms.DomainUpDown();
            this.dudx_MinScore_Matching = new System.Windows.Forms.DomainUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbx_SubPixel_Matching = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbx_AngleStart_Matching = new System.Windows.Forms.TextBox();
            this.tbx_AngleExtent_Matching = new System.Windows.Forms.TextBox();
            this.panel_FindTemplateOperate = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.cbx_MatchingModelMethod = new System.Windows.Forms.ComboBox();
            this.cbx_DrawFindRegion = new System.Windows.Forms.ComboBox();
            this.btn_FindTeamplate = new System.Windows.Forms.Button();
            this.btn_DrawFindRegion = new System.Windows.Forms.Button();
            this.tabPage_MatchResult = new System.Windows.Forms.TabPage();
            this.panel_MathingResult = new System.Windows.Forms.Panel();
            this.dgvx_MatchResult = new System.Windows.Forms.DataGridView();
            this.Column_Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Scaled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_MatchItem = new System.Windows.Forms.Panel();
            this.panel_LoadImage = new System.Windows.Forms.Panel();
            this.btn_ImageLoad = new System.Windows.Forms.Button();
            this.tbx_LoadImage = new System.Windows.Forms.TextBox();
            this.panel_MessageBar = new System.Windows.Forms.Panel();
            this.GroupBox_Message = new System.Windows.Forms.GroupBox();
            this.rtbx_MessageLog = new System.Windows.Forms.RichTextBox();
            this.panel_ImageWindowBar = new System.Windows.Forms.Panel();
            this.groupBox_ImageWin = new System.Windows.Forms.GroupBox();
            this.panel_ImageWindow = new System.Windows.Forms.Panel();
            this.ImageWindow = new HalconDotNet.HSmartWindowControl();
            this.panel_ImageInfo = new System.Windows.Forms.Panel();
            this.tbx_WindowState = new System.Windows.Forms.TextBox();
            this.panel_ImageListBar = new System.Windows.Forms.Panel();
            this.cbx_ImageList = new System.Windows.Forms.ComboBox();
            this.cmsx_RightMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.清空内容ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsx_RoiRightMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ROItoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_OperatorBar.SuspendLayout();
            this.groupBox_Operator.SuspendLayout();
            this.panel_Match.SuspendLayout();
            this.tabControl_Match.SuspendLayout();
            this.tabPage_RoiParams.SuspendLayout();
            this.panel_CreateTemplateParam.SuspendLayout();
            this.panel_CreateTemplateOperate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_EraserSize)).BeginInit();
            this.tabPage_RoiList.SuspendLayout();
            this.tabPage_MatchParams.SuspendLayout();
            this.panel_FindTemplateParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudx_NumMatches_Matching)).BeginInit();
            this.panel_FindTemplateOperate.SuspendLayout();
            this.tabPage_MatchResult.SuspendLayout();
            this.panel_MathingResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvx_MatchResult)).BeginInit();
            this.panel_LoadImage.SuspendLayout();
            this.panel_MessageBar.SuspendLayout();
            this.GroupBox_Message.SuspendLayout();
            this.panel_ImageWindowBar.SuspendLayout();
            this.groupBox_ImageWin.SuspendLayout();
            this.panel_ImageWindow.SuspendLayout();
            this.panel_ImageInfo.SuspendLayout();
            this.panel_ImageListBar.SuspendLayout();
            this.cmsx_RightMenu.SuspendLayout();
            this.cmsx_RoiRightMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_OperatorBar
            // 
            this.panel_OperatorBar.Controls.Add(this.groupBox_Operator);
            this.panel_OperatorBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_OperatorBar.Location = new System.Drawing.Point(691, 0);
            this.panel_OperatorBar.Name = "panel_OperatorBar";
            this.panel_OperatorBar.Padding = new System.Windows.Forms.Padding(5);
            this.panel_OperatorBar.Size = new System.Drawing.Size(482, 714);
            this.panel_OperatorBar.TabIndex = 0;
            // 
            // groupBox_Operator
            // 
            this.groupBox_Operator.Controls.Add(this.panel_Match);
            this.groupBox_Operator.Controls.Add(this.panel_LoadImage);
            this.groupBox_Operator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Operator.Location = new System.Drawing.Point(5, 5);
            this.groupBox_Operator.Name = "groupBox_Operator";
            this.groupBox_Operator.Size = new System.Drawing.Size(472, 704);
            this.groupBox_Operator.TabIndex = 0;
            this.groupBox_Operator.TabStop = false;
            this.groupBox_Operator.Text = "操作栏";
            // 
            // panel_Match
            // 
            this.panel_Match.Controls.Add(this.tabControl_Match);
            this.panel_Match.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Match.Location = new System.Drawing.Point(3, 229);
            this.panel_Match.Name = "panel_Match";
            this.panel_Match.Size = new System.Drawing.Size(466, 472);
            this.panel_Match.TabIndex = 5;
            // 
            // tabControl_Match
            // 
            this.tabControl_Match.Controls.Add(this.tabPage_RoiParams);
            this.tabControl_Match.Controls.Add(this.tabPage_RoiList);
            this.tabControl_Match.Controls.Add(this.tabPage_MatchParams);
            this.tabControl_Match.Controls.Add(this.tabPage_MatchResult);
            this.tabControl_Match.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Match.Font = new System.Drawing.Font("宋体", 12F);
            this.tabControl_Match.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Match.Name = "tabControl_Match";
            this.tabControl_Match.SelectedIndex = 0;
            this.tabControl_Match.Size = new System.Drawing.Size(466, 472);
            this.tabControl_Match.TabIndex = 7;
            // 
            // tabPage_RoiParams
            // 
            this.tabPage_RoiParams.Controls.Add(this.panel_CreateTemplateParam);
            this.tabPage_RoiParams.Controls.Add(this.panel_CreateTemplateOperate);
            this.tabPage_RoiParams.Font = new System.Drawing.Font("宋体", 12F);
            this.tabPage_RoiParams.Location = new System.Drawing.Point(4, 26);
            this.tabPage_RoiParams.Name = "tabPage_RoiParams";
            this.tabPage_RoiParams.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_RoiParams.Size = new System.Drawing.Size(458, 442);
            this.tabPage_RoiParams.TabIndex = 0;
            this.tabPage_RoiParams.Text = "ROI参数";
            this.tabPage_RoiParams.UseVisualStyleBackColor = true;
            // 
            // panel_CreateTemplateParam
            // 
            this.panel_CreateTemplateParam.BackColor = System.Drawing.Color.DarkGray;
            this.panel_CreateTemplateParam.Controls.Add(this.dudx_ScaledMax_Creating);
            this.panel_CreateTemplateParam.Controls.Add(this.label20);
            this.panel_CreateTemplateParam.Controls.Add(this.dudx_ScaledMin_Creating);
            this.panel_CreateTemplateParam.Controls.Add(this.label21);
            this.panel_CreateTemplateParam.Controls.Add(this.dudx__NumLevels_Creating);
            this.panel_CreateTemplateParam.Controls.Add(this.dudx_MinContrast_Creating);
            this.panel_CreateTemplateParam.Controls.Add(this.dudx_Contrast_Creating);
            this.panel_CreateTemplateParam.Controls.Add(this.label8);
            this.panel_CreateTemplateParam.Controls.Add(this.label7);
            this.panel_CreateTemplateParam.Controls.Add(this.label6);
            this.panel_CreateTemplateParam.Controls.Add(this.cbx_Metric_Creating);
            this.panel_CreateTemplateParam.Controls.Add(this.label5);
            this.panel_CreateTemplateParam.Controls.Add(this.cbx_Optimization_Creating);
            this.panel_CreateTemplateParam.Controls.Add(this.label4);
            this.panel_CreateTemplateParam.Controls.Add(this.label3);
            this.panel_CreateTemplateParam.Controls.Add(this.label2);
            this.panel_CreateTemplateParam.Controls.Add(this.label1);
            this.panel_CreateTemplateParam.Controls.Add(this.tbx_AngleStart_Creating);
            this.panel_CreateTemplateParam.Controls.Add(this.tbx_AngleStep_Creating);
            this.panel_CreateTemplateParam.Controls.Add(this.tbx_AngleExtent_Creating);
            this.panel_CreateTemplateParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_CreateTemplateParam.Location = new System.Drawing.Point(3, 128);
            this.panel_CreateTemplateParam.Name = "panel_CreateTemplateParam";
            this.panel_CreateTemplateParam.Size = new System.Drawing.Size(452, 311);
            this.panel_CreateTemplateParam.TabIndex = 6;
            // 
            // dudx_ScaledMax_Creating
            // 
            this.dudx_ScaledMax_Creating.Items.Add("0.01");
            this.dudx_ScaledMax_Creating.Items.Add("0.02");
            this.dudx_ScaledMax_Creating.Items.Add("0.03");
            this.dudx_ScaledMax_Creating.Items.Add("0.04");
            this.dudx_ScaledMax_Creating.Items.Add("0.05");
            this.dudx_ScaledMax_Creating.Items.Add("0.06");
            this.dudx_ScaledMax_Creating.Items.Add("0.07");
            this.dudx_ScaledMax_Creating.Items.Add("0.08");
            this.dudx_ScaledMax_Creating.Items.Add("0.09");
            this.dudx_ScaledMax_Creating.Items.Add("0.10");
            this.dudx_ScaledMax_Creating.Items.Add("0.11");
            this.dudx_ScaledMax_Creating.Items.Add("0.12");
            this.dudx_ScaledMax_Creating.Items.Add("0.13");
            this.dudx_ScaledMax_Creating.Items.Add("0.14");
            this.dudx_ScaledMax_Creating.Items.Add("0.15");
            this.dudx_ScaledMax_Creating.Items.Add("0.16");
            this.dudx_ScaledMax_Creating.Items.Add("0.17");
            this.dudx_ScaledMax_Creating.Items.Add("0.18");
            this.dudx_ScaledMax_Creating.Items.Add("0.19");
            this.dudx_ScaledMax_Creating.Items.Add("0.20");
            this.dudx_ScaledMax_Creating.Items.Add("0.21");
            this.dudx_ScaledMax_Creating.Items.Add("0.22");
            this.dudx_ScaledMax_Creating.Items.Add("0.23");
            this.dudx_ScaledMax_Creating.Items.Add("0.24");
            this.dudx_ScaledMax_Creating.Items.Add("0.25");
            this.dudx_ScaledMax_Creating.Items.Add("0.26");
            this.dudx_ScaledMax_Creating.Items.Add("0.27");
            this.dudx_ScaledMax_Creating.Items.Add("0.28");
            this.dudx_ScaledMax_Creating.Items.Add("0.29");
            this.dudx_ScaledMax_Creating.Items.Add("0.30");
            this.dudx_ScaledMax_Creating.Items.Add("0.31");
            this.dudx_ScaledMax_Creating.Items.Add("0.32");
            this.dudx_ScaledMax_Creating.Items.Add("0.33");
            this.dudx_ScaledMax_Creating.Items.Add("0.34");
            this.dudx_ScaledMax_Creating.Items.Add("0.35");
            this.dudx_ScaledMax_Creating.Items.Add("0.36");
            this.dudx_ScaledMax_Creating.Items.Add("0.37");
            this.dudx_ScaledMax_Creating.Items.Add("0.38");
            this.dudx_ScaledMax_Creating.Items.Add("0.39");
            this.dudx_ScaledMax_Creating.Items.Add("0.40");
            this.dudx_ScaledMax_Creating.Items.Add("0.41");
            this.dudx_ScaledMax_Creating.Items.Add("0.42");
            this.dudx_ScaledMax_Creating.Items.Add("0.43");
            this.dudx_ScaledMax_Creating.Items.Add("0.44");
            this.dudx_ScaledMax_Creating.Items.Add("0.45");
            this.dudx_ScaledMax_Creating.Items.Add("0.46");
            this.dudx_ScaledMax_Creating.Items.Add("0.47");
            this.dudx_ScaledMax_Creating.Items.Add("0.48");
            this.dudx_ScaledMax_Creating.Items.Add("0.49");
            this.dudx_ScaledMax_Creating.Items.Add("0.50");
            this.dudx_ScaledMax_Creating.Items.Add("0.51");
            this.dudx_ScaledMax_Creating.Items.Add("0.52");
            this.dudx_ScaledMax_Creating.Items.Add("0.53");
            this.dudx_ScaledMax_Creating.Items.Add("0.54");
            this.dudx_ScaledMax_Creating.Items.Add("0.55");
            this.dudx_ScaledMax_Creating.Items.Add("0.56");
            this.dudx_ScaledMax_Creating.Items.Add("0.57");
            this.dudx_ScaledMax_Creating.Items.Add("0.58");
            this.dudx_ScaledMax_Creating.Items.Add("0.59");
            this.dudx_ScaledMax_Creating.Items.Add("0.60");
            this.dudx_ScaledMax_Creating.Items.Add("0.61");
            this.dudx_ScaledMax_Creating.Items.Add("0.62");
            this.dudx_ScaledMax_Creating.Items.Add("0.63");
            this.dudx_ScaledMax_Creating.Items.Add("0.64");
            this.dudx_ScaledMax_Creating.Items.Add("0.65");
            this.dudx_ScaledMax_Creating.Items.Add("0.66");
            this.dudx_ScaledMax_Creating.Items.Add("0.67");
            this.dudx_ScaledMax_Creating.Items.Add("0.68");
            this.dudx_ScaledMax_Creating.Items.Add("0.69");
            this.dudx_ScaledMax_Creating.Items.Add("0.70");
            this.dudx_ScaledMax_Creating.Items.Add("0.71");
            this.dudx_ScaledMax_Creating.Items.Add("0.72");
            this.dudx_ScaledMax_Creating.Items.Add("0.73");
            this.dudx_ScaledMax_Creating.Items.Add("0.74");
            this.dudx_ScaledMax_Creating.Items.Add("0.75");
            this.dudx_ScaledMax_Creating.Items.Add("0.76");
            this.dudx_ScaledMax_Creating.Items.Add("0.77");
            this.dudx_ScaledMax_Creating.Items.Add("0.78");
            this.dudx_ScaledMax_Creating.Items.Add("0.79");
            this.dudx_ScaledMax_Creating.Items.Add("0.80");
            this.dudx_ScaledMax_Creating.Items.Add("0.81");
            this.dudx_ScaledMax_Creating.Items.Add("0.82");
            this.dudx_ScaledMax_Creating.Items.Add("0.83");
            this.dudx_ScaledMax_Creating.Items.Add("0.84");
            this.dudx_ScaledMax_Creating.Items.Add("0.85");
            this.dudx_ScaledMax_Creating.Items.Add("0.86");
            this.dudx_ScaledMax_Creating.Items.Add("0.87");
            this.dudx_ScaledMax_Creating.Items.Add("0.88");
            this.dudx_ScaledMax_Creating.Items.Add("0.89");
            this.dudx_ScaledMax_Creating.Items.Add("0.90");
            this.dudx_ScaledMax_Creating.Items.Add("0.91");
            this.dudx_ScaledMax_Creating.Items.Add("0.92");
            this.dudx_ScaledMax_Creating.Items.Add("0.93");
            this.dudx_ScaledMax_Creating.Items.Add("0.94");
            this.dudx_ScaledMax_Creating.Items.Add("0.95");
            this.dudx_ScaledMax_Creating.Items.Add("0.96");
            this.dudx_ScaledMax_Creating.Items.Add("0.97");
            this.dudx_ScaledMax_Creating.Items.Add("0.98");
            this.dudx_ScaledMax_Creating.Items.Add("0.99");
            this.dudx_ScaledMax_Creating.Items.Add("1.00");
            this.dudx_ScaledMax_Creating.Location = new System.Drawing.Point(329, 142);
            this.dudx_ScaledMax_Creating.Name = "dudx_ScaledMax_Creating";
            this.dudx_ScaledMax_Creating.Size = new System.Drawing.Size(120, 26);
            this.dudx_ScaledMax_Creating.TabIndex = 48;
            this.dudx_ScaledMax_Creating.Text = "1.20";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(240, 147);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 16);
            this.label20.TabIndex = 47;
            this.label20.Text = "最大缩放：";
            // 
            // dudx_ScaledMin_Creating
            // 
            this.dudx_ScaledMin_Creating.Items.Add("0.01");
            this.dudx_ScaledMin_Creating.Items.Add("0.02");
            this.dudx_ScaledMin_Creating.Items.Add("0.03");
            this.dudx_ScaledMin_Creating.Items.Add("0.04");
            this.dudx_ScaledMin_Creating.Items.Add("0.05");
            this.dudx_ScaledMin_Creating.Items.Add("0.06");
            this.dudx_ScaledMin_Creating.Items.Add("0.07");
            this.dudx_ScaledMin_Creating.Items.Add("0.08");
            this.dudx_ScaledMin_Creating.Items.Add("0.09");
            this.dudx_ScaledMin_Creating.Items.Add("0.10");
            this.dudx_ScaledMin_Creating.Items.Add("0.11");
            this.dudx_ScaledMin_Creating.Items.Add("0.12");
            this.dudx_ScaledMin_Creating.Items.Add("0.13");
            this.dudx_ScaledMin_Creating.Items.Add("0.14");
            this.dudx_ScaledMin_Creating.Items.Add("0.15");
            this.dudx_ScaledMin_Creating.Items.Add("0.16");
            this.dudx_ScaledMin_Creating.Items.Add("0.17");
            this.dudx_ScaledMin_Creating.Items.Add("0.18");
            this.dudx_ScaledMin_Creating.Items.Add("0.19");
            this.dudx_ScaledMin_Creating.Items.Add("0.20");
            this.dudx_ScaledMin_Creating.Items.Add("0.21");
            this.dudx_ScaledMin_Creating.Items.Add("0.22");
            this.dudx_ScaledMin_Creating.Items.Add("0.23");
            this.dudx_ScaledMin_Creating.Items.Add("0.24");
            this.dudx_ScaledMin_Creating.Items.Add("0.25");
            this.dudx_ScaledMin_Creating.Items.Add("0.26");
            this.dudx_ScaledMin_Creating.Items.Add("0.27");
            this.dudx_ScaledMin_Creating.Items.Add("0.28");
            this.dudx_ScaledMin_Creating.Items.Add("0.29");
            this.dudx_ScaledMin_Creating.Items.Add("0.30");
            this.dudx_ScaledMin_Creating.Items.Add("0.31");
            this.dudx_ScaledMin_Creating.Items.Add("0.32");
            this.dudx_ScaledMin_Creating.Items.Add("0.33");
            this.dudx_ScaledMin_Creating.Items.Add("0.34");
            this.dudx_ScaledMin_Creating.Items.Add("0.35");
            this.dudx_ScaledMin_Creating.Items.Add("0.36");
            this.dudx_ScaledMin_Creating.Items.Add("0.37");
            this.dudx_ScaledMin_Creating.Items.Add("0.38");
            this.dudx_ScaledMin_Creating.Items.Add("0.39");
            this.dudx_ScaledMin_Creating.Items.Add("0.40");
            this.dudx_ScaledMin_Creating.Items.Add("0.41");
            this.dudx_ScaledMin_Creating.Items.Add("0.42");
            this.dudx_ScaledMin_Creating.Items.Add("0.43");
            this.dudx_ScaledMin_Creating.Items.Add("0.44");
            this.dudx_ScaledMin_Creating.Items.Add("0.45");
            this.dudx_ScaledMin_Creating.Items.Add("0.46");
            this.dudx_ScaledMin_Creating.Items.Add("0.47");
            this.dudx_ScaledMin_Creating.Items.Add("0.48");
            this.dudx_ScaledMin_Creating.Items.Add("0.49");
            this.dudx_ScaledMin_Creating.Items.Add("0.50");
            this.dudx_ScaledMin_Creating.Items.Add("0.51");
            this.dudx_ScaledMin_Creating.Items.Add("0.52");
            this.dudx_ScaledMin_Creating.Items.Add("0.53");
            this.dudx_ScaledMin_Creating.Items.Add("0.54");
            this.dudx_ScaledMin_Creating.Items.Add("0.55");
            this.dudx_ScaledMin_Creating.Items.Add("0.56");
            this.dudx_ScaledMin_Creating.Items.Add("0.57");
            this.dudx_ScaledMin_Creating.Items.Add("0.58");
            this.dudx_ScaledMin_Creating.Items.Add("0.59");
            this.dudx_ScaledMin_Creating.Items.Add("0.60");
            this.dudx_ScaledMin_Creating.Items.Add("0.61");
            this.dudx_ScaledMin_Creating.Items.Add("0.62");
            this.dudx_ScaledMin_Creating.Items.Add("0.63");
            this.dudx_ScaledMin_Creating.Items.Add("0.64");
            this.dudx_ScaledMin_Creating.Items.Add("0.65");
            this.dudx_ScaledMin_Creating.Items.Add("0.66");
            this.dudx_ScaledMin_Creating.Items.Add("0.67");
            this.dudx_ScaledMin_Creating.Items.Add("0.68");
            this.dudx_ScaledMin_Creating.Items.Add("0.69");
            this.dudx_ScaledMin_Creating.Items.Add("0.70");
            this.dudx_ScaledMin_Creating.Items.Add("0.71");
            this.dudx_ScaledMin_Creating.Items.Add("0.72");
            this.dudx_ScaledMin_Creating.Items.Add("0.73");
            this.dudx_ScaledMin_Creating.Items.Add("0.74");
            this.dudx_ScaledMin_Creating.Items.Add("0.75");
            this.dudx_ScaledMin_Creating.Items.Add("0.76");
            this.dudx_ScaledMin_Creating.Items.Add("0.77");
            this.dudx_ScaledMin_Creating.Items.Add("0.78");
            this.dudx_ScaledMin_Creating.Items.Add("0.79");
            this.dudx_ScaledMin_Creating.Items.Add("0.80");
            this.dudx_ScaledMin_Creating.Items.Add("0.81");
            this.dudx_ScaledMin_Creating.Items.Add("0.82");
            this.dudx_ScaledMin_Creating.Items.Add("0.83");
            this.dudx_ScaledMin_Creating.Items.Add("0.84");
            this.dudx_ScaledMin_Creating.Items.Add("0.85");
            this.dudx_ScaledMin_Creating.Items.Add("0.86");
            this.dudx_ScaledMin_Creating.Items.Add("0.87");
            this.dudx_ScaledMin_Creating.Items.Add("0.88");
            this.dudx_ScaledMin_Creating.Items.Add("0.89");
            this.dudx_ScaledMin_Creating.Items.Add("0.90");
            this.dudx_ScaledMin_Creating.Items.Add("0.91");
            this.dudx_ScaledMin_Creating.Items.Add("0.92");
            this.dudx_ScaledMin_Creating.Items.Add("0.93");
            this.dudx_ScaledMin_Creating.Items.Add("0.94");
            this.dudx_ScaledMin_Creating.Items.Add("0.95");
            this.dudx_ScaledMin_Creating.Items.Add("0.96");
            this.dudx_ScaledMin_Creating.Items.Add("0.97");
            this.dudx_ScaledMin_Creating.Items.Add("0.98");
            this.dudx_ScaledMin_Creating.Items.Add("0.99");
            this.dudx_ScaledMin_Creating.Items.Add("1.00");
            this.dudx_ScaledMin_Creating.Location = new System.Drawing.Point(108, 142);
            this.dudx_ScaledMin_Creating.Name = "dudx_ScaledMin_Creating";
            this.dudx_ScaledMin_Creating.Size = new System.Drawing.Size(120, 26);
            this.dudx_ScaledMin_Creating.TabIndex = 46;
            this.dudx_ScaledMin_Creating.Text = "0.80";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(16, 147);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(87, 16);
            this.label21.TabIndex = 45;
            this.label21.Text = "最小缩放：";
            // 
            // dudx__NumLevels_Creating
            // 
            this.dudx__NumLevels_Creating.Items.Add("auto");
            this.dudx__NumLevels_Creating.Items.Add("0");
            this.dudx__NumLevels_Creating.Items.Add("1");
            this.dudx__NumLevels_Creating.Items.Add("2");
            this.dudx__NumLevels_Creating.Items.Add("3");
            this.dudx__NumLevels_Creating.Items.Add("4");
            this.dudx__NumLevels_Creating.Items.Add("5");
            this.dudx__NumLevels_Creating.Items.Add("6");
            this.dudx__NumLevels_Creating.Items.Add("7");
            this.dudx__NumLevels_Creating.Items.Add("8");
            this.dudx__NumLevels_Creating.Items.Add("9");
            this.dudx__NumLevels_Creating.Items.Add("10");
            this.dudx__NumLevels_Creating.Location = new System.Drawing.Point(115, 226);
            this.dudx__NumLevels_Creating.Name = "dudx__NumLevels_Creating";
            this.dudx__NumLevels_Creating.Size = new System.Drawing.Size(120, 26);
            this.dudx__NumLevels_Creating.TabIndex = 19;
            this.dudx__NumLevels_Creating.Text = "2";
            // 
            // dudx_MinContrast_Creating
            // 
            this.dudx_MinContrast_Creating.Items.Add("auto");
            this.dudx_MinContrast_Creating.Items.Add("1");
            this.dudx_MinContrast_Creating.Items.Add("2");
            this.dudx_MinContrast_Creating.Items.Add("3");
            this.dudx_MinContrast_Creating.Items.Add("5");
            this.dudx_MinContrast_Creating.Items.Add("7");
            this.dudx_MinContrast_Creating.Items.Add("10");
            this.dudx_MinContrast_Creating.Items.Add("20");
            this.dudx_MinContrast_Creating.Items.Add("30");
            this.dudx_MinContrast_Creating.Items.Add("40");
            this.dudx_MinContrast_Creating.Items.Add("254");
            this.dudx_MinContrast_Creating.Location = new System.Drawing.Point(327, 74);
            this.dudx_MinContrast_Creating.Name = "dudx_MinContrast_Creating";
            this.dudx_MinContrast_Creating.Size = new System.Drawing.Size(120, 26);
            this.dudx_MinContrast_Creating.TabIndex = 18;
            this.dudx_MinContrast_Creating.Text = "10";
            // 
            // dudx_Contrast_Creating
            // 
            this.dudx_Contrast_Creating.Items.Add("auto");
            this.dudx_Contrast_Creating.Items.Add("auto_contrast");
            this.dudx_Contrast_Creating.Items.Add("auto_contrast_hyst");
            this.dudx_Contrast_Creating.Items.Add("auto_min_size");
            this.dudx_Contrast_Creating.Items.Add("10");
            this.dudx_Contrast_Creating.Items.Add("20");
            this.dudx_Contrast_Creating.Items.Add("30");
            this.dudx_Contrast_Creating.Items.Add("40");
            this.dudx_Contrast_Creating.Items.Add("60");
            this.dudx_Contrast_Creating.Items.Add("80");
            this.dudx_Contrast_Creating.Items.Add("100");
            this.dudx_Contrast_Creating.Items.Add("120");
            this.dudx_Contrast_Creating.Items.Add("140");
            this.dudx_Contrast_Creating.Items.Add("160");
            this.dudx_Contrast_Creating.Location = new System.Drawing.Point(327, 30);
            this.dudx_Contrast_Creating.Name = "dudx_Contrast_Creating";
            this.dudx_Contrast_Creating.Size = new System.Drawing.Size(120, 26);
            this.dudx_Contrast_Creating.TabIndex = 17;
            this.dudx_Contrast_Creating.Text = "30";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "金字塔层数：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "最小阈值：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "阈值：";
            // 
            // cbx_Metric_Creating
            // 
            this.cbx_Metric_Creating.FormattingEnabled = true;
            this.cbx_Metric_Creating.Items.AddRange(new object[] {
            "ignore_color_polarity",
            "ignore_global_polarity",
            "ignore_local_polarity",
            "use_polarity"});
            this.cbx_Metric_Creating.Location = new System.Drawing.Point(256, 274);
            this.cbx_Metric_Creating.Name = "cbx_Metric_Creating";
            this.cbx_Metric_Creating.Size = new System.Drawing.Size(193, 24);
            this.cbx_Metric_Creating.TabIndex = 9;
            this.cbx_Metric_Creating.Text = "use_polarity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "匹配方法：";
            // 
            // cbx_Optimization_Creating
            // 
            this.cbx_Optimization_Creating.FormattingEnabled = true;
            this.cbx_Optimization_Creating.Items.AddRange(new object[] {
            "auto",
            "no_pregeneration",
            "none",
            "point_reduction_high",
            "point_reduction_low",
            "point_reduction_medium",
            "pregeneration"});
            this.cbx_Optimization_Creating.Location = new System.Drawing.Point(109, 189);
            this.cbx_Optimization_Creating.Name = "cbx_Optimization_Creating";
            this.cbx_Optimization_Creating.Size = new System.Drawing.Size(194, 24);
            this.cbx_Optimization_Creating.TabIndex = 7;
            this.cbx_Optimization_Creating.Text = "auto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "优化方法：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "角度步长：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "角度范围：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "起始角度：";
            // 
            // tbx_AngleStart_Creating
            // 
            this.tbx_AngleStart_Creating.Location = new System.Drawing.Point(109, 29);
            this.tbx_AngleStart_Creating.Name = "tbx_AngleStart_Creating";
            this.tbx_AngleStart_Creating.Size = new System.Drawing.Size(113, 26);
            this.tbx_AngleStart_Creating.TabIndex = 1;
            this.tbx_AngleStart_Creating.Text = "-180";
            // 
            // tbx_AngleStep_Creating
            // 
            this.tbx_AngleStep_Creating.Location = new System.Drawing.Point(109, 100);
            this.tbx_AngleStep_Creating.Name = "tbx_AngleStep_Creating";
            this.tbx_AngleStep_Creating.Size = new System.Drawing.Size(113, 26);
            this.tbx_AngleStep_Creating.TabIndex = 0;
            this.tbx_AngleStep_Creating.Text = "0";
            // 
            // tbx_AngleExtent_Creating
            // 
            this.tbx_AngleExtent_Creating.Location = new System.Drawing.Point(109, 66);
            this.tbx_AngleExtent_Creating.Name = "tbx_AngleExtent_Creating";
            this.tbx_AngleExtent_Creating.Size = new System.Drawing.Size(113, 26);
            this.tbx_AngleExtent_Creating.TabIndex = 0;
            this.tbx_AngleExtent_Creating.Text = "360";
            // 
            // panel_CreateTemplateOperate
            // 
            this.panel_CreateTemplateOperate.Controls.Add(this.label22);
            this.panel_CreateTemplateOperate.Controls.Add(this.btn_FlushCreateingParams);
            this.panel_CreateTemplateOperate.Controls.Add(this.btn_ConfirmParam);
            this.panel_CreateTemplateOperate.Controls.Add(this.comboBox1);
            this.panel_CreateTemplateOperate.Controls.Add(this.numUD_EraserSize);
            this.panel_CreateTemplateOperate.Controls.Add(this.btn_Eraser);
            this.panel_CreateTemplateOperate.Controls.Add(this.cbx_DrawObjectList);
            this.panel_CreateTemplateOperate.Controls.Add(this.btn_CreateTemplate);
            this.panel_CreateTemplateOperate.Controls.Add(this.btn_DrawROI);
            this.panel_CreateTemplateOperate.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_CreateTemplateOperate.Location = new System.Drawing.Point(3, 3);
            this.panel_CreateTemplateOperate.Name = "panel_CreateTemplateOperate";
            this.panel_CreateTemplateOperate.Size = new System.Drawing.Size(452, 125);
            this.panel_CreateTemplateOperate.TabIndex = 5;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 95);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 16);
            this.label22.TabIndex = 46;
            this.label22.Text = "匹配算子：";
            // 
            // btn_FlushCreateingParams
            // 
            this.btn_FlushCreateingParams.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_FlushCreateingParams.Location = new System.Drawing.Point(345, 53);
            this.btn_FlushCreateingParams.Name = "btn_FlushCreateingParams";
            this.btn_FlushCreateingParams.Size = new System.Drawing.Size(102, 33);
            this.btn_FlushCreateingParams.TabIndex = 8;
            this.btn_FlushCreateingParams.Text = "刷新参数";
            this.btn_FlushCreateingParams.UseVisualStyleBackColor = true;
            this.btn_FlushCreateingParams.Click += new System.EventHandler(this.btn_FlushCreateingParams_Click);
            // 
            // btn_ConfirmParam
            // 
            this.btn_ConfirmParam.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_ConfirmParam.Location = new System.Drawing.Point(347, 4);
            this.btn_ConfirmParam.Name = "btn_ConfirmParam";
            this.btn_ConfirmParam.Size = new System.Drawing.Size(102, 33);
            this.btn_ConfirmParam.TabIndex = 7;
            this.btn_ConfirmParam.Text = "确认参数";
            this.btn_ConfirmParam.UseVisualStyleBackColor = true;
            this.btn_ConfirmParam.Click += new System.EventHandler(this.btn_ConfirmParam_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CreateScaleShapeModel",
            "CreateShapeModel"});
            this.comboBox1.Location = new System.Drawing.Point(99, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 24);
            this.comboBox1.TabIndex = 47;
            this.comboBox1.Text = "CreateScaleShapeModel";
            // 
            // numUD_EraserSize
            // 
            this.numUD_EraserSize.Location = new System.Drawing.Point(122, 43);
            this.numUD_EraserSize.Name = "numUD_EraserSize";
            this.numUD_EraserSize.Size = new System.Drawing.Size(120, 26);
            this.numUD_EraserSize.TabIndex = 6;
            this.numUD_EraserSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btn_Eraser
            // 
            this.btn_Eraser.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_Eraser.Location = new System.Drawing.Point(14, 43);
            this.btn_Eraser.Name = "btn_Eraser";
            this.btn_Eraser.Size = new System.Drawing.Size(102, 33);
            this.btn_Eraser.TabIndex = 5;
            this.btn_Eraser.Text = "橡皮擦";
            this.btn_Eraser.UseVisualStyleBackColor = true;
            // 
            // cbx_DrawObjectList
            // 
            this.cbx_DrawObjectList.Font = new System.Drawing.Font("宋体", 14F);
            this.cbx_DrawObjectList.FormattingEnabled = true;
            this.cbx_DrawObjectList.Location = new System.Drawing.Point(122, 4);
            this.cbx_DrawObjectList.Name = "cbx_DrawObjectList";
            this.cbx_DrawObjectList.Size = new System.Drawing.Size(160, 27);
            this.cbx_DrawObjectList.TabIndex = 3;
            this.cbx_DrawObjectList.SelectedIndexChanged += new System.EventHandler(this.cbx_DrawObjectList_SelectedIndexChanged);
            // 
            // btn_CreateTemplate
            // 
            this.btn_CreateTemplate.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_CreateTemplate.Location = new System.Drawing.Point(345, 92);
            this.btn_CreateTemplate.Name = "btn_CreateTemplate";
            this.btn_CreateTemplate.Size = new System.Drawing.Size(102, 33);
            this.btn_CreateTemplate.TabIndex = 4;
            this.btn_CreateTemplate.Text = "创建模板";
            this.btn_CreateTemplate.UseVisualStyleBackColor = true;
            this.btn_CreateTemplate.Click += new System.EventHandler(this.btn_CreateTemplate_Click);
            // 
            // btn_DrawROI
            // 
            this.btn_DrawROI.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_DrawROI.Location = new System.Drawing.Point(14, 4);
            this.btn_DrawROI.Name = "btn_DrawROI";
            this.btn_DrawROI.Size = new System.Drawing.Size(102, 33);
            this.btn_DrawROI.TabIndex = 2;
            this.btn_DrawROI.Text = "绘制ROI";
            this.btn_DrawROI.UseVisualStyleBackColor = true;
            this.btn_DrawROI.Click += new System.EventHandler(this.btn_DrawROI_Click);
            // 
            // tabPage_RoiList
            // 
            this.tabPage_RoiList.Controls.Add(this.lbx_RoiList);
            this.tabPage_RoiList.Location = new System.Drawing.Point(4, 26);
            this.tabPage_RoiList.Name = "tabPage_RoiList";
            this.tabPage_RoiList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_RoiList.Size = new System.Drawing.Size(458, 442);
            this.tabPage_RoiList.TabIndex = 1;
            this.tabPage_RoiList.Text = "ROI列表";
            this.tabPage_RoiList.UseVisualStyleBackColor = true;
            // 
            // lbx_RoiList
            // 
            this.lbx_RoiList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbx_RoiList.FormattingEnabled = true;
            this.lbx_RoiList.ItemHeight = 16;
            this.lbx_RoiList.Location = new System.Drawing.Point(3, 3);
            this.lbx_RoiList.Name = "lbx_RoiList";
            this.lbx_RoiList.Size = new System.Drawing.Size(452, 436);
            this.lbx_RoiList.TabIndex = 3;
            this.lbx_RoiList.SelectedIndexChanged += new System.EventHandler(this.lbx_RoiList_SelectedIndexChanged);
            this.lbx_RoiList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbx_RoiList_MouseDown);
            // 
            // tabPage_MatchParams
            // 
            this.tabPage_MatchParams.Controls.Add(this.panel_FindTemplateParam);
            this.tabPage_MatchParams.Controls.Add(this.panel_FindTemplateOperate);
            this.tabPage_MatchParams.Location = new System.Drawing.Point(4, 26);
            this.tabPage_MatchParams.Name = "tabPage_MatchParams";
            this.tabPage_MatchParams.Size = new System.Drawing.Size(458, 442);
            this.tabPage_MatchParams.TabIndex = 2;
            this.tabPage_MatchParams.Text = "匹配参数";
            this.tabPage_MatchParams.UseVisualStyleBackColor = true;
            // 
            // panel_FindTemplateParam
            // 
            this.panel_FindTemplateParam.BackColor = System.Drawing.Color.DarkGray;
            this.panel_FindTemplateParam.Controls.Add(this.dudx_MaxScale_Matching);
            this.panel_FindTemplateParam.Controls.Add(this.label18);
            this.panel_FindTemplateParam.Controls.Add(this.dudx_MixScale_Matching);
            this.panel_FindTemplateParam.Controls.Add(this.label14);
            this.panel_FindTemplateParam.Controls.Add(this.dudx_Greediness_Matching);
            this.panel_FindTemplateParam.Controls.Add(this.label17);
            this.panel_FindTemplateParam.Controls.Add(this.dudx_MaxOverlap_Matching);
            this.panel_FindTemplateParam.Controls.Add(this.label13);
            this.panel_FindTemplateParam.Controls.Add(this.nudx_NumMatches_Matching);
            this.panel_FindTemplateParam.Controls.Add(this.dudx_NumLevels_Matching);
            this.panel_FindTemplateParam.Controls.Add(this.dudx_MinScore_Matching);
            this.panel_FindTemplateParam.Controls.Add(this.label9);
            this.panel_FindTemplateParam.Controls.Add(this.label10);
            this.panel_FindTemplateParam.Controls.Add(this.label11);
            this.panel_FindTemplateParam.Controls.Add(this.cbx_SubPixel_Matching);
            this.panel_FindTemplateParam.Controls.Add(this.label12);
            this.panel_FindTemplateParam.Controls.Add(this.label15);
            this.panel_FindTemplateParam.Controls.Add(this.label16);
            this.panel_FindTemplateParam.Controls.Add(this.tbx_AngleStart_Matching);
            this.panel_FindTemplateParam.Controls.Add(this.tbx_AngleExtent_Matching);
            this.panel_FindTemplateParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_FindTemplateParam.Location = new System.Drawing.Point(0, 100);
            this.panel_FindTemplateParam.Name = "panel_FindTemplateParam";
            this.panel_FindTemplateParam.Size = new System.Drawing.Size(458, 342);
            this.panel_FindTemplateParam.TabIndex = 7;
            // 
            // dudx_MaxScale_Matching
            // 
            this.dudx_MaxScale_Matching.Items.Add("0.01");
            this.dudx_MaxScale_Matching.Items.Add("0.02");
            this.dudx_MaxScale_Matching.Items.Add("0.03");
            this.dudx_MaxScale_Matching.Items.Add("0.04");
            this.dudx_MaxScale_Matching.Items.Add("0.05");
            this.dudx_MaxScale_Matching.Items.Add("0.06");
            this.dudx_MaxScale_Matching.Items.Add("0.07");
            this.dudx_MaxScale_Matching.Items.Add("0.08");
            this.dudx_MaxScale_Matching.Items.Add("0.09");
            this.dudx_MaxScale_Matching.Items.Add("0.10");
            this.dudx_MaxScale_Matching.Items.Add("0.11");
            this.dudx_MaxScale_Matching.Items.Add("0.12");
            this.dudx_MaxScale_Matching.Items.Add("0.13");
            this.dudx_MaxScale_Matching.Items.Add("0.14");
            this.dudx_MaxScale_Matching.Items.Add("0.15");
            this.dudx_MaxScale_Matching.Items.Add("0.16");
            this.dudx_MaxScale_Matching.Items.Add("0.17");
            this.dudx_MaxScale_Matching.Items.Add("0.18");
            this.dudx_MaxScale_Matching.Items.Add("0.19");
            this.dudx_MaxScale_Matching.Items.Add("0.20");
            this.dudx_MaxScale_Matching.Items.Add("0.21");
            this.dudx_MaxScale_Matching.Items.Add("0.22");
            this.dudx_MaxScale_Matching.Items.Add("0.23");
            this.dudx_MaxScale_Matching.Items.Add("0.24");
            this.dudx_MaxScale_Matching.Items.Add("0.25");
            this.dudx_MaxScale_Matching.Items.Add("0.26");
            this.dudx_MaxScale_Matching.Items.Add("0.27");
            this.dudx_MaxScale_Matching.Items.Add("0.28");
            this.dudx_MaxScale_Matching.Items.Add("0.29");
            this.dudx_MaxScale_Matching.Items.Add("0.30");
            this.dudx_MaxScale_Matching.Items.Add("0.31");
            this.dudx_MaxScale_Matching.Items.Add("0.32");
            this.dudx_MaxScale_Matching.Items.Add("0.33");
            this.dudx_MaxScale_Matching.Items.Add("0.34");
            this.dudx_MaxScale_Matching.Items.Add("0.35");
            this.dudx_MaxScale_Matching.Items.Add("0.36");
            this.dudx_MaxScale_Matching.Items.Add("0.37");
            this.dudx_MaxScale_Matching.Items.Add("0.38");
            this.dudx_MaxScale_Matching.Items.Add("0.39");
            this.dudx_MaxScale_Matching.Items.Add("0.40");
            this.dudx_MaxScale_Matching.Items.Add("0.41");
            this.dudx_MaxScale_Matching.Items.Add("0.42");
            this.dudx_MaxScale_Matching.Items.Add("0.43");
            this.dudx_MaxScale_Matching.Items.Add("0.44");
            this.dudx_MaxScale_Matching.Items.Add("0.45");
            this.dudx_MaxScale_Matching.Items.Add("0.46");
            this.dudx_MaxScale_Matching.Items.Add("0.47");
            this.dudx_MaxScale_Matching.Items.Add("0.48");
            this.dudx_MaxScale_Matching.Items.Add("0.49");
            this.dudx_MaxScale_Matching.Items.Add("0.50");
            this.dudx_MaxScale_Matching.Items.Add("0.51");
            this.dudx_MaxScale_Matching.Items.Add("0.52");
            this.dudx_MaxScale_Matching.Items.Add("0.53");
            this.dudx_MaxScale_Matching.Items.Add("0.54");
            this.dudx_MaxScale_Matching.Items.Add("0.55");
            this.dudx_MaxScale_Matching.Items.Add("0.56");
            this.dudx_MaxScale_Matching.Items.Add("0.57");
            this.dudx_MaxScale_Matching.Items.Add("0.58");
            this.dudx_MaxScale_Matching.Items.Add("0.59");
            this.dudx_MaxScale_Matching.Items.Add("0.60");
            this.dudx_MaxScale_Matching.Items.Add("0.61");
            this.dudx_MaxScale_Matching.Items.Add("0.62");
            this.dudx_MaxScale_Matching.Items.Add("0.63");
            this.dudx_MaxScale_Matching.Items.Add("0.64");
            this.dudx_MaxScale_Matching.Items.Add("0.65");
            this.dudx_MaxScale_Matching.Items.Add("0.66");
            this.dudx_MaxScale_Matching.Items.Add("0.67");
            this.dudx_MaxScale_Matching.Items.Add("0.68");
            this.dudx_MaxScale_Matching.Items.Add("0.69");
            this.dudx_MaxScale_Matching.Items.Add("0.70");
            this.dudx_MaxScale_Matching.Items.Add("0.71");
            this.dudx_MaxScale_Matching.Items.Add("0.72");
            this.dudx_MaxScale_Matching.Items.Add("0.73");
            this.dudx_MaxScale_Matching.Items.Add("0.74");
            this.dudx_MaxScale_Matching.Items.Add("0.75");
            this.dudx_MaxScale_Matching.Items.Add("0.76");
            this.dudx_MaxScale_Matching.Items.Add("0.77");
            this.dudx_MaxScale_Matching.Items.Add("0.78");
            this.dudx_MaxScale_Matching.Items.Add("0.79");
            this.dudx_MaxScale_Matching.Items.Add("0.80");
            this.dudx_MaxScale_Matching.Items.Add("0.81");
            this.dudx_MaxScale_Matching.Items.Add("0.82");
            this.dudx_MaxScale_Matching.Items.Add("0.83");
            this.dudx_MaxScale_Matching.Items.Add("0.84");
            this.dudx_MaxScale_Matching.Items.Add("0.85");
            this.dudx_MaxScale_Matching.Items.Add("0.86");
            this.dudx_MaxScale_Matching.Items.Add("0.87");
            this.dudx_MaxScale_Matching.Items.Add("0.88");
            this.dudx_MaxScale_Matching.Items.Add("0.89");
            this.dudx_MaxScale_Matching.Items.Add("0.90");
            this.dudx_MaxScale_Matching.Items.Add("0.91");
            this.dudx_MaxScale_Matching.Items.Add("0.92");
            this.dudx_MaxScale_Matching.Items.Add("0.93");
            this.dudx_MaxScale_Matching.Items.Add("0.94");
            this.dudx_MaxScale_Matching.Items.Add("0.95");
            this.dudx_MaxScale_Matching.Items.Add("0.96");
            this.dudx_MaxScale_Matching.Items.Add("0.97");
            this.dudx_MaxScale_Matching.Items.Add("0.98");
            this.dudx_MaxScale_Matching.Items.Add("0.99");
            this.dudx_MaxScale_Matching.Items.Add("1.00");
            this.dudx_MaxScale_Matching.Location = new System.Drawing.Point(325, 188);
            this.dudx_MaxScale_Matching.Name = "dudx_MaxScale_Matching";
            this.dudx_MaxScale_Matching.Size = new System.Drawing.Size(120, 26);
            this.dudx_MaxScale_Matching.TabIndex = 44;
            this.dudx_MaxScale_Matching.Text = "1.20";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(236, 193);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 16);
            this.label18.TabIndex = 43;
            this.label18.Text = "最大缩放：";
            // 
            // dudx_MixScale_Matching
            // 
            this.dudx_MixScale_Matching.Items.Add("0.01");
            this.dudx_MixScale_Matching.Items.Add("0.02");
            this.dudx_MixScale_Matching.Items.Add("0.03");
            this.dudx_MixScale_Matching.Items.Add("0.04");
            this.dudx_MixScale_Matching.Items.Add("0.05");
            this.dudx_MixScale_Matching.Items.Add("0.06");
            this.dudx_MixScale_Matching.Items.Add("0.07");
            this.dudx_MixScale_Matching.Items.Add("0.08");
            this.dudx_MixScale_Matching.Items.Add("0.09");
            this.dudx_MixScale_Matching.Items.Add("0.10");
            this.dudx_MixScale_Matching.Items.Add("0.11");
            this.dudx_MixScale_Matching.Items.Add("0.12");
            this.dudx_MixScale_Matching.Items.Add("0.13");
            this.dudx_MixScale_Matching.Items.Add("0.14");
            this.dudx_MixScale_Matching.Items.Add("0.15");
            this.dudx_MixScale_Matching.Items.Add("0.16");
            this.dudx_MixScale_Matching.Items.Add("0.17");
            this.dudx_MixScale_Matching.Items.Add("0.18");
            this.dudx_MixScale_Matching.Items.Add("0.19");
            this.dudx_MixScale_Matching.Items.Add("0.20");
            this.dudx_MixScale_Matching.Items.Add("0.21");
            this.dudx_MixScale_Matching.Items.Add("0.22");
            this.dudx_MixScale_Matching.Items.Add("0.23");
            this.dudx_MixScale_Matching.Items.Add("0.24");
            this.dudx_MixScale_Matching.Items.Add("0.25");
            this.dudx_MixScale_Matching.Items.Add("0.26");
            this.dudx_MixScale_Matching.Items.Add("0.27");
            this.dudx_MixScale_Matching.Items.Add("0.28");
            this.dudx_MixScale_Matching.Items.Add("0.29");
            this.dudx_MixScale_Matching.Items.Add("0.30");
            this.dudx_MixScale_Matching.Items.Add("0.31");
            this.dudx_MixScale_Matching.Items.Add("0.32");
            this.dudx_MixScale_Matching.Items.Add("0.33");
            this.dudx_MixScale_Matching.Items.Add("0.34");
            this.dudx_MixScale_Matching.Items.Add("0.35");
            this.dudx_MixScale_Matching.Items.Add("0.36");
            this.dudx_MixScale_Matching.Items.Add("0.37");
            this.dudx_MixScale_Matching.Items.Add("0.38");
            this.dudx_MixScale_Matching.Items.Add("0.39");
            this.dudx_MixScale_Matching.Items.Add("0.40");
            this.dudx_MixScale_Matching.Items.Add("0.41");
            this.dudx_MixScale_Matching.Items.Add("0.42");
            this.dudx_MixScale_Matching.Items.Add("0.43");
            this.dudx_MixScale_Matching.Items.Add("0.44");
            this.dudx_MixScale_Matching.Items.Add("0.45");
            this.dudx_MixScale_Matching.Items.Add("0.46");
            this.dudx_MixScale_Matching.Items.Add("0.47");
            this.dudx_MixScale_Matching.Items.Add("0.48");
            this.dudx_MixScale_Matching.Items.Add("0.49");
            this.dudx_MixScale_Matching.Items.Add("0.50");
            this.dudx_MixScale_Matching.Items.Add("0.51");
            this.dudx_MixScale_Matching.Items.Add("0.52");
            this.dudx_MixScale_Matching.Items.Add("0.53");
            this.dudx_MixScale_Matching.Items.Add("0.54");
            this.dudx_MixScale_Matching.Items.Add("0.55");
            this.dudx_MixScale_Matching.Items.Add("0.56");
            this.dudx_MixScale_Matching.Items.Add("0.57");
            this.dudx_MixScale_Matching.Items.Add("0.58");
            this.dudx_MixScale_Matching.Items.Add("0.59");
            this.dudx_MixScale_Matching.Items.Add("0.60");
            this.dudx_MixScale_Matching.Items.Add("0.61");
            this.dudx_MixScale_Matching.Items.Add("0.62");
            this.dudx_MixScale_Matching.Items.Add("0.63");
            this.dudx_MixScale_Matching.Items.Add("0.64");
            this.dudx_MixScale_Matching.Items.Add("0.65");
            this.dudx_MixScale_Matching.Items.Add("0.66");
            this.dudx_MixScale_Matching.Items.Add("0.67");
            this.dudx_MixScale_Matching.Items.Add("0.68");
            this.dudx_MixScale_Matching.Items.Add("0.69");
            this.dudx_MixScale_Matching.Items.Add("0.70");
            this.dudx_MixScale_Matching.Items.Add("0.71");
            this.dudx_MixScale_Matching.Items.Add("0.72");
            this.dudx_MixScale_Matching.Items.Add("0.73");
            this.dudx_MixScale_Matching.Items.Add("0.74");
            this.dudx_MixScale_Matching.Items.Add("0.75");
            this.dudx_MixScale_Matching.Items.Add("0.76");
            this.dudx_MixScale_Matching.Items.Add("0.77");
            this.dudx_MixScale_Matching.Items.Add("0.78");
            this.dudx_MixScale_Matching.Items.Add("0.79");
            this.dudx_MixScale_Matching.Items.Add("0.80");
            this.dudx_MixScale_Matching.Items.Add("0.81");
            this.dudx_MixScale_Matching.Items.Add("0.82");
            this.dudx_MixScale_Matching.Items.Add("0.83");
            this.dudx_MixScale_Matching.Items.Add("0.84");
            this.dudx_MixScale_Matching.Items.Add("0.85");
            this.dudx_MixScale_Matching.Items.Add("0.86");
            this.dudx_MixScale_Matching.Items.Add("0.87");
            this.dudx_MixScale_Matching.Items.Add("0.88");
            this.dudx_MixScale_Matching.Items.Add("0.89");
            this.dudx_MixScale_Matching.Items.Add("0.90");
            this.dudx_MixScale_Matching.Items.Add("0.91");
            this.dudx_MixScale_Matching.Items.Add("0.92");
            this.dudx_MixScale_Matching.Items.Add("0.93");
            this.dudx_MixScale_Matching.Items.Add("0.94");
            this.dudx_MixScale_Matching.Items.Add("0.95");
            this.dudx_MixScale_Matching.Items.Add("0.96");
            this.dudx_MixScale_Matching.Items.Add("0.97");
            this.dudx_MixScale_Matching.Items.Add("0.98");
            this.dudx_MixScale_Matching.Items.Add("0.99");
            this.dudx_MixScale_Matching.Items.Add("1.00");
            this.dudx_MixScale_Matching.Location = new System.Drawing.Point(108, 188);
            this.dudx_MixScale_Matching.Name = "dudx_MixScale_Matching";
            this.dudx_MixScale_Matching.Size = new System.Drawing.Size(120, 26);
            this.dudx_MixScale_Matching.TabIndex = 42;
            this.dudx_MixScale_Matching.Text = "0.80";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 193);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 16);
            this.label14.TabIndex = 41;
            this.label14.Text = "最小缩放：";
            // 
            // dudx_Greediness_Matching
            // 
            this.dudx_Greediness_Matching.Items.Add("0.01");
            this.dudx_Greediness_Matching.Items.Add("0.02");
            this.dudx_Greediness_Matching.Items.Add("0.03");
            this.dudx_Greediness_Matching.Items.Add("0.04");
            this.dudx_Greediness_Matching.Items.Add("0.05");
            this.dudx_Greediness_Matching.Items.Add("0.06");
            this.dudx_Greediness_Matching.Items.Add("0.07");
            this.dudx_Greediness_Matching.Items.Add("0.08");
            this.dudx_Greediness_Matching.Items.Add("0.09");
            this.dudx_Greediness_Matching.Items.Add("0.10");
            this.dudx_Greediness_Matching.Items.Add("0.11");
            this.dudx_Greediness_Matching.Items.Add("0.12");
            this.dudx_Greediness_Matching.Items.Add("0.13");
            this.dudx_Greediness_Matching.Items.Add("0.14");
            this.dudx_Greediness_Matching.Items.Add("0.15");
            this.dudx_Greediness_Matching.Items.Add("0.16");
            this.dudx_Greediness_Matching.Items.Add("0.17");
            this.dudx_Greediness_Matching.Items.Add("0.18");
            this.dudx_Greediness_Matching.Items.Add("0.19");
            this.dudx_Greediness_Matching.Items.Add("0.20");
            this.dudx_Greediness_Matching.Items.Add("0.21");
            this.dudx_Greediness_Matching.Items.Add("0.22");
            this.dudx_Greediness_Matching.Items.Add("0.23");
            this.dudx_Greediness_Matching.Items.Add("0.24");
            this.dudx_Greediness_Matching.Items.Add("0.25");
            this.dudx_Greediness_Matching.Items.Add("0.26");
            this.dudx_Greediness_Matching.Items.Add("0.27");
            this.dudx_Greediness_Matching.Items.Add("0.28");
            this.dudx_Greediness_Matching.Items.Add("0.29");
            this.dudx_Greediness_Matching.Items.Add("0.30");
            this.dudx_Greediness_Matching.Items.Add("0.31");
            this.dudx_Greediness_Matching.Items.Add("0.32");
            this.dudx_Greediness_Matching.Items.Add("0.33");
            this.dudx_Greediness_Matching.Items.Add("0.34");
            this.dudx_Greediness_Matching.Items.Add("0.35");
            this.dudx_Greediness_Matching.Items.Add("0.36");
            this.dudx_Greediness_Matching.Items.Add("0.37");
            this.dudx_Greediness_Matching.Items.Add("0.38");
            this.dudx_Greediness_Matching.Items.Add("0.39");
            this.dudx_Greediness_Matching.Items.Add("0.40");
            this.dudx_Greediness_Matching.Items.Add("0.41");
            this.dudx_Greediness_Matching.Items.Add("0.42");
            this.dudx_Greediness_Matching.Items.Add("0.43");
            this.dudx_Greediness_Matching.Items.Add("0.44");
            this.dudx_Greediness_Matching.Items.Add("0.45");
            this.dudx_Greediness_Matching.Items.Add("0.46");
            this.dudx_Greediness_Matching.Items.Add("0.47");
            this.dudx_Greediness_Matching.Items.Add("0.48");
            this.dudx_Greediness_Matching.Items.Add("0.49");
            this.dudx_Greediness_Matching.Items.Add("0.50");
            this.dudx_Greediness_Matching.Items.Add("0.51");
            this.dudx_Greediness_Matching.Items.Add("0.52");
            this.dudx_Greediness_Matching.Items.Add("0.53");
            this.dudx_Greediness_Matching.Items.Add("0.54");
            this.dudx_Greediness_Matching.Items.Add("0.55");
            this.dudx_Greediness_Matching.Items.Add("0.56");
            this.dudx_Greediness_Matching.Items.Add("0.57");
            this.dudx_Greediness_Matching.Items.Add("0.58");
            this.dudx_Greediness_Matching.Items.Add("0.59");
            this.dudx_Greediness_Matching.Items.Add("0.60");
            this.dudx_Greediness_Matching.Items.Add("0.61");
            this.dudx_Greediness_Matching.Items.Add("0.62");
            this.dudx_Greediness_Matching.Items.Add("0.63");
            this.dudx_Greediness_Matching.Items.Add("0.64");
            this.dudx_Greediness_Matching.Items.Add("0.65");
            this.dudx_Greediness_Matching.Items.Add("0.66");
            this.dudx_Greediness_Matching.Items.Add("0.67");
            this.dudx_Greediness_Matching.Items.Add("0.68");
            this.dudx_Greediness_Matching.Items.Add("0.69");
            this.dudx_Greediness_Matching.Items.Add("0.70");
            this.dudx_Greediness_Matching.Items.Add("0.71");
            this.dudx_Greediness_Matching.Items.Add("0.72");
            this.dudx_Greediness_Matching.Items.Add("0.73");
            this.dudx_Greediness_Matching.Items.Add("0.74");
            this.dudx_Greediness_Matching.Items.Add("0.75");
            this.dudx_Greediness_Matching.Items.Add("0.76");
            this.dudx_Greediness_Matching.Items.Add("0.77");
            this.dudx_Greediness_Matching.Items.Add("0.78");
            this.dudx_Greediness_Matching.Items.Add("0.79");
            this.dudx_Greediness_Matching.Items.Add("0.80");
            this.dudx_Greediness_Matching.Items.Add("0.81");
            this.dudx_Greediness_Matching.Items.Add("0.82");
            this.dudx_Greediness_Matching.Items.Add("0.83");
            this.dudx_Greediness_Matching.Items.Add("0.84");
            this.dudx_Greediness_Matching.Items.Add("0.85");
            this.dudx_Greediness_Matching.Items.Add("0.86");
            this.dudx_Greediness_Matching.Items.Add("0.87");
            this.dudx_Greediness_Matching.Items.Add("0.88");
            this.dudx_Greediness_Matching.Items.Add("0.89");
            this.dudx_Greediness_Matching.Items.Add("0.90");
            this.dudx_Greediness_Matching.Items.Add("0.91");
            this.dudx_Greediness_Matching.Items.Add("0.92");
            this.dudx_Greediness_Matching.Items.Add("0.93");
            this.dudx_Greediness_Matching.Items.Add("0.94");
            this.dudx_Greediness_Matching.Items.Add("0.95");
            this.dudx_Greediness_Matching.Items.Add("0.96");
            this.dudx_Greediness_Matching.Items.Add("0.97");
            this.dudx_Greediness_Matching.Items.Add("0.98");
            this.dudx_Greediness_Matching.Items.Add("0.99");
            this.dudx_Greediness_Matching.Items.Add("1.00");
            this.dudx_Greediness_Matching.Location = new System.Drawing.Point(329, 103);
            this.dudx_Greediness_Matching.Name = "dudx_Greediness_Matching";
            this.dudx_Greediness_Matching.Size = new System.Drawing.Size(120, 26);
            this.dudx_Greediness_Matching.TabIndex = 40;
            this.dudx_Greediness_Matching.Text = "0.90";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(252, 108);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 16);
            this.label17.TabIndex = 39;
            this.label17.Text = "贪婪度：";
            // 
            // dudx_MaxOverlap_Matching
            // 
            this.dudx_MaxOverlap_Matching.Items.Add("0.01");
            this.dudx_MaxOverlap_Matching.Items.Add("0.02");
            this.dudx_MaxOverlap_Matching.Items.Add("0.03");
            this.dudx_MaxOverlap_Matching.Items.Add("0.04");
            this.dudx_MaxOverlap_Matching.Items.Add("0.05");
            this.dudx_MaxOverlap_Matching.Items.Add("0.06");
            this.dudx_MaxOverlap_Matching.Items.Add("0.07");
            this.dudx_MaxOverlap_Matching.Items.Add("0.08");
            this.dudx_MaxOverlap_Matching.Items.Add("0.09");
            this.dudx_MaxOverlap_Matching.Items.Add("0.10");
            this.dudx_MaxOverlap_Matching.Items.Add("0.11");
            this.dudx_MaxOverlap_Matching.Items.Add("0.12");
            this.dudx_MaxOverlap_Matching.Items.Add("0.13");
            this.dudx_MaxOverlap_Matching.Items.Add("0.14");
            this.dudx_MaxOverlap_Matching.Items.Add("0.15");
            this.dudx_MaxOverlap_Matching.Items.Add("0.16");
            this.dudx_MaxOverlap_Matching.Items.Add("0.17");
            this.dudx_MaxOverlap_Matching.Items.Add("0.18");
            this.dudx_MaxOverlap_Matching.Items.Add("0.19");
            this.dudx_MaxOverlap_Matching.Items.Add("0.20");
            this.dudx_MaxOverlap_Matching.Items.Add("0.21");
            this.dudx_MaxOverlap_Matching.Items.Add("0.22");
            this.dudx_MaxOverlap_Matching.Items.Add("0.23");
            this.dudx_MaxOverlap_Matching.Items.Add("0.24");
            this.dudx_MaxOverlap_Matching.Items.Add("0.25");
            this.dudx_MaxOverlap_Matching.Items.Add("0.26");
            this.dudx_MaxOverlap_Matching.Items.Add("0.27");
            this.dudx_MaxOverlap_Matching.Items.Add("0.28");
            this.dudx_MaxOverlap_Matching.Items.Add("0.29");
            this.dudx_MaxOverlap_Matching.Items.Add("0.30");
            this.dudx_MaxOverlap_Matching.Items.Add("0.31");
            this.dudx_MaxOverlap_Matching.Items.Add("0.32");
            this.dudx_MaxOverlap_Matching.Items.Add("0.33");
            this.dudx_MaxOverlap_Matching.Items.Add("0.34");
            this.dudx_MaxOverlap_Matching.Items.Add("0.35");
            this.dudx_MaxOverlap_Matching.Items.Add("0.36");
            this.dudx_MaxOverlap_Matching.Items.Add("0.37");
            this.dudx_MaxOverlap_Matching.Items.Add("0.38");
            this.dudx_MaxOverlap_Matching.Items.Add("0.39");
            this.dudx_MaxOverlap_Matching.Items.Add("0.40");
            this.dudx_MaxOverlap_Matching.Items.Add("0.41");
            this.dudx_MaxOverlap_Matching.Items.Add("0.42");
            this.dudx_MaxOverlap_Matching.Items.Add("0.43");
            this.dudx_MaxOverlap_Matching.Items.Add("0.44");
            this.dudx_MaxOverlap_Matching.Items.Add("0.45");
            this.dudx_MaxOverlap_Matching.Items.Add("0.46");
            this.dudx_MaxOverlap_Matching.Items.Add("0.47");
            this.dudx_MaxOverlap_Matching.Items.Add("0.48");
            this.dudx_MaxOverlap_Matching.Items.Add("0.49");
            this.dudx_MaxOverlap_Matching.Items.Add("0.50");
            this.dudx_MaxOverlap_Matching.Items.Add("0.51");
            this.dudx_MaxOverlap_Matching.Items.Add("0.52");
            this.dudx_MaxOverlap_Matching.Items.Add("0.53");
            this.dudx_MaxOverlap_Matching.Items.Add("0.54");
            this.dudx_MaxOverlap_Matching.Items.Add("0.55");
            this.dudx_MaxOverlap_Matching.Items.Add("0.56");
            this.dudx_MaxOverlap_Matching.Items.Add("0.57");
            this.dudx_MaxOverlap_Matching.Items.Add("0.58");
            this.dudx_MaxOverlap_Matching.Items.Add("0.59");
            this.dudx_MaxOverlap_Matching.Items.Add("0.60");
            this.dudx_MaxOverlap_Matching.Items.Add("0.61");
            this.dudx_MaxOverlap_Matching.Items.Add("0.62");
            this.dudx_MaxOverlap_Matching.Items.Add("0.63");
            this.dudx_MaxOverlap_Matching.Items.Add("0.64");
            this.dudx_MaxOverlap_Matching.Items.Add("0.65");
            this.dudx_MaxOverlap_Matching.Items.Add("0.66");
            this.dudx_MaxOverlap_Matching.Items.Add("0.67");
            this.dudx_MaxOverlap_Matching.Items.Add("0.68");
            this.dudx_MaxOverlap_Matching.Items.Add("0.69");
            this.dudx_MaxOverlap_Matching.Items.Add("0.70");
            this.dudx_MaxOverlap_Matching.Items.Add("0.71");
            this.dudx_MaxOverlap_Matching.Items.Add("0.72");
            this.dudx_MaxOverlap_Matching.Items.Add("0.73");
            this.dudx_MaxOverlap_Matching.Items.Add("0.74");
            this.dudx_MaxOverlap_Matching.Items.Add("0.75");
            this.dudx_MaxOverlap_Matching.Items.Add("0.76");
            this.dudx_MaxOverlap_Matching.Items.Add("0.77");
            this.dudx_MaxOverlap_Matching.Items.Add("0.78");
            this.dudx_MaxOverlap_Matching.Items.Add("0.79");
            this.dudx_MaxOverlap_Matching.Items.Add("0.80");
            this.dudx_MaxOverlap_Matching.Items.Add("0.81");
            this.dudx_MaxOverlap_Matching.Items.Add("0.82");
            this.dudx_MaxOverlap_Matching.Items.Add("0.83");
            this.dudx_MaxOverlap_Matching.Items.Add("0.84");
            this.dudx_MaxOverlap_Matching.Items.Add("0.85");
            this.dudx_MaxOverlap_Matching.Items.Add("0.86");
            this.dudx_MaxOverlap_Matching.Items.Add("0.87");
            this.dudx_MaxOverlap_Matching.Items.Add("0.88");
            this.dudx_MaxOverlap_Matching.Items.Add("0.89");
            this.dudx_MaxOverlap_Matching.Items.Add("0.90");
            this.dudx_MaxOverlap_Matching.Items.Add("0.91");
            this.dudx_MaxOverlap_Matching.Items.Add("0.92");
            this.dudx_MaxOverlap_Matching.Items.Add("0.93");
            this.dudx_MaxOverlap_Matching.Items.Add("0.94");
            this.dudx_MaxOverlap_Matching.Items.Add("0.95");
            this.dudx_MaxOverlap_Matching.Items.Add("0.96");
            this.dudx_MaxOverlap_Matching.Items.Add("0.97");
            this.dudx_MaxOverlap_Matching.Items.Add("0.98");
            this.dudx_MaxOverlap_Matching.Items.Add("0.99");
            this.dudx_MaxOverlap_Matching.Items.Add("1.00");
            this.dudx_MaxOverlap_Matching.Location = new System.Drawing.Point(110, 100);
            this.dudx_MaxOverlap_Matching.Name = "dudx_MaxOverlap_Matching";
            this.dudx_MaxOverlap_Matching.Size = new System.Drawing.Size(120, 26);
            this.dudx_MaxOverlap_Matching.TabIndex = 38;
            this.dudx_MaxOverlap_Matching.Text = "0.50";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 16);
            this.label13.TabIndex = 37;
            this.label13.Text = "最大重叠率：";
            // 
            // nudx_NumMatches_Matching
            // 
            this.nudx_NumMatches_Matching.Location = new System.Drawing.Point(329, 30);
            this.nudx_NumMatches_Matching.Name = "nudx_NumMatches_Matching";
            this.nudx_NumMatches_Matching.Size = new System.Drawing.Size(120, 26);
            this.nudx_NumMatches_Matching.TabIndex = 36;
            // 
            // dudx_NumLevels_Matching
            // 
            this.dudx_NumLevels_Matching.Items.Add("auto");
            this.dudx_NumLevels_Matching.Items.Add("0");
            this.dudx_NumLevels_Matching.Items.Add("1");
            this.dudx_NumLevels_Matching.Items.Add("2");
            this.dudx_NumLevels_Matching.Items.Add("3");
            this.dudx_NumLevels_Matching.Items.Add("4");
            this.dudx_NumLevels_Matching.Items.Add("5");
            this.dudx_NumLevels_Matching.Items.Add("6");
            this.dudx_NumLevels_Matching.Items.Add("7");
            this.dudx_NumLevels_Matching.Items.Add("8");
            this.dudx_NumLevels_Matching.Items.Add("9");
            this.dudx_NumLevels_Matching.Items.Add("10");
            this.dudx_NumLevels_Matching.Location = new System.Drawing.Point(110, 141);
            this.dudx_NumLevels_Matching.Name = "dudx_NumLevels_Matching";
            this.dudx_NumLevels_Matching.Size = new System.Drawing.Size(120, 26);
            this.dudx_NumLevels_Matching.TabIndex = 35;
            this.dudx_NumLevels_Matching.Text = "2";
            // 
            // dudx_MinScore_Matching
            // 
            this.dudx_MinScore_Matching.Items.Add("0.01");
            this.dudx_MinScore_Matching.Items.Add("0.02");
            this.dudx_MinScore_Matching.Items.Add("0.03");
            this.dudx_MinScore_Matching.Items.Add("0.04");
            this.dudx_MinScore_Matching.Items.Add("0.05");
            this.dudx_MinScore_Matching.Items.Add("0.06");
            this.dudx_MinScore_Matching.Items.Add("0.07");
            this.dudx_MinScore_Matching.Items.Add("0.08");
            this.dudx_MinScore_Matching.Items.Add("0.09");
            this.dudx_MinScore_Matching.Items.Add("0.10");
            this.dudx_MinScore_Matching.Items.Add("0.11");
            this.dudx_MinScore_Matching.Items.Add("0.12");
            this.dudx_MinScore_Matching.Items.Add("0.13");
            this.dudx_MinScore_Matching.Items.Add("0.14");
            this.dudx_MinScore_Matching.Items.Add("0.15");
            this.dudx_MinScore_Matching.Items.Add("0.16");
            this.dudx_MinScore_Matching.Items.Add("0.17");
            this.dudx_MinScore_Matching.Items.Add("0.18");
            this.dudx_MinScore_Matching.Items.Add("0.19");
            this.dudx_MinScore_Matching.Items.Add("0.20");
            this.dudx_MinScore_Matching.Items.Add("0.21");
            this.dudx_MinScore_Matching.Items.Add("0.22");
            this.dudx_MinScore_Matching.Items.Add("0.23");
            this.dudx_MinScore_Matching.Items.Add("0.24");
            this.dudx_MinScore_Matching.Items.Add("0.25");
            this.dudx_MinScore_Matching.Items.Add("0.26");
            this.dudx_MinScore_Matching.Items.Add("0.27");
            this.dudx_MinScore_Matching.Items.Add("0.28");
            this.dudx_MinScore_Matching.Items.Add("0.29");
            this.dudx_MinScore_Matching.Items.Add("0.30");
            this.dudx_MinScore_Matching.Items.Add("0.31");
            this.dudx_MinScore_Matching.Items.Add("0.32");
            this.dudx_MinScore_Matching.Items.Add("0.33");
            this.dudx_MinScore_Matching.Items.Add("0.34");
            this.dudx_MinScore_Matching.Items.Add("0.35");
            this.dudx_MinScore_Matching.Items.Add("0.36");
            this.dudx_MinScore_Matching.Items.Add("0.37");
            this.dudx_MinScore_Matching.Items.Add("0.38");
            this.dudx_MinScore_Matching.Items.Add("0.39");
            this.dudx_MinScore_Matching.Items.Add("0.40");
            this.dudx_MinScore_Matching.Items.Add("0.41");
            this.dudx_MinScore_Matching.Items.Add("0.42");
            this.dudx_MinScore_Matching.Items.Add("0.43");
            this.dudx_MinScore_Matching.Items.Add("0.44");
            this.dudx_MinScore_Matching.Items.Add("0.45");
            this.dudx_MinScore_Matching.Items.Add("0.46");
            this.dudx_MinScore_Matching.Items.Add("0.47");
            this.dudx_MinScore_Matching.Items.Add("0.48");
            this.dudx_MinScore_Matching.Items.Add("0.49");
            this.dudx_MinScore_Matching.Items.Add("0.50");
            this.dudx_MinScore_Matching.Items.Add("0.51");
            this.dudx_MinScore_Matching.Items.Add("0.52");
            this.dudx_MinScore_Matching.Items.Add("0.53");
            this.dudx_MinScore_Matching.Items.Add("0.54");
            this.dudx_MinScore_Matching.Items.Add("0.55");
            this.dudx_MinScore_Matching.Items.Add("0.56");
            this.dudx_MinScore_Matching.Items.Add("0.57");
            this.dudx_MinScore_Matching.Items.Add("0.58");
            this.dudx_MinScore_Matching.Items.Add("0.59");
            this.dudx_MinScore_Matching.Items.Add("0.60");
            this.dudx_MinScore_Matching.Items.Add("0.61");
            this.dudx_MinScore_Matching.Items.Add("0.62");
            this.dudx_MinScore_Matching.Items.Add("0.63");
            this.dudx_MinScore_Matching.Items.Add("0.64");
            this.dudx_MinScore_Matching.Items.Add("0.65");
            this.dudx_MinScore_Matching.Items.Add("0.66");
            this.dudx_MinScore_Matching.Items.Add("0.67");
            this.dudx_MinScore_Matching.Items.Add("0.68");
            this.dudx_MinScore_Matching.Items.Add("0.69");
            this.dudx_MinScore_Matching.Items.Add("0.70");
            this.dudx_MinScore_Matching.Items.Add("0.71");
            this.dudx_MinScore_Matching.Items.Add("0.72");
            this.dudx_MinScore_Matching.Items.Add("0.73");
            this.dudx_MinScore_Matching.Items.Add("0.74");
            this.dudx_MinScore_Matching.Items.Add("0.75");
            this.dudx_MinScore_Matching.Items.Add("0.76");
            this.dudx_MinScore_Matching.Items.Add("0.77");
            this.dudx_MinScore_Matching.Items.Add("0.78");
            this.dudx_MinScore_Matching.Items.Add("0.79");
            this.dudx_MinScore_Matching.Items.Add("0.80");
            this.dudx_MinScore_Matching.Items.Add("0.81");
            this.dudx_MinScore_Matching.Items.Add("0.82");
            this.dudx_MinScore_Matching.Items.Add("0.83");
            this.dudx_MinScore_Matching.Items.Add("0.84");
            this.dudx_MinScore_Matching.Items.Add("0.85");
            this.dudx_MinScore_Matching.Items.Add("0.86");
            this.dudx_MinScore_Matching.Items.Add("0.87");
            this.dudx_MinScore_Matching.Items.Add("0.88");
            this.dudx_MinScore_Matching.Items.Add("0.89");
            this.dudx_MinScore_Matching.Items.Add("0.90");
            this.dudx_MinScore_Matching.Items.Add("0.91");
            this.dudx_MinScore_Matching.Items.Add("0.92");
            this.dudx_MinScore_Matching.Items.Add("0.93");
            this.dudx_MinScore_Matching.Items.Add("0.94");
            this.dudx_MinScore_Matching.Items.Add("0.95");
            this.dudx_MinScore_Matching.Items.Add("0.96");
            this.dudx_MinScore_Matching.Items.Add("0.97");
            this.dudx_MinScore_Matching.Items.Add("0.98");
            this.dudx_MinScore_Matching.Items.Add("0.99");
            this.dudx_MinScore_Matching.Items.Add("1.00");
            this.dudx_MinScore_Matching.Location = new System.Drawing.Point(330, 67);
            this.dudx_MinScore_Matching.Name = "dudx_MinScore_Matching";
            this.dudx_MinScore_Matching.Size = new System.Drawing.Size(120, 26);
            this.dudx_MinScore_Matching.TabIndex = 34;
            this.dudx_MinScore_Matching.Text = "0.50";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "金字塔层数：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(241, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "最低分数：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(241, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 16);
            this.label11.TabIndex = 30;
            this.label11.Text = "匹配个数：";
            // 
            // cbx_SubPixel_Matching
            // 
            this.cbx_SubPixel_Matching.FormattingEnabled = true;
            this.cbx_SubPixel_Matching.Items.AddRange(new object[] {
            "none",
            "interpolation",
            "least_squares",
            "least_squares_high",
            "least_squares_very_high",
            "max_deformation 1",
            "max_deformation 2",
            "max_deformation 3",
            "max_deformation 4",
            "max_deformation 5",
            "max_deformation 6"});
            this.cbx_SubPixel_Matching.Location = new System.Drawing.Point(262, 302);
            this.cbx_SubPixel_Matching.Name = "cbx_SubPixel_Matching";
            this.cbx_SubPixel_Matching.Size = new System.Drawing.Size(193, 24);
            this.cbx_SubPixel_Matching.TabIndex = 29;
            this.cbx_SubPixel_Matching.Text = "least_squares";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(170, 305);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "匹配精度：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 16);
            this.label15.TabIndex = 24;
            this.label15.Text = "角度范围：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 16);
            this.label16.TabIndex = 23;
            this.label16.Text = "起始角度：";
            // 
            // tbx_AngleStart_Matching
            // 
            this.tbx_AngleStart_Matching.Location = new System.Drawing.Point(112, 22);
            this.tbx_AngleStart_Matching.Name = "tbx_AngleStart_Matching";
            this.tbx_AngleStart_Matching.Size = new System.Drawing.Size(113, 26);
            this.tbx_AngleStart_Matching.TabIndex = 22;
            this.tbx_AngleStart_Matching.Text = "-180";
            // 
            // tbx_AngleExtent_Matching
            // 
            this.tbx_AngleExtent_Matching.Location = new System.Drawing.Point(112, 61);
            this.tbx_AngleExtent_Matching.Name = "tbx_AngleExtent_Matching";
            this.tbx_AngleExtent_Matching.Size = new System.Drawing.Size(113, 26);
            this.tbx_AngleExtent_Matching.TabIndex = 21;
            this.tbx_AngleExtent_Matching.Text = "360";
            // 
            // panel_FindTemplateOperate
            // 
            this.panel_FindTemplateOperate.Controls.Add(this.label19);
            this.panel_FindTemplateOperate.Controls.Add(this.cbx_MatchingModelMethod);
            this.panel_FindTemplateOperate.Controls.Add(this.cbx_DrawFindRegion);
            this.panel_FindTemplateOperate.Controls.Add(this.btn_FindTeamplate);
            this.panel_FindTemplateOperate.Controls.Add(this.btn_DrawFindRegion);
            this.panel_FindTemplateOperate.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_FindTemplateOperate.Location = new System.Drawing.Point(0, 0);
            this.panel_FindTemplateOperate.Name = "panel_FindTemplateOperate";
            this.panel_FindTemplateOperate.Size = new System.Drawing.Size(458, 100);
            this.panel_FindTemplateOperate.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(45, 69);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 16);
            this.label19.TabIndex = 45;
            this.label19.Text = "匹配算子：";
            // 
            // cbx_MatchingModelMethod
            // 
            this.cbx_MatchingModelMethod.FormattingEnabled = true;
            this.cbx_MatchingModelMethod.Items.AddRange(new object[] {
            "FindScaleShapeModel",
            "FindShapeModel"});
            this.cbx_MatchingModelMethod.Location = new System.Drawing.Point(154, 66);
            this.cbx_MatchingModelMethod.Name = "cbx_MatchingModelMethod";
            this.cbx_MatchingModelMethod.Size = new System.Drawing.Size(193, 24);
            this.cbx_MatchingModelMethod.TabIndex = 45;
            this.cbx_MatchingModelMethod.Text = "FindScaleShapeModel";
            // 
            // cbx_DrawFindRegion
            // 
            this.cbx_DrawFindRegion.Font = new System.Drawing.Font("宋体", 14F);
            this.cbx_DrawFindRegion.FormattingEnabled = true;
            this.cbx_DrawFindRegion.Location = new System.Drawing.Point(114, 13);
            this.cbx_DrawFindRegion.Name = "cbx_DrawFindRegion";
            this.cbx_DrawFindRegion.Size = new System.Drawing.Size(160, 27);
            this.cbx_DrawFindRegion.TabIndex = 7;
            // 
            // btn_FindTeamplate
            // 
            this.btn_FindTeamplate.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_FindTeamplate.Location = new System.Drawing.Point(353, 61);
            this.btn_FindTeamplate.Name = "btn_FindTeamplate";
            this.btn_FindTeamplate.Size = new System.Drawing.Size(102, 33);
            this.btn_FindTeamplate.TabIndex = 5;
            this.btn_FindTeamplate.Text = "模板匹配";
            this.btn_FindTeamplate.UseVisualStyleBackColor = true;
            this.btn_FindTeamplate.Click += new System.EventHandler(this.btn_FindTeamplate_Click);
            // 
            // btn_DrawFindRegion
            // 
            this.btn_DrawFindRegion.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_DrawFindRegion.Location = new System.Drawing.Point(6, 10);
            this.btn_DrawFindRegion.Name = "btn_DrawFindRegion";
            this.btn_DrawFindRegion.Size = new System.Drawing.Size(102, 33);
            this.btn_DrawFindRegion.TabIndex = 6;
            this.btn_DrawFindRegion.Text = "绘制搜索区域";
            this.btn_DrawFindRegion.UseVisualStyleBackColor = true;
            // 
            // tabPage_MatchResult
            // 
            this.tabPage_MatchResult.Controls.Add(this.panel_MathingResult);
            this.tabPage_MatchResult.Controls.Add(this.panel_MatchItem);
            this.tabPage_MatchResult.Location = new System.Drawing.Point(4, 26);
            this.tabPage_MatchResult.Name = "tabPage_MatchResult";
            this.tabPage_MatchResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_MatchResult.Size = new System.Drawing.Size(458, 442);
            this.tabPage_MatchResult.TabIndex = 3;
            this.tabPage_MatchResult.Text = "匹配结果";
            this.tabPage_MatchResult.UseVisualStyleBackColor = true;
            // 
            // panel_MathingResult
            // 
            this.panel_MathingResult.BackColor = System.Drawing.Color.DarkGray;
            this.panel_MathingResult.Controls.Add(this.dgvx_MatchResult);
            this.panel_MathingResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_MathingResult.Location = new System.Drawing.Point(3, 98);
            this.panel_MathingResult.Name = "panel_MathingResult";
            this.panel_MathingResult.Size = new System.Drawing.Size(452, 341);
            this.panel_MathingResult.TabIndex = 1;
            // 
            // dgvx_MatchResult
            // 
            this.dgvx_MatchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvx_MatchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Index,
            this.Column_Row,
            this.Column_Column,
            this.Column_Score,
            this.Column_Scaled});
            this.dgvx_MatchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvx_MatchResult.Location = new System.Drawing.Point(0, 0);
            this.dgvx_MatchResult.Name = "dgvx_MatchResult";
            this.dgvx_MatchResult.RowTemplate.Height = 23;
            this.dgvx_MatchResult.Size = new System.Drawing.Size(452, 341);
            this.dgvx_MatchResult.TabIndex = 0;
            // 
            // Column_Index
            // 
            this.Column_Index.HeaderText = "序号";
            this.Column_Index.Name = "Column_Index";
            this.Column_Index.ReadOnly = true;
            this.Column_Index.Width = 80;
            // 
            // Column_Row
            // 
            this.Column_Row.HeaderText = "Row";
            this.Column_Row.Name = "Column_Row";
            this.Column_Row.ReadOnly = true;
            // 
            // Column_Column
            // 
            this.Column_Column.HeaderText = "Colum";
            this.Column_Column.Name = "Column_Column";
            this.Column_Column.ReadOnly = true;
            // 
            // Column_Score
            // 
            this.Column_Score.HeaderText = "Score";
            this.Column_Score.Name = "Column_Score";
            this.Column_Score.ReadOnly = true;
            // 
            // Column_Scaled
            // 
            this.Column_Scaled.HeaderText = "Scaled";
            this.Column_Scaled.Name = "Column_Scaled";
            this.Column_Scaled.ReadOnly = true;
            // 
            // panel_MatchItem
            // 
            this.panel_MatchItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_MatchItem.Location = new System.Drawing.Point(3, 3);
            this.panel_MatchItem.Name = "panel_MatchItem";
            this.panel_MatchItem.Size = new System.Drawing.Size(452, 95);
            this.panel_MatchItem.TabIndex = 0;
            // 
            // panel_LoadImage
            // 
            this.panel_LoadImage.Controls.Add(this.btn_ImageLoad);
            this.panel_LoadImage.Controls.Add(this.tbx_LoadImage);
            this.panel_LoadImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_LoadImage.Location = new System.Drawing.Point(3, 17);
            this.panel_LoadImage.Name = "panel_LoadImage";
            this.panel_LoadImage.Size = new System.Drawing.Size(466, 212);
            this.panel_LoadImage.TabIndex = 4;
            // 
            // btn_ImageLoad
            // 
            this.btn_ImageLoad.FlatAppearance.BorderSize = 0;
            this.btn_ImageLoad.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_ImageLoad.Location = new System.Drawing.Point(400, 16);
            this.btn_ImageLoad.Name = "btn_ImageLoad";
            this.btn_ImageLoad.Size = new System.Drawing.Size(63, 26);
            this.btn_ImageLoad.TabIndex = 1;
            this.btn_ImageLoad.Text = "...";
            this.btn_ImageLoad.UseVisualStyleBackColor = true;
            this.btn_ImageLoad.Click += new System.EventHandler(this.btn_ImageLoad_Click);
            // 
            // tbx_LoadImage
            // 
            this.tbx_LoadImage.Font = new System.Drawing.Font("宋体", 12F);
            this.tbx_LoadImage.Location = new System.Drawing.Point(7, 16);
            this.tbx_LoadImage.Name = "tbx_LoadImage";
            this.tbx_LoadImage.Size = new System.Drawing.Size(455, 26);
            this.tbx_LoadImage.TabIndex = 0;
            // 
            // panel_MessageBar
            // 
            this.panel_MessageBar.Controls.Add(this.GroupBox_Message);
            this.panel_MessageBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_MessageBar.Location = new System.Drawing.Point(0, 505);
            this.panel_MessageBar.Name = "panel_MessageBar";
            this.panel_MessageBar.Padding = new System.Windows.Forms.Padding(5);
            this.panel_MessageBar.Size = new System.Drawing.Size(691, 209);
            this.panel_MessageBar.TabIndex = 1;
            // 
            // GroupBox_Message
            // 
            this.GroupBox_Message.Controls.Add(this.rtbx_MessageLog);
            this.GroupBox_Message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox_Message.Location = new System.Drawing.Point(5, 5);
            this.GroupBox_Message.Name = "GroupBox_Message";
            this.GroupBox_Message.Size = new System.Drawing.Size(681, 199);
            this.GroupBox_Message.TabIndex = 0;
            this.GroupBox_Message.TabStop = false;
            this.GroupBox_Message.Text = "消息栏";
            // 
            // rtbx_MessageLog
            // 
            this.rtbx_MessageLog.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtbx_MessageLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbx_MessageLog.Location = new System.Drawing.Point(3, 17);
            this.rtbx_MessageLog.Name = "rtbx_MessageLog";
            this.rtbx_MessageLog.ReadOnly = true;
            this.rtbx_MessageLog.Size = new System.Drawing.Size(675, 179);
            this.rtbx_MessageLog.TabIndex = 0;
            this.rtbx_MessageLog.Text = "";
            this.rtbx_MessageLog.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rtbx_MessageLog_MouseDown);
            // 
            // panel_ImageWindowBar
            // 
            this.panel_ImageWindowBar.Controls.Add(this.groupBox_ImageWin);
            this.panel_ImageWindowBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ImageWindowBar.Location = new System.Drawing.Point(0, 0);
            this.panel_ImageWindowBar.Name = "panel_ImageWindowBar";
            this.panel_ImageWindowBar.Padding = new System.Windows.Forms.Padding(5);
            this.panel_ImageWindowBar.Size = new System.Drawing.Size(691, 505);
            this.panel_ImageWindowBar.TabIndex = 2;
            // 
            // groupBox_ImageWin
            // 
            this.groupBox_ImageWin.Controls.Add(this.panel_ImageWindow);
            this.groupBox_ImageWin.Controls.Add(this.panel_ImageInfo);
            this.groupBox_ImageWin.Controls.Add(this.panel_ImageListBar);
            this.groupBox_ImageWin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_ImageWin.Location = new System.Drawing.Point(5, 5);
            this.groupBox_ImageWin.Name = "groupBox_ImageWin";
            this.groupBox_ImageWin.Size = new System.Drawing.Size(681, 495);
            this.groupBox_ImageWin.TabIndex = 0;
            this.groupBox_ImageWin.TabStop = false;
            this.groupBox_ImageWin.Text = "图像窗口";
            // 
            // panel_ImageWindow
            // 
            this.panel_ImageWindow.Controls.Add(this.ImageWindow);
            this.panel_ImageWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ImageWindow.Location = new System.Drawing.Point(3, 43);
            this.panel_ImageWindow.Name = "panel_ImageWindow";
            this.panel_ImageWindow.Size = new System.Drawing.Size(675, 423);
            this.panel_ImageWindow.TabIndex = 3;
            // 
            // ImageWindow
            // 
            this.ImageWindow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ImageWindow.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ImageWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageWindow.HDoubleClickToFitContent = true;
            this.ImageWindow.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
            this.ImageWindow.HImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.ImageWindow.HKeepAspectRatio = true;
            this.ImageWindow.HMoveContent = true;
            this.ImageWindow.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
            this.ImageWindow.Location = new System.Drawing.Point(0, 0);
            this.ImageWindow.Margin = new System.Windows.Forms.Padding(0);
            this.ImageWindow.Name = "ImageWindow";
            this.ImageWindow.Size = new System.Drawing.Size(675, 423);
            this.ImageWindow.TabIndex = 0;
            this.ImageWindow.WindowSize = new System.Drawing.Size(675, 423);
            // 
            // panel_ImageInfo
            // 
            this.panel_ImageInfo.Controls.Add(this.tbx_WindowState);
            this.panel_ImageInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_ImageInfo.Location = new System.Drawing.Point(3, 466);
            this.panel_ImageInfo.Name = "panel_ImageInfo";
            this.panel_ImageInfo.Size = new System.Drawing.Size(675, 26);
            this.panel_ImageInfo.TabIndex = 2;
            // 
            // tbx_WindowState
            // 
            this.tbx_WindowState.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbx_WindowState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_WindowState.Font = new System.Drawing.Font("宋体", 12F);
            this.tbx_WindowState.Location = new System.Drawing.Point(0, 0);
            this.tbx_WindowState.Name = "tbx_WindowState";
            this.tbx_WindowState.ReadOnly = true;
            this.tbx_WindowState.Size = new System.Drawing.Size(675, 26);
            this.tbx_WindowState.TabIndex = 0;
            // 
            // panel_ImageListBar
            // 
            this.panel_ImageListBar.Controls.Add(this.cbx_ImageList);
            this.panel_ImageListBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ImageListBar.Location = new System.Drawing.Point(3, 17);
            this.panel_ImageListBar.Name = "panel_ImageListBar";
            this.panel_ImageListBar.Size = new System.Drawing.Size(675, 26);
            this.panel_ImageListBar.TabIndex = 1;
            // 
            // cbx_ImageList
            // 
            this.cbx_ImageList.BackColor = System.Drawing.Color.Silver;
            this.cbx_ImageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_ImageList.Font = new System.Drawing.Font("宋体", 12F);
            this.cbx_ImageList.FormattingEnabled = true;
            this.cbx_ImageList.Location = new System.Drawing.Point(0, 0);
            this.cbx_ImageList.Name = "cbx_ImageList";
            this.cbx_ImageList.Size = new System.Drawing.Size(675, 24);
            this.cbx_ImageList.TabIndex = 0;
            this.cbx_ImageList.SelectedIndexChanged += new System.EventHandler(this.cbx_ImageList_SelectedIndexChanged);
            // 
            // cmsx_RightMenu
            // 
            this.cmsx_RightMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清空内容ToolStripMenuItem});
            this.cmsx_RightMenu.Name = "cms_RightMenu";
            this.cmsx_RightMenu.Size = new System.Drawing.Size(125, 26);
            // 
            // 清空内容ToolStripMenuItem
            // 
            this.清空内容ToolStripMenuItem.Name = "清空内容ToolStripMenuItem";
            this.清空内容ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.清空内容ToolStripMenuItem.Text = "清空内容";
            this.清空内容ToolStripMenuItem.Click += new System.EventHandler(this.清空内容ToolStripMenuItem_Click);
            // 
            // cmsx_RoiRightMenu
            // 
            this.cmsx_RoiRightMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ROItoolStripMenuItem});
            this.cmsx_RoiRightMenu.Name = "cms_RightMenu";
            this.cmsx_RoiRightMenu.Size = new System.Drawing.Size(123, 26);
            // 
            // 删除ROItoolStripMenuItem
            // 
            this.删除ROItoolStripMenuItem.Name = "删除ROItoolStripMenuItem";
            this.删除ROItoolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.删除ROItoolStripMenuItem.Text = "删除ROI";
            this.删除ROItoolStripMenuItem.Click += new System.EventHandler(this.删除ROItoolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 714);
            this.Controls.Add(this.panel_ImageWindowBar);
            this.Controls.Add(this.panel_MessageBar);
            this.Controls.Add(this.panel_OperatorBar);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_OperatorBar.ResumeLayout(false);
            this.groupBox_Operator.ResumeLayout(false);
            this.panel_Match.ResumeLayout(false);
            this.tabControl_Match.ResumeLayout(false);
            this.tabPage_RoiParams.ResumeLayout(false);
            this.panel_CreateTemplateParam.ResumeLayout(false);
            this.panel_CreateTemplateParam.PerformLayout();
            this.panel_CreateTemplateOperate.ResumeLayout(false);
            this.panel_CreateTemplateOperate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_EraserSize)).EndInit();
            this.tabPage_RoiList.ResumeLayout(false);
            this.tabPage_MatchParams.ResumeLayout(false);
            this.panel_FindTemplateParam.ResumeLayout(false);
            this.panel_FindTemplateParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudx_NumMatches_Matching)).EndInit();
            this.panel_FindTemplateOperate.ResumeLayout(false);
            this.panel_FindTemplateOperate.PerformLayout();
            this.tabPage_MatchResult.ResumeLayout(false);
            this.panel_MathingResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvx_MatchResult)).EndInit();
            this.panel_LoadImage.ResumeLayout(false);
            this.panel_LoadImage.PerformLayout();
            this.panel_MessageBar.ResumeLayout(false);
            this.GroupBox_Message.ResumeLayout(false);
            this.panel_ImageWindowBar.ResumeLayout(false);
            this.groupBox_ImageWin.ResumeLayout(false);
            this.panel_ImageWindow.ResumeLayout(false);
            this.panel_ImageInfo.ResumeLayout(false);
            this.panel_ImageInfo.PerformLayout();
            this.panel_ImageListBar.ResumeLayout(false);
            this.cmsx_RightMenu.ResumeLayout(false);
            this.cmsx_RoiRightMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_OperatorBar;
        private System.Windows.Forms.Panel panel_MessageBar;
        private System.Windows.Forms.Panel panel_ImageWindowBar;
        private System.Windows.Forms.GroupBox GroupBox_Message;
        private System.Windows.Forms.RichTextBox rtbx_MessageLog;
        private System.Windows.Forms.GroupBox groupBox_Operator;
        private System.Windows.Forms.GroupBox groupBox_ImageWin;
        private System.Windows.Forms.TextBox tbx_LoadImage;
        private System.Windows.Forms.Button btn_ImageLoad;
        private System.Windows.Forms.Panel panel_ImageListBar;
        private System.Windows.Forms.Panel panel_ImageWindow;
        private System.Windows.Forms.Panel panel_ImageInfo;
        private HalconDotNet.HSmartWindowControl ImageWindow;
        private System.Windows.Forms.TextBox tbx_WindowState;
        private System.Windows.Forms.ComboBox cbx_ImageList;
        private System.Windows.Forms.Button btn_DrawROI;
        private System.Windows.Forms.ContextMenuStrip cmsx_RightMenu;
        private System.Windows.Forms.ToolStripMenuItem 清空内容ToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbx_DrawObjectList;
        private System.Windows.Forms.ContextMenuStrip cmsx_RoiRightMenu;
        private System.Windows.Forms.ToolStripMenuItem 删除ROItoolStripMenuItem;
        private System.Windows.Forms.Panel panel_LoadImage;
        private System.Windows.Forms.Panel panel_Match;
        private System.Windows.Forms.TabControl tabControl_Match;
        private System.Windows.Forms.TabPage tabPage_RoiList;
        private System.Windows.Forms.ListBox lbx_RoiList;
        private System.Windows.Forms.TabPage tabPage_RoiParams;
        private System.Windows.Forms.TabPage tabPage_MatchParams;
        private System.Windows.Forms.Button btn_CreateTemplate;
        private System.Windows.Forms.Button btn_FindTeamplate;
        private System.Windows.Forms.Panel panel_CreateTemplateOperate;
        private System.Windows.Forms.Panel panel_CreateTemplateParam;
        private System.Windows.Forms.Button btn_Eraser;
        private System.Windows.Forms.NumericUpDown numUD_EraserSize;
        private System.Windows.Forms.Panel panel_FindTemplateOperate;
        private System.Windows.Forms.Panel panel_FindTemplateParam;
        private System.Windows.Forms.TabPage tabPage_MatchResult;
        private System.Windows.Forms.Panel panel_MatchItem;
        private System.Windows.Forms.Panel panel_MathingResult;
        private System.Windows.Forms.Button btn_ConfirmParam;
        private System.Windows.Forms.Button btn_FlushCreateingParams;
        private System.Windows.Forms.TextBox tbx_AngleExtent_Creating;
        private System.Windows.Forms.TextBox tbx_AngleStep_Creating;
        private System.Windows.Forms.TextBox tbx_AngleStart_Creating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_Metric_Creating;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_Optimization_Creating;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DomainUpDown dudx_Contrast_Creating;
        private System.Windows.Forms.DomainUpDown dudx_MinContrast_Creating;
        private System.Windows.Forms.DomainUpDown dudx__NumLevels_Creating;
        private System.Windows.Forms.DataGridView dgvx_MatchResult;
        private System.Windows.Forms.DomainUpDown dudx_NumLevels_Matching;
        private System.Windows.Forms.DomainUpDown dudx_MinScore_Matching;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbx_SubPixel_Matching;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbx_AngleStart_Matching;
        private System.Windows.Forms.TextBox tbx_AngleExtent_Matching;
        private System.Windows.Forms.NumericUpDown nudx_NumMatches_Matching;
        private System.Windows.Forms.DomainUpDown dudx_MaxOverlap_Matching;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DomainUpDown dudx_Greediness_Matching;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbx_DrawFindRegion;
        private System.Windows.Forms.Button btn_DrawFindRegion;
        private System.Windows.Forms.DomainUpDown dudx_MixScale_Matching;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DomainUpDown dudx_MaxScale_Matching;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbx_MatchingModelMethod;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DomainUpDown dudx_ScaledMax_Creating;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DomainUpDown dudx_ScaledMin_Creating;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Row;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Scaled;
    }
}

