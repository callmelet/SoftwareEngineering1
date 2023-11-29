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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1username_user = new System.Windows.Forms.TextBox();
            this.textBox1userpassword = new System.Windows.Forms.TextBox();
            this.loginbutton1_user = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(210, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(210, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1username_user
            // 
            this.textBox1username_user.Location = new System.Drawing.Point(408, 176);
            this.textBox1username_user.Name = "textBox1username_user";
            this.textBox1username_user.Size = new System.Drawing.Size(235, 26);
            this.textBox1username_user.TabIndex = 3;
            // 
            // textBox1userpassword
            // 
            this.textBox1userpassword.Location = new System.Drawing.Point(408, 292);
            this.textBox1userpassword.Name = "textBox1userpassword";
            this.textBox1userpassword.PasswordChar = '*';
            this.textBox1userpassword.Size = new System.Drawing.Size(235, 26);
            this.textBox1userpassword.TabIndex = 4;
            // 
            // loginbutton1_user
            // 
            this.loginbutton1_user.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.loginbutton1_user.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginbutton1_user.Location = new System.Drawing.Point(112, 279);
            this.loginbutton1_user.Name = "loginbutton1_user";
            this.loginbutton1_user.Size = new System.Drawing.Size(149, 34);
            this.loginbutton1_user.TabIndex = 5;
            this.loginbutton1_user.Text = "LOGIN";
            this.loginbutton1_user.UseVisualStyleBackColor = false;
            this.loginbutton1_user.Click += new System.EventHandler(this.loginbutton1_user_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.backbutton.Location = new System.Drawing.Point(293, 279);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(143, 34);
            this.backbutton.TabIndex = 6;
            this.backbutton.Text = "BACK";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.backbutton);
            this.panel1.Controls.Add(this.loginbutton1_user);
            this.panel1.Location = new System.Drawing.Point(175, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 368);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(268, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(908, 565);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1userpassword);
            this.Controls.Add(this.textBox1username_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "UserLoginForm";
            this.Text = "UserLoginForm";
            this.Load += new System.EventHandler(this.UserLoginForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1username_user;
        private System.Windows.Forms.TextBox textBox1userpassword;
        private System.Windows.Forms.Button loginbutton1_user;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}