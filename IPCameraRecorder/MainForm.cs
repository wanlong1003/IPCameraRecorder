using AForge.Video;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace IPCameraRecorder
{
    public partial class MainForm : Form
    {
        List<VideoInfo> list;
        private MJPEGStream mjpeg = new MJPEGStream();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.pbVideo.Image = System.Drawing.Image.FromFile(Path.Combine(Application.StartupPath, "novideo.jpg"));
            this.mjpeg.ForceBasicAuthentication = true;
            this.mjpeg.HttpUserAgent = "lwl IP Camera Recoder";
            this.mjpeg.NewFrame += mjpeg_NewFrame;
            this.mjpeg.PlayingFinished += mjpeg_PlayingFinished;
            this.mjpeg.VideoSourceError += mjpeg_VideoSourceError;

            string fileName = Path.Combine(Application.StartupPath, System.Configuration.ConfigurationManager.AppSettings["FileName"]);
            list = ReadData(fileName);
            ReloadTree();
            timer.Start();
        }

        void mjpeg_VideoSourceError(object sender, VideoSourceErrorEventArgs eventArgs)
        {
            //视频源发生错误
            this.mjpeg.Stop();
            this.pbVideo.Image = null;
        }

        void mjpeg_PlayingFinished(object sender, ReasonToFinishPlaying reason)
        {
            //停止播放后触发的事件
            this.pbVideo.Image = null;
        }

        void mjpeg_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //接收到完整帧触发的事件
            if (this.mjpeg.IsRunning)
            {
                Bitmap image = new Bitmap(eventArgs.Frame);
                this.pbVideo.Image = image;
            }
        }

        private void tvDevice_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.mjpeg.IsRunning)
            {
                this.mjpeg.Stop();
                this.mjpeg.WaitForStop();
            }

            this.pbVideo.Image = System.Drawing.Image.FromFile(Path.Combine(Application.StartupPath, "novideo.jpg"));
            VideoInfo video = e.Node.Tag as VideoInfo;
            if (video != null)
            {
                this.mjpeg.Source = video.Url;
                this.mjpeg.Login = video.UserName;
                this.mjpeg.Password = video.UserPassword;
                this.mjpeg.Start();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.statusTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if (this.mjpeg.IsRunning)
            {
                this.statusVideoInfo.Text = string.Format("帧率:{0}    已收到:{1}", this.mjpeg.FramesReceived, this.mjpeg.BytesReceived);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.mjpeg.IsRunning)
            {
                this.mjpeg.Stop();
                this.mjpeg.WaitForStop();
            }
        }

        private void menuItemAdd_Click(object sender, EventArgs e)
        {
            VideoInfo video = new VideoInfo();
            AddForm add = new AddForm(video);
            if (add.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                list.Add(video);
                ReloadTree(video);
                string fileName = Path.Combine(Application.StartupPath, System.Configuration.ConfigurationManager.AppSettings["FileName"]);
                WriteData(fileName);
            }
        }

        private void ReloadTree(VideoInfo current = null)
        {
            tvDevice.Nodes[0].Nodes.Clear();
            foreach (var video in list)
            {
                TreeNode node = new TreeNode();
                node.Text = video.Url;
                node.Tag = video;
                tvDevice.Nodes[0].Nodes.Add(node);
                if (current == video)
                {
                    tvDevice.SelectedNode = node;
                }
            }
            tvDevice.ExpandAll();
        }

        private List<VideoInfo> ReadData(string fileName)
        {
            List<VideoInfo> temp = null;
            if (File.Exists(fileName))
            {
                temp = JsonConvert.DeserializeObject<List<VideoInfo>>(File.ReadAllText(fileName));
            }
            if (temp == null)
            {
                temp = new List<VideoInfo>();
            }
            return temp;
        }

        private void WriteData(string fileName)
        {
            var data = JsonConvert.SerializeObject(list);
            File.WriteAllText(fileName, data);
        }

    }
}
