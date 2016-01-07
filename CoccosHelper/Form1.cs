using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Diagnostics;
namespace CoccosHelper
{
    public partial class Form1 : Form
    {
        string PATH = System.Environment.CurrentDirectory;

        public Form1()
        {
            InitializeComponent();
            this.fileSystemWatcher1.Path = PATH;
        }


        private void button_create_resource_Click(object sender, EventArgs e)
        {
            Resource.createResource();
        }

        private void button_create_file_Click(object sender, EventArgs e)
        {
            JS.createFilesJs();
        }

        private void checkBox_auto_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_auto.Checked)
            {
                this.button_create_file.Enabled = false;
                this.button_create_resource.Enabled = false;
            }
            else {
                this.button_create_file.Enabled = true;
                this.button_create_resource.Enabled = true;
            }

        }

        void tryReCreate()
        {
            if (this.checkBox_auto.Checked)
            {
                Resource.createResource();
                JS.createFilesJs();
            }
            if (checkBoxRemoveSlice.Checked) {
                Resource.removeSlice();
            }
        }

        private void fileSystemWatcher1_Renamed(object sender, RenamedEventArgs e)
        {
            tryReCreate();
        }

        private void fileSystemWatcher1_Deleted(object sender, FileSystemEventArgs e)
        {
            tryReCreate();
        }

        private void fileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            tryReCreate();
        }

        private void radioButtonSliceOn_CheckedChanged(object sender, EventArgs e)
        {
            Global.slice = this.radioButtonSliceOn.Checked;
           
        }

        private void checkBoxRemoveSlice_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRemoveSlice.Checked) {
                Resource.removeSlice();
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)    //最小化到系统托盘
            {
                this.ShowInTaskbar = false;  //不显示在系统任务栏
                this.notifyIcon1.Visible = true;  //托盘图标可见
            }
 
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ShowInTaskbar = true;  //显示在系统任务栏
            this.WindowState = FormWindowState.Normal;  //还原窗体
            this.notifyIcon1.Visible = false;  //托盘图标隐藏
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "当前目录:"+ PATH;
        }

        private void buttonPublish_Click(object sender, EventArgs e)
        {
            this.buttonPublish.Text = "发布中...";
            this.buttonPublish.Enabled = false;

            var disk = PATH.Split(':')[0]+":";

            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            try
            {
                p.Start();
                p.StandardInput.WriteLine(disk + "&cd " + PATH + "\\helper\\&release_web.py");
                p.StandardInput.WriteLine("exit");
                p.WaitForExit();
                p.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("发布失败:"+ ex.ToString());

            }
            this.buttonPublish.Text = "打包发布";
            this.buttonPublish.Enabled = true;


        }
    }
}
