namespace ModernInterface
{
    partial class FormFacebook2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacebook2));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblLogin = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.PicFacebook = new System.Windows.Forms.PictureBox();
            this.Picgeneral = new System.Windows.Forms.PictureBox();
            this.PicPassword = new System.Windows.Forms.PictureBox();
            this.PicUsername = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picgeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(40, 162);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 1);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // TxtUsername
            // 
            this.TxtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsername.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.ForeColor = System.Drawing.SystemColors.Info;
            this.TxtUsername.HideSelection = false;
            this.TxtUsername.Location = new System.Drawing.Point(75, 137);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(215, 19);
            this.TxtUsername.TabIndex = 10;
            this.TxtUsername.Text = "fb Username";
            this.TxtUsername.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(40, 208);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(250, 1);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.SystemColors.Info;
            this.TxtPassword.HideSelection = false;
            this.TxtPassword.Location = new System.Drawing.Point(75, 183);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(215, 19);
            this.TxtPassword.TabIndex = 12;
            this.TxtPassword.Text = " fb Password";
            this.TxtPassword.Click += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblLogin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblLogin.Location = new System.Drawing.Point(94, 271);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(129, 20);
            this.LblLogin.TabIndex = 19;
            this.LblLogin.Text = "login with Facebook";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(267, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Counter";
            // 
            // PicFacebook
            // 
            this.PicFacebook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicFacebook.Image = global::ModernInterface.Properties.Resources.fb;
            this.PicFacebook.Location = new System.Drawing.Point(138, 314);
            this.PicFacebook.Name = "PicFacebook";
            this.PicFacebook.Size = new System.Drawing.Size(37, 52);
            this.PicFacebook.TabIndex = 16;
            this.PicFacebook.TabStop = false;
            this.PicFacebook.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // Picgeneral
            // 
            this.Picgeneral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Picgeneral.BackgroundImage")));
            this.Picgeneral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Picgeneral.Image = global::ModernInterface.Properties.Resources._5;
            this.Picgeneral.Location = new System.Drawing.Point(123, 38);
            this.Picgeneral.Name = "Picgeneral";
            this.Picgeneral.Size = new System.Drawing.Size(65, 48);
            this.Picgeneral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picgeneral.TabIndex = 14;
            this.Picgeneral.TabStop = false;
            // 
            // PicPassword
            // 
            this.PicPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicPassword.BackgroundImage")));
            this.PicPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PicPassword.Image = global::ModernInterface.Properties.Resources.password;
            this.PicPassword.Location = new System.Drawing.Point(40, 169);
            this.PicPassword.Name = "PicPassword";
            this.PicPassword.Size = new System.Drawing.Size(29, 33);
            this.PicPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicPassword.TabIndex = 11;
            this.PicPassword.TabStop = false;
            // 
            // PicUsername
            // 
            this.PicUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicUsername.BackgroundImage")));
            this.PicUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PicUsername.Image = global::ModernInterface.Properties.Resources.login_profile;
            this.PicUsername.Location = new System.Drawing.Point(40, 119);
            this.PicUsername.Name = "PicUsername";
            this.PicUsername.Size = new System.Drawing.Size(29, 37);
            this.PicUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicUsername.TabIndex = 8;
            this.PicUsername.TabStop = false;
            // 
            // FormFacebook2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(314, 495);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.PicFacebook);
            this.Controls.Add(this.Picgeneral);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.PicPassword);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.PicUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFacebook2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picgeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicUsername)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox PicUsername;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.PictureBox PicPassword;
        private System.Windows.Forms.PictureBox Picgeneral;
        private System.Windows.Forms.PictureBox PicFacebook;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
    }
}