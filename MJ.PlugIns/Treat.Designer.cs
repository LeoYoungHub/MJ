namespace MJ.PlugIns
{
    partial class Treat
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPatientInfo = new System.Windows.Forms.TabPage();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPuncture = new System.Windows.Forms.TabPage();
            this.tabOrientation = new System.Windows.Forms.TabPage();
            this.tabVisualAnalysis = new System.Windows.Forms.TabPage();
            this.tabBeamShotAbutment = new System.Windows.Forms.TabPage();
            this.tabBeamShot = new System.Windows.Forms.TabPage();
            this.tabTreatOver = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPatientInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabOrientation.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPatientInfo);
            this.tabControl1.Controls.Add(this.tabPuncture);
            this.tabControl1.Controls.Add(this.tabOrientation);
            this.tabControl1.Controls.Add(this.tabVisualAnalysis);
            this.tabControl1.Controls.Add(this.tabBeamShotAbutment);
            this.tabControl1.Controls.Add(this.tabBeamShot);
            this.tabControl1.Controls.Add(this.tabTreatOver);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.ItemSize = new System.Drawing.Size(80, 120);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1266, 744);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // tabPatientInfo
            // 
            this.tabPatientInfo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPatientInfo.Controls.Add(this.tableLayoutPanel1);
            this.tabPatientInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tabPatientInfo.Location = new System.Drawing.Point(124, 4);
            this.tabPatientInfo.Name = "tabPatientInfo";
            this.tabPatientInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatientInfo.Size = new System.Drawing.Size(1030, 685);
            this.tabPatientInfo.TabIndex = 0;
            this.tabPatientInfo.Text = "病人信息";
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLoad.ForeColor = System.Drawing.Color.Black;
            this.btnLoad.Location = new System.Drawing.Point(560, 320);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(20);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(218, 44);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "计划载入";
            this.btnLoad.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.SkyBlue;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 258F));
            this.tableLayoutPanel1.Controls.Add(this.btnLoad, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSex, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAge, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(104, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(798, 384);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(103, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(114, 80);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label2";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(223, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 80);
            this.label2.TabIndex = 2;
            this.label2.Text = "性别";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblSex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSex.ForeColor = System.Drawing.Color.Black;
            this.lblSex.Location = new System.Drawing.Point(323, 0);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(114, 80);
            this.lblSex.TabIndex = 3;
            this.lblSex.Text = "label3";
            this.lblSex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblAge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAge.ForeColor = System.Drawing.Color.Black;
            this.lblAge.Location = new System.Drawing.Point(543, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(252, 80);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "label3";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(443, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 80);
            this.label3.TabIndex = 5;
            this.label3.Text = "年龄";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 6);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(792, 40);
            this.label4.TabIndex = 6;
            this.label4.Text = "出束计划";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.label5, 2);
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(3, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 60);
            this.label5.TabIndex = 7;
            this.label5.Text = "处方剂量";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.label6, 2);
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(3, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 60);
            this.label6.TabIndex = 8;
            this.label6.Text = "驻留点个数";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.label7, 2);
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.Location = new System.Drawing.Point(3, 240);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 60);
            this.label7.TabIndex = 9;
            this.label7.Text = "预计出束时间";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.label8, 4);
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(223, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(572, 60);
            this.label8.TabIndex = 10;
            this.label8.Text = "label8";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.label9, 4);
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(223, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(572, 60);
            this.label9.TabIndex = 11;
            this.label9.Text = "label9";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.label10, 4);
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(223, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(572, 60);
            this.label10.TabIndex = 12;
            this.label10.Text = "label10";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPuncture
            // 
            this.tabPuncture.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPuncture.Location = new System.Drawing.Point(124, 4);
            this.tabPuncture.Name = "tabPuncture";
            this.tabPuncture.Padding = new System.Windows.Forms.Padding(3);
            this.tabPuncture.Size = new System.Drawing.Size(1030, 685);
            this.tabPuncture.TabIndex = 1;
            this.tabPuncture.Text = "辅助穿刺";
            // 
            // tabOrientation
            // 
            this.tabOrientation.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabOrientation.Controls.Add(this.tableLayoutPanel2);
            this.tabOrientation.Location = new System.Drawing.Point(124, 4);
            this.tabOrientation.Name = "tabOrientation";
            this.tabOrientation.Size = new System.Drawing.Size(1138, 736);
            this.tabOrientation.TabIndex = 2;
            this.tabOrientation.Text = "机械定位";
            // 
            // tabVisualAnalysis
            // 
            this.tabVisualAnalysis.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabVisualAnalysis.Location = new System.Drawing.Point(124, 4);
            this.tabVisualAnalysis.Name = "tabVisualAnalysis";
            this.tabVisualAnalysis.Size = new System.Drawing.Size(1030, 685);
            this.tabVisualAnalysis.TabIndex = 3;
            this.tabVisualAnalysis.Text = "视觉分析";
            // 
            // tabBeamShotAbutment
            // 
            this.tabBeamShotAbutment.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabBeamShotAbutment.Location = new System.Drawing.Point(124, 4);
            this.tabBeamShotAbutment.Name = "tabBeamShotAbutment";
            this.tabBeamShotAbutment.Size = new System.Drawing.Size(1030, 685);
            this.tabBeamShotAbutment.TabIndex = 4;
            this.tabBeamShotAbutment.Text = "束流针对接";
            // 
            // tabBeamShot
            // 
            this.tabBeamShot.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabBeamShot.Location = new System.Drawing.Point(124, 4);
            this.tabBeamShot.Name = "tabBeamShot";
            this.tabBeamShot.Size = new System.Drawing.Size(1030, 685);
            this.tabBeamShot.TabIndex = 5;
            this.tabBeamShot.Text = "出束控制";
            // 
            // tabTreatOver
            // 
            this.tabTreatOver.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabTreatOver.Location = new System.Drawing.Point(124, 4);
            this.tabTreatOver.Name = "tabTreatOver";
            this.tabTreatOver.Size = new System.Drawing.Size(1030, 685);
            this.tabTreatOver.TabIndex = 6;
            this.tabTreatOver.Text = "结束治疗";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.SkyBlue;
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 5, 5);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label12, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label13, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label14, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label15, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label16, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label17, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label18, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label19, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label20, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label24, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.label25, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.label26, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label27, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.label28, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown1, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown2, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown3, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown4, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown5, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown6, 3, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(63, 36);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1000, 384);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(660, 320);
            this.button1.Margin = new System.Windows.Forms.Padding(20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "计划载入";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.ForeColor = System.Drawing.Color.MediumBlue;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 80);
            this.label11.TabIndex = 0;
            this.label11.Text = "使能状态";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(123, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 80);
            this.label12.TabIndex = 1;
            this.label12.Text = "label2";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.ForeColor = System.Drawing.Color.MediumBlue;
            this.label13.Location = new System.Drawing.Point(263, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 80);
            this.label13.TabIndex = 2;
            this.label13.Text = "解释器状态";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(383, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 80);
            this.label14.TabIndex = 3;
            this.label14.Text = "label3";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(643, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 80);
            this.label15.TabIndex = 4;
            this.label15.Text = "label3";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.ForeColor = System.Drawing.Color.MediumBlue;
            this.label16.Location = new System.Drawing.Point(523, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 80);
            this.label16.TabIndex = 5;
            this.label16.Text = "机器状态";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.MediumBlue;
            this.tableLayoutPanel2.SetColumnSpan(this.label17, 8);
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(3, 80);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(994, 40);
            this.label17.TabIndex = 6;
            this.label17.Text = "工具坐标";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.ForeColor = System.Drawing.Color.MediumBlue;
            this.label18.Location = new System.Drawing.Point(3, 120);
            this.label18.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 60);
            this.label18.TabIndex = 7;
            this.label18.Text = "X";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.ForeColor = System.Drawing.Color.MediumBlue;
            this.label19.Location = new System.Drawing.Point(3, 180);
            this.label19.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(107, 60);
            this.label19.TabIndex = 8;
            this.label19.Text = "Y";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.ForeColor = System.Drawing.Color.MediumBlue;
            this.label20.Location = new System.Drawing.Point(3, 240);
            this.label20.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 60);
            this.label20.TabIndex = 9;
            this.label20.Text = "Z";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.ForeColor = System.Drawing.Color.MediumBlue;
            this.label24.Location = new System.Drawing.Point(783, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(114, 80);
            this.label24.TabIndex = 13;
            this.label24.Text = "机器速度";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Location = new System.Drawing.Point(903, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(94, 80);
            this.label25.TabIndex = 14;
            this.label25.Text = "label25";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label26.Location = new System.Drawing.Point(263, 120);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(114, 60);
            this.label26.TabIndex = 15;
            this.label26.Text = "A";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label27.Location = new System.Drawing.Point(263, 180);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(114, 60);
            this.label27.TabIndex = 16;
            this.label27.Text = "B";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label28.Location = new System.Drawing.Point(263, 240);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(114, 60);
            this.label28.TabIndex = 17;
            this.label28.Text = "C";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown1.Location = new System.Drawing.Point(123, 123);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(134, 23);
            this.numericUpDown1.TabIndex = 18;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown2.Location = new System.Drawing.Point(123, 183);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(134, 23);
            this.numericUpDown2.TabIndex = 18;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown3.Location = new System.Drawing.Point(123, 243);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(134, 23);
            this.numericUpDown3.TabIndex = 18;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown4.Location = new System.Drawing.Point(383, 123);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(134, 23);
            this.numericUpDown4.TabIndex = 18;
            this.numericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown5.Location = new System.Drawing.Point(383, 183);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(134, 23);
            this.numericUpDown5.TabIndex = 18;
            this.numericUpDown5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown6.Location = new System.Drawing.Point(383, 243);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(134, 23);
            this.numericUpDown6.TabIndex = 18;
            this.numericUpDown6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Treat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1266, 744);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Treat";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Treat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPatientInfo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabOrientation.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPatientInfo;
        private System.Windows.Forms.TabPage tabPuncture;
        private System.Windows.Forms.TabPage tabOrientation;
        private System.Windows.Forms.TabPage tabVisualAnalysis;
        private System.Windows.Forms.TabPage tabBeamShotAbutment;
        private System.Windows.Forms.TabPage tabBeamShot;
        private System.Windows.Forms.TabPage tabTreatOver;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
    }
}

