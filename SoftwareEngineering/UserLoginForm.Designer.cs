namespace SoftwareEngineering
{
    partial class UserLoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1username_user = new System.Windows.Forms.TextBox();
            this.textBox1userpassword = new System.Windows.Forms.TextBox();
            this.loginbutton1_user = new System.Windows.Forms.Button();
            this.button2register_user = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(174, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(174, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1username_user
            // 
            this.textBox1username_user.Location = new System.Drawing.Point(386, 101);
            this.textBox1username_user.Name = "textBox1username_user";
            this.textBox1username_user.Size = new System.Drawing.Size(235, 26);
            this.textBox1username_user.TabIndex = 3;
            this.textBox1username_user.TextChanged += new System.EventHandler(this.textBox1username_user_TextChanged);
            // 
            // textBox1userpassword
            // 
            this.textBox1userpassword.Location = new System.Drawing.Point(386, 194);
            this.textBox1userpassword.Name = "textBox1userpassword";
            this.textBox1userpassword.PasswordChar = '*';
            this.textBox1userpassword.Size = new System.Drawing.Size(235, 26);
            this.textBox1userpassword.TabIndex = 4;
            this.textBox1userpassword.TextChanged += new System.EventHandler(this.textBox1userpassword_TextChanged);
            // 
            // loginbutton1_user
            // 
            this.loginbutton1_user.Location = new System.Drawing.Point(240, 301);
            this.loginbutton1_user.Name = "loginbutton1_user";
            this.loginbutton1_user.Size = new System.Drawing.Size(149, 34);
            this.loginbutton1_user.TabIndex = 5;
            this.loginbutton1_user.Text = "LOGIN";
            this.loginbutton1_user.UseVisualStyleBackColor = true;
            this.loginbutton1_user.Click += new System.EventHandler(this.loginbutton1_user_Click);
            // 
            // button2register_user
            // 
            this.button2register_user.Location = new System.Drawing.Point(421, 301);
            this.button2register_user.Name = "button2register_user";
            this.button2register_user.Size = new System.Drawing.Size(149, 34);
            this.button2register_user.TabIndex = 6;
            this.button2register_user.Text = "REGISTER";
            this.button2register_user.UseVisualStyleBackColor = true;
            this.button2register_user.Click += new System.EventHandler(this.button2register_user_Click);
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2register_user);
            this.Controls.Add(this.loginbutton1_user);
            this.Controls.Add(this.textBox1userpassword);
            this.Controls.Add(this.textBox1username_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserLoginForm";
            this.Text = "UserLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1username_user;
        private System.Windows.Forms.TextBox textBox1userpassword;
        private System.Windows.Forms.Button loginbutton1_user;
        private System.Windows.Forms.Button button2register_user;
    }
}