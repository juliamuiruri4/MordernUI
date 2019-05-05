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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form3 frm3 = new Form3();

       

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        

        

        private void timer3_Tick(object sender, EventArgs e)
        {

            label2.Text = frm3.Left.ToString();
            frm3.Left += 10;
            if (frm3.Left >= 900)
            {
                timer3.Stop();
                this.TopMost = false;
                frm3.TopMost = true;
                timer3.Start();
            }

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            label2.Text = frm3.Left.ToString();
            frm3.Left -= 10;
            if (frm3.Left <= 525)
            {

                timer3.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            frm3.Show();
        }

       
    }
}
