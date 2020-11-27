namespace EasyPomo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlTime = new System.Windows.Forms.Panel();
            this.ckbOnTop = new System.Windows.Forms.CheckBox();
            this.lklSetting = new System.Windows.Forms.LinkLabel();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.lblRestTime = new System.Windows.Forms.Label();
            this.lblWorkTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlSetting = new System.Windows.Forms.Panel();
            this.nudRt = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudWt = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkCloseBack = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmChangeStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlTime.SuspendLayout();
            this.pnlSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWt)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTime
            // 
            this.pnlTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTime.Controls.Add(this.ckbOnTop);
            this.pnlTime.Controls.Add(this.lklSetting);
            this.pnlTime.Controls.Add(this.btnChangeStatus);
            this.pnlTime.Controls.Add(this.lblRestTime);
            this.pnlTime.Controls.Add(this.lblWorkTime);
            this.pnlTime.Location = new System.Drawing.Point(12, 12);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(180, 157);
            this.pnlTime.TabIndex = 0;
            // 
            // ckbOnTop
            // 
            this.ckbOnTop.AutoSize = true;
            this.ckbOnTop.Location = new System.Drawing.Point(2, 137);
            this.ckbOnTop.Name = "ckbOnTop";
            this.ckbOnTop.Size = new System.Drawing.Size(72, 16);
            this.ckbOnTop.TabIndex = 4;
            this.ckbOnTop.Text = "置顶显示";
            this.ckbOnTop.UseVisualStyleBackColor = true;
            this.ckbOnTop.CheckedChanged += new System.EventHandler(this.ckbOnTop_CheckedChanged);
            // 
            // lklSetting
            // 
            this.lklSetting.AutoSize = true;
            this.lklSetting.Location = new System.Drawing.Point(122, 139);
            this.lklSetting.Name = "lklSetting";
            this.lklSetting.Size = new System.Drawing.Size(53, 12);
            this.lklSetting.TabIndex = 3;
            this.lklSetting.TabStop = true;
            this.lklSetting.Text = "打开设置";
            this.lklSetting.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklSetting_LinkClicked);
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChangeStatus.Location = new System.Drawing.Point(23, 94);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(127, 35);
            this.btnChangeStatus.TabIndex = 2;
            this.btnChangeStatus.Text = "开始";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // lblRestTime
            // 
            this.lblRestTime.AutoSize = true;
            this.lblRestTime.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRestTime.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblRestTime.Location = new System.Drawing.Point(18, 52);
            this.lblRestTime.Name = "lblRestTime";
            this.lblRestTime.Size = new System.Drawing.Size(141, 29);
            this.lblRestTime.TabIndex = 1;
            this.lblRestTime.Text = "05:00:00";
            // 
            // lblWorkTime
            // 
            this.lblWorkTime.AutoSize = true;
            this.lblWorkTime.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWorkTime.ForeColor = System.Drawing.Color.DarkRed;
            this.lblWorkTime.Location = new System.Drawing.Point(18, 13);
            this.lblWorkTime.Name = "lblWorkTime";
            this.lblWorkTime.Size = new System.Drawing.Size(141, 29);
            this.lblWorkTime.TabIndex = 0;
            this.lblWorkTime.Text = "25:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlSetting
            // 
            this.pnlSetting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSetting.Controls.Add(this.nudRt);
            this.pnlSetting.Controls.Add(this.label2);
            this.pnlSetting.Controls.Add(this.nudWt);
            this.pnlSetting.Controls.Add(this.btnSave);
            this.pnlSetting.Controls.Add(this.label1);
            this.pnlSetting.Controls.Add(this.chkCloseBack);
            this.pnlSetting.Location = new System.Drawing.Point(212, 12);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Size = new System.Drawing.Size(180, 157);
            this.pnlSetting.TabIndex = 1;
            // 
            // nudRt
            // 
            this.nudRt.Location = new System.Drawing.Point(122, 67);
            this.nudRt.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudRt.Name = "nudRt";
            this.nudRt.Size = new System.Drawing.Size(40, 21);
            this.nudRt.TabIndex = 5;
            this.nudRt.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "休息时间（分钟）：";
            // 
            // nudWt
            // 
            this.nudWt.Location = new System.Drawing.Point(122, 40);
            this.nudWt.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudWt.Name = "nudWt";
            this.nudWt.Size = new System.Drawing.Size(40, 21);
            this.nudWt.TabIndex = 3;
            this.nudWt.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(100, 130);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "生效";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "工作时间（分钟）：";
            // 
            // chkCloseBack
            // 
            this.chkCloseBack.AutoSize = true;
            this.chkCloseBack.Location = new System.Drawing.Point(3, 13);
            this.chkCloseBack.Name = "chkCloseBack";
            this.chkCloseBack.Size = new System.Drawing.Size(120, 16);
            this.chkCloseBack.TabIndex = 0;
            this.chkCloseBack.Text = "关闭时缩小到托盘";
            this.chkCloseBack.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            this.notifyIcon1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseMove);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShow,
            this.tsmChangeStatus,
            this.toolStripSeparator1,
            this.tsmClose});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 76);
            // 
            // tsmChangeStatus
            // 
            this.tsmChangeStatus.Name = "tsmChangeStatus";
            this.tsmChangeStatus.Size = new System.Drawing.Size(124, 22);
            this.tsmChangeStatus.Text = "开始";
            this.tsmChangeStatus.Click += new System.EventHandler(this.tsmChangeStatus_Click);
            // 
            // tsmClose
            // 
            this.tsmClose.Name = "tsmClose";
            this.tsmClose.Size = new System.Drawing.Size(124, 22);
            this.tsmClose.Text = "退出";
            this.tsmClose.Click += new System.EventHandler(this.tsmClose_Click);
            // 
            // tsmShow
            // 
            this.tsmShow.Name = "tsmShow";
            this.tsmShow.Size = new System.Drawing.Size(124, 22);
            this.tsmShow.Text = "显示界面";
            this.tsmShow.Click += new System.EventHandler(this.tsmShow_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 181);
            this.Controls.Add(this.pnlSetting);
            this.Controls.Add(this.pnlTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 220);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(220, 220);
            this.Name = "Form1";
            this.Text = "EsayPomo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlTime.ResumeLayout(false);
            this.pnlTime.PerformLayout();
            this.pnlSetting.ResumeLayout(false);
            this.pnlSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWt)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTime;
        private System.Windows.Forms.Label lblWorkTime;
        private System.Windows.Forms.Label lblRestTime;
        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel lklSetting;
        private System.Windows.Forms.CheckBox ckbOnTop;
        private System.Windows.Forms.Panel pnlSetting;
        private System.Windows.Forms.NumericUpDown nudRt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudWt;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkCloseBack;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmChangeStatus;
        private System.Windows.Forms.ToolStripMenuItem tsmClose;
        private System.Windows.Forms.ToolStripMenuItem tsmShow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

