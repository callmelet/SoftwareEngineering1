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
            this.usernamelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1username = new System.Windows.Forms.TextBox();
            this.textBox1_password = new System.Windows.Forms.TextBox();
            this.textBox2_passwordconfirm = new System.Windows.Forms.TextBox();
            this.button1register_user = new System.Windows.Forms.Button();
            this.button1back_user = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernamelabel
            // 
            this.usernamelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernamelabel.Location = new System.Drawing.Point(144, 79);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(209, 35);
            this.usernamelabel.TabIndex = 1;
            this.usernamelabel.Text = "Username";
            this.usernamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(144, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(144, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Confirm Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1username
            // 
            this.textBox1username.Location = new System.Drawing.Point(407, 83);
            this.textBox1username.Name = "textBox1username";
            this.textBox1username.Size = new System.Drawing.Size(221, 26);
            this.textBox1username.TabIndex = 4;
            this.textBox1username.Click += new System.EventHandler(this.textBox1username_TextChanged);
            this.textBox1username.TextChanged += new System.EventHandler(this.textBox1username_TextChanged);
            // 
            // textBox1_password
            // 
            this.textBox1_password.Location = new System.Drawing.Point(407, 160);
            this.textBox1_password.Name = "textBox1_password";
            this.textBox1_password.PasswordChar = '*';
            this.textBox1_password.Size = new System.Drawing.Size(221, 26);
            this.textBox1_password.TabIndex = 5;
            this.textBox1_password.Click += new System.EventHandler(this.textBox1_password_TextChanged);
            this.textBox1_password.TextChanged += new System.EventHandler(this.textBox1_password_TextChanged);
            // 
            // textBox2_passwordconfirm
            // 
            this.textBox2_passwordconfirm.Location = new System.Drawing.Point(407, 231);
            this.textBox2_passwordconfirm.Name = "textBox2_passwordconfirm";
            this.textBox2_passwordconfirm.PasswordChar = '*';
            this.textBox2_passwordconfirm.Size = new System.Drawing.Size(221, 26);
            this.textBox2_passwordconfirm.TabIndex = 6;
            this.textBox2_passwordconfirm.Click += new System.EventHandler(this.textBox2_passwordconfirm_TextChanged);
            this.textBox2_passwordconfirm.TextChanged += new System.EventHandler(this.textBox2_passwordconfirm_TextChanged);
            // 
            // button1register_user
            // 
            this.button1register_user.Location = new System.Drawing.Point(234, 302);
            this.button1register_user.Name = "button1register_user";
            this.button1register_user.Size = new System.Drawing.Size(140, 39);
            this.button1register_user.TabIndex = 7;
            this.button1register_user.Text = "REGISTER";
            this.button1register_user.UseVisualStyleBackColor = true;
            this.button1register_user.Click += new System.EventHandler(this.button1register_user_Click);
            // 
            // button1back_user
            // 
            this.button1back_user.Location = new System.Drawing.Point(407, 302);
            this.button1back_user.Name = "button1back_user";
            this.button1back_user.Size = new System.Drawing.Size(140, 39);
            this.button1back_user.TabIndex = 8;
            this.button1back_user.Text = "BACK";
            this.button1back_user.UseVisualStyleBackColor = true;
            this.button1back_user.Click += new System.EventHandler(this.button1back_user_Click);
            // 
            // UserRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1back_user);
            this.Controls.Add(this.button1register_user);
            this.Controls.Add(this.textBox2_passwordconfirm);
            this.Controls.Add(this.textBox1_password);
            this.Controls.Add(this.textBox1username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernamelabel);
            this.Name = "UserRegistrationForm";
            this.Text = "userRegisterForm";
            this.Load += new System.EventHandler(this.UserRegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}