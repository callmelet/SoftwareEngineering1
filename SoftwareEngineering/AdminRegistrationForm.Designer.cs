namespace SoftwareEngineering
{
    partial class AdminRegistrationForm
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
            this.button1register_admin = new System.Windows.Forms.Button();
            this.button1back_admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernamelabel
            // 
            this.usernamelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernamelabel.Location = new System.Drawing.Point(142, 85);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(209, 35);
            this.usernamelabel.TabIndex = 2;
            this.usernamelabel.Text = "Username";
            this.usernamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(142, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Create Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(142, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirm Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1username
            // 
            this.textBox1username.Location = new System.Drawing.Point(387, 89);
            this.textBox1username.Name = "textBox1username";
            this.textBox1username.Size = new System.Drawing.Size(221, 26);
            this.textBox1username.TabIndex = 5;
            // 
            // textBox1_password
            // 
            this.textBox1_password.Location = new System.Drawing.Point(387, 168);
            this.textBox1_password.Name = "textBox1_password";
            this.textBox1_password.PasswordChar = '*';
            this.textBox1_password.Size = new System.Drawing.Size(221, 26);
            this.textBox1_password.TabIndex = 6;
            // 
            // textBox2_passwordconfirm
            // 
            this.textBox2_passwordconfirm.Location = new System.Drawing.Point(387, 242);
            this.textBox2_passwordconfirm.Name = "textBox2_passwordconfirm";
            this.textBox2_passwordconfirm.PasswordChar = '*';
            this.textBox2_passwordconfirm.Size = new System.Drawing.Size(221, 26);
            this.textBox2_passwordconfirm.TabIndex = 7;
            // 
            // button1register_admin
            // 
            this.button1register_admin.Location = new System.Drawing.Point(230, 320);
            this.button1register_admin.Name = "button1register_admin";
            this.button1register_admin.Size = new System.Drawing.Size(140, 39);
            this.button1register_admin.TabIndex = 8;
            this.button1register_admin.Text = "REGISTER";
            this.button1register_admin.UseVisualStyleBackColor = true;
            this.button1register_admin.Click += new System.EventHandler(this.button1register_admin_Click);
            // 
            // button1back_admin
            // 
            this.button1back_admin.Location = new System.Drawing.Point(387, 320);
            this.button1back_admin.Name = "button1back_admin";
            this.button1back_admin.Size = new System.Drawing.Size(140, 39);
            this.button1back_admin.TabIndex = 9;
            this.button1back_admin.Text = "BACK";
            this.button1back_admin.UseVisualStyleBackColor = true;
            this.button1back_admin.Click += new System.EventHandler(this.button1back_user_Click);
            // 
            // AdminRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 417);
            this.Controls.Add(this.button1back_admin);
            this.Controls.Add(this.button1register_admin);
            this.Controls.Add(this.textBox2_passwordconfirm);
            this.Controls.Add(this.textBox1_password);
            this.Controls.Add(this.textBox1username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernamelabel);
            this.Name = "AdminRegistrationForm";
            this.Text = "AdminRegistrationForm";
            this.Load += new System.EventHandler(this.AdminRegistrationForm_Load);
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
        private System.Windows.Forms.Button button1register_admin;
        private System.Windows.Forms.Button button1back_admin;
    }
}