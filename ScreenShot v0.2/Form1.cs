using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenShot_v0._2
{
    public partial class Form1 : Form
    {
        Form2 frm = new Form2();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bitmap foto = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics grafik = Graphics.FromImage(foto);
            grafik.CopyFromScreen(0, 0, 0, 0, new Size(foto.Width, foto.Height));
            pictureBox1.Image = foto;
            if (pictureBox1.Image == null)
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "jpeg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";

            sfd.Title = "Kayıt";

            sfd.FileName = "resim";

            DialogResult sonuç = sfd.ShowDialog();

            if (sonuç == DialogResult.OK)
            {
                pictureBox1.Image.Save(sfd.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            button2.Enabled = false;
            button7.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = true;
            if (pictureBox1.Image == null)
            {
                button2.Enabled = false;
                button7.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(30000);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            notifyIcon1.Visible = false;
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Width = 308;
            this.Height = 61;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bitmap foto = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics grafik = Graphics.FromImage(foto);
            grafik.CopyFromScreen(0, 0, 0, 0, new Size(foto.Width, foto.Height));
            pictureBox1.Image = foto;
            if (pictureBox1.Image == null)
            {
                button2.Enabled = false;
                button7.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
                button7.Enabled = true;
            }
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "jpeg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";

            sfd.Title = "Kayıt";

            sfd.FileName = "resim";

            DialogResult sonuç = sfd.ShowDialog();

            if (sonuç == DialogResult.OK)
            {
                pictureBox1.Image.Save(sfd.FileName);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Width = 308;
            this.Height = 320;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Width = 308;
            this.Height = 61;
        }
    }
}

