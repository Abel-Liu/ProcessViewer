namespace ProcessView
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemKnown = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHidden = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemKill = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpenLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.ckHideKnown = new System.Windows.Forms.CheckBox();
            this.ckDoNotDisplayHidden = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.betterListView1 = new ComponentOwl.BetterListView.BetterListView();
            this.betterListViewColumnHeader1 = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
            this.betterListViewColumnHeader2 = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
            this.betterListViewColumnHeader3 = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
            this.betterListViewColumnHeader4 = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betterListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemKnown,
            this.toolStripMenuItemHidden,
            this.toolStripSeparator1,
            this.toolStripMenuItemKill,
            this.toolStripMenuItemOpenLocation});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 98);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // toolStripMenuItemKnown
            // 
            this.toolStripMenuItemKnown.Name = "toolStripMenuItemKnown";
            this.toolStripMenuItemKnown.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItemKnown.Tag = "known";
            this.toolStripMenuItemKnown.Text = "标记为已知";
            // 
            // toolStripMenuItemHidden
            // 
            this.toolStripMenuItemHidden.Name = "toolStripMenuItemHidden";
            this.toolStripMenuItemHidden.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItemHidden.Tag = "hidden";
            this.toolStripMenuItemHidden.Text = "隐藏";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // toolStripMenuItemKill
            // 
            this.toolStripMenuItemKill.Name = "toolStripMenuItemKill";
            this.toolStripMenuItemKill.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItemKill.Tag = "kill";
            this.toolStripMenuItemKill.Text = "结束进程";
            // 
            // toolStripMenuItemOpenLocation
            // 
            this.toolStripMenuItemOpenLocation.Name = "toolStripMenuItemOpenLocation";
            this.toolStripMenuItemOpenLocation.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItemOpenLocation.Tag = "location";
            this.toolStripMenuItemOpenLocation.Text = "打开文件位置";
            // 
            // ckHideKnown
            // 
            this.ckHideKnown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckHideKnown.AutoSize = true;
            this.ckHideKnown.Checked = true;
            this.ckHideKnown.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckHideKnown.Location = new System.Drawing.Point(782, 12);
            this.ckHideKnown.Name = "ckHideKnown";
            this.ckHideKnown.Size = new System.Drawing.Size(84, 16);
            this.ckHideKnown.TabIndex = 1;
            this.ckHideKnown.Text = "不显示已知";
            this.ckHideKnown.UseVisualStyleBackColor = true;
            this.ckHideKnown.CheckedChanged += new System.EventHandler(this.ckHideKnown_CheckedChanged);
            // 
            // ckDoNotDisplayHidden
            // 
            this.ckDoNotDisplayHidden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckDoNotDisplayHidden.AutoSize = true;
            this.ckDoNotDisplayHidden.Checked = true;
            this.ckDoNotDisplayHidden.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckDoNotDisplayHidden.Location = new System.Drawing.Point(896, 12);
            this.ckDoNotDisplayHidden.Name = "ckDoNotDisplayHidden";
            this.ckDoNotDisplayHidden.Size = new System.Drawing.Size(84, 16);
            this.ckDoNotDisplayHidden.TabIndex = 2;
            this.ckDoNotDisplayHidden.Text = "不显示隐藏";
            this.ckDoNotDisplayHidden.UseVisualStyleBackColor = true;
            this.ckDoNotDisplayHidden.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // betterListView1
            // 
            this.betterListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.betterListView1.Columns.Add(this.betterListViewColumnHeader1);
            this.betterListView1.Columns.Add(this.betterListViewColumnHeader2);
            this.betterListView1.Columns.Add(this.betterListViewColumnHeader3);
            this.betterListView1.Columns.Add(this.betterListViewColumnHeader4);
            this.betterListView1.ContextMenuStripItems = this.contextMenuStrip1;
            this.betterListView1.Location = new System.Drawing.Point(12, 34);
            this.betterListView1.MultiSelect = false;
            this.betterListView1.Name = "betterListView1";
            this.betterListView1.Size = new System.Drawing.Size(968, 525);
            this.betterListView1.TabIndex = 4;
            // 
            // betterListViewColumnHeader1
            // 
            this.betterListViewColumnHeader1.Name = "betterListViewColumnHeader1";
            this.betterListViewColumnHeader1.Text = "Name";
            this.betterListViewColumnHeader1.Width = 400;
            // 
            // betterListViewColumnHeader2
            // 
            this.betterListViewColumnHeader2.Name = "betterListViewColumnHeader2";
            this.betterListViewColumnHeader2.Text = "PID";
            this.betterListViewColumnHeader2.Width = 80;
            // 
            // betterListViewColumnHeader3
            // 
            this.betterListViewColumnHeader3.Name = "betterListViewColumnHeader3";
            this.betterListViewColumnHeader3.Text = "Path";
            this.betterListViewColumnHeader3.Width = 600;
            // 
            // betterListViewColumnHeader4
            // 
            this.betterListViewColumnHeader4.Name = "betterListViewColumnHeader4";
            this.betterListViewColumnHeader4.Text = "Description";
            this.betterListViewColumnHeader4.Width = 200;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 571);
            this.Controls.Add(this.betterListView1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.ckDoNotDisplayHidden);
            this.Controls.Add(this.ckHideKnown);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProcessView";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.betterListView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemKnown;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHidden;
        private System.Windows.Forms.CheckBox ckHideKnown;
        private System.Windows.Forms.CheckBox ckDoNotDisplayHidden;
        private System.Windows.Forms.Button btnRefresh;
        private ComponentOwl.BetterListView.BetterListView betterListView1;
        private ComponentOwl.BetterListView.BetterListViewColumnHeader betterListViewColumnHeader1;
        private ComponentOwl.BetterListView.BetterListViewColumnHeader betterListViewColumnHeader2;
        private ComponentOwl.BetterListView.BetterListViewColumnHeader betterListViewColumnHeader3;
        private ComponentOwl.BetterListView.BetterListViewColumnHeader betterListViewColumnHeader4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemKill;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenLocation;
    }
}

