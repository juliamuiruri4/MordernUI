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
    public partial class FormGoogle2: Form
    {
        public FormGoogle2()
        {
            InitializeComponent();
        }
        FormGoogle3 frm5 = new FormGoogle3();



        private void pictureBox6_Click(object sender, EventArgs e)
        {
            timer1.Start();
            frm5.Show();
        }


        


       

        private void Form4_Load_1(object sender, EventArgs e)
        {
           //frm5.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox3.PasswordChar = '*';
        }
    }
}

