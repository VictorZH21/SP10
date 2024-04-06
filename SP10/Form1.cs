using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP10
{
    public partial class Form1 : Form
    {
        public static Bitmap screen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPG|*.jpg";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Form1.screen.Save(sfd.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = Graphics.FromImage(screen as Image);
            graphics.CopyFromScreen(0, 0, 0, 0, screen.Size);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Form1.screen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG|*.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Form1.screen.Save(sfd.FileName);
            }
        }
    }
}
