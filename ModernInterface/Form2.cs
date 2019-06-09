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
    public partial class FormFacebook2 : Form
    {
        public FormFacebook2()
        {
            InitializeComponent();
        }
        FormFacebook3 frm3 = new FormFacebook3();//object

        private void textBox1_Click(object sender, EventArgs e)
        {
            PicUsername.BackgroundImage = Properties.Resources.login_profile;//image location
            TxtUsername.Clear();//click event triggers clearing of the text box
        }

      
        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            PicPassword.BackgroundImage = Properties.Resources.password;//image location
            TxtPassword.Clear();//click event triggers clearing of the text box
            TxtPassword.PasswordChar = '*';//password hiding and displaying asterics
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
           timer1.Start();//timer1 starts after picture is clicked on
        }

        

        

        private void timer1_Tick(object sender, EventArgs e)//events to take place after timer1 starts
        {

           label2.Text = frm3.Left.ToString();

           frm3.Left += 10;
           if (frm3.Left >= 900)
          {
             timer1.Stop();
             this.TopMost = false;
             frm3.TopMost = true;
             timer2.Start();
          }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = frm3.Left.ToString();
            frm3.Left -= 10;
            if (frm3.Left <= 530)
          {

             timer2.Stop();
          }
        }
        
        
        private void Form2_Load(object sender, EventArgs e)
        {
            frm3.Show();
        }

        
    }
}
