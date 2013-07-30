namespace pokeTools
{
    partial class mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.CMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hourBox = new System.Windows.Forms.NumericUpDown();
            this.minuteBox = new System.Windows.Forms.NumericUpDown();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.ODlg1 = new System.Windows.Forms.OpenFileDialog();
            this.AddBtn = new System.Windows.Forms.Button();
            this.RemBtn = new System.Windows.Forms.Button();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.list1 = new System.Windows.Forms.ListView();
            this.Wpfile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Min = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hourBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteBox)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.CMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Poke Wallpaper Sentinel\r\n - v 0.0.2";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // CMenu
            // 
            this.CMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.CMenu.Name = "CMenu";
            this.CMenu.Size = new System.Drawing.Size(93, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // hourBox
            // 
            this.hourBox.Location = new System.Drawing.Point(236, 12);
            this.hourBox.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(39, 21);
            this.hourBox.TabIndex = 2;
            // 
            // minuteBox
            // 
            this.minuteBox.Location = new System.Drawing.Point(281, 12);
            this.minuteBox.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minuteBox.Name = "minuteBox";
            this.minuteBox.Size = new System.Drawing.Size(39, 21);
            this.minuteBox.TabIndex = 3;
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(41, 12);
            this.pathBox.Name = "pathBox";
            this.pathBox.ReadOnly = true;
            this.pathBox.Size = new System.Drawing.Size(189, 21);
            this.pathBox.TabIndex = 99;
            this.pathBox.TabStop = false;
            // 
            // ODlg1
            // 
            this.ODlg1.FileName = "openFileDialog1";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(326, 11);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RemBtn
            // 
            this.RemBtn.Location = new System.Drawing.Point(407, 11);
            this.RemBtn.Name = "RemBtn";
            this.RemBtn.Size = new System.Drawing.Size(75, 23);
            this.RemBtn.TabIndex = 5;
            this.RemBtn.Text = "Remove";
            this.RemBtn.UseVisualStyleBackColor = true;
            this.RemBtn.Click += new System.EventHandler(this.RemBtn_Click);
            // 
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(12, 11);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(23, 23);
            this.OpenBtn.TabIndex = 0;
            this.OpenBtn.Text = "..";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // list1
            // 
            this.list1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Wpfile,
            this.Hr,
            this.Min});
            this.list1.FullRowSelect = true;
            this.list1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list1.Location = new System.Drawing.Point(12, 40);
            this.list1.MultiSelect = false;
            this.list1.Name = "list1";
            this.list1.ShowGroups = false;
            this.list1.Size = new System.Drawing.Size(470, 300);
            this.list1.TabIndex = 10;
            this.list1.UseCompatibleStateImageBehavior = false;
            this.list1.View = System.Windows.Forms.View.Details;
            // 
            // Wpfile
            // 
            this.Wpfile.Text = "Wallpaper";
            this.Wpfile.Width = 340;
            // 
            // Hr
            // 
            this.Hr.Text = "Hour";
            // 
            // Min
            // 
            this.Min.Text = "Minute";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 352);
            this.Controls.Add(this.list1);
            this.Controls.Add(this.RemBtn);
            this.Controls.Add(this.OpenBtn);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.hourBox);
            this.Controls.Add(this.minuteBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainform";
            this.ShowInTaskbar = false;
            this.Text = "Poke Wallpaper Sentinel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainform_Closing);
            this.Load += new System.EventHandler(this.mainform_Load);
            this.CMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hourBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip CMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown hourBox;
        private System.Windows.Forms.NumericUpDown minuteBox;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.OpenFileDialog ODlg1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button RemBtn;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.ListView list1;
        private System.Windows.Forms.ColumnHeader Wpfile;
        private System.Windows.Forms.ColumnHeader Hr;
        private System.Windows.Forms.ColumnHeader Min;
    }
}

