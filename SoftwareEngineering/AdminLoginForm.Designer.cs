namespace SoftwareEngineering
{
    partial class AdminLoginForm
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
            this.textBox1username = new System.Windows.Forms.TextBox();
            this.textBox2password = new System.Windows.Forms.TextBox();
            this.loginbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(175, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(174, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admin Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1username
            // 
            this.textBox1username.Location = new System.Drawing.Point(399, 90);
            this.textBox1username.Name = "textBox1username";
            this.textBox1username.Size = new System.Drawing.Size(235, 26);
            this.textBox1username.TabIndex = 2;
            this.textBox1username.TextChanged += new System.EventHandler(this.textBox1username_TextChanged);
            // 
            // textBox2password
            // 
            this.textBox2password.Location = new System.Drawing.Point(399, 182);
            this.textBox2password.Name = "textBox2password";
            this.textBox2password.PasswordChar = '*';
            this.textBox2password.Size = new System.Drawing.Size(235, 26);
            this.textBox2password.TabIndex = 3;
            this.textBox2password.TextChanged += new System.EventHandler(this.textBox2password_TextChanged);
            // 
            // loginbutton1
            // 
            this.loginbutton1.Location = new System.Drawing.Point(318, 271);
            this.loginbutton1.Name = "loginbutton1";
            this.loginbutton1.Size = new System.Drawing.Size(149, 34);
            this.loginbutton1.TabIndex = 4;
            this.loginbutton1.Text = "LOGIN";
            this.loginbutton1.UseVisualStyleBackColor = true;
            this.loginbutton1.Click += new System.EventHandler(this.loginbutton1_Click);
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginbutton1);
            this.Controls.Add(this.textBox2password);
            this.Controls.Add(this.textBox1username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminLoginForm";
            this.Text = "AdminLoginForm";
            this.Load += new System.EventHandler(this.AdminLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1username;
        private System.Windows.Forms.TextBox textBox2password;
        private System.Windows.Forms.Button loginbutton1;
    }
}