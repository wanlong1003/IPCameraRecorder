using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPCameraRecorder
{
    public partial class AddForm : Form
    {
        private VideoInfo _video;
        public AddForm(VideoInfo video)
        {
            InitializeComponent();
            if (video == null)
            {
                video = new VideoInfo();
            }
            _video = video;
            tbUrl.Text = video.Url;
            tbUser.Text = video.UserName;
            tbPassword.Text = video.UserPassword;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _video.Url = tbUrl.Text;
            _video.UserName = tbUser.Text;
            _video.UserPassword = tbPassword.Text;
        }
    }
}
