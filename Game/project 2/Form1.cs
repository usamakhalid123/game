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
    
    public partial class Form1 : Form
    {                
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }       

        private void button1_Click(object sender, EventArgs e) {
            timer1.Enabled = false;
            button1.Enabled = false;
            if (!button1.Enabled && !button2.Enabled && !button3.Enabled)
            {
                int lb1 = Convert.ToInt32(label1.Text);
                int lb2 = Convert.ToInt32(label2.Text);
                int lb3 = Convert.ToInt32(label3.Text);
                if (lb1 == lb2 && lb1 == lb3 && lb2 == lb3) {
                    Form3 obj1 = new Form3("win");
                    obj1.Show();
                    this.Hide();
                }
                else {
                    Form3 obj2 = new Form3("lose");
                    obj2.Show();
                    this.Hide();
                }
            }           
        }      

        private void button2_Click(object sender, EventArgs e) {
            timer2.Enabled = false;
            button2.Enabled = false;
            if (!button1.Enabled && !button2.Enabled && !button3.Enabled)
            {
                int lb1 = Convert.ToInt32(label1.Text);
                int lb2 = Convert.ToInt32(label2.Text);
                int lb3 = Convert.ToInt32(label3.Text);
                if (lb1 == lb2 && lb1 == lb3 && lb2 == lb3) {
                    Form3 obj1 = new Form3("win");
                    obj1.Show();
                    this.Hide();
                }
                else {
                    Form3 obj2 = new Form3("lose");
                    obj2.Show();
                    this.Hide();

                }
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            timer3.Enabled = false;
            button3.Enabled = false;
            if (!button1.Enabled&& !button2.Enabled && !button3.Enabled) {
                int lb1 = Convert.ToInt32(label1.Text);
                int lb2 = Convert.ToInt32(label2.Text);
                int lb3 = Convert.ToInt32(label3.Text);
                if (lb1 == lb2 && lb1 == lb3 && lb2 == lb3) {
                    Form3 obj1 = new Form3("win");
                    obj1.Show();
                    this.Hide();
                } 
                else {
                    Form3 obj2 = new Form3("lose");
                    obj2.Show();
                    this.Hide();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            timer1.Enabled = true;
            button1.Enabled = true;
            timer2.Enabled = true;
            button2.Enabled = true;
            timer3.Enabled = true;
            button3.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            Random r = new Random();
            label1.Text = Convert.ToString(r.Next(0, 9));
        }

        private void timer2_Tick(object sender, EventArgs e) {
            Random S = new Random();
            label2.Text = Convert.ToString(S.Next(0,8));
        }

        private void timer3_Tick(object sender, EventArgs e) {
            Random T = new Random();
            label3.Text = Convert.ToString(T.Next(0,10));
        }
    }
}
