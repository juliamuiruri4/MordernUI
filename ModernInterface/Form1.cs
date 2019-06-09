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
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }


        FormFacebook2 frm2 = new FormFacebook2();//create an object named frm2 to link to the next facebook form created
        FormGoogle2 frm4 = new FormGoogle2();//create an object named frm4 to link to the next google form created
        FormTwitter1 frm6 = new FormTwitter1();//create an object named frm6 to link to the next twitter form created

        private void textBox1_Click(object sender, EventArgs e)
        {
            PicUsername.BackgroundImage = Properties.Resources.login_profile;//link to image location
            TxtUsername.Clear();//clear text content in textbox when click event occurs

          //flowLayoutPanel1.BackColor = Color.FromArgb(78, 184, 206);
          //TxtUsername.ForeColor = Color.FromArgb(78, 184, 206);

          // flowLayoutPanel2.BackColor = Color.WhiteSmoke;
          // TxtUsername.ForeColor = Color.WhiteSmoke;

          //  flowLayoutPanel3.BackColor = Color.WhiteSmoke;
          // TxtUsername.ForeColor = Color.WhiteSmoke;
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            PicEmail.BackgroundImage = Properties.Resources.IT_Student_2_20181107_222013;//image location
            TxtEmail.Clear();//clear text content in textbox when click event occurs

            //flowLayoutPanel1.BackColor = Color.FromArgb(78, 184, 206);
            //TxtEmail.ForeColor = Color.FromArgb(78, 184, 206);

            //flowLayoutPanel2.BackColor = Color.WhiteSmoke;
            //TxtEmail.ForeColor = Color.WhiteSmoke;

            //flowLayoutPanel3.BackColor = Color.WhiteSmoke;
            //TxtEmail.ForeColor = Color.WhiteSmoke;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            PicPassword.BackgroundImage = Properties.Resources.login_profile;//image location
            TxtPassword.Clear();//clear text content in textbox when click event occurs
            TxtPassword.PasswordChar = '*';//encrypt password with asterics for security reason
         
           
            //flowLayoutPanel1.BackColor = Color.FromArgb(78, 184, 206);
            //TxtPassword.ForeColor = Color.FromArgb(78, 184, 206);

            //pictureBox4.BackgroundImage = Properties.Resources.IT_Student_2_20181107_222013;
            //flowLayoutPanel2.BackColor = Color.WhiteSmoke;
            //TxtPassword.ForeColor = Color.WhiteSmoke;

            //pictureBox4.BackgroundImage = Properties.Resources.password;
            //flowLayoutPanel3.BackColor = Color.WhiteSmoke;
            //TxtPassword.ForeColor = Color.WhiteSmoke;
        }



        private void pictureBox5_Click(object sender, EventArgs e)
        {
            timer1.Start();//timer 1 starts when the picture box 5 is clicked on
            frm2.Show();//To show the form on the screen
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            timer3.Start();//timer 3 starts when the picture box 6 is clicked on
            frm4.Show();// To show the form on the screen
        }


        private void pictureBox7_Click(object sender, EventArgs e)
        {
            timer5.Start();//timer 5 starts when the picture box 7 is clicked on
            frm6.Show();// To show the form on the screen
        }
        private void timer1_Tick_1(object sender, EventArgs e)//events to tale place when timer 1 starts
        {

            label2.Text = frm2.Left.ToString();

            frm2.Left += 10;//increament speed of sliding towards the right
            if (frm2.Left >= 900)
            {
                timer1.Stop();
                this.TopMost = false;//responsible for making the form 2 settle in front of the original one
                this.frm2.TopMost = true;//responsible for making the form 2 settle in front of the original one
                timer2.Start();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)//events to tale place when timer 2 starts
        {

            label2.Text = frm2.Left.ToString();

            frm2.Left -= 10;//decrement speed of sliding towards the left
            if (frm2.Left <= 530)//the position of the next form on the front
            {

                timer2.Stop();
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            label2.Text = frm6.Left.ToString();

            frm6.Left += 10;
            if (frm6.Left >= 900)
            {
                timer5.Stop();
                this.TopMost = false;
                this.frm6.TopMost = true;
                timer6.Start();
            }

        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            label2.Text = frm6.Left.ToString();

            frm6.Left -= 10;
            if (frm6.Left <= 530)
            {
                timer6.Stop();
            }
        }

        
    }
    }
//TO DO
//add the see password option



