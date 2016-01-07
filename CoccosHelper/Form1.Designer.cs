namespace CoccosHelper
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
            this.button_create_resource = new System.Windows.Forms.Button();
            this.button_create_file = new System.Windows.Forms.Button();
            this.checkBox_auto = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxRemoveSlice = new System.Windows.Forms.CheckBox();
            this.radioButtonSliceOff = new System.Windows.Forms.RadioButton();
            this.radioButtonSliceOn = new System.Windows.Forms.RadioButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonPublish = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_create_resource
            // 
            this.button_create_resource.Location = new System.Drawing.Point(115, 20);
            this.button_create_resource.Name = "button_create_resource";
            this.button_create_resource.Size = new System.Drawing.Size(139, 23);
            this.button_create_resource.TabIndex = 0;
            this.button_create_resource.Text = "生成resource.js文件";
            this.button_create_resource.UseVisualStyleBackColor = true;
            this.button_create_resource.Click += new System.EventHandler(this.button_create_resource_Click);
            // 
            // button_create_file
            // 
            this.button_create_file.Location = new System.Drawing.Point(115, 63);
            this.button_create_file.Name = "button_create_file";
            this.button_create_file.Size = new System.Drawing.Size(139, 23);
            this.button_create_file.TabIndex = 1;
            this.button_create_file.Text = "生成file.js文件";
            this.button_create_file.UseVisualStyleBackColor = true;
            this.button_create_file.Click += new System.EventHandler(this.button_create_file_Click);
            // 
            // checkBox_auto
            // 
            this.checkBox_auto.AutoSize = true;
            this.checkBox_auto.Location = new System.Drawing.Point(21, 24);
            this.checkBox_auto.Name = "checkBox_auto";
            this.checkBox_auto.Size = new System.Drawing.Size(72, 16);
            this.checkBox_auto.TabIndex = 2;
            this.checkBox_auto.Text = "自动监控";
            this.checkBox_auto.UseVisualStyleBackColor = true;
            this.checkBox_auto.CheckedChanged += new System.EventHandler(this.checkBox_auto_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_auto);
            this.groupBox1.Controls.Add(this.button_create_resource);
            this.groupBox1.Controls.Add(this.button_create_file);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 104);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发布";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.IncludeSubdirectories = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Created);
            this.fileSystemWatcher1.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Deleted);
            this.fileSystemWatcher1.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher1_Renamed);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxRemoveSlice);
            this.groupBox2.Controls.Add(this.radioButtonSliceOff);
            this.groupBox2.Controls.Add(this.radioButtonSliceOn);
            this.groupBox2.Location = new System.Drawing.Point(329, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 104);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "slice文件夹过滤";
            // 
            // checkBoxRemoveSlice
            // 
            this.checkBoxRemoveSlice.AutoSize = true;
            this.checkBoxRemoveSlice.Checked = true;
            this.checkBoxRemoveSlice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRemoveSlice.Location = new System.Drawing.Point(142, 33);
            this.checkBoxRemoveSlice.Name = "checkBoxRemoveSlice";
            this.checkBoxRemoveSlice.Size = new System.Drawing.Size(102, 16);
            this.checkBoxRemoveSlice.TabIndex = 2;
            this.checkBoxRemoveSlice.Text = "强制移除Slice";
            this.checkBoxRemoveSlice.UseVisualStyleBackColor = true;
            this.checkBoxRemoveSlice.CheckedChanged += new System.EventHandler(this.checkBoxRemoveSlice_CheckedChanged);
            // 
            // radioButtonSliceOff
            // 
            this.radioButtonSliceOff.AutoSize = true;
            this.radioButtonSliceOff.Location = new System.Drawing.Point(74, 33);
            this.radioButtonSliceOff.Name = "radioButtonSliceOff";
            this.radioButtonSliceOff.Size = new System.Drawing.Size(47, 16);
            this.radioButtonSliceOff.TabIndex = 1;
            this.radioButtonSliceOff.Text = "关闭";
            this.radioButtonSliceOff.UseVisualStyleBackColor = true;
            // 
            // radioButtonSliceOn
            // 
            this.radioButtonSliceOn.AutoSize = true;
            this.radioButtonSliceOn.Checked = true;
            this.radioButtonSliceOn.Location = new System.Drawing.Point(21, 33);
            this.radioButtonSliceOn.Name = "radioButtonSliceOn";
            this.radioButtonSliceOn.Size = new System.Drawing.Size(47, 16);
            this.radioButtonSliceOn.TabIndex = 0;
            this.radioButtonSliceOn.TabStop = true;
            this.radioButtonSliceOn.Text = "开启";
            this.radioButtonSliceOn.UseVisualStyleBackColor = true;
            this.radioButtonSliceOn.CheckedChanged += new System.EventHandler(this.radioButtonSliceOn_CheckedChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Cocos 资源管理器";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 181);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(669, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(75, 17);
            this.toolStripStatusLabel1.Text = "当前目录:C:\\";
            // 
            // buttonPublish
            // 
            this.buttonPublish.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonPublish.Location = new System.Drawing.Point(12, 122);
            this.buttonPublish.Name = "buttonPublish";
            this.buttonPublish.Size = new System.Drawing.Size(143, 42);
            this.buttonPublish.TabIndex = 5;
            this.buttonPublish.Text = "打包发布";
            this.buttonPublish.UseVisualStyleBackColor = false;
            this.buttonPublish.Click += new System.EventHandler(this.buttonPublish_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 203);
            this.Controls.Add(this.buttonPublish);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cocos - Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_create_resource;
        private System.Windows.Forms.CheckBox checkBox_auto;
        private System.Windows.Forms.Button button_create_file;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonSliceOff;
        private System.Windows.Forms.RadioButton radioButtonSliceOn;
        private System.Windows.Forms.CheckBox checkBoxRemoveSlice;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button buttonPublish;
    }
}

