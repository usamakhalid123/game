using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project_2
{
    public partial class Form3 : Form
    {
         public string pic = "";
        public Form3(string value)
        {
            InitializeComponent();
            pic = value;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (pic == "win")
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\Haier\Desktop\semister projects\Game\New folder\win.png");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\Haier\Desktop\semister projects\Game\New folder\lose.png");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
