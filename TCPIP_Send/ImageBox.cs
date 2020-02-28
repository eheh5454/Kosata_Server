using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPIP_Send
{
    public partial class ImageBox : Form
    {
        public ImageBox(Bitmap bmp)
        {
            InitializeComponent();
            pictureBox1.Image = (Image)bmp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ImageBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
