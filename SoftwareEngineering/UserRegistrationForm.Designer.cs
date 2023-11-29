namespace SoftwareEngineering
{
    partial class UserRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegistrationForm));
            this.usernamelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1username = new System.Windows.Forms.TextBox();
            this.textBox1_password = new System.Windows.Forms.TextBox();
            this.textBox2_passwordconfirm = new System.Windows.Forms.TextBox();
            this.button1register_user = new System.Windows.Forms.Button();
            this.button1back_user = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernamelabel
            // 
            this.usernamelabel.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.usernamelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernamelabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usernamelabel.Location = new System.Drawing.Point(59, 34);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(209, 35);
            this.usernamelabel.TabIndex = 1;
            this.usernamelabel.Text = "Username";
            this.usernamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(59, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(59, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Confirm Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1username
            // 
            this.textBox1username.Location = new System.Drawing.Point(293, 34);
            this.textBox1username.Name = "textBox1username";
            this.textBox1username.Size = new System.Drawing.Size(221, 26);
            this.textBox1username.TabIndex = 4;
            // 
            // textBox1_password
            // 
            this.textBox1_password.Location = new System.Drawing.Point(293, 101);
            this.textBox1_password.Name = "textBox1_password";
            this.textBox1_password.PasswordChar = '*';
            this.textBox1_password.Size = new System.Drawing.Size(221, 26);
            this.textBox1_password.TabIndex = 5;
            // 
            // textBox2_passwordconfirm
            // 
            this.textBox2_passwordconfirm.Location = new System.Drawing.Point(293, 164);
            this.textBox2_passwordconfirm.Name = "textBox2_passwordconfirm";
            this.textBox2_passwordconfirm.PasswordChar = '*';
            this.textBox2_passwordconfirm.Size = new System.Drawing.Size(221, 26);
            this.textBox2_passwordconfirm.TabIndex = 6;
            // 
            // button1register_user
            // 
            this.button1register_user.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1register_user.Location = new System.Drawing.Point(128, 242);
            this.button1register_user.Name = "button1register_user";
            this.button1register_user.Size = new System.Drawing.Size(140, 39);
            this.button1register_user.TabIndex = 7;
            this.button1register_user.Text = "REGISTER";
            this.button1register_user.UseVisualStyleBackColor = false;
            this.button1register_user.Click += new System.EventHandler(this.button1register_user_Click);
            // 
            // button1back_user
            // 
            this.button1back_user.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1back_user.Location = new System.Drawing.Point(293, 242);
            this.button1back_user.Name = "button1back_user";
            this.button1back_user.Size = new System.Drawing.Size(140, 39);
            this.button1back_user.TabIndex = 8;
            this.button1back_user.Text = "BACK";
            this.button1back_user.UseVisualStyleBackColor = false;
            this.button1back_user.Click += new System.EventHandler(this.button1back_user_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1username);
            this.panel1.Controls.Add(this.textBox1_password);
            this.panel1.Controls.Add(this.textBox2_passwordconfirm);
            this.panel1.Controls.Add(this.button1back_user);
            this.panel1.Controls.Add(this.usernamelabel);
            this.panel1.Controls.Add(this.button1register_user);
            this.panel1.Location = new System.Drawing.Point(144, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 330);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(246, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // UserRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(876, 530);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "UserRegistrationForm";
            this.Text = "userRegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1username;
        private System.Windows.Forms.TextBox textBox1_password;
        private System.Windows.Forms.TextBox textBox2_passwordconfirm;
        private System.Windows.Forms.Button button1register_user;
        private System.Windows.Forms.Button button1back_user;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}