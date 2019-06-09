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
    public partial class FormTwitter1 : Form
    {
        public FormTwitter1()
        {
            InitializeComponent();
        }

        FormTwitter3 frm7 = new FormTwitter3();

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label2.Text = frm7.Left.ToString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            frm7.Left += 10;
            if (frm7.Left >= 900)
            {
                timer1.Stop();
            this.TopMost = false;
                this.frm7.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            frm7.Left -= 10;
            if (frm7.Left<=530)
            {


                timer2.Stop();
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            frm7.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox3.PasswordChar = '*';
        }
    }
}
