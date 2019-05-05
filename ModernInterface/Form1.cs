using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        Form2 frm2 = new Form2();//create an object named frm2

       

        private void textBox1_Click(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.login_profile;//link to image location
            textBox1.Clear();
            flowLayoutPanel1.BackColor = Color.FromArgb(78, 184, 206);
            textBox1.ForeColor= Color.FromArgb(78, 184, 206);

            flowLayoutPanel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            flowLayoutPanel3.BackColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.IT_Student_2_20181107_222013;
            textBox2.Clear();
            flowLayoutPanel1.BackColor = Color.FromArgb(78, 184, 206);
            textBox1.ForeColor = Color.FromArgb(78, 184, 206);

            flowLayoutPanel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            flowLayoutPanel3.BackColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.password;
            textBox3.PasswordChar = '*';
           // textBox3.Clear();
           
            flowLayoutPanel3.BackColor = Color.FromArgb(78, 184, 206);
            textBox3.ForeColor = Color.FromArgb(78, 184, 206);

            flowLayoutPanel1.BackColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.WhiteSmoke;

            flowLayoutPanel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

        }

        

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = frm2.Left.ToString();
            frm2.Left += 10;
            if(frm2.Left >=900)
            {
                timer1.Stop();
                this.TopMost = false;
                frm2.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = frm2.Left.ToString();
            frm2.Left -= 10;
            if (frm2.Left <= 525)
            {
                
                timer2.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frm2.Show();
        }

        
    }
}
